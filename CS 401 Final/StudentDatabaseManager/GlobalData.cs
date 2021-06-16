using System;
using System.Collections.Generic;
using System.Text;

namespace StudentDatabaseManager
{
    // Use this class to store all global data for your application
    public static class GlobalData
    {

        // Database setup (either one works)
        public static string dataSource = @"Data Source=..\..\..\StudentDatabase\FinalExam.db";
        //public static string dataSource = @"Data Source=..\..\Databases\booksDatabase.db";
        
        //Stores the acc_Id of current logged user.
        public static string accId;


    }
}
 