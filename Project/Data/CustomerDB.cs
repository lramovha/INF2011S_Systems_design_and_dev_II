using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Properties;
using Project.Business;

namespace Project.Data
{
    public class CustomerDB:DB
    {
        #region  Data members 
        private string table1 = "Reservations";
        private string sqlLocal1 = "SELECT * FROM Reservations";

        private Collection<Customer> customers;
        #endregion

        #region Property Method: Collection
        public Collection<Customer> AllCustomers
        {

            get
            {
                return customers;
            }
        }
        #endregion

        #region Constructor
        public CustomerDB() : base()
        {
            customers = new Collection<Customer>();
            FillDataSet(sqlLocal1, table1);
            Add2Collection(table1);
        }
        #endregion

        #region Utility Methods
        public DataSet GetDataSet()
        {
            return dsMain;
        }
        private void Add2Collection(string table)
        {
            //Declare references to a myRow object and an Customer object
            DataRow myRow = null;
            Customer aCust;
            //READ from the table  
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //Instantiate a new Customer object
                    aCust = new Customer();
                    
                    aCust.CustomerID = Convert.ToString(myRow["CustomerID"]).TrimEnd();
                    aCust.Name = Convert.ToString(myRow["Name"]).TrimEnd();
                    aCust.Telephone = Convert.ToString(myRow["Phone"]).TrimEnd();
                    aCust.dates = Convert.ToString(myRow["Dates"]).TrimEnd();
                    aCust.status = Convert.ToString(myRow["Status"]).TrimEnd();
                    customers.Add(aCust);
                }
            }
        }
        private void FillRow(DataRow aRow, Customer aCust, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                //aRow["ID"] = aCust.ID;  //NOTE square brackets to indicate index of collections of fields in row.
                aRow["CustomerID"] = aCust.CustomerID;
            }
            aRow["Name"] = aCust.Name;
            aRow["Phone"] = aCust.Telephone;
            aRow["Dates"] = aCust.dates;
            aRow["Status"] = aCust.status;
            

        }
        private int FindRow(Customer aCust, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                //Ignore rows marked as deleted in dataset
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //In c# there is no item property (but we use the 2-dim array) it 
                    //is automatically known to the compiler when used as below
                    if (aCust.CustomerID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["CustomerID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }
        #endregion

        #region Database Operations CRUD
        public void DataSetChange(Customer aCust, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, aCust, operation);
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aCust, dataTable)];
                    FillRow(aRow, aCust, operation);
                    break;
                case DB.DBOperation.Delete:
                    //to delete
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aCust, dataTable)];
                    aRow.Delete();
                    break;
            }
        }
        #endregion



        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Customer aCust)
        {
            //Create Parameters to communicate with SQL INSERT...
            //add the input parameter and set its properties.             
            SqlParameter param = default(SqlParameter);
            // param = new SqlParameter("@ID", SqlDbType.NVarChar, 15, "ID");
            //daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.
            param = daMain.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
            param.Direction = ParameterDirection.Output;

            param = new SqlParameter("@CustomerID", SqlDbType.NVarChar, 10, "CustomerID");
            daMain.InsertCommand.Parameters.Add(param);

            //Do the same for Description & answer -ensure that you choose the right size
            param = new SqlParameter("@Name", SqlDbType.NVarChar, 100, "Name");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Phone", SqlDbType.NVarChar, 15, "Phone");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Dates", SqlDbType.NVarChar, 20, "Dates");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Status", SqlDbType.NVarChar, 20, "Status");
            daMain.InsertCommand.Parameters.Add(param);

            //***https://msdn.microsoft.com/en-za/library/ms179882.aspx
        }
        private void Build_UPDATE_Parameters(Customer aCust)
        {
            //---Create Parameters to communicate with SQL UPDATE
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 100, "Name");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            //Do for all fields other than ID and CUSTID as for Insert 
            param = new SqlParameter("@Phone", SqlDbType.NVarChar, 10, "Phone");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            //Do for all fields other than ID and CUSTID as for Insert 
            param = new SqlParameter("@Dates", SqlDbType.NVarChar, 20, "Dates");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Status", SqlDbType.NVarChar, 20, "Status");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);


            //testing the ID of record that needs to change with the original ID of the record
            param = new SqlParameter("@Original_ID", SqlDbType.NVarChar, 15, "ID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Build_DELETE_Parameters(Customer aCust)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@Original_ID", SqlDbType.NVarChar, 15, "ID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.DeleteCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

        }

        private void Create_DELETE_Command(Customer aCust)
        {
            //Create the command that must be used to insert values into one of the three tables
            //Assumption is that the ID and CUSTID cannot be changed
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Customer " + "WHERE ID = @Original_ID", cnMain);
            Build_DELETE_Parameters(aCust);

        }

        private void Create_INSERT_Command(Customer aCust)
        {
            //Create the command that must be used to insert values into the table..
            daMain.InsertCommand = new SqlCommand("INSERT into Customer (CustID, Name, Phone, Dates, Status) VALUES (@CustID, @Name, @Phone, @Dates, @Status)", cnMain);
            Build_INSERT_Parameters(aCust);
        }
        private void Create_UPDATE_Command(Customer aCust)
        {
            //Create the command that must be used to insert values into one of the three tables
            //Assumption is that the ID and CUSTID cannot be changed

            daMain.UpdateCommand = new SqlCommand("UPDATE Customer SET Name =@Name, Phone =@Phone, Dates =@Dates, Status =@Status " + "WHERE ID = @Original_ID", cnMain);
            Build_UPDATE_Parameters(aCust);
        }
        public bool UpdateDataSource(Customer aCust)
        {
            bool success = true;
            Create_INSERT_Command(aCust);
            Create_UPDATE_Command(aCust);
            Create_DELETE_Command(aCust);
            success = UpdateDataSource(sqlLocal1, table1);

            return success;
        }

        #endregion
    }
}
