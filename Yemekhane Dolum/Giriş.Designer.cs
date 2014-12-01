namespace Yemekhane_Dolum
{
    partial class Giriş
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.girişYap = new System.Windows.Forms.Button();
            this.kullanıcıt = new System.Windows.Forms.TextBox();
            this.parola = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Parola";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.girişYap);
            this.groupBox1.Controls.Add(this.kullanıcıt);
            this.groupBox1.Controls.Add(this.parola);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 300);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Yap";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(416, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // girişYap
            // 
            this.girişYap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.girişYap.Location = new System.Drawing.Point(3, 238);
            this.girişYap.Name = "girişYap";
            this.girişYap.Size = new System.Drawing.Size(444, 59);
            this.girişYap.TabIndex = 2;
            this.girişYap.Text = "Giriş Yap";
            this.girişYap.UseVisualStyleBackColor = true;
            this.girişYap.Click += new System.EventHandler(this.girişYap_Click);
            // 
            // kullanıcıt
            // 
            this.kullanıcıt.Location = new System.Drawing.Point(26, 81);
            this.kullanıcıt.Name = "kullanıcıt";
            this.kullanıcıt.Size = new System.Drawing.Size(400, 36);
            this.kullanıcıt.TabIndex = 1;
            this.kullanıcıt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // parola
            // 
            this.parola.Location = new System.Drawing.Point(26, 163);
            this.parola.Name = "parola";
            this.parola.Size = new System.Drawing.Size(400, 36);
            this.parola.TabIndex = 1;
            this.parola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.parola.UseSystemPasswordChar = true;
            // 
            // Giriş
            // 
            this.AcceptButton = this.girişYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Giriş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Giriş_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button girişYap;
        private System.Windows.Forms.TextBox kullanıcıt;
        private System.Windows.Forms.TextBox parola;
        private System.Windows.Forms.Button button1;

    }
}