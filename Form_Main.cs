using DevExpress.XtraBars;
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
    public partial class Form_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        public Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        
        private void btn_DangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Form_DangNhap));
            if (frm != null) frm.Activate();
            else
            {
                Form_DangNhap f = new Form_DangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }
        private bool CheckHasDevice()
        {

            String sqlQuery = "USE master SELECT name FROM sys.backup_devices where name like " + "'%" + Program.Dbname + "%'"; // lay tat ca database so sanh voi DB co chua co thi them vao
            Program.myReader = Program.ExecSqlDataReader(sqlQuery);
            while (Program.myReader.Read())
            {
                Program.myReader.Close();
                return true;

            }
            return false;
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            
            rib_role_login.Visible = rib_backup_restore.Visible =ribbonPage2.Visible  = false;
            btn_TaoTK.Enabled = btn_DangXuat.Enabled = btn_soanch.Enabled= btn_thitn.Enabled= false;
        }

        private void btn_DangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                f.Dispose();
            rib_role_login.Visible = rib_backup_restore.Visible =  false;
            btn_TaoTK.Enabled = btn_DangXuat.Enabled = false;
            btn_DangNhap.Enabled = btn_dangnhapSV.Enabled= true;
            MessageBox.Show("Đăng xuất thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            /*            if (Program.KetNoi() == 0)
                            return;
                        Program.conn = new SqlConnection(Program.connstr);
                        Program.conn.Open();
                        SqlCommand cmd = new SqlCommand("SP_BACKUPDBdiff", Program.conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader myReader = null;
                        try
                        {
                            myReader = cmd.ExecuteReader();
                            MessageBox.Show("Tạo backup  diff thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Không thể tạo backup  diff\nLý do: " + ex.Message, "", MessageBoxButtons.OK);
                        }*/
            Form frm = this.CheckExists(typeof(Form_DiffBackup));
            if (frm != null) frm.Activate();
            else
            {
                Form_DiffBackup f = new Form_DiffBackup();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_FullBU_ItemClick(object sender, ItemClickEventArgs e)
        {
            /*            if (Program.KetNoi() == 0)
                            return;
                        Program.conn = new SqlConnection(Program.connstr);
                        Program.conn.Open();
                        SqlCommand cmd = new SqlCommand("SP_BACKUPDB", Program.conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader myReader = null;
                        try
                        {
                            myReader = cmd.ExecuteReader();
                            MessageBox.Show("Tạo backup   thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Không thể tạo backup\nLý do: " + ex.Message, "", MessageBoxButtons.OK);
                        }*/
            Form frm = this.CheckExists(typeof(Form_FullBackup));
            if (frm != null) frm.Activate();
            else
            {
                Form_FullBackup f = new Form_FullBackup();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_Restore_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Form_Restore));
            if (frm != null) frm.Activate();
            else
            {
                Form_Restore f = new Form_Restore();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_TaoRole_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Form_TaoRole));
            if (frm != null) frm.Activate();
            else
            {
                Form_TaoRole f = new Form_TaoRole();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_capquyenrole_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Form_phanquyen));
            if (frm != null) frm.Activate();
            else
            {
                Form_phanquyen f = new Form_phanquyen();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_taologin_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Form_TaoLogin));
            if (frm != null) frm.Activate();
            else
            {
                Form_TaoLogin f = new Form_TaoLogin();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_XoaRole_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Form_xoa_role_login));
            if (frm != null) frm.Activate();
            else
            {
                Form_xoa_role_login f = new Form_xoa_role_login();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_doimk_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Form_DoiMK));
            if (frm != null) frm.Activate();
            else
            {
                Form_DoiMK f = new Form_DoiMK();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem5_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Form_LoginSV));
            if (frm != null) frm.Activate();
            else
            {
                Form_LoginSV f = new Form_LoginSV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_dangnhapSV_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    } 
       
}