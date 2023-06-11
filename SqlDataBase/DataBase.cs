using SqlDataBase.Tables;
using SqlDataBase.Tables.Staffs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Runtime.Remoting.Messaging;

namespace SqlDataBase
{
    public static class DataBase
    {
        private static SqlConnection _connection;

        public static void InitConnection()
        {
            _connection = new SqlConnection($"Server ={Environment.MachineName}\\SQLEXPRESS;Database = DTSCM;Trusted_Connection=True;");
        }
        public static void OpenConnection()
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message + " connection opening error");
            }
        }

        public static void CloseConnection()
        {
            try
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message + " connection closing error");
            }
        }

        public static DataTable SelectRequestExecute(string request)
        {
            OpenConnection();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(request, _connection);
            try
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    table.Load(reader);
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message + " select request error");
            }

            CloseConnection();
            return table;
        }
        public static int NonQueryRequestExecuteAsync(string request)
        {
            OpenConnection();
            int affectedRowsAmount = 0;

            SqlCommand command = new SqlCommand(request, _connection);

            try
            {
                affectedRowsAmount = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message + " execute non query error");
            }
            CloseConnection();
            return affectedRowsAmount;
        }

        public static List<T> ConvertToList<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        public static List<string> ConvertToList(DataTable dt, string propertyName)
        {
            List<string> result = new List<string>();

            foreach (DataRow row in dt.Rows)
                result.Add(Convert.ToString(row[propertyName]));
            return result;
        }

        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    try
                    {
                        if (pro.Name == column.ColumnName)
                            pro.SetValue(obj, dr[column.ColumnName], null);
                        else
                            continue;
                    }
                    catch
                    {
                    }
                }
            }
            return obj;
        }

        public static class Update
        {

        }
        public static class Add
        {
            public static void Detector(FireDetector fireDetector)//требует обдумывания, пока в разработке
            {
                NonQueryRequestExecuteAsync
                    ($"insert into FireDetectors values '({fireDetector.Model})', {fireDetector.ChannelAmount}, {fireDetector.MaxChannelLength}");

                foreach (Channel channel in fireDetector.Channels)
                    NonQueryRequestExecuteAsync
                        ($"insert into Channels values({channel.DetectorId}, '{channel.Title}', {channel.CurrentLength}, {channel.IsActive})");
            }
        }
        public static class Get
        {
            public static IStaff Staff<T>(string login,string password)
            {
                List<T> Staffs = ConvertToList<T>
                  (SelectRequestExecute($"select * from Staffs where StaffLogin ='{login}' and StaffPassword ='{password}'"));
                if (Staffs.Count == 1)
                    return (IStaff)Staffs[0];
                return null;
            }
            public static DataTable Staffs() => SelectRequestExecute("select * from Staffs");
            public static string StaffPostByLogin(string login)
            {
                List<string> posts = ConvertToList(SelectRequestExecute($"select Post from Staffs where StaffLogin ='{login}'"),"Post");
               
                if(posts.Count == 1)
                    return posts[0];
                return null;
            }
            public static List<string> Posts() => ConvertToList(SelectRequestExecute("select * from Posts"), "Title");
        }
        public static class Delete
        {

        }
    }
}

