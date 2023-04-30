using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Transparent_Form
{
    /*
     * In this class Create the connection between application and mysql database
     * we need to install xampp and mysql connector to this project
     * we need to create the student database
     */

    //singleton pattern implementation (singleton class)
    public sealed class DbConnectionSingleton
    {
        private DbConnectionSingleton() 
        {
            Console.WriteLine("Connection Instance created");

        }
        private static DbConnectionSingleton ConnectionInstance;
        public static DbConnectionSingleton GetConnectionInstance()
        {
            if (ConnectionInstance == null)
            {
                ConnectionInstance = new DbConnectionSingleton();
            }
            return ConnectionInstance;
        }
    }


    class DBconnect
    {
        //Singleton object creation to demostrate the singleton pattern
        DbConnectionSingleton Connection1 = DbConnectionSingleton.GetConnectionInstance();
        DbConnectionSingleton Connection2 = DbConnectionSingleton.GetConnectionInstance();

        //to create original connection
        MySqlConnection connect = new MySqlConnection("datasource=localhost;port=3306;username=root;database=student");

        //to get connection
        public MySqlConnection getconnection
        {
            get
            {
                return connect;
            }
        }

        //create a function to Open conncetion
        public void openConnect()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
        }

        //Create a fuction to close connection
        public void closeConnect()
        {
            if (connect.State == System.Data.ConnectionState.Open)
                connect.Close();
        }
    }
}
