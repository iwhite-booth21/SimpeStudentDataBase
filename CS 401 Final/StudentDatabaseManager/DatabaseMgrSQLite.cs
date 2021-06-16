using System;
using System.IO;
using System.Data;

//SQLite library
using System.Data.SQLite;


namespace StudentDatabaseManager
{

    public class DatabaseMgrSQLite
    {
        public static string connStr = GlobalData.dataSource;
        
        //SQLite
        public static SQLiteConnection myConn;
        public static SQLiteCommand myUpdateCommand;
        public static SQLiteDataAdapter myAdapter;

        public DatabaseMgrSQLite()
        {
            try
            {
                //Test if database file exists
                string dbPath = GlobalData.dataSource.Replace("Data Source=", "");
                if (!File.Exists(dbPath))
                {
                    System.Windows.Forms.MessageBox.Show("Invalid database path. Database NOT connected.");
                }
                else
                {
                    //Create the connection to the DB
                    myConn = new SQLiteConnection(connStr);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        // This method is used for selecting data from database
        public DataTable getData(string sqlStr, out int numRowsReturned)
        {
            numRowsReturned = -1;
            DataTable tmpDataTable = new DataTable();
            try
            {
                myAdapter = new SQLiteDataAdapter(sqlStr, myConn);
                numRowsReturned = myAdapter.Fill(tmpDataTable);                
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Exception: getData()");                
            }

            return tmpDataTable;  //Return a table representation of the data
        }


        // This method is used for updating or inserting data into the database
        public int putData(string sqlStr)
        {
            int numRowsModified = -1;                                        
            try
            {
                myConn.Open();
                myUpdateCommand = new SQLiteCommand();
                myUpdateCommand.CommandText = sqlStr;
                myUpdateCommand.Connection = myConn;
                numRowsModified = myUpdateCommand.ExecuteNonQuery();                
                myConn.Close();
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Exception: putData()");
                myConn.Close();
            }
            return numRowsModified;
        }        

    }    

}
