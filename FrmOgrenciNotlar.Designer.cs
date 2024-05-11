namespace Okul_Projesi
{
    partial class FrmOgrenciNotlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenciNotlar));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelçıkış = new System.Windows.Forms.Label();
            this.btnÇıkış = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 76);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1386, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelçıkış
            // 
            this.labelçıkış.AutoSize = true;
            this.labelçıkış.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelçıkış.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelçıkış.Location = new System.Drawing.Point(1246, 7);
            this.labelçıkış.Name = "labelçıkış";
            this.labelçıkış.Size = new System.Drawing.Size(95, 28);
            this.labelçıkış.TabIndex = 28;
            this.labelçıkış.Text = "Çıkış Yap";
            // 
            // btnÇıkış
            // 
            this.btnÇıkış.BackColor = System.Drawing.Color.Transparent;
            this.btnÇıkış.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnÇıkış.BackgroundImage")));
            this.btnÇıkış.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnÇıkış.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnÇıkış.FlatAppearance.BorderSize = 0;
            this.btnÇıkış.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnÇıkış.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnÇıkış.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnÇıkış.ForeColor = System.Drawing.Color.Transparent;
            this.btnÇıkış.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnÇıkış.Location = new System.Drawing.Point(1338, 12);
            this.btnÇıkış.Name = "btnÇıkış";
            this.btnÇıkış.Size = new System.Drawing.Size(36, 37);
            this.btnÇıkış.TabIndex = 27;
            this.btnÇıkış.UseVisualStyleBackColor = false;
            this.btnÇıkış.Click += new System.EventHandler(this.btnÇıkış_Click);
            this.btnÇıkış.MouseLeave += new System.EventHandler(this.btnÇıkış_MouseLeave);
            this.btnÇıkış.MouseHover += new System.EventHandler(this.btnÇıkış_MouseHover);
            // 
            // FrmOgrenciNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 362);
            this.Controls.Add(this.labelçıkış);
            this.Controls.Add(this.btnÇıkış);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmOgrenciNotlar";
            this.Load += new System.EventHandler(this.FrmOgrenciNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelçıkış;
        private System.Windows.Forms.Button btnÇıkış;
    }
}