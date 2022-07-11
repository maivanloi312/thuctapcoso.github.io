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
    public partial class Form_phanquyen : Form
    {
        public Form_phanquyen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form_phanquyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.V_DSquyen' table. You can move, or remove it, as needed.
            this.v_DSquyenTableAdapter.Fill(this.dS.V_DSquyen);
            // TODO: This line of code loads data into the 'dS.V_DSROLE' table. You can move, or remove it, as needed.
            this.v_DSROLETableAdapter.Fill(this.dS.V_DSROLE);

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cap_Click(object sender, EventArgs e)
        {
            String role = cmb_role.Text;
            String quyen = cmb_quyen.Text;
            if (Program.KetNoi() == 0) return;

            Program.conn = new SqlConnection(Program.connstr);
            Program.conn.Open();

            SqlCommand cmd = new SqlCommand("SP_CAPQUYENROLE", Program.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ROLE", quyen));
            cmd.Parameters.Add(new SqlParameter("@USER",role ));
            SqlDataReader myReader = null;
            try
            {
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Cấp quyền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể cấp quyền \nLý do: " + ex.Message, "", MessageBoxButtons.OK);
            }
            Program.conn.Close();

        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.V_DSquyen' table. You can move, or remove it, as needed.
            this.v_DSquyenTableAdapter.Fill(this.dS.V_DSquyen);
            // TODO: This line of code loads data into the 'dS.V_DSROLE' table. You can move, or remove it, as needed.
            this.v_DSROLETableAdapter.Fill(this.dS.V_DSROLE);
        }
    }
}
