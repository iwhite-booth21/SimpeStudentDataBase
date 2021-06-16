using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDatabaseManager
{
    public partial class AddStudentFRM : Form
    {
        ViewStudent vStudent;

        // Create table for student fields & database connector
        DatabaseMgrSQLite studentMgr = new DatabaseMgrSQLite();
        DataTable studentTable = new DataTable();

        public AddStudentFRM()
        {
            InitializeComponent();
        }

        private void Student_AddBTN_Click(object sender, EventArgs e)
        {
            // Function will complete the entire insert process.
            InsertStudent();


           
            this.Hide();
             if (vStudent == null || vStudent.IsDisposed)
             {
                 vStudent = new ViewStudent();
             }
             vStudent.Show();
            

        }

        // This Function Verifies that the students name is unique
        public bool UniqueName() 
        {
            // Select Statement to verify against. 
            string studentSelSql = String.Format("SELECT * from Student WHERE "
                + "Name = '{0}'", studentNameLBL.Text);

            int numRows = 0;
            studentTable.Clear();
            studentTable = studentMgr.getData(studentSelSql, out numRows);

            // If User name is found in database.
            if (numRows == 1)
            {
                //Verifies the name of the student is not being repeated/
                MessageBox.Show("This student Exists");
                // Save StudentID
                GlobalData.accId = studentTable.Rows[0]["StudentID"].ToString();
                return false;
            }
            // If no user is found
            else 
            {
                MessageBox.Show("Generating account");
                return true;
            }

        }

        // This function handle the insert statement necesary for the program
        public bool InsertStudent() 
        {
            // Insert Statement for the Program
            string studentInSql = String.Format("INSERT INTO Student(Name,Major)VALUES" +
                "('{0}','{1}')", sNameRSP.Text, sMajorRSP.Text);

            // Variable will use the value from the previous function
            bool uniqueStudent = UniqueName();

            // If any textbox is blank, notify the user.
            if (sNameRSP.Text.Equals("") || sMajorRSP.Text.Equals(""))
            {
                MessageBox.Show("Please give name and major");
                return false;
            }
            // if the user is unique, insert into the database
            else if (uniqueStudent == true)
            {
                int rowsInserted = 0;
                rowsInserted = studentMgr.putData(studentInSql);
                MessageBox.Show("Inserting Student information");
                return true;
            }
            // if not
            else if (uniqueStudent == false)
            {
                MessageBox.Show("Student Exists, try again");
                return false;
            }
            // If all else is not true return false, the only case to not return a message box.
            else 
            {
                return false;
            }
        }
    }

}
