﻿using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AdminBackups
{
    public partial class ProductManager : Form
    {
        int id;
        Store store;

        public ProductManager(int UserID, Store s)
        {
            InitializeComponent();
            id = UserID;
            store = s;

            UpdateProducts();
        }

        //Logout 

        protected override void OnClosing(CancelEventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            //iD

            //FormEditEmployeeData editEmployeeData = new FormEditEmployeeData();
            //editEmployeeData.Show();
        }

        // availability
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            UpdateProducts();
        }

        // products (Esther)
        public void UpdateProducts()
        {
            //Get Back here
            dgProducts.DataSource = store.productManagment.ViewAllProducts("");
        }

        private void dgProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgProducts.Rows[e.RowIndex];

                tbID.Text = row.Cells["ProductID"].Value.ToString();
                tbName.Text = row.Cells["Name"].Value.ToString();
                tbBarcode.Text = row.Cells["Barcode"].Value.ToString();
                tbxPrice.Text = row.Cells["Price"].Value.ToString();
                cbxProductType.Text = row.Cells["Type"].Value.ToString();
            }
        }

        private void btnAddPorduct_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbName.Text;
                //if (string.IsNullOrEmpty(name))
                //{
                //    MessageBox.Show("Please add a product name");
                //}
                string barcode = tbBarcode.Text;
                //if (string.IsNullOrEmpty(barcode))
                //{
                //    MessageBox.Show("Please add a barcode");
                //}
                string type = cbxProductType.SelectedItem.ToString();
                //if (string.IsNullOrEmpty(type))
                //{
                //    MessageBox.Show("Please select a product type");
                //}
                double price = Convert.ToDouble(tbxPrice.Text);
                //if (price == 0)
                //{
                //    MessageBox.Show("Please enter a price");
                //}

                store.productManagment.AddProduct(name, barcode, type, price);
            } catch (NullReferenceException nullRefEx)
            {
                MessageBox.Show("Please enter all product details");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            UpdateProducts();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int productID = Convert.ToInt32(tbID.Text);
            string name = tbName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please add a product name");
            }
            string barcode = tbBarcode.Text;
            if (string.IsNullOrEmpty(barcode))
            {
                MessageBox.Show("Please add a barcode");
            }
            string type = cbxProductType.SelectedItem.ToString();
            if (string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Please select a product type");
            }
            double price = Convert.ToDouble(tbxPrice.Text);

            store.productManagment.EditProduct(productID, name, barcode, type, price);

            UpdateProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int productID = Convert.ToInt32(tbID.Text);
                store.productManagment.DeleteProduct(productID);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            UpdateProducts();
        }
    }
}
