using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StoreManagement.DTO
{
    public class DataProvider
    {
        private static DataProvider instance;


        private string conectionSTR = @"Data Source=.\sqlexpress;Initial Catalog=DemoStoreManager;Integrated Security=True;";

        public static DataProvider Instance 
        { 
            get { if (instance == null) instance = new DataProvider(); return instance; } 
            private set => instance = value;
        }
        public DataProvider() { }
        public DataTable ExecuteQuerry(string querry, object[] parameter= null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(conectionSTR))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(querry, connection);
                    command.CommandType = CommandType.Text;
                    if (parameter != null)
                    {
                        string[] listPara = querry.Split(' ');
                        int i = 0;
                        foreach (string para in listPara)
                        {
                            if (para.Contains('@'))
                            {
                                command.Parameters.AddWithValue(para, parameter[i]);
                                i++;
                            }
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.ToString()); 
            }
            
            
            return dt;
        }
        public int ExecuteNonQuerry(string querry, object[] parameter = null)
        {
            int res = 0;
            using (SqlConnection connection = new SqlConnection(conectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(querry, connection);
                command.CommandType = CommandType.Text;
                if (parameter != null)
                {
                    string[] listPara = querry.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        if (para.Contains('@'))
                        {
                            command.Parameters.AddWithValue(para, parameter[i]);
                            i++;
                        }
                    }
                }
                try
                {
                    res = command.ExecuteNonQuery();

                }catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                connection.Close();
            }
            return res;
        }
        public object ExecuteScalar(string querry, object[] parameter = null)
        {
            object obj = 0;

            using (SqlConnection connection = new SqlConnection(conectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(querry, connection);
                command.CommandType = CommandType.Text;
                if (parameter != null)
                {
                    string[] listPara = querry.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        if (para.Contains('@'))
                        {
                            command.Parameters.AddWithValue(para, parameter[i]);
                            i++;
                        }
                    }
                }
                obj = command.ExecuteScalar();
                connection.Close();
            }
            

            return obj;
        }
    }
}
