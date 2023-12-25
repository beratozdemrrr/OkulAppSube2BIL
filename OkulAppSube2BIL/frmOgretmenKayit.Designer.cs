namespace OkulAppSube2BIL
{
    partial class frmOgretmenKayit
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
            this.grpOgretmen = new System.Windows.Forms.GroupBox();
            this.btnOgrtmnKaydet = new System.Windows.Forms.Button();
            this.txtOgrtmnAd = new System.Windows.Forms.TextBox();
            this.txtOgrtmnSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrtmnTc = new System.Windows.Forms.TextBox();
            this.lblOgrtmnAd = new System.Windows.Forms.Label();
            this.lblOgrtmnSoyad = new System.Windows.Forms.Label();
            this.lblOgrtmnTc = new System.Windows.Forms.Label();
            this.grpOgretmen.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOgretmen
            // 
            this.grpOgretmen.Controls.Add(this.lblOgrtmnTc);
            this.grpOgretmen.Controls.Add(this.lblOgrtmnSoyad);
            this.grpOgretmen.Controls.Add(this.lblOgrtmnAd);
            this.grpOgretmen.Controls.Add(this.txtOgrtmnTc);
            this.grpOgretmen.Controls.Add(this.txtOgrtmnSoyad);
            this.grpOgretmen.Controls.Add(this.txtOgrtmnAd);
            this.grpOgretmen.Location = new System.Drawing.Point(44, 28);
            this.grpOgretmen.Name = "grpOgretmen";
            this.grpOgretmen.Size = new System.Drawing.Size(358, 216);
            this.grpOgretmen.TabIndex = 0;
            this.grpOgretmen.TabStop = false;
            this.grpOgretmen.Text = "Öğretmen Bilgileri";
            // 
            // btnOgrtmnKaydet
            // 
            this.btnOgrtmnKaydet.Location = new System.Drawing.Point(105, 262);
            this.btnOgrtmnKaydet.Name = "btnOgrtmnKaydet";
            this.btnOgrtmnKaydet.Size = new System.Drawing.Size(237, 39);
            this.btnOgrtmnKaydet.TabIndex = 1;
            this.btnOgrtmnKaydet.Text = "Kaydet";
            this.btnOgrtmnKaydet.UseVisualStyleBackColor = true;
            this.btnOgrtmnKaydet.Click += new System.EventHandler(this.btnOgrtmnKaydet_Click);
            // 
            // txtOgrtmnAd
            // 
            this.txtOgrtmnAd.Location = new System.Drawing.Point(193, 63);
            this.txtOgrtmnAd.Name = "txtOgrtmnAd";
            this.txtOgrtmnAd.Size = new System.Drawing.Size(100, 22);
            this.txtOgrtmnAd.TabIndex = 0;
            // 
            // txtOgrtmnSoyad
            // 
            this.txtOgrtmnSoyad.Location = new System.Drawing.Point(193, 101);
            this.txtOgrtmnSoyad.Name = "txtOgrtmnSoyad";
            this.txtOgrtmnSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtOgrtmnSoyad.TabIndex = 1;
            // 
            // txtOgrtmnTc
            // 
            this.txtOgrtmnTc.Location = new System.Drawing.Point(193, 144);
            this.txtOgrtmnTc.Name = "txtOgrtmnTc";
            this.txtOgrtmnTc.Size = new System.Drawing.Size(100, 22);
            this.txtOgrtmnTc.TabIndex = 2;
            // 
            // lblOgrtmnAd
            // 
            this.lblOgrtmnAd.AutoSize = true;
            this.lblOgrtmnAd.Location = new System.Drawing.Point(45, 63);
            this.lblOgrtmnAd.Name = "lblOgrtmnAd";
            this.lblOgrtmnAd.Size = new System.Drawing.Size(24, 16);
            this.lblOgrtmnAd.TabIndex = 3;
            this.lblOgrtmnAd.Text = "Ad";
            // 
            // lblOgrtmnSoyad
            // 
            this.lblOgrtmnSoyad.AutoSize = true;
            this.lblOgrtmnSoyad.Location = new System.Drawing.Point(45, 101);
            this.lblOgrtmnSoyad.Name = "lblOgrtmnSoyad";
            this.lblOgrtmnSoyad.Size = new System.Drawing.Size(47, 16);
            this.lblOgrtmnSoyad.TabIndex = 4;
            this.lblOgrtmnSoyad.Text = "Soyad";
            // 
            // lblOgrtmnTc
            // 
            this.lblOgrtmnTc.AutoSize = true;
            this.lblOgrtmnTc.Location = new System.Drawing.Point(45, 144);
            this.lblOgrtmnTc.Name = "lblOgrtmnTc";
            this.lblOgrtmnTc.Size = new System.Drawing.Size(116, 16);
            this.lblOgrtmnTc.TabIndex = 5;
            this.lblOgrtmnTc.Text = "TcKimlikNumarası";
            // 
            // frmOgretmenKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 330);
            this.Controls.Add(this.btnOgrtmnKaydet);
            this.Controls.Add(this.grpOgretmen);
            this.Name = "frmOgretmenKayit";
            this.Text = "frmOgretmenKayit";
            this.grpOgretmen.ResumeLayout(false);
            this.grpOgretmen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOgretmen;
        private System.Windows.Forms.Button btnOgrtmnKaydet;
        private System.Windows.Forms.Label lblOgrtmnTc;
        private System.Windows.Forms.Label lblOgrtmnSoyad;
        private System.Windows.Forms.Label lblOgrtmnAd;
        private System.Windows.Forms.TextBox txtOgrtmnTc;
        private System.Windows.Forms.TextBox txtOgrtmnSoyad;
        private System.Windows.Forms.TextBox txtOgrtmnAd;
    }
}