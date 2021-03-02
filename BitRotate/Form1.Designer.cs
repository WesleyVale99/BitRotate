
namespace BitRotate
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtPath = new System.Windows.Forms.TextBox();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnSave = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.chkBoxEnc = new System.Windows.Forms.CheckBox();
            this.chkBoxDec = new System.Windows.Forms.CheckBox();
            this.txtShift = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.SystemColors.Window;
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPath.Enabled = false;
            this.txtPath.ForeColor = System.Drawing.Color.Black;
            this.txtPath.Location = new System.Drawing.Point(64, 9);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(352, 20);
            this.txtPath.TabIndex = 0;
            this.txtPath.Text = "...";
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(7, 5);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(50, 49);
            this.BtnOpen.TabIndex = 1;
            this.BtnOpen.Text = "Open";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Enabled = false;
            this.BtnSave.Location = new System.Drawing.Point(342, 33);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(74, 23);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnClean
            // 
            this.btnClean.Enabled = false;
            this.btnClean.Location = new System.Drawing.Point(280, 33);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(63, 23);
            this.btnClean.TabIndex = 3;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // chkBoxEnc
            // 
            this.chkBoxEnc.AutoSize = true;
            this.chkBoxEnc.Checked = true;
            this.chkBoxEnc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxEnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBoxEnc.Location = new System.Drawing.Point(134, 34);
            this.chkBoxEnc.Name = "chkBoxEnc";
            this.chkBoxEnc.Size = new System.Drawing.Size(59, 17);
            this.chkBoxEnc.TabIndex = 5;
            this.chkBoxEnc.Text = "Encrypt";
            this.chkBoxEnc.UseVisualStyleBackColor = true;
            this.chkBoxEnc.CheckedChanged += new System.EventHandler(this.ChkBoxEnc_CheckedChanged);
            // 
            // chkBoxDec
            // 
            this.chkBoxDec.AutoSize = true;
            this.chkBoxDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBoxDec.Location = new System.Drawing.Point(196, 35);
            this.chkBoxDec.Name = "chkBoxDec";
            this.chkBoxDec.Size = new System.Drawing.Size(60, 17);
            this.chkBoxDec.TabIndex = 6;
            this.chkBoxDec.Text = "Decrypt";
            this.chkBoxDec.UseVisualStyleBackColor = true;
            this.chkBoxDec.CheckedChanged += new System.EventHandler(this.ChkBoxDec_CheckedChanged);
            // 
            // txtShift
            // 
            this.txtShift.Location = new System.Drawing.Point(64, 32);
            this.txtShift.MaxLength = 100;
            this.txtShift.Name = "txtShift";
            this.txtShift.Size = new System.Drawing.Size(27, 20);
            this.txtShift.TabIndex = 7;
            this.txtShift.Text = "0";
            this.txtShift.TextChanged += new System.EventHandler(this.TxtShift_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 57);
            this.Controls.Add(this.txtShift);
            this.Controls.Add(this.chkBoxDec);
            this.Controls.Add(this.chkBoxEnc);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.txtPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bit Rotate Files    -      Build 0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.CheckBox chkBoxEnc;
        private System.Windows.Forms.CheckBox chkBoxDec;
        private System.Windows.Forms.TextBox txtShift;
    }
}

