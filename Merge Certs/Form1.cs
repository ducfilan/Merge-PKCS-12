using System;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Merge_Certs
{
    public partial class Form1 : Form
    {
        private const string CertPassword = "fuji";

        public Form1()
        {
            InitializeComponent();

            txtCertFiles.Text = string.Join("\r\n", Properties.Settings.Default.SourceCertFilesPath.Cast<string>().ToArray());
            txtOutputFile.Text = Properties.Settings.Default.TargetCertFilePath;
        }

        private void btnSelectCertFiles_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            txtCertFiles.Text = string.Join("\r\n", openFileDialog.FileNames);

            var sourceCertFilesPath = new StringCollection();
            sourceCertFilesPath.AddRange(openFileDialog.FileNames);
            Properties.Settings.Default.SourceCertFilesPath = sourceCertFilesPath;
            Properties.Settings.Default.Save();
        }

        private void btnCombineCertFiles_Click(object sender, EventArgs e)
        {
            var certs = new X509Certificate2Collection();

            foreach (var certFile in txtCertFiles.Text.Split("\r\n".ToCharArray()))
            {
                certs.Add(new X509Certificate2(certFile, CertPassword, X509KeyStorageFlags.Exportable));
            }

            var oneBigPfx = certs.Export(X509ContentType.Pfx, CertPassword);
            File.WriteAllBytes(txtOutputFile.Text, oneBigPfx);

            MessageBox.Show("Combination has been done!", "Done", MessageBoxButtons.OK);
        }

        private void btnBrowseOutputFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            txtOutputFile.Text = saveFileDialog.FileName;
            Properties.Settings.Default.TargetCertFilePath = txtOutputFile.Text;
            Properties.Settings.Default.Save();
        }
    }
}
