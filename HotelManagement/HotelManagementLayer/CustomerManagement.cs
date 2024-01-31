using BussinessLogic.Repository;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementLayer
{
    public partial class CustomerManagement : Form
    {
        HotelManagementContext context;
        CustomerRepo customerRepo;
        public CustomerManagement()
        {
            context = new HotelManagementContext();
            customerRepo = new CustomerRepo(context);
            InitializeComponent();
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            LoadUI();
        }
        private void LoadUI()
        {
            IEnumerable<Customer> cus = customerRepo.GetAll();

            dataGridView1.DataSource = cus
                                        .Select(x => new
                                        {
                                            x.CustomerId,
                                            x.Name,
                                            x.PhoneNumber,
                                            x.Email,
                                            x.Address
                                        })
                                        .ToList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            IEnumerable<Customer> cus = customerRepo.GetAll();

            dataGridView1.DataSource = cus
                                        .Select(x => new
                                        {
                                            x.CustomerId,
                                            x.Name,
                                            x.PhoneNumber,
                                            x.Email,
                                            x.Address
                                        })
                                        .Where(x =>
                                            x.Name.Contains(txtSearch.Text) ||
                                            x.PhoneNumber.Contains(txtSearch.Text) ||
                                            x.Email.Contains(txtSearch.Text) ||
                                            x.Address.Contains(txtSearch.Text))
                                        .ToList();
        }

        // Add a new customer
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var name = txtName.Text;
                var phoneNumber = txtPhoneNumber.Text;
                var email = txtEmail.Text;
                var address = txtAddress.Text;

                // Create a new Customer object
                Customer newCustomer = new Customer
                {
                    Name = name,
                    PhoneNumber = phoneNumber,
                    Email = email,
                    Address = address
                };

                customerRepo.Add(newCustomer);

                LoadUI();

                ClearTextFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding customer: " + ex.Message);
            }
        }

        // Update an existing customer
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRowIndex = txtCustomerID.Text;
                var selectedCustomer = customerRepo.Get(int.Parse(selectedRowIndex));

                selectedCustomer.Name = txtName.Text;
                selectedCustomer.PhoneNumber = txtPhoneNumber.Text;
                selectedCustomer.Email = txtEmail.Text;
                selectedCustomer.Address = txtAddress.Text;

                customerRepo.Update(selectedCustomer);

                LoadUI();

                ClearTextFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating customer: " + ex.Message);
            }
        }

        // Delete a customer
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                var selectedCustomer = (Customer)dataGridView1.Rows[selectedRowIndex].DataBoundItem;

                customerRepo.Delete(selectedCustomer.CustomerId);

                LoadUI();

                ClearTextFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting customer: " + ex.Message);
            }
        }

        private void ClearTextFields()
        {
            txtCustomerID.Text = "";
            txtName.Text = "";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a row is clicked (not header or empty space)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Populate the textboxes with customer data
                txtCustomerID.Text = selectedRow.Cells["CustomerID"].Value.ToString();
                txtName.Text = selectedRow.Cells["Name"].Value.ToString();
                txtPhoneNumber.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                txtAddress.Text = selectedRow.Cells["Address"].Value.ToString();

            }
        }

    }
}
