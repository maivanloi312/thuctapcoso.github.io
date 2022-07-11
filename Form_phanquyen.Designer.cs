
namespace TRACNGHIEM
{
    partial class Form_phanquyen
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
            this.cmb_role = new System.Windows.Forms.ComboBox();
            this.vDSROLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new TRACNGHIEM.DS();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_quyen = new System.Windows.Forms.ComboBox();
            this.vDSquyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cap = new DevExpress.XtraEditors.SimpleButton();
            this.v_DSROLETableAdapter = new TRACNGHIEM.DSTableAdapters.V_DSROLETableAdapter();
            this.v_DSquyenTableAdapter = new TRACNGHIEM.DSTableAdapters.V_DSquyenTableAdapter();
            this.btn_Load = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.vDSROLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSquyenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_role
            // 
            this.cmb_role.DataSource = this.vDSROLEBindingSource;
            this.cmb_role.DisplayMember = "name";
            this.cmb_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_role.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_role.FormattingEnabled = true;
            this.cmb_role.Location = new System.Drawing.Point(173, 26);
            this.cmb_role.Name = "cmb_role";
            this.cmb_role.Size = new System.Drawing.Size(239, 34);
            this.cmb_role.TabIndex = 0;
            this.cmb_role.ValueMember = "name";
            // 
            // vDSROLEBindingSource
            // 
            this.vDSROLEBindingSource.DataMember = "V_DSROLE";
            this.vDSROLEBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Role";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quyền";
            // 
            // cmb_quyen
            // 
            this.cmb_quyen.DataSource = this.vDSquyenBindingSource;
            this.cmb_quyen.DisplayMember = "name";
            this.cmb_quyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_quyen.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_quyen.FormattingEnabled = true;
            this.cmb_quyen.Location = new System.Drawing.Point(173, 120);
            this.cmb_quyen.Name = "cmb_quyen";
            this.cmb_quyen.Size = new System.Drawing.Size(239, 34);
            this.cmb_quyen.TabIndex = 3;
            this.cmb_quyen.ValueMember = "name";
            // 
            // vDSquyenBindingSource
            // 
            this.vDSquyenBindingSource.DataMember = "V_DSquyen";
            this.vDSquyenBindingSource.DataSource = this.dS;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(40, 265);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(118, 36);
            this.btn_thoat.TabIndex = 4;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_cap
            // 
            this.btn_cap.Location = new System.Drawing.Point(357, 265);
            this.btn_cap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cap.Name = "btn_cap";
            this.btn_cap.Size = new System.Drawing.Size(118, 36);
            this.btn_cap.TabIndex = 5;
            this.btn_cap.Text = "Cấp";
            this.btn_cap.Click += new System.EventHandler(this.btn_cap_Click);
            // 
            // v_DSROLETableAdapter
            // 
            this.v_DSROLETableAdapter.ClearBeforeFill = true;
            // 
            // v_DSquyenTableAdapter
            // 
            this.v_DSquyenTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(213, 265);
            this.btn_Load.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(118, 36);
            this.btn_Load.TabIndex = 6;
            this.btn_Load.Text = "Load";
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // Form_phanquyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 338);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.btn_cap);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.cmb_quyen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_role);
            this.Name = "Form_phanquyen";
            this.Text = "Form_phanquyen";
            this.Load += new System.EventHandler(this.Form_phanquyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vDSROLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSquyenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_role;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_quyen;
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
        private DevExpress.XtraEditors.SimpleButton btn_cap;
        private DS dS;
        private System.Windows.Forms.BindingSource vDSROLEBindingSource;
        private DSTableAdapters.V_DSROLETableAdapter v_DSROLETableAdapter;
        private System.Windows.Forms.BindingSource vDSquyenBindingSource;
        private DSTableAdapters.V_DSquyenTableAdapter v_DSquyenTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btn_Load;
    }
}