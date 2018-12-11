namespace Merge_Certs
{
    partial class Form1
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtCertFiles = new System.Windows.Forms.RichTextBox();
            this.btnSelectCertFiles = new System.Windows.Forms.Button();
            this.btnCombineCertFiles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseOutputFile = new System.Windows.Forms.Button();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCertPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Cert files|*.pfx;*.p12";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.Title = "Select your certs";
            // 
            // txtCertFiles
            // 
            this.txtCertFiles.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCertFiles.Location = new System.Drawing.Point(12, 21);
            this.txtCertFiles.Name = "txtCertFiles";
            this.txtCertFiles.ReadOnly = true;
            this.txtCertFiles.Size = new System.Drawing.Size(695, 246);
            this.txtCertFiles.TabIndex = 0;
            this.txtCertFiles.Text = "";
            // 
            // btnSelectCertFiles
            // 
            this.btnSelectCertFiles.Location = new System.Drawing.Point(713, 19);
            this.btnSelectCertFiles.Name = "btnSelectCertFiles";
            this.btnSelectCertFiles.Size = new System.Drawing.Size(75, 23);
            this.btnSelectCertFiles.TabIndex = 1;
            this.btnSelectCertFiles.Text = "Browse";
            this.btnSelectCertFiles.UseVisualStyleBackColor = true;
            this.btnSelectCertFiles.Click += new System.EventHandler(this.btnSelectCertFiles_Click);
            // 
            // btnCombineCertFiles
            // 
            this.btnCombineCertFiles.Location = new System.Drawing.Point(277, 364);
            this.btnCombineCertFiles.Name = "btnCombineCertFiles";
            this.btnCombineCertFiles.Size = new System.Drawing.Size(168, 74);
            this.btnCombineCertFiles.TabIndex = 2;
            this.btnCombineCertFiles.Text = "Combine certs";
            this.btnCombineCertFiles.UseVisualStyleBackColor = true;
            this.btnCombineCertFiles.Click += new System.EventHandler(this.btnCombineCertFiles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cert files";
            // 
            // btnBrowseOutputFile
            // 
            this.btnBrowseOutputFile.Location = new System.Drawing.Point(713, 327);
            this.btnBrowseOutputFile.Name = "btnBrowseOutputFile";
            this.btnBrowseOutputFile.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseOutputFile.TabIndex = 4;
            this.btnBrowseOutputFile.Text = "Browse";
            this.btnBrowseOutputFile.UseVisualStyleBackColor = true;
            this.btnBrowseOutputFile.Click += new System.EventHandler(this.btnBrowseOutputFile_Click);
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtOutputFile.Location = new System.Drawing.Point(12, 329);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.ReadOnly = true;
            this.txtOutputFile.Size = new System.Drawing.Size(695, 19);
            this.txtOutputFile.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output file";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Cert files|*.pfx;*.p12";
            this.saveFileDialog.Title = "Specify your file to save";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cert password";
            // 
            // txtCertPassword
            // 
            this.txtCertPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCertPassword.Location = new System.Drawing.Point(12, 292);
            this.txtCertPassword.Name = "txtCertPassword";
            this.txtCertPassword.Size = new System.Drawing.Size(695, 19);
            this.txtCertPassword.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCertPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOutputFile);
            this.Controls.Add(this.btnBrowseOutputFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCombineCertFiles);
            this.Controls.Add(this.btnSelectCertFiles);
            this.Controls.Add(this.txtCertFiles);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Merge Certs | FPT-Nghiaduc_Hoang@jmas.co.jp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.RichTextBox txtCertFiles;
        private System.Windows.Forms.Button btnSelectCertFiles;
        private System.Windows.Forms.Button btnCombineCertFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseOutputFile;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCertPassword;
    }
}

