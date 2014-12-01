namespace Yemekhane_Dolum
{
    partial class Ana_Menü
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.menuGBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuSec = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.yemekSec = new System.Windows.Forms.Button();
            this.yemek = new System.Windows.Forms.ComboBox();
            this.ogunGBox = new System.Windows.Forms.GroupBox();
            this.akşam = new System.Windows.Forms.RadioButton();
            this.ögle = new System.Windows.Forms.RadioButton();
            this.sabah = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.menuGBox.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.ogunGBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(519, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.data);
            this.groupBox1.Controls.Add(this.menuGBox);
            this.groupBox1.Controls.Add(this.ogunGBox);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 544);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ana Menü";
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data.Location = new System.Drawing.Point(3, 351);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(547, 190);
            this.data.TabIndex = 4;
            // 
            // menuGBox
            // 
            this.menuGBox.Controls.Add(this.label1);
            this.menuGBox.Controls.Add(this.menuSec);
            this.menuGBox.Controls.Add(this.groupBox5);
            this.menuGBox.Location = new System.Drawing.Point(11, 116);
            this.menuGBox.Name = "menuGBox";
            this.menuGBox.Size = new System.Drawing.Size(528, 230);
            this.menuGBox.TabIndex = 3;
            this.menuGBox.TabStop = false;
            this.menuGBox.Text = "Menü Seçimi";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menü:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuSec
            // 
            this.menuSec.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuSec.Location = new System.Drawing.Point(3, 181);
            this.menuSec.Name = "menuSec";
            this.menuSec.Size = new System.Drawing.Size(522, 46);
            this.menuSec.TabIndex = 1;
            this.menuSec.Text = "Menü Ekle";
            this.menuSec.UseVisualStyleBackColor = true;
            this.menuSec.Click += new System.EventHandler(this.menuSec_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.yemekSec);
            this.groupBox5.Controls.Add(this.yemek);
            this.groupBox5.Location = new System.Drawing.Point(18, 26);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(490, 101);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Yemek Seçimi";
            // 
            // yemekSec
            // 
            this.yemekSec.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.yemekSec.Location = new System.Drawing.Point(3, 54);
            this.yemekSec.Name = "yemekSec";
            this.yemekSec.Size = new System.Drawing.Size(484, 44);
            this.yemekSec.TabIndex = 1;
            this.yemekSec.Text = "Yemek Ekle";
            this.yemekSec.UseVisualStyleBackColor = true;
            this.yemekSec.Click += new System.EventHandler(this.yemekSec_Click);
            // 
            // yemek
            // 
            this.yemek.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.yemek.Dock = System.Windows.Forms.DockStyle.Top;
            this.yemek.FormattingEnabled = true;
            this.yemek.Location = new System.Drawing.Point(3, 22);
            this.yemek.Name = "yemek";
            this.yemek.Size = new System.Drawing.Size(484, 28);
            this.yemek.TabIndex = 0;
            // 
            // ogunGBox
            // 
            this.ogunGBox.Controls.Add(this.akşam);
            this.ogunGBox.Controls.Add(this.ögle);
            this.ogunGBox.Controls.Add(this.sabah);
            this.ogunGBox.Location = new System.Drawing.Point(280, 41);
            this.ogunGBox.Name = "ogunGBox";
            this.ogunGBox.Size = new System.Drawing.Size(259, 69);
            this.ogunGBox.TabIndex = 2;
            this.ogunGBox.TabStop = false;
            this.ogunGBox.Text = "Öğün Seçimi";
            // 
            // akşam
            // 
            this.akşam.AutoSize = true;
            this.akşam.Location = new System.Drawing.Point(163, 25);
            this.akşam.Name = "akşam";
            this.akşam.Size = new System.Drawing.Size(76, 24);
            this.akşam.TabIndex = 0;
            this.akşam.TabStop = true;
            this.akşam.Text = "Akşam";
            this.akşam.UseVisualStyleBackColor = true;
            this.akşam.CheckedChanged += new System.EventHandler(this.akşam_CheckedChanged);
            // 
            // ögle
            // 
            this.ögle.AutoSize = true;
            this.ögle.Location = new System.Drawing.Point(97, 25);
            this.ögle.Name = "ögle";
            this.ögle.Size = new System.Drawing.Size(60, 24);
            this.ögle.TabIndex = 0;
            this.ögle.TabStop = true;
            this.ögle.Text = "Öğle";
            this.ögle.UseVisualStyleBackColor = true;
            this.ögle.CheckedChanged += new System.EventHandler(this.ögle_CheckedChanged);
            // 
            // sabah
            // 
            this.sabah.AutoSize = true;
            this.sabah.Location = new System.Drawing.Point(17, 25);
            this.sabah.Name = "sabah";
            this.sabah.Size = new System.Drawing.Size(74, 24);
            this.sabah.TabIndex = 0;
            this.sabah.TabStop = true;
            this.sabah.Text = "Sabah";
            this.sabah.UseVisualStyleBackColor = true;
            this.sabah.CheckedChanged += new System.EventHandler(this.sabah_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.date);
            this.groupBox2.Location = new System.Drawing.Point(11, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 69);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tarih Seçimi";
            // 
            // date
            // 
            this.date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date.Location = new System.Drawing.Point(3, 22);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(257, 26);
            this.date.TabIndex = 0;
            this.date.Value = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.date.ValueChanged += new System.EventHandler(this.tarihChange);
            // 
            // Ana_Menü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(553, 544);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ana_Menü";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana_Menü";
            this.Load += new System.EventHandler(this.Ana_Menü_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.menuGBox.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ogunGBox.ResumeLayout(false);
            this.ogunGBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox ogunGBox;
        private System.Windows.Forms.RadioButton akşam;
        private System.Windows.Forms.RadioButton ögle;
        private System.Windows.Forms.RadioButton sabah;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.GroupBox menuGBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button menuSec;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button yemekSec;
        private System.Windows.Forms.ComboBox yemek;
    }
}