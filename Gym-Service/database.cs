using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gym_Service
{
    class Database
    {
        public static void insertPerson(string tablename, string fname, string lname,string gender, string dob, string mobile, string email,string joindate, string gymtime,
             string address, string member, string position)
        {
            try
            {
                string query ="";
                string message = "";
                string connectionString = "datasource = localhost; username = root; password=; database = gymdata";
                if (position == "")
                {
                     query = "insert into " + tablename + "(Fname,Lname,Gender,Dob,Mobile,Email,Joindate,Gymtime,Address,Membership)" +
                    " VALUES ('" + fname + "','" + lname + "','" + gender + "','" + dob + "','" + mobile + "','" + email + "','" + joindate + "','" + gymtime + "','" + address + "','" + member + "')";
                    message = "Member";
                }
                else if(position != ""&& gymtime==""&& member=="")
                {
                    query = "insert into " + tablename + "(Fname ,  Lname ,  Gender ,  Dob ,  Mobile ,  Email ,  Joindate ,  Position ,  Address )" +
                    " VALUES ('" + fname + "','" + lname + "','" + gender + "','" + dob + "','" + mobile + "','" + email + "','" + joindate + "','" + position + "','" + address + "')";
                    message = "Staff";
                }
                MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader mySqlDataReader;
                mySqlConnection.Open();
                mySqlDataReader = mySqlCommand.ExecuteReader();
                MessageBox.Show(message+" registered!");
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void insertEquipment(string equipname, string description, string muscle, string delivery, string cost)
        {
            try
            {
                
                string connectionString = "datasource = localhost; username = root; password=; database = gymdata";
                
                
                string query = "insert into equipment  (Equipment_name ,  Description ,  Muscle ,  Delivery_date ,  Cost  )  VALUES ('" + equipname + "','" + description + "','" + muscle + "','" + delivery + "','" + cost + "')";
                MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader mySqlDataReader;
                mySqlConnection.Open();
                mySqlDataReader = mySqlCommand.ExecuteReader();
                MessageBox.Show("Equipment added!");
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static DataTable show(string tablename)
        {
            try
            {
                string MyConnection2 = "datasource = localhost; username = root; password=; database = gymdata";
                string Query = "select * from "+tablename+"";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                return dTable;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable searchById(string tablename, int id)
        {
            try
            {
                string MyConnection2 = "datasource = localhost; username = root; password=; database = gymdata";
                string Query = "SELECT * from " + tablename + " where ID='" + id + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                return dTable;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static void deleteById(string tablename, int id)
        {
            try
            {
                string MyConnection2 = "datasource = localhost; username = root; password=; database = gymdata";
                string Query = "delete from "+tablename+" where ID='" + id + "'";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Member Deleted");
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
