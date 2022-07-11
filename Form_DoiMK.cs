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
    public partial class Form_DoiMK : Form
    {
        public Form_DoiMK()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "" || txtPassMoi.Text.Trim() == "")
            {
                MessageBox.Show("Login/pass mới không được để trống!", "", MessageBoxButtons.OK);
                return;
            }
            String login = txtLogin.Text;
            String passcu = txtPass.Text;
            String passmoi = txtPassMoi.Text;
            if (Program.KetNoi() == 0)
                return;
            Program.conn = new SqlConnection(Program.connstr);
            Program.conn.Open();
            SqlCommand cmd = new SqlCommand("SP_DoiMK", Program.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@mk_cu", passcu));
            cmd.Parameters.Add(new SqlParameter("@mk_moi", passmoi));
            cmd.Parameters.Add(new SqlParameter("@username",login));
            
            SqlDataReader myReader = null;
            try
            {
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể đổi\nLý do: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }
    }
}
