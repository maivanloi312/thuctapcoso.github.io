
namespace TRACNGHIEM
{
    partial class Form_FullBackup
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
            this.txt_duongdan = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_fullbackup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_duongdan
            // 
            this.txt_duongdan.Location = new System.Drawing.Point(109, 127);
            this.txt_duongdan.Name = "txt_duongdan";
            this.txt_duongdan.Size = new System.Drawing.Size(415, 22);
            this.txt_duongdan.TabIndex = 1;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(549, 123);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(86, 30);
            this.btn_browse.TabIndex = 2;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(247, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "Full Backup";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_fullbackup
            // 
            this.btn_fullbackup.Location = new System.Drawing.Point(284, 175);
            this.btn_fullbackup.Name = "btn_fullbackup";
            this.btn_fullbackup.Size = new System.Drawing.Size(115, 50);
            this.btn_fullbackup.TabIndex = 5;
            this.btn_fullbackup.Text = "Backup";
            this.btn_fullbackup.UseVisualStyleBackColor = true;
            this.btn_fullbackup.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // Form_FullBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 275);
            this.Controls.Add(this.btn_fullbackup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.txt_duongdan);
            this.Name = "Form_FullBackup";
            this.Text = "Form_FullBackup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_duongdan;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_fullbackup;
    }
}