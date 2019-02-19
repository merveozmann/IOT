namespace translete
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.en2 = new System.Windows.Forms.RadioButton();
            this.tr2 = new System.Windows.Forms.RadioButton();
            this.de2 = new System.Windows.Forms.RadioButton();
            this.de1 = new System.Windows.Forms.RadioButton();
            this.tr1 = new System.Windows.Forms.RadioButton();
            this.en1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sonuç = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "ÇEVİR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(154, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 22);
            this.textBox2.TabIndex = 2;
            // 
            // en2
            // 
            this.en2.AutoSize = true;
            this.en2.Location = new System.Drawing.Point(50, 24);
            this.en2.Name = "en2";
            this.en2.Size = new System.Drawing.Size(45, 21);
            this.en2.TabIndex = 3;
            this.en2.TabStop = true;
            this.en2.Text = "en";
            this.en2.UseVisualStyleBackColor = true;
            this.en2.CheckedChanged += new System.EventHandler(this.en2_CheckedChanged);
            // 
            // tr2
            // 
            this.tr2.AutoSize = true;
            this.tr2.Location = new System.Drawing.Point(50, 74);
            this.tr2.Name = "tr2";
            this.tr2.Size = new System.Drawing.Size(38, 21);
            this.tr2.TabIndex = 4;
            this.tr2.TabStop = true;
            this.tr2.Text = "tr";
            this.tr2.UseVisualStyleBackColor = true;
            this.tr2.CheckedChanged += new System.EventHandler(this.tr2_CheckedChanged);
            // 
            // de2
            // 
            this.de2.AutoSize = true;
            this.de2.Location = new System.Drawing.Point(50, 123);
            this.de2.Name = "de2";
            this.de2.Size = new System.Drawing.Size(45, 21);
            this.de2.TabIndex = 5;
            this.de2.TabStop = true;
            this.de2.Text = "de";
            this.de2.UseVisualStyleBackColor = true;
            this.de2.CheckedChanged += new System.EventHandler(this.de2_CheckedChanged);
            // 
            // de1
            // 
            this.de1.AutoSize = true;
            this.de1.Location = new System.Drawing.Point(33, 113);
            this.de1.Name = "de1";
            this.de1.Size = new System.Drawing.Size(45, 21);
            this.de1.TabIndex = 9;
            this.de1.TabStop = true;
            this.de1.Text = "de";
            this.de1.UseVisualStyleBackColor = true;
            this.de1.CheckedChanged += new System.EventHandler(this.de1_CheckedChanged);
            // 
            // tr1
            // 
            this.tr1.AutoSize = true;
            this.tr1.Location = new System.Drawing.Point(33, 64);
            this.tr1.Name = "tr1";
            this.tr1.Size = new System.Drawing.Size(38, 21);
            this.tr1.TabIndex = 8;
            this.tr1.TabStop = true;
            this.tr1.Text = "tr";
            this.tr1.UseVisualStyleBackColor = true;
            this.tr1.CheckedChanged += new System.EventHandler(this.tr1_CheckedChanged);
            // 
            // en1
            // 
            this.en1.AutoSize = true;
            this.en1.Location = new System.Drawing.Point(33, 14);
            this.en1.Name = "en1";
            this.en1.Size = new System.Drawing.Size(45, 21);
            this.en1.TabIndex = 7;
            this.en1.TabStop = true;
            this.en1.Text = "en";
            this.en1.UseVisualStyleBackColor = true;
            this.en1.CheckedChanged += new System.EventHandler(this.en1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 22);
            this.textBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kelime";
            // 
            // Sonuç
            // 
            this.Sonuç.AutoSize = true;
            this.Sonuç.Location = new System.Drawing.Point(154, 103);
            this.Sonuç.Name = "Sonuç";
            this.Sonuç.Size = new System.Drawing.Size(48, 17);
            this.Sonuç.TabIndex = 12;
            this.Sonuç.Text = "Sonuç";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.en1);
            this.panel1.Controls.Add(this.tr1);
            this.panel1.Controls.Add(this.de1);
            this.panel1.Location = new System.Drawing.Point(35, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 147);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.en2);
            this.panel2.Controls.Add(this.tr2);
            this.panel2.Controls.Add(this.de2);
            this.panel2.Location = new System.Drawing.Point(384, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 165);
            this.panel2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 384);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Sonuç);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton en2;
        private System.Windows.Forms.RadioButton tr2;
        private System.Windows.Forms.RadioButton de2;
        private System.Windows.Forms.RadioButton de1;
        private System.Windows.Forms.RadioButton tr1;
        private System.Windows.Forms.RadioButton en1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Sonuç;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

