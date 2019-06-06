// *
// * ******** TQ File Manager - Open Source ********
// * Copyright (C) 2015 Jean-Philippe Boivin
// *
// * Please read the WARNING, DISCLAIMER and PATENTS
// * sections in the LICENSE file.
// *

namespace FileManager
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.lblSource = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.rbtnEncrypt = new System.Windows.Forms.RadioButton();
            this.rbtnDecrypt = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(13, 15);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(47, 13);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Source :";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(13, 41);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(31, 13);
            this.lblKey.TabIndex = 2;
            this.lblKey.Text = "Key :";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(66, 12);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(145, 20);
            this.txtSource.TabIndex = 3;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(66, 38);
            this.txtKey.MaxLength = 8;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(78, 20);
            this.txtKey.TabIndex = 5;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(217, 9);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(62, 23);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(109, 84);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "TXT files|*.txt|DAT files|*.dat|All files|*.*";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "dat";
            this.openFileDialog.Filter = "DAT files|*.dat|TXT files|*.txt|All files|*.*";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // rbtnEncrypt
            // 
            this.rbtnEncrypt.AutoSize = true;
            this.rbtnEncrypt.Location = new System.Drawing.Point(150, 37);
            this.rbtnEncrypt.Name = "rbtnEncrypt";
            this.rbtnEncrypt.Size = new System.Drawing.Size(61, 17);
            this.rbtnEncrypt.TabIndex = 8;
            this.rbtnEncrypt.Text = "Encrypt";
            this.rbtnEncrypt.UseVisualStyleBackColor = true;
            // 
            // rbtnDecrypt
            // 
            this.rbtnDecrypt.AutoSize = true;
            this.rbtnDecrypt.Checked = true;
            this.rbtnDecrypt.Location = new System.Drawing.Point(217, 37);
            this.rbtnDecrypt.Name = "rbtnDecrypt";
            this.rbtnDecrypt.Size = new System.Drawing.Size(62, 17);
            this.rbtnDecrypt.TabIndex = 9;
            this.rbtnDecrypt.TabStop = true;
            this.rbtnDecrypt.Text = "Decrypt";
            this.rbtnDecrypt.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 117);
            this.Controls.Add(this.rbtnDecrypt);
            this.Controls.Add(this.rbtnEncrypt);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblSource);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "TQ File Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.RadioButton rbtnEncrypt;
        private System.Windows.Forms.RadioButton rbtnDecrypt;
    }
}

