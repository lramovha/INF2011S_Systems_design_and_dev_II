using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Project.Business;
using Project.Data;
using Project.presentation;


namespace Project.Business
{
    public class CustomerController
    {
        #region Data Members
        private CustomerDB customerDB;
        private Collection<Customer> customers;
        private bool found;
        #endregion

        #region Properties
        public Collection<Customer> AllCustomers
        {
            get
            {
                return customers;
            }
        }

        public bool Found { get => found; set => found = value; }
        #endregion

        #region Constructor
        public CustomerController()
        {
            //***instantiate the CustomerDB object to communicate with the database
            customerDB = new CustomerDB();
            customers = customerDB.AllCustomers;
        }
        #endregion

        #region Database Communication.
        public void DataMaintenance(Customer aCust, DB.DBOperation operation)
        {
            int index = 0;
            //perform a given database operation to the dataset in meory; 
            customerDB.DataSetChange(aCust, operation);//calling method to do the insert
            switch (operation)
            {
                case DB.DBOperation.Add:
                    //*** Add the Customer to the Collection
                    customers.Add(aCust);
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(aCust);
                    customers[index] = aCust;  // replace Customer at this index with the updated Customer
                    break;
                case DB.DBOperation.Delete:
                    customers.Remove(aCust);
                    break;
            }
        }

        //***Commit the changes to the database
        public bool FinalizeChanges(Customer customer)
        {
            //***call the CustomerDB method that will commit the changes to the database
            return customerDB.UpdateDataSource(customer);

        }
        #endregion

        #region Search Methods
        //This method  (function) searched through all the employess to finds onlly those with the required role

        public Customer Find(string ID)
        {
            int index = 0;
            Found = (customers[index].ID == ID);  //check if it is the first record
            int count = customers.Count;
            while (!(Found) && (index < customers.Count - 1))  //if not "this" record and you are not at the end of the list 
            {
                index = index + 1;
                Found = (customers[index].ID == ID);   // this will be TRUE if found
            }
            return customers[index];  // this is the one!  
        }

        public int FindIndex(Customer aCust)
        {
            int counter = 0;
            found = false;
            found = (aCust.ID == customers[counter].ID);   //using a Boolean Expression to initialise found
            while (!(found) & counter < customers.Count - 1)
            {
                counter += 1;
                found = (aCust.ID == customers[counter].ID);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }
        #endregion
    }
}
