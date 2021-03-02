using BitRotate.FileNetwork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitRotate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openFileDialog1.FileName;
                BtnOpen.Enabled = false;
                BtnSave.Enabled = true;
                btnClean.Enabled = true;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtShift.Text) == 0)
            {
                MessageBox.Show("select a number!", "BitRotate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BtnSave.Enabled = false;
            btnClean.Enabled = false;
            byte[] data = File.ReadAllBytes(txtPath.Text);
            if (data.Length > 0)
            {
                for (var i = 0; i < data.Length; i += 2048)
                {
                    if (chkBoxEnc.Checked)
                    {
                        Shift.Encrypt(data, i, 2048, int.Parse(txtShift.Text));
                    }
                    else if (chkBoxDec.Checked)
                    {
                        Shift.Decrypt(data, i, 2048, int.Parse(txtShift.Text));
                    }
                }
                SaveFile(data);
            }
        }
        public async void SaveFile(byte[] buffer)
        {
            await Task.Run(() =>
                {
                    for (var i = 0; i < buffer.Length; i++)
                    {
                        using (FileStream stream = new FileStream(txtPath.Text, FileMode.Create))
                        {
                            stream.Write(buffer, 0, buffer.Length);
                        }
                    }
                    string newPath = Application.StartupPath + @"\BitRotate.log";
                    using(StreamWriter stream = new StreamWriter(newPath, true))
                    {
                        stream.WriteLine("Path: " + txtPath.Text);
                        stream.WriteLine("the size of the matrix: " + buffer.Length);
                        stream.WriteLine("Shift: " + int.Parse(txtShift.Text));
                        stream.WriteLine("Encrypt: " + chkBoxEnc.Checked);
                        stream.WriteLine("Decrypt: " + chkBoxDec.Checked);
                        stream.WriteLine(Environment.NewLine);
                        stream.Flush();
                        stream.Dispose();
                    }
                });
            BtnSave.Enabled = true;
            btnClean.Enabled = true;
            string txt = chkBoxEnc.Checked == true ? "File successfully encrypted." : "File successfully decrypted.";
            MessageBox.Show(txt, "BitRotate", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void BtnClean_Click(object sender, EventArgs e)
        {
            BtnSave.Enabled = false;
            btnClean.Enabled = false;
            BtnOpen.Enabled = true;
            txtPath.Text = "...";
            txtShift.Text = "0";
            openFileDialog1.Reset();
            openFileDialog1.Dispose();
        }

        private void ChkBoxDec_CheckedChanged(object sender, EventArgs e)
        {
            chkBoxEnc.Checked = !chkBoxDec.Checked;
        }

        private void ChkBoxEnc_CheckedChanged(object sender, EventArgs e)
        {
            chkBoxDec.Checked = !chkBoxEnc.Checked;
        }

        private void TxtShift_TextChanged(object sender, EventArgs e)
        {
            bool detect = IsLettersToInts();
            if (detect)
            {
                MessageBox.Show("just try numbers!", "BitRotate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtShift.Text = "0";
            }
        }
        public bool IsLettersToInts()
        {
            for (int i = 0; i < txtShift.Text.Length; i++)
            {
                char txt = txtShift.Text[i];
                return char.IsLetter(txt);
            }
            return false;
        }
    }
}
