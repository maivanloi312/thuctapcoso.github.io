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
    public partial class Form_TaoRole : Form
    {
        public Form_TaoRole()
        {
            InitializeComponent();
        }

        private void btn_tao_Click(object sender, EventArgs e)
        {

            if (txt_rolename.Text.Trim() == "" )
            {
                MessageBox.Show("Tên role không được để trống!", "", MessageBoxButtons.OK);
                return;
            }

            if (Program.KetNoi() == 0)
                return;
            String rolename = txt_rolename.Text;
           

            Program.conn = new SqlConnection(Program.connstr);
            Program.conn.Open();
            SqlCommand cmd = new SqlCommand("SP_TAOROLE", Program.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ROLE", rolename));
            SqlDataReader myreader = null;
            try
            {
                myreader = cmd.ExecuteReader();
                MessageBox.Show("Tạo role thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể tạo role\nLý do: " + ex.Message, "", MessageBoxButtons.OK);
            }
            Program.conn.Close();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_TaoRole_Load(object sender, EventArgs e)
        {

        }
    }
}
