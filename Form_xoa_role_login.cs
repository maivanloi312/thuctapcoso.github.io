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
    public partial class Form_xoa_role_login : Form
    {
        public Form_xoa_role_login()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (txtuser.Text.Trim() == ""  )
            {
                MessageBox.Show("User/role không được để trống!", "", MessageBoxButtons.OK);
                return;
            }
            String user = txtuser.Text;
           
            String role = cmb_role.Text;
            if (Program.KetNoi() == 0)
                return;
            Program.conn = new SqlConnection(Program.connstr);
            Program.conn.Open();
            SqlCommand cmd = new SqlCommand("SP_XoaUserKhoiRole", Program.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@username",user));
            cmd.Parameters.Add(new SqlParameter("@role", role));
            SqlDataReader myReader = null;
            try
            {
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Xóa login khỏi role thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể xóa\nLý do: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_xoa_role_login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.V_DSROLE' table. You can move, or remove it, as needed.
            this.v_DSROLETableAdapter.Fill(this.dS.V_DSROLE);

        }
    }
}
