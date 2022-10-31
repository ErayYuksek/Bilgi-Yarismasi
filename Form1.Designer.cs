namespace Bilgi_Yarışması
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSoruNo = new System.Windows.Forms.Label();
            this.lblYAnlısSayısı = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnA = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnB = new System.Windows.Forms.Button();
            this.BtnD = new System.Windows.Forms.Button();
            this.lblDogruSayısı = new System.Windows.Forms.Label();
            this.lblDogruCevap = new System.Windows.Forms.Label();
            this.lblverilenCevap = new System.Windows.Forms.Label();
            this.BtnSonraki = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soru ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(580, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dogru Sayısı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(575, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yanlış Sayısı  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(580, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Soru No :";
            // 
            // lblSoruNo
            // 
            this.lblSoruNo.AutoSize = true;
            this.lblSoruNo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoruNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSoruNo.Location = new System.Drawing.Point(725, 31);
            this.lblSoruNo.Name = "lblSoruNo";
            this.lblSoruNo.Size = new System.Drawing.Size(24, 25);
            this.lblSoruNo.TabIndex = 0;
            this.lblSoruNo.Text = "0";
            // 
            // lblYAnlısSayısı
            // 
            this.lblYAnlısSayısı.AutoSize = true;
            this.lblYAnlısSayısı.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYAnlısSayısı.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblYAnlısSayısı.Location = new System.Drawing.Point(725, 155);
            this.lblYAnlısSayısı.Name = "lblYAnlısSayısı";
            this.lblYAnlısSayısı.Size = new System.Drawing.Size(24, 25);
            this.lblYAnlısSayısı.TabIndex = 0;
            this.lblYAnlısSayısı.Text = "0";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(78, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(451, 159);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Türkiyenin Başkenti neresidir ";
            // 
            // BtnA
            // 
            this.BtnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnA.Location = new System.Drawing.Point(37, 219);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(218, 57);
            this.BtnA.TabIndex = 3;
            this.BtnA.Text = "Ankara";
            this.BtnA.UseVisualStyleBackColor = true;
            this.BtnA.Click += new System.EventHandler(this.BtnA_Click);
            // 
            // BtnC
            // 
            this.BtnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnC.Location = new System.Drawing.Point(37, 321);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(218, 57);
            this.BtnC.TabIndex = 3;
            this.BtnC.Text = "Bursa";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnB
            // 
            this.BtnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnB.Location = new System.Drawing.Point(316, 219);
            this.BtnB.Name = "BtnB";
            this.BtnB.Size = new System.Drawing.Size(218, 57);
            this.BtnB.TabIndex = 3;
            this.BtnB.Text = "İstanbul";
            this.BtnB.UseVisualStyleBackColor = true;
            this.BtnB.Click += new System.EventHandler(this.BtnB_Click);
            // 
            // BtnD
            // 
            this.BtnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnD.Location = new System.Drawing.Point(311, 321);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(218, 57);
            this.BtnD.TabIndex = 3;
            this.BtnD.Text = "Antalya";
            this.BtnD.UseVisualStyleBackColor = true;
            this.BtnD.Click += new System.EventHandler(this.BtnD_Click);
            // 
            // lblDogruSayısı
            // 
            this.lblDogruSayısı.AutoSize = true;
            this.lblDogruSayısı.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogruSayısı.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDogruSayısı.Location = new System.Drawing.Point(725, 94);
            this.lblDogruSayısı.Name = "lblDogruSayısı";
            this.lblDogruSayısı.Size = new System.Drawing.Size(24, 25);
            this.lblDogruSayısı.TabIndex = 5;
            this.lblDogruSayısı.Text = "0";
            // 
            // lblDogruCevap
            // 
            this.lblDogruCevap.AutoSize = true;
            this.lblDogruCevap.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogruCevap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDogruCevap.Location = new System.Drawing.Point(605, 283);
            this.lblDogruCevap.Name = "lblDogruCevap";
            this.lblDogruCevap.Size = new System.Drawing.Size(117, 25);
            this.lblDogruCevap.TabIndex = 7;
            this.lblDogruCevap.Text = "DogruCevap";
            this.lblDogruCevap.Visible = false;
            // 
            // lblverilenCevap
            // 
            this.lblverilenCevap.AutoSize = true;
            this.lblverilenCevap.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblverilenCevap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblverilenCevap.Location = new System.Drawing.Point(605, 336);
            this.lblverilenCevap.Name = "lblverilenCevap";
            this.lblverilenCevap.Size = new System.Drawing.Size(122, 25);
            this.lblverilenCevap.TabIndex = 8;
            this.lblverilenCevap.Text = "verilenCevap";
            this.lblverilenCevap.Visible = false;
            // 
            // BtnSonraki
            // 
            this.BtnSonraki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSonraki.Location = new System.Drawing.Point(570, 200);
            this.BtnSonraki.Name = "BtnSonraki";
            this.BtnSonraki.Size = new System.Drawing.Size(218, 31);
            this.BtnSonraki.TabIndex = 9;
            this.BtnSonraki.Text = "Sonraki";
            this.BtnSonraki.UseVisualStyleBackColor = true;
            this.BtnSonraki.Click += new System.EventHandler(this.BtnSonraki_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSonraki);
            this.Controls.Add(this.lblverilenCevap);
            this.Controls.Add(this.lblDogruCevap);
            this.Controls.Add(this.lblDogruSayısı);
            this.Controls.Add(this.BtnD);
            this.Controls.Add(this.BtnB);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnA);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblYAnlısSayısı);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSoruNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bilgi Yarışması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSoruNo;
        private System.Windows.Forms.Label lblYAnlısSayısı;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnA;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnB;
        private System.Windows.Forms.Button BtnD;
        private System.Windows.Forms.Label lblDogruSayısı;
        private System.Windows.Forms.Label lblDogruCevap;
        private System.Windows.Forms.Label lblverilenCevap;
        private System.Windows.Forms.Button BtnSonraki;
    }
}

