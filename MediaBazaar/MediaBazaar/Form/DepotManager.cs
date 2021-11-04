﻿using ClassLibraryProject.Class;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class DepotManager : Form
    {
        int ID;
        Store store;
        int i;

        public DepotManager(int UserID, Store s)
        {
            InitializeComponent();

            store = s;
            ID = UserID;

            Initialize();
            UpdateRestockRequests();
            UpdateSchedule();
            UpdateSupplier();
        }

        //Initialize
        public void Initialize()
        {
            DateTime date = DateTime.Now;
            lblWeek.Text = GetCurrentWeekOfYear(date).ToString();
            i = Convert.ToInt32(lblWeek.Text);
            txtYear.Text = date.Year.ToString();
        }

        //Overview
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgOverviewSchedule_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void dgOverviewRestock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void lstEmployeesWorkingToday_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tabControl1.SelectTab(3);
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectTab(4);
        }

        //Restock
        public void UpdateRestockRequests()
        {
            dgOverviewRestock.DataSource = store.restockManagment.ViewPendingRestockRequests();
            dgRestock.DataSource = store.restockManagment.ViewPendingRestockRequests();
        }
        private void rbPending_Click(object sender, EventArgs e)
        {
            dgRestock.DataSource = store.restockManagment.ViewPendingRestockRequests();
        }

        private void rbHistory_CheckedChanged(object sender, EventArgs e)
        {
            dgRestock.DataSource = store.restockManagment.ViewHistoryRestockRequests();
        }
        public void DeleteRestockRequest()
        {
            string restockID = txtRestockID.Text;
            try
            {
                store.restockManagment.DeleteRestockRequest(Convert.ToInt32(restockID));
            }
            catch (Exception)
            {
                MessageBox.Show("Select any restock request you want to reject.");
            }

            UpdateRestockRequests();
        }
        private void btnOrderRestock_Click(object sender, EventArgs e)
        {
            string restockID = txtRestockID.Text;
            try
            {
                store.restockManagment.OrderRestock(Convert.ToInt32(restockID));
            }
            catch
            {
                MessageBox.Show("Select any restock request you want to finalize.");
            }
            UpdateRestockRequests();
            MessageBox.Show("Product ordered. Wait for shipment to arrive");
        }
        private void btnDeleteRestockRequest_Click(object sender, EventArgs e)
        {
            DeleteRestockRequest();
            MessageBox.Show("Restock request deleted!");
        }
        private void dgRestock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgRestock.Rows[e.RowIndex];
                txtRestockID.Text = row.Cells["RestockReplenishmentID"].Value.ToString();
                txtProductID.Text = row.Cells["ProductID"].Value.ToString();
                txtBarcode.Text = row.Cells["Barcode"].Value.ToString();
                txtCurrentAmount.Text = row.Cells["ReceivedAmount"].Value.ToString();
            }
        }

        //Schedule
        public static int GetCurrentWeekOfYear(DateTime time)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
        public void UpdateSchedule()
        {
            try
            {
                if (store.scheduleManagment.GetDepotCount(Convert.ToInt32(txtYear.Text), Convert.ToInt32(lblWeek.Text)) == true)
                {
                    store.scheduleManagment.CreateDepotWeek(Convert.ToInt32(txtYear.Text), Convert.ToInt32(lblWeek.Text));
                }
                dgSchedule.DataSource = store.scheduleManagment.ViewDepotSchedule(Convert.ToInt32(lblWeek.Text), Convert.ToInt32(txtYear.Text));
                dgOverviewSchedule.DataSource = store.scheduleManagment.ViewDepotSchedule(Convert.ToInt32(lblWeek.Text), Convert.ToInt32(txtYear.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Please insert year!");
            }
            
        }
        private void dgSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgSchedule.Rows[e.RowIndex];
                lbScheduleDay.Text = row.Cells["Day"].Value.ToString();
                lbScheduleEvening.Text = row.Cells["Evening"].Value.ToString();
                lbScheduleMorning.Text = row.Cells["Morning"].Value.ToString();
                lbScheduleAfternoon.Text = row.Cells["Afternoon"].Value.ToString();
            }
        }
        private void btnEditschedule_Click(object sender, EventArgs e)
        {
            string Morning = lbScheduleMorning.Text;
            if (string.IsNullOrEmpty(Morning))
            {
                MessageBox.Show("Amount in Morning is required.");
                return;
            }

            string Afternoon = lbScheduleAfternoon.Text;
            if (string.IsNullOrEmpty(Afternoon))
            {
                MessageBox.Show("Amount in Afternoon is required.");
                return;
            }

            string Evening = lbScheduleEvening.Text;
            if (string.IsNullOrEmpty(Evening))
            {
                MessageBox.Show("Amount in Evening is required.");
                return;
            }

            string Day = lbScheduleDay.Text;
            if (string.IsNullOrEmpty(Day))
            {
                MessageBox.Show("Day is required.");
                return;
            }
            try
            {
                store.scheduleManagment.EditDepotSchedule(Day, Morning, Afternoon, Evening, Convert.ToInt32(lblWeek.Text), Convert.ToInt32(txtYear.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Please insert year!");
            }

            UpdateSchedule();
            MessageBox.Show("Schedule updated!");
        }
        private void btnIncreaseWeek_Click(object sender, EventArgs e)
        {
            try
            {
                if (i < ISOWeek.GetWeeksInYear(Convert.ToInt32(txtYear.Text)))
                {
                    i++;
                }
                else if (i >= ISOWeek.GetWeeksInYear(Convert.ToInt32(txtYear.Text)))
                {
                    i = ISOWeek.GetWeeksInYear(Convert.ToInt32(txtYear.Text));
                }
                lblWeek.Text = i.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please insert year!");
            }
            UpdateSchedule();
        }
        private void btnDecreaseWeek_Click(object sender, EventArgs e)
        {
            if (i > 1)
            {
                i--;
            }
            else if (i <= 0)
            {
                i = 1;
            }
            lblWeek.Text = i.ToString();
            UpdateSchedule();
        }

        //Planning


        //Supplier
        private void UpdateSupplier()
        {
            dgOverviewSupplier.DataSource = store.supplierManagment.ViewAllSuppliers();
            dgSupplier.DataSource = store.supplierManagment.ViewAllSuppliers();
        }
        private void dgSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgSupplier.Rows[e.RowIndex];
                txtSupplierID.Text = row.Cells["SupplierID"].Value.ToString();
                txtSupplierName.Text = row.Cells["SupplierName"].Value.ToString();
                txtCountry.Text = row.Cells["Country"].Value.ToString();
                txtBuildingNumber.Text = row.Cells["BuildingNumber"].Value.ToString();
                txtPostalCode.Text = row.Cells["PostalCode"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value.ToString();
                txtBankNumber.Text = row.Cells["BankNumber"].Value.ToString();
            }
        }
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            string name = txtSupplierName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("'Name' is required.");
                return;
            }
            string country = txtCountry.Text;
            if (string.IsNullOrEmpty(country))
            {
                MessageBox.Show("'Country' is required.");
                return;
            }
            string buildingNumber = txtBuildingNumber.Text;
            string postalCode = txtPostalCode.Text;
            if (string.IsNullOrEmpty(postalCode))
            {
                MessageBox.Show("'Postal Code' is required.");
                return;
            }
            string email = txtEmail.Text;
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("'Email' is required.");
                return;
            }
            string phoneNumber = txtPhoneNumber.Text;
            string bankNumber = txtBankNumber.Text;
            if (string.IsNullOrEmpty(bankNumber))
            {
                MessageBox.Show("'Bank Number' is required.");
                return;
            }
            try
            {
                store.supplierManagment.AddSupplier(name, country, Convert.ToInt32(buildingNumber), postalCode, email, Convert.ToInt32(phoneNumber), bankNumber);
            }
            catch (Exception)
            {
                MessageBox.Show("Select a supplier you want to edit");
            }
            UpdateSupplier();
            MessageBox.Show("Supplier added!");
        }
        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            string id = txtSupplierID.Text;
            string name = txtSupplierName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("'Name' is required.");
                return;
            }
            string country = txtCountry.Text;
            if (string.IsNullOrEmpty(country))
            {
                MessageBox.Show("'Country' is required.");
                return;
            }
            string buildingNumber = txtBuildingNumber.Text;
            string postalCode = txtPostalCode.Text;
            if (string.IsNullOrEmpty(postalCode))
            {
                MessageBox.Show("'Postal Code' is required.");
                return;
            }
            string email = txtEmail.Text;
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("'Email' is required.");
                return;
            }
            string phoneNumber = txtPhoneNumber.Text;
            string bankNumber = txtBankNumber.Text;
            if (string.IsNullOrEmpty(bankNumber))
            {
                MessageBox.Show("'Bank Number' is required.");
                return;
            }
            try
            {
                store.supplierManagment.EditSupplier(Convert.ToInt32(id), name, country, Convert.ToInt32(buildingNumber), postalCode, email, Convert.ToInt32(phoneNumber), bankNumber);
            }
            catch (Exception)
            {
                MessageBox.Show("Select a supplier you want to edit");
            }
            UpdateSupplier();
            MessageBox.Show("Selected supplier deleted!");
        }
        private void btnRemoveSupplier_Click(object sender, EventArgs e)
        {
            string supplierID = txtSupplierID.Text;
            try
            {
                store.supplierManagment.DeleteSupplier(Convert.ToInt32(supplierID));
            }
            catch (Exception)
            {
                MessageBox.Show("Select supplier you want to delete");
            }

            UpdateSupplier();
            MessageBox.Show("Selected supplier deleted!");
        }
        private void btnOrderInfo_Click(object sender, EventArgs e)
        {
            string supplierID = txtSupplierID.Text;
            try
            {
                FormOrderInfo formOrderInfo = new FormOrderInfo(Convert.ToInt32(supplierID));
                formOrderInfo.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Select supplier");
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSupplierID.Text = "";
            txtSupplierName.Text = "";
            txtCountry.Text = "";
            txtBuildingNumber.Text = "";
            txtPostalCode.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            txtBankNumber.Text = "";
        }
    }
}
