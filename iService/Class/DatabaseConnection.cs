using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using iService.Properties;
using System.Data;

namespace iService.Class
{
    public class DatabaseConnection
    {
        string connetionString = Resources.ResourceManager.GetString("ConnectionString");
        SqlConnection connection;
        SqlCommand command;
        string sql = string.Empty;
        SqlDataReader dataReader;
        public void Dispose()
        {
            if (connection != null) { connection.Dispose(); connection = null; }
            if (command != null) { command.Dispose(); command = null; }
            if (dataReader != null) { dataReader.Dispose(); dataReader = null; }
        }
        public DataTable getSQLDataReader(string sqlCommand)
        {
            var resultTable = new DataTable();
            sql = sqlCommand;
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                resultTable.Load(dataReader);
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return resultTable;
        }
    }
}
