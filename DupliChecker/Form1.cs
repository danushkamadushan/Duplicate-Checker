using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DupliChecker
{
    public partial class Main : Form
    {
        [DllImport("kernel32.dll")]
        static extern bool CreateSymbolicLink(string lpSymlinkFileName, string lpTargetFileName, SymbolicLink dwFlags);
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        static string GetHash(string path)
        {
            using (var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                return Encoding.UTF8.GetString(new SHA1Managed().ComputeHash(fileStream));
            }
        }

        enum SymbolicLink
        {
            File = 0,
            Directory = 1
        }

        private void GenarateSymlink(string fname)
        {
            string dupliName = fname.Replace(original_textBox.Text, @"\");
            string symbolicLink = symlink_textBox.Text + dupliName; //symlink location
            string fileName = fname; //original file location

            CreateSymbolicLink(symbolicLink, fileName, SymbolicLink.File);
        }

        private void originalbtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        original_textBox.Text = fbd.SelectedPath;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        List<string> duplicateFileNameList;
        private void check_button_Click(object sender, EventArgs e)
        {
            size = 0;
            listBox.DataSource = null;
            listBox.Items.Clear();
            duplicateFileNameList = new List<string>();
            try
            {
                if (!string.IsNullOrWhiteSpace(original_textBox.Text) && !string.IsNullOrWhiteSpace(symlink_textBox.Text))
                {
                    var getfilenames = Directory.GetFiles(original_textBox.Text)
                      .Select(
                      f => new
                      {
                          FileName = f,
                          FileHash = GetHash(f)
                      })
                      .GroupBy(f => f.FileHash)
                      .Select(g => new { FileHash = g.Key, Files = g.Select(z => z.FileName).ToList() })
                      .SelectMany(f => f.Files.Skip(1))
                      .ToList();

                    listBox.DataSource = getfilenames;

                    if (getfilenames.Count > 0)
                    {
                        duplicateFileNameList = getfilenames;
                        foreach (var fname in getfilenames)
                        {
                            GenarateSymlink(fname);
                            GetTotalSpaceWastage(fname);
                        }

                        string s = FormatSize(size);

                        label2.Text = "Total space wasted: " + (s).ToString();
                    }
                    else
                    {
                        MessageBox.Show("No duplicate file found in selected location", "No Duplicates");
                    }

                }
                else
                {
                    MessageBox.Show("Folder path cannot be null", "Error");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        static readonly string[] suffixes = { "Bytes", "KB", "MB", "GB", "TB", "PB" };
        public static string FormatSize(Int64 bytes)
        {
            int counter = 0;
            decimal number = (decimal)bytes;
            while (Math.Round(number / 1024) >= 1)
            {
                number = number / 1024;
                counter++;
            }
            return string.Format("{0:n1}{1}", number, suffixes[counter]);
        }

        public long size = 0;
        private void GetTotalSpaceWastage(string fileName)
        {
            FileInfo fi = new FileInfo(fileName);
            size = size + fi.Length;
        }

        private void symlincbtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        symlink_textBox.Text = fbd.SelectedPath;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox.Items.Count > 0)
                {
                    if (duplicateFileNameList.Count > 0)
                    {
                        duplicateFileNameList.ForEach(File.Delete);
                        listBox.DataSource = null;
                        listBox.Items.Clear();
                        size = 0;
                    }
                    else
                    {
                        MessageBox.Show("No duplicate file(s) to delete", "No Duplicates");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
