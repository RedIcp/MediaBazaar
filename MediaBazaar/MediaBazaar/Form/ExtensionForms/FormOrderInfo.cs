﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses;
using MediaBazaar;

namespace AdminBackups
{
    public partial class FormOrderInfo : Form
    {
        ProductManager productManager;
        Product product;
        public FormOrderInfo(ProductManager pm, Product p)
        {
            InitializeComponent();

            this.productManager = pm;
            this.product = p;

            LoadProductInfo();
            LoadSuppliers();
        }
        private void LoadProductInfo()
        {
            if (product != null)
            {
                this.Text = product.ProductName;

                lblProductName.Text = product.ProductName;
                tbxBarcode.Text = product.Barcode;
            }
        }
        /* Supplier Start */
        private void LoadSuppliers()
        {
            List<Supplier> suppliers = productManager.SupplierManagerPM.ReadSuppliers();

            lbxSupplier.Items.Clear();

            foreach (Supplier s in suppliers)
            {
                if (s.ProductType == product.ProductType)
                {
                    lbxSupplier.Items.Add(s);
                }
            }
        }
        /* Search Bar Supplier */
        private void tbxSearchSupplier_TextChanged(object sender, EventArgs e)
        {
            string search = tbxSearchSupplier.Text;

            if (!string.IsNullOrEmpty(search))
            {
                List<Supplier> suppliers = productManager.SupplierManagerPM.SearchSuppliers(search);
                lbxSupplier.Items.Clear();

                foreach (Supplier s in suppliers)
                {
                    if (s.ProductType == product.ProductType)
                    {
                        lbxSupplier.Items.Add(s);
                    }
                }
            } else
            {
                LoadSuppliers();
            }
        }
        /* Select Supplier */
        private Supplier SelectSupplier()
        {
            if (lbxSupplier.SelectedIndex < 0)
            {
                return null;
            }

            Object supplierObject = lbxSupplier.SelectedItem;
            if (!(supplierObject is Supplier))
            {
                return null;
            }

            Supplier supplier = (Supplier)supplierObject;

            tbxSupplier.Text = supplier.ToString();


            // check if supplier already has order info

            bool orderInfound = false;

            product.OrderInfos = productManager.OrderInfoManagerPM.GetOrderInfosForProduct(product);

            foreach (OrderInfo oi in product.OrderInfos)
            {
                if (oi.Supplier.ID == supplier.ID)
                {
                    tbxMinAmount.Text = oi.MinAmount.ToString();
                    tbxMaxAmount.Text = oi.MaxAmount.ToString();
                    tbxMultiples.Text = oi.Multiples.ToString();
                    tbxPurchasePrice.Text = oi.PurchasePrice.ToString();

                    orderInfound = true;
                }

                if (!orderInfound)
                {
                    tbxMinAmount.Text = "";
                    tbxMaxAmount.Text = "";
                    tbxMultiples.Text = "";
                    tbxPurchasePrice.Text = "";
                }
            }

            return supplier;
        }

        private void lbxSupplier_DoubleClick(object sender, EventArgs e)
        {
            SelectSupplier();
        }
        private void lbxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectSupplier();
        }
        /* Supplier End */
        private void btnAddNewOrder_Click(object sender, EventArgs e)
        {
            if (CreateOrderInfo())
            {
                var formProductManager = Application.OpenForms.OfType<FormProductManager>().FirstOrDefault();
                formProductManager.ReadProducts();
                formProductManager.ReadProductsNoOrderInfo();

                var formViewProduct = Application.OpenForms.OfType<FormViewProduct>().FirstOrDefault();
                if (formViewProduct != null)
                {
                    formViewProduct.LoadSuppliersForProduct();
                }
            }
        }
        private bool CreateOrderInfo()
        {
            Supplier supplier = SelectSupplier();
            if (supplier == null)
            {
                MessageBox.Show("Please select a supplier first");
                return false;
            }

            int minAmount = 0;
            if (string.IsNullOrEmpty(tbxMinAmount.Text))
            {
                MessageBox.Show("Please enter a minimum amount");
                return false;
            }
            try
            {
                minAmount = Convert.ToInt32(tbxMinAmount.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a number");
                return false;
            }

            int maxAmount = 0;
            if (string.IsNullOrEmpty(tbxMaxAmount.Text))
            {
                MessageBox.Show("Please enter a maximum amount");
                return false;
            }
            try
            {
                maxAmount = Convert.ToInt32(tbxMaxAmount.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a number");
                return false;
            }

            int multiples = 0;
            if (string.IsNullOrEmpty(tbxMultiples.Text))
            {
                MessageBox.Show("Please enter multiples amount");
                return false;
            }
            try
            {
                multiples = Convert.ToInt32(tbxMultiples.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a number");
                return false;
            }

            double purchasePrice = 0;
            if (string.IsNullOrEmpty(tbxPurchasePrice.Text))
            {
                MessageBox.Show("Please enter a purchase price");
                return false;
            }
            try
            {
                purchasePrice = Convert.ToDouble(tbxPurchasePrice.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a number");
                return false;
            }

            OrderInfo newOrderInfo = new OrderInfo(supplier, product, minAmount, maxAmount, multiples, purchasePrice);

            if (productManager.OrderInfoManagerPM.CreateOrderInfo(newOrderInfo))
            {
                DialogResult dr = MessageBox.Show("Do you want to add another order info?", "Order Info added", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    tbxMinAmount.Clear();
                    tbxMaxAmount.Clear();
                    tbxMultiples.Clear();
                    tbxPurchasePrice.Clear();
                    return true;
                }
                else if (dr == DialogResult.No)
                {
                    this.Close();
                    return true;
                }
            }

            return false;
        }
        private void UpdateOrderInfo()
        {
            Supplier supplier = SelectSupplier();

            // check if supplier has order info
            product.OrderInfos = productManager.OrderInfoManagerPM.GetOrderInfosForProduct(product);

            foreach (OrderInfo oi in product.OrderInfos)
            {
                if (oi.Supplier.ID == supplier.ID)
                {
                    if (oi != null)
                    {
                        if (string.IsNullOrEmpty(tbxMinAmount.Text))
                        {
                            MessageBox.Show("Min amount cannot be empty");
                            return;
                        }
                        oi.MinAmount = Convert.ToInt32(tbxMinAmount.Text);

                        if (string.IsNullOrEmpty(tbxMaxAmount.Text))
                        {
                            MessageBox.Show("Max amount cannot be empty");
                            return;
                        }
                        oi.MaxAmount = Convert.ToInt32(tbxMaxAmount.Text);

                        if (string.IsNullOrEmpty(tbxMultiples.Text))
                        {
                            MessageBox.Show("Multiples cannot be empty");
                            return;
                        }
                        oi.Multiples = Convert.ToInt32(tbxMultiples.Text);

                        if (string.IsNullOrEmpty(tbxPurchasePrice.Text))
                        {
                            MessageBox.Show("Purchase price cannot be empty");
                            return;
                        }
                        oi.PurchasePrice = Convert.ToDouble(tbxPurchasePrice.Text);

                        if (productManager.OrderInfoManagerPM.UpdateOrderInfo(oi))
                        {
                            MessageBox.Show("Order Info Updated");
                        }
                    }
                }
            }
        }
        private void DeleteOrderInfo()
        {
            Supplier supplier = SelectSupplier();

            // check if supplier has order info
            product.OrderInfos = productManager.OrderInfoManagerPM.GetOrderInfosForProduct(product);

            foreach (OrderInfo oi in product.OrderInfos)
            {
                if (oi.Supplier.ID == supplier.ID)
                {
                    if (oi != null)
                    {
                        if (productManager.OrderInfoManagerPM.DeleteOrderInfo(oi))
                        {
                            MessageBox.Show("Order Info deleted");

                            tbxMinAmount.Clear();
                            tbxMaxAmount.Clear();
                            tbxMultiples.Clear();
                            tbxPurchasePrice.Clear();
                        }
                    }
                }
            }
        }

        private void btnUpdateOrderInfo_Click(object sender, EventArgs e)
        {
            UpdateOrderInfo();
        }

        private void btnDeleteOrderInfo_Click(object sender, EventArgs e)
        {
            DeleteOrderInfo();
        }
    }
}
