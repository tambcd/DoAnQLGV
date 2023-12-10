using System;
using System.Data.SqlClient;


namespace OutlookDemo
{
    public class connectDB
    {
        private readonly string connectionString;
        public connectDB()
        {
            //this.connectionString = "Data Source=MITSUTI;Initial Catalog=QL_klct;Integrated Security=True";
            this.connectionString = "Data Source=TVTAM\\SQLEXPRESS;Initial Catalog=QL_klct;Integrated Security=True";
        }

        public SqlConnection MoKetNoi()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kết nối đến cơ sở dữ liệu: " + ex.Message);
            }
        }

        public void DongKetNoi(SqlConnection connection)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
