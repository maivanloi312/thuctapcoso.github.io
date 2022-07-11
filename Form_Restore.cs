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
    public partial class Form_Restore : Form
    {
        public Form_Restore()
        {
            InitializeComponent();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup file|*.bak";
            dlg.Title = "Database restore";
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                txt_duongdan.Text = dlg.FileName;

            }
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            Program.conn = new SqlConnection(Program.connstr);
            Program.conn.Open();
            try
            {
                string str = string.Format("ALTER DATABASE QLDSV SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd = new SqlCommand(str, Program.conn);
                cmd.ExecuteNonQuery();
                string str2 = string.Format("USE MASTER RESTORE DATABASE QLDSV FROM DISK='" + txt_duongdan.Text + "'WITH REPLACE;");
                SqlCommand cmd2 = new SqlCommand(str2, Program.conn);
                cmd2.ExecuteNonQuery();
                string str3 = string.Format("ALTER DATABASE QLDSV SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(str3, Program.conn);
                cmd3.ExecuteNonQuery();

                MessageBox.Show("Restore database thành công");
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể Restore\nLý do: " + ex.Message, "", MessageBoxButtons.OK);
            }
            Program.conn.Close();
        }
    }
}
