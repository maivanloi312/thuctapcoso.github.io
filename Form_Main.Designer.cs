
namespace TRACNGHIEM
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_DangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btn_TaoTK = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_difBU = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_FullBU = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Restore = new DevExpress.XtraBars.BarButtonItem();
            this.btn_TaoRole = new DevExpress.XtraBars.BarButtonItem();
            this.btn_capquyenrole = new DevExpress.XtraBars.BarButtonItem();
            this.btn_taologin = new DevExpress.XtraBars.BarButtonItem();
            this.btn_XoaRole = new DevExpress.XtraBars.BarButtonItem();
            this.btn_doimk = new DevExpress.XtraBars.BarButtonItem();
            this.Ta = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_soanch = new DevExpress.XtraBars.BarButtonItem();
            this.btn_thitn = new DevExpress.XtraBars.BarButtonItem();
            this.btn_dangnhapSV = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rib_backup_restore = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rib_role_login = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btn_DangNhap,
            this.btn_DangXuat,
            this.btn_TaoTK,
            this.barButtonItem1,
            this.btn_difBU,
            this.barButtonItem3,
            this.barButtonItem4,
            this.btn_FullBU,
            this.btn_Restore,
            this.btn_TaoRole,
            this.btn_capquyenrole,
            this.btn_taologin,
            this.btn_XoaRole,
            this.btn_doimk,
            this.Ta,
            this.barButtonItem2,
            this.btn_soanch,
            this.btn_thitn,
            this.btn_dangnhapSV});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.ribbon.MaxItemId = 24;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.rib_backup_restore,
            this.rib_role_login,
            this.ribbonPage2});
            this.ribbon.Size = new System.Drawing.Size(1119, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Caption = "Đăng Nhập GV";
            this.btn_DangNhap.Id = 1;
            this.btn_DangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DangNhap.ImageOptions.Image")));
            this.btn_DangNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DangNhap.ImageOptions.LargeImage")));
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_DangNhap.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_DangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DangNhap_ItemClick);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Caption = "Đăng Xuất";
            this.btn_DangXuat.Id = 2;
            this.btn_DangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_DangXuat.ImageOptions.SvgImage")));
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_DangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DangXuat_ItemClick);
            // 
            // btn_TaoTK
            // 
            this.btn_TaoTK.Caption = "Tạo Tài Khoản";
            this.btn_TaoTK.Id = 3;
            this.btn_TaoTK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_TaoTK.ImageOptions.SvgImage")));
            this.btn_TaoTK.Name = "btn_TaoTK";
            this.btn_TaoTK.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Full  Back Up ";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btn_difBU
            // 
            this.btn_difBU.Caption = "Differential Back Up";
            this.btn_difBU.Id = 5;
            this.btn_difBU.Name = "btn_difBU";
            this.btn_difBU.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 6;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 7;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btn_FullBU
            // 
            this.btn_FullBU.Caption = "Full Back Up";
            this.btn_FullBU.Id = 8;
            this.btn_FullBU.Name = "btn_FullBU";
            this.btn_FullBU.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_FullBU_ItemClick);
            // 
            // btn_Restore
            // 
            this.btn_Restore.Caption = "Restore";
            this.btn_Restore.Id = 9;
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Restore_ItemClick);
            // 
            // btn_TaoRole
            // 
            this.btn_TaoRole.Caption = "Tạo Role";
            this.btn_TaoRole.Id = 10;
            this.btn_TaoRole.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_TaoRole.ImageOptions.Image")));
            this.btn_TaoRole.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_TaoRole.ImageOptions.LargeImage")));
            this.btn_TaoRole.Name = "btn_TaoRole";
            this.btn_TaoRole.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)));
            this.btn_TaoRole.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_TaoRole_ItemClick);
            // 
            // btn_capquyenrole
            // 
            this.btn_capquyenrole.Caption = "Cấp Quyền Role";
            this.btn_capquyenrole.Id = 11;
            this.btn_capquyenrole.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_capquyenrole.ImageOptions.Image")));
            this.btn_capquyenrole.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_capquyenrole.ImageOptions.LargeImage")));
            this.btn_capquyenrole.Name = "btn_capquyenrole";
            this.btn_capquyenrole.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)));
            this.btn_capquyenrole.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_capquyenrole_ItemClick);
            // 
            // btn_taologin
            // 
            this.btn_taologin.Caption = "Tạo Login";
            this.btn_taologin.Id = 12;
            this.btn_taologin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_taologin.ImageOptions.Image")));
            this.btn_taologin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_taologin.ImageOptions.LargeImage")));
            this.btn_taologin.Name = "btn_taologin";
            this.btn_taologin.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)));
            this.btn_taologin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_taologin_ItemClick);
            // 
            // btn_XoaRole
            // 
            this.btn_XoaRole.Caption = "Xóa Role Login";
            this.btn_XoaRole.Id = 13;
            this.btn_XoaRole.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaRole.ImageOptions.Image")));
            this.btn_XoaRole.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_XoaRole.ImageOptions.LargeImage")));
            this.btn_XoaRole.Name = "btn_XoaRole";
            this.btn_XoaRole.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)));
            this.btn_XoaRole.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_XoaRole_ItemClick);
            // 
            // btn_doimk
            // 
            this.btn_doimk.Caption = "Đổi MK";
            this.btn_doimk.Id = 14;
            this.btn_doimk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_doimk.ImageOptions.Image")));
            this.btn_doimk.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_doimk.ImageOptions.LargeImage")));
            this.btn_doimk.Name = "btn_doimk";
            this.btn_doimk.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)));
            this.btn_doimk.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_doimk_ItemClick);
            // 
            // Ta
            // 
            this.Ta.Caption = "Tạo Trigger";
            this.Ta.Id = 15;
            this.Ta.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Ta.ImageOptions.Image")));
            this.Ta.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Ta.ImageOptions.LargeImage")));
            this.Ta.Name = "Ta";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Xóa Trigger";
            this.barButtonItem2.Id = 16;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btn_soanch
            // 
            this.btn_soanch.Id = 21;
            this.btn_soanch.Name = "btn_soanch";
            // 
            // btn_thitn
            // 
            this.btn_thitn.Id = 22;
            this.btn_thitn.Name = "btn_thitn";
            // 
            // btn_dangnhapSV
            // 
            this.btn_dangnhapSV.Enabled = false;
            this.btn_dangnhapSV.Id = 23;
            this.btn_dangnhapSV.Name = "btn_dangnhapSV";
            this.btn_dangnhapSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_dangnhapSV_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ Thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_DangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_dangnhapSV);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_DangXuat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // rib_backup_restore
            // 
            this.rib_backup_restore.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rib_backup_restore.Name = "rib_backup_restore";
            this.rib_backup_restore.Text = "Back up/ Restore";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_difBU);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_FullBU);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_Restore);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // rib_role_login
            // 
            this.rib_role_login.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rib_role_login.Name = "rib_role_login";
            this.rib_role_login.Text = "Role/Login";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_TaoRole);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_capquyenrole);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_taologin);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_XoaRole);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_doimk);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Trigger";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.Ta);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 552);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1119, 30);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 530);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1119, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 582);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "Form_Main";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Form_Main";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btn_TaoTK;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btn_difBU;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btn_FullBU;
        private DevExpress.XtraBars.BarButtonItem btn_Restore;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btn_TaoRole;
        private DevExpress.XtraBars.BarButtonItem btn_capquyenrole;
        private DevExpress.XtraBars.BarButtonItem btn_taologin;
        private DevExpress.XtraBars.BarButtonItem btn_XoaRole;
        private DevExpress.XtraBars.BarButtonItem btn_doimk;
        public DevExpress.XtraBars.Ribbon.RibbonPage rib_backup_restore;
        public DevExpress.XtraBars.Ribbon.RibbonPage rib_role_login;
        public DevExpress.XtraBars.BarButtonItem btn_DangXuat;
        public DevExpress.XtraBars.BarButtonItem btn_DangNhap;
        private DevExpress.XtraBars.BarButtonItem Ta;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        public DevExpress.XtraBars.BarButtonItem btn_soanch;
        public DevExpress.XtraBars.BarButtonItem btn_thitn;
        public DevExpress.XtraBars.BarButtonItem btn_dangnhapSV;
        public DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
    }
}