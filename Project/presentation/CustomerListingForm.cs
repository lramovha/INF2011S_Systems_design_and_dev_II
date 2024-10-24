using Project.Business;
using Project.Data;
using Project.presentation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Project.presentation
{
    public partial class CustomerListingForm : Form
    {

        #region Variables
        public bool listFormClosed;
        private Collection<Customer> customers;
        private CustomerController customerController;
        private FormStates state;
        private Customer customer;
        #endregion

        #region Enumeration
        public enum FormStates
        {
            View = 0,
            Add = 1,
            Edit = 2,
            Delete = 3
        }
        #endregion

        public CustomerListingForm(CustomerController custController)
        {
            InitializeComponent();
            customerController = custController;
            this.Load += CustomerListingForm_Load;
            this.Activated += CustomerListingForm_Activated;
            this.FormClosed += CustomerListingForm_FormClosed;
            state = FormStates.View;
        }

        #region The List View
        public void setUpCustomerListView()
        {
            ListViewItem customerDetails;   //Declare variables
            //Clear current List View Control
            customerListViews.Clear();
            //Set Up Columns of List View
            customerListViews.Columns.Insert(0, "ID", 120, HorizontalAlignment.Left);
            customerListViews.Columns.Insert(1, "CustomerID", 120, HorizontalAlignment.Left);
            customerListViews.Columns.Insert(2, "Name", 150, HorizontalAlignment.Left);
            customerListViews.Columns.Insert(3, "Phone", 100, HorizontalAlignment.Left);
            customerListViews.Columns.Insert(4, "Dates", 100, HorizontalAlignment.Left);
            customerListViews.Columns.Insert(5, "Status", 100, HorizontalAlignment.Left);

            customers = null;                      //customers collection will be filled by role
            // Get all the customers from the CustomerController object 
            // (use the property) and assign to a local customers collection reference
            customers = customerController.AllCustomers;
            listLabel.Text = "Listing of all customers";
            //customerListViews.Columns.Insert(4, "Payment", 100, HorizontalAlignment.Center);

            //Add customer details to each ListView item 
            foreach (Customer customer in customers)
            {
                customerDetails = new ListViewItem();
                customerDetails.Text = customer.ID.ToString();
                customerDetails.SubItems.Add(customer.CustomerID);
                customerDetails.SubItems.Add(customer.Name);
                customerDetails.SubItems.Add(customer.Telephone);
                customerDetails.SubItems.Add(customer.dates);
                customerDetails.SubItems.Add(customer.status);

                //customerDetails.SubItems.Add(headW.SalaryAmount.ToString());
                customerListViews.Items.Add(customerDetails);
            }
            customerListViews.Refresh();
            customerListViews.GridLines = true;
        }
        #endregion

        #region Form Events
        private void CustomerListingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            listFormClosed = true;
        }

        private void CustomerListingForm_Load(object sender, EventArgs e)
        {
            customerListViews.View = View.Details;
        }

        private void CustomerListingForm_Activated(object sender, EventArgs e)
        {
            customerListViews.View = View.Details;
            setUpCustomerListView();
            ShowAll(true);

        }

        #endregion

        #region Utility Methods
        private void ShowAll(bool value)
        {
            idLabel.Visible = value;
            custIDLabel.Visible = value;
            nameLabel.Visible = value;
            phoneLabel.Visible = value;
            idTextBox.Visible = value;
            custIDTextBox.Visible = value;
            nameTextBox.Visible = value;
            phoneTextBox.Visible = value;
            //If the form state is View, the Submit button and the Edit button should not be visible
            if (state == FormStates.Delete)
            {
                cancelButton.Visible = !value;
                submitButton.Visible = !value;
            }
            else
            {
                cancelButton.Visible = value;
                submitButton.Visible = value;
            }
            deleteButton.Visible = value;
            editButton.Visible = value;

        }
        private void EnableEntries(bool value)
        {
            if ((state == FormStates.Edit) && value)
            {
                idTextBox.Enabled = !value;
                custIDTextBox.Enabled = !value;
            }
            else
            {
                idTextBox.Enabled = value;
                custIDTextBox.Enabled = value;
            }
            nameTextBox.Enabled = value;
            phoneTextBox.Enabled = value;
            if (state == FormStates.Delete)
            {
                cancelButton.Visible = !value;
                submitButton.Visible = !value;
            }
            else
            {
                cancelButton.Visible = value;
                submitButton.Visible = value;
            }
        }
        private void ClearAll()
        {
            idTextBox.Text = "";
            custIDTextBox.Text = "";
            nameTextBox.Text = "";
            phoneTextBox.Text = "";
        }
        private void PopulateTextBoxes(Customer cust)
        {
            idTextBox.Text = cust.ID;
            custIDTextBox.Text = cust.CustomerID;
            nameTextBox.Text = cust.Name;
            phoneTextBox.Text = cust.Telephone;



            //paymentTextBox.Text = Convert.ToString(headW.SalaryAmount);

        }
        private void PopulateObject()
        {
            customer = new Customer();
            customer.ID = idTextBox.Text;
            customer.CustomerID = custIDTextBox.Text;
            customer.Name = nameTextBox.Text;
            customer.Telephone = phoneTextBox.Text;

            //headW.SalaryAmount = decimal.Parse(paymentTextBox.Text);
        }

        #endregion
        private void customerListViews_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAll(true);
            state = FormStates.View;
            EnableEntries(false);
            if (customerListViews.SelectedItems.Count > 0)   // if you selected an item 
            {
                customer = customerController.Find(customerListViews.SelectedItems[0].Text);  //selected customer becoms current customer
                                                                                              //customer = customerController.Find(Convert.ToString(customerListViews.SelectedItems[0]));  //selected customer becomes current customer
                PopulateTextBoxes(customer);


            }
        }


        private void editButton_Click_1(object sender, EventArgs e)
        {
            //set the form state to Edit
            state = FormStates.Edit;
            deleteButton.Visible = false;
            EnableEntries(true);//call the EnableEntities method
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            PopulateObject();
            if (state == FormStates.Edit)
            {
                customerController.DataMaintenance(customer, DB.DBOperation.Edit);

            }
            else//delete code
            {


            }
            customerController.FinalizeChanges(customer);
            ClearAll();
            state = FormStates.View;
            ShowAll(false);
            setUpCustomerListView();   //refresh List View
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //set the form state to Delete
            state = FormStates.Delete;

            string id = customer.CustomerID;
            customerController.DataMaintenance(customer, DB.DBOperation.Delete);
            customerController.FinalizeChanges(customer);
            state = FormStates.View;
            ShowAll(false);
            setUpCustomerListView();
            MessageBox.Show("Successfully deleted " + id);
        }
    }
}
