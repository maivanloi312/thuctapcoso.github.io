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
    public partial class Form_TaoLogin : Form
    {
        public Form_TaoLogin()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "" || txtPass.Text.Trim() == "" || txtUser.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản, mật khẩu và username không được để trống!", "", MessageBoxButtons.OK);
                return;
            }
            String login = txtLogin.Text;
            String pass = txtPass.Text;
            String username = txtUser.Text;
            String role =cmb_role.Text;
            if (Program.KetNoi() == 0)
                return;
            Program.conn = new SqlConnection(Program.connstr);
            Program.conn.Open();
            SqlCommand cmd = new SqlCommand("SP_TaoLogin", Program.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@lgname", login));
            cmd.Parameters.Add(new SqlParameter("@pass", pass));
            cmd.Parameters.Add(new SqlParameter("@username",username));
            cmd.Parameters.Add(new SqlParameter("@role",role));
            SqlDataReader myReader = null;
            try
            {
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể tạo tài khoản\nLý do: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_TaoLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.V_DSROLE' table. You can move, or remove it, as needed.
            this.v_DSROLETableAdapter.Fill(this.dS.V_DSROLE);
            // TODO: This line of code loads data into the 'dS.V_ROLE' table. You can move, or remove it, as needed.
            this.v_ROLETableAdapter.Fill(this.dS.V_ROLE);

        }

        private void cmb_role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
