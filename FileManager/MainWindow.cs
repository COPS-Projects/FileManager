// *
// * ******** TQ File Manager - Open Source ********
// * Copyright (C) 2015 Jean-Philippe Boivin
// *
// * Please read the WARNING, DISCLAIMER and PATENTS
// * sections in the LICENSE file.
// *

using FileManager.Security.Cryptography;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace FileManager
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtSource.Text))
                saveFileDialog.ShowDialog();
            else
                MessageBox.Show("Please select a valid source.", "File not found !",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            txtSource.Text = openFileDialog.FileName;
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            var path = saveFileDialog.FileName;

            if (!File.Exists(txtSource.Text))
                MessageBox.Show("Please select a valid source.", "File not found !",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (!File.Exists(path))
                MessageBox.Show("Please select a valid destination.", "File not found !",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            UInt32 seed = 0;
            if (!UInt32.TryParse(txtKey.Text, out seed))
                MessageBox.Show("Please specify a valid key for the cipher.", "Invalid key !",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            var cipher = new FileCipher(seed);
            byte[] buffer = new byte[4096];
            int read = 0;

            bool encrypt = rbtnEncrypt.Checked;

            try
            {
                using (var input = new FileStream(txtSource.Text, FileMode.Open, FileAccess.Read))
                {
                    using (var output = new FileStream(path, FileMode.Create, FileAccess.Write))
                    {
                        read = input.Read(buffer, 0, buffer.Length);
                        while (read > 0)
                        {
                            if (encrypt)
                                cipher.Encrypt(ref buffer, read);
                            else
                                cipher.Decrypt(ref buffer, read);

                            output.Write(buffer, 0, read);
                            read = input.Read(buffer, 0, buffer.Length);
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                var type = exc.GetType().ToString();
                var msg = exc.Message;

                MessageBox.Show(
                    String.Format("Something wrong happened while saving the encrypted/decrypted file.\n{0}: {1}", type, msg), "Error !",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
