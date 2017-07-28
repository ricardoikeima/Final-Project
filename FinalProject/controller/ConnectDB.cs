using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.model
{
    class ConnectDB
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader reader;

        public ConnectDB()
        {
            con = new MySqlConnection("server=40.76.205.114;user id=cproject;password=PROG37721;"
                + "persistsecurityinfo=True;database=cproject");
        }

        public DataTable getTableSchema(String table)
        {
            DataTable dt = new DataTable();

            try
            {
                con.Open();

                cmd = new MySqlCommand("SELECT * FROM " + table, con);
                reader = cmd.ExecuteReader();

                dt = reader.GetSchemaTable();

                reader.Close();

            }
            catch (SqlException sql)
            {
                //MessageBox.Show("issue connection to the db " + sql.Errors);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("some other error " + ex.Message);
            }
            con.Close();
            return dt;

        }
        public DataTable executeReader(String command)
        {
            DataTable dt = new DataTable();

            try
            {
                con.Open();

                cmd = new MySqlCommand(command, con);
                reader = cmd.ExecuteReader();

                dt.Load(reader);
                
                reader.Close();

            }
            catch (SqlException sql)
            {
                //MessageBox.Show("issue connection to the db " + sql.Errors);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("some other error " + ex.Message);
            }
            con.Close();
            return dt;

        }

        public int executeNonQuery(String command)
        {
            int result = 0;

            try
            {
                con.Open();

                cmd = new MySqlCommand(command, con);
                result = cmd.ExecuteNonQuery();

                reader.Close();

            }
            catch (SqlException sql)
            {
                //MessageBox.Show("issue connection to the db " + sql.Errors);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("some other error " + ex.Message);
            }
            con.Close();

            return result;
        }
    }
}
