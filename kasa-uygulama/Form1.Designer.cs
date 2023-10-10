namespace kasa_uygulama
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.btnYatir = new System.Windows.Forms.Button();
            this.btnCek = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tutar";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(113, 47);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(222, 31);
            this.txtTutar.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBakiye);
            this.groupBox1.Location = new System.Drawing.Point(457, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 125);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hesap";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(6, 57);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(83, 25);
            this.lblBakiye.TabIndex = 0;
            this.lblBakiye.Text = "Bakiye:";
            // 
            // btnYatir
            // 
            this.btnYatir.Location = new System.Drawing.Point(113, 102);
            this.btnYatir.Name = "btnYatir";
            this.btnYatir.Size = new System.Drawing.Size(108, 54);
            this.btnYatir.TabIndex = 3;
            this.btnYatir.Text = "Yatır";
            this.btnYatir.UseVisualStyleBackColor = true;
            this.btnYatir.Click += new System.EventHandler(this.btnYatir_Click);
            // 
            // btnCek
            // 
            this.btnCek.Location = new System.Drawing.Point(227, 102);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(108, 54);
            this.btnCek.TabIndex = 4;
            this.btnCek.Text = "Çek";
            this.btnCek.UseVisualStyleBackColor = true;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 211);
            this.Controls.Add(this.btnCek);
            this.Controls.Add(this.btnYatir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Button btnYatir;
        private System.Windows.Forms.Button btnCek;
    }
}

