
namespace TRACNGHIEM
{
    partial class Form_DiffBackup
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
            this.label = new System.Windows.Forms.Label();
            this.txt_duongdan = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_diffbackup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label.Location = new System.Drawing.Point(296, 65);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(193, 52);
            this.label.TabIndex = 5;
            this.label.Text = "Diff Backup";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_duongdan
            // 
            this.txt_duongdan.Location = new System.Drawing.Point(148, 132);
            this.txt_duongdan.Name = "txt_duongdan";
            this.txt_duongdan.Size = new System.Drawing.Size(415, 22);
            this.txt_duongdan.TabIndex = 6;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(590, 128);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(86, 30);
            this.btn_browse.TabIndex = 7;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_diffbackup
            // 
            this.btn_diffbackup.Location = new System.Drawing.Point(333, 179);
            this.btn_diffbackup.Name = "btn_diffbackup";
            this.btn_diffbackup.Size = new System.Drawing.Size(115, 50);
            this.btn_diffbackup.TabIndex = 8;
            this.btn_diffbackup.Text = "Backup";
            this.btn_diffbackup.UseVisualStyleBackColor = true;
            this.btn_diffbackup.Click += new System.EventHandler(this.btn_diffbackup_Click);
            // 
            // Form_DiffBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_diffbackup);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.txt_duongdan);
            this.Controls.Add(this.label);
            this.Name = "Form_DiffBackup";
            this.Text = "Form_DiffBackup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txt_duongdan;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_diffbackup;
    }
}