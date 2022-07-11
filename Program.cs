using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRACNGHIEM
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String connstr_publisher = "Data Source=DESKTOP-O0DI5T2;Initial Catalog=QLDSV;Integrated Security=True";
        public static string Dbname = "QLDSV";
        public static SqlDataReader myReader;

        /*public static BindingSource bds_dspm = new BindingSource();*/
        public static Form_Main frmChinh;
        public static String id = "";
        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";
        public static String CMND = "";


        public static String database = "QLDSV";
        public static String remotelogin = "HTKN";
        public static String remotepassword = "123";
        public static String mloginDN = "";
        public static String mpasswordDN = "";
        public static String mHoten = "";
        public static int mChinhanh = 0;
        public static String mGroup = "";

        public static SqlDataReader ExecSqlDataReader(String strlenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strlenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (Exception ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        /* public static int ExecSqlNonQuerry(String strlenh)
         {
             SqlCommand sqlcmd = new SqlCommand(strlenh, conn);
             sqlcmd.CommandType = CommandType.Text;
             sqlcmd.CommandTimeout = 600;
             if (conn.State == ConnectionState.Closed) conn.Open();
             try
             {
                 sqlcmd.ExecuteNonQuery();
                 conn.Close();
                 return 0;
             }
             catch (SqlException ex)
             {
                 if (ex.Message.Contains("Error converting data type varchar to int"))
                     MessageBox.Show("Ban format cell lai !!!!");
                 else MessageBox.Show(ex.Message);
                 conn.Close();
                 return ex.State;
             }
         }*/
        public static void ExecSqlNonQuery(String strLenh)
        {
            if (Program.KetNoi() == 0) return;
            conn.Close();
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 300; // Đợi lệnh chạy. đơn vị: giây.
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                sqlcmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);

            }
        }

        public static int ExecSqlKiemTra(String tenSP, String a)
        {
            String sql = "DECLARE @return_value int " +
                         "EXEC @return_value = [dbo].[" + tenSP + "] " +
                         "@a " +
                         "SELECT 'Return Value' = @return_value";

            SqlCommand sqlCommand = new SqlCommand(sql, Program.conn);
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            sqlCommand.Parameters.AddWithValue("@a", a);
            SqlDataReader dataReader = null;
            try
            {
                dataReader = sqlCommand.ExecuteReader();
                dataReader.Read();
                int result_value = int.Parse(dataReader.GetValue(0).ToString());
                conn.Close();
                return result_value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return 5;
            }
        }


        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                    Program.database + ";User ID=" +
                    Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Loi ket noi co so du lieu !! \nBan xem lai username va password.\n" + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //application.run(new frmnhanvien());
            frmChinh = new Form_Main();
            Application.Run(frmChinh);
        }
    
    }
}
