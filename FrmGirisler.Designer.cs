namespace Okul_Projesi
{
    partial class FrmGirisler
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.btnÖğrenci = new System.Windows.Forms.Button();
            this.btnÖğretmen = new System.Windows.Forms.Button();
            this.labelÖgr = new System.Windows.Forms.Label();
            this.labelOgrtmn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textno = new System.Windows.Forms.TextBox();
            this.textsifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnÖğrenci
            // 
            this.btnÖğrenci.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnÖğrenci.BackgroundImage")));
            this.btnÖğrenci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnÖğrenci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnÖğrenci.Location = new System.Drawing.Point(13, 12);
            this.btnÖğrenci.Name = "btnÖğrenci";
            this.btnÖğrenci.Size = new System.Drawing.Size(226, 170);
            this.btnÖğrenci.TabIndex = 4;
            this.btnÖğrenci.UseVisualStyleBackColor = true;
            this.btnÖğrenci.Click += new System.EventHandler(this.btnÖğrenci_Click);
            this.btnÖğrenci.MouseLeave += new System.EventHandler(this.btnÖğrenci_MouseLeave);
            this.btnÖğrenci.MouseHover += new System.EventHandler(this.btnÖğrenci_MouseHover);
            // 
            // btnÖğretmen
            // 
            this.btnÖğretmen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnÖğretmen.BackgroundImage")));
            this.btnÖğretmen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnÖğretmen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnÖğretmen.Location = new System.Drawing.Point(268, 12);
            this.btnÖğretmen.Name = "btnÖğretmen";
            this.btnÖğretmen.Size = new System.Drawing.Size(226, 170);
            this.btnÖğretmen.TabIndex = 52;
            this.btnÖğretmen.UseVisualStyleBackColor = true;
            this.btnÖğretmen.Click += new System.EventHandler(this.btnÖğretmen_Click);
            this.btnÖğretmen.MouseLeave += new System.EventHandler(this.btnÖğretmen_MouseLeave);
            this.btnÖğretmen.MouseHover += new System.EventHandler(this.btnÖğretmen_MouseHover);
            // 
            // labelÖgr
            // 
            this.labelÖgr.AutoSize = true;
            this.labelÖgr.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelÖgr.Location = new System.Drawing.Point(81, 185);
            this.labelÖgr.Name = "labelÖgr";
            this.labelÖgr.Size = new System.Drawing.Size(91, 24);
            this.labelÖgr.TabIndex = 3;
            this.labelÖgr.Text = "Öğrenci";
            // 
            // labelOgrtmn
            // 
            this.labelOgrtmn.AutoSize = true;
            this.labelOgrtmn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOgrtmn.Location = new System.Drawing.Point(325, 185);
            this.labelOgrtmn.Name = "labelOgrtmn";
            this.labelOgrtmn.Size = new System.Drawing.Size(112, 24);
            this.labelOgrtmn.TabIndex = 4;
            this.labelOgrtmn.Text = "Öğretmen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(119, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "No:";
            // 
            // textno
            // 
            this.textno.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textno.Location = new System.Drawing.Point(170, 224);
            this.textno.Name = "textno";
            this.textno.Size = new System.Drawing.Size(216, 38);
            this.textno.TabIndex = 0;
            // 
            // textsifre
            // 
            this.textsifre.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textsifre.Location = new System.Drawing.Point(170, 264);
            this.textsifre.Name = "textsifre";
            this.textsifre.Size = new System.Drawing.Size(216, 38);
            this.textsifre.TabIndex = 1;
            this.textsifre.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(103, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şifre:";
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(523, 317);
            this.Controls.Add(this.textsifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelOgrtmn);
            this.Controls.Add(this.labelÖgr);
            this.Controls.Add(this.btnÖğretmen);
            this.Controls.Add(this.btnÖğrenci);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGirisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Girişler";
            this.Load += new System.EventHandler(this.FrmGirisler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnÖğrenci;
        private System.Windows.Forms.Button btnÖğretmen;
        private System.Windows.Forms.Label labelÖgr;
        private System.Windows.Forms.Label labelOgrtmn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textno;
        private System.Windows.Forms.TextBox textsifre;
        private System.Windows.Forms.Label label4;
    }
}

