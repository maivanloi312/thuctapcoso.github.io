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
    public partial class Form_FullBackup : Form
    {
        public Form_FullBackup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            Program.conn = new SqlConnection(Program.connstr);
            string database = Program.conn.Database.ToString();
            if (txt_duongdan.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn đường dẫn file backup");
            }
            else
            {
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + txt_duongdan.Text + "\\" + "database" + "-" + "full" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
                
                using (SqlCommand command = new SqlCommand(cmd, Program.conn))
                {
                    if (Program.conn.State != ConnectionState.Open)
                    {
                        Program.conn.Open();
                    }
                    command.ExecuteNonQuery();
                    Program.conn.Close();
                    MessageBox.Show("Full backup database thành công");
                    btn_fullbackup.Enabled = false;
                }
            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            /*            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                        saveFileDialog1.AddExtension = true;
                        saveFileDialog1.Filter = "Backup Files (*.bak)|*.bak";
                        saveFileDialog1.ShowDialog();
                        txt_duongdan.Text = saveFileDialog1.FileName;*/
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txt_duongdan.Text = dlg.SelectedPath;
                btn_fullbackup.Enabled = true;
            }
        }
    }
}
