
namespace WindowsForm4
{
    partial class Form1
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
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.lbl_sonuc2 = new System.Windows.Forms.Label();
            this.btn_cıkısYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_sonuc.Location = new System.Drawing.Point(76, 61);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(60, 17);
            this.lbl_sonuc.TabIndex = 0;
            this.lbl_sonuc.Text = "Sonuc : ";
            this.lbl_sonuc.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_sonuc2
            // 
            this.lbl_sonuc2.AutoSize = true;
            this.lbl_sonuc2.Location = new System.Drawing.Point(186, 61);
            this.lbl_sonuc2.Name = "lbl_sonuc2";
            this.lbl_sonuc2.Size = new System.Drawing.Size(12, 17);
            this.lbl_sonuc2.TabIndex = 1;
            this.lbl_sonuc2.Text = ".";
            // 
            // btn_cıkısYap
            // 
            this.btn_cıkısYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_cıkısYap.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cıkısYap.Location = new System.Drawing.Point(79, 96);
            this.btn_cıkısYap.Name = "btn_cıkısYap";
            this.btn_cıkısYap.Size = new System.Drawing.Size(163, 57);
            this.btn_cıkısYap.TabIndex = 2;
            this.btn_cıkısYap.TabStop = false;
            this.btn_cıkısYap.Text = "Çıkış Yap";
            this.btn_cıkısYap.UseVisualStyleBackColor = false;
            this.btn_cıkısYap.Click += new System.EventHandler(this.btn_cıkısYap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(447, 322);
            this.Controls.Add(this.btn_cıkısYap);
            this.Controls.Add(this.lbl_sonuc2);
            this.Controls.Add(this.lbl_sonuc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_sonuc;
        private System.Windows.Forms.Label lbl_sonuc2;
        private System.Windows.Forms.Button btn_cıkısYap;
    }
}

