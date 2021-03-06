using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRACNGHIEM
{
    public partial class Form_DangNhap : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();
        public Form_DangNhap()
        {
            InitializeComponent();
        }
        public void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed)
                conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();

        }
        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception)
            {
                MessageBox.Show("Loi ket noi ve co so du lieu !!! ", "", MessageBoxButtons.OK);
                return 0;
            }
        }
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
             if (txtLogin.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Login name va password khong duoc trong !!!","", MessageBoxButtons.OK);
                return;
            }
            Program.mlogin = txtLogin.Text;
            Program.password = txtPass.Text;
            if (Program.KetNoi() == 0) return;
            Program.mloginDN = Program.mlogin;
            Program.mpasswordDN = Program.password;
            String strLenh = "EXEC SP_LayThongTinTuLogin '" + Program.mlogin + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username)) {
                MessageBox.Show("Login ban nhap khong co quyen truy cap du lieu!! \n Ban xem lai username va password","",MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            Program.frmChinh.rib_backup_restore.Visible = Program.frmChinh.rib_role_login.Visible = true;
            
            Program.frmChinh.btn_DangXuat.Enabled = true;
            Program.frmChinh.btn_DangNhap.Enabled = Program.frmChinh.btn_dangnhapSV.Enabled = false;
            
            MessageBox.Show("Đăng nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
           
        }
    }
}
