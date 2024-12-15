using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QuanLySuShi.DTO;

namespace QuanLySuShi
{
    public class DataProvider
    {
        private static DataProvider instance;
        const string connstring = "Data Source=DESKTOP-RI069V5;Initial Catalog=QLShiShu;Integrated Security=True;TrustServerCertificate=True";
        public static SqlConnection connection;
        public static List<DangNhap> DangNhap_KHs = new List<DangNhap>();
        public static List<DangNhap> DangNhap_NVs = new List<DangNhap>();

        public static DataProvider Instance {
             get {
                if (instance == null)
                    instance = new DataProvider();
                return DataProvider.instance; 
             } 
            private set {  
                DataProvider.instance = value; 
            }
        }
        private DataProvider() { }
        public static void OpenConnection()
        {
            connection = new SqlConnection(connstring);
            connection.Open();
        }
        public static void CloseConnection()
        {
            connection.Close();
        }
        public static void GetAllDangNhap_KH()
        {
            try
            {
                OpenConnection();
                string query = "select taikhoan, matkhau from khachhang";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DangNhap dangNhap = new DangNhap();
                    dangNhap.TaiKhoan = reader["Taikhoan"].ToString();
                    dangNhap.MatKhau = reader["MatKhau"].ToString();
                    DangNhap_KHs.Add(dangNhap);

                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);   
            }
        
            finally
            {
                CloseConnection();
            }

        }
        public static void GetAllDangNhap_NV()
        {
            try
            {
                OpenConnection();
                string query = "select taikhoan, matkhau from nhanvien";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DangNhap dangNhap = new DangNhap();
                    dangNhap.TaiKhoan = reader["Taikhoan"].ToString();
                    dangNhap.MatKhau = reader["MatKhau"].ToString();
                    DangNhap_NVs.Add(dangNhap);

                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                CloseConnection();
            }

        }
        public static DataTable ExecuteSelectQuery(string query, Dictionary<string, object> parameters = null)
        {
            DataTable dataTable = new DataTable();

            try
            {
                OpenConnection();

                SqlCommand command = new SqlCommand(query, connection);

                // Thêm tham số nếu có
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi truy vấn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }

            return dataTable;
        }
        public static object ExecuteScalarQuery(string query, Dictionary<string, object> parameters = null)
        {
            object result = null;

            try
            {
                OpenConnection();

                SqlCommand command = new SqlCommand(query, connection);

                // Thêm tham số nếu có
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                result = command.ExecuteScalar();  // Trả về giá trị duy nhất (Scalar)
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi truy vấn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }

            return result;
        }
        public static bool ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
        {
            bool isSuccess = false;

            try
            {
                OpenConnection();

                SqlCommand command = new SqlCommand(query, connection);

                // Thêm tham số nếu có
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                int affectedRows = command.ExecuteNonQuery(); // Trả về số lượng bản ghi bị ảnh hưởng
                isSuccess = affectedRows > 0;  // Kiểm tra nếu có bản ghi bị thay đổi
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi truy vấn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }

            return isSuccess;
        }


    }
}
