namespace Format
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
            this.chRegular = new System.Windows.Forms.CheckBox();
            this.chBold = new System.Windows.Forms.CheckBox();
            this.chItalic = new System.Windows.Forms.CheckBox();
            this.chBI = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdBlue = new System.Windows.Forms.RadioButton();
            this.rdGreen = new System.Windows.Forms.RadioButton();
            this.rdRed = new System.Windows.Forms.RadioButton();
            this.rdAutoColor = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trường Đại Học Công Nghiệp Thực Phẩm \r\nKhoa Công Nghệ Thông Tin ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chRegular
            // 
            this.chRegular.AutoSize = true;
            this.chRegular.Location = new System.Drawing.Point(10, 38);
            this.chRegular.Name = "chRegular";
            this.chRegular.Size = new System.Drawing.Size(95, 28);
            this.chRegular.TabIndex = 2;
            this.chRegular.Text = "Regular";
            this.chRegular.UseVisualStyleBackColor = true;
            this.chRegular.CheckedChanged += new System.EventHandler(this.chRegular_CheckedChanged);
            // 
            // chBold
            // 
            this.chBold.AutoSize = true;
            this.chBold.Location = new System.Drawing.Point(10, 83);
            this.chBold.Name = "chBold";
            this.chBold.Size = new System.Drawing.Size(67, 28);
            this.chBold.TabIndex = 3;
            this.chBold.Text = "Bold";
            this.chBold.UseVisualStyleBackColor = true;
            this.chBold.CheckedChanged += new System.EventHandler(this.chBold_CheckedChanged);
            // 
            // chItalic
            // 
            this.chItalic.AutoSize = true;
            this.chItalic.Location = new System.Drawing.Point(10, 127);
            this.chItalic.Name = "chItalic";
            this.chItalic.Size = new System.Drawing.Size(65, 28);
            this.chItalic.TabIndex = 4;
            this.chItalic.Text = "Italic";
            this.chItalic.UseVisualStyleBackColor = true;
            this.chItalic.CheckedChanged += new System.EventHandler(this.chItalic_CheckedChanged);
            // 
            // chBI
            // 
            this.chBI.AutoSize = true;
            this.chBI.Location = new System.Drawing.Point(10, 179);
            this.chBI.Name = "chBI";
            this.chBI.Size = new System.Drawing.Size(145, 28);
            this.chBI.TabIndex = 5;
            this.chBI.Text = "Bold and Italic";
            this.chBI.UseVisualStyleBackColor = true;
            this.chBI.CheckedChanged += new System.EventHandler(this.chBI_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chBI);
            this.groupBox1.Controls.Add(this.chRegular);
            this.groupBox1.Controls.Add(this.chItalic);
            this.groupBox1.Controls.Add(this.chBold);
            this.groupBox1.Location = new System.Drawing.Point(45, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 234);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Font Style";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdBlue);
            this.groupBox2.Controls.Add(this.rdGreen);
            this.groupBox2.Controls.Add(this.rdRed);
            this.groupBox2.Controls.Add(this.rdAutoColor);
            this.groupBox2.Location = new System.Drawing.Point(382, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 234);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            // 
            // rdBlue
            // 
            this.rdBlue.AutoSize = true;
            this.rdBlue.Location = new System.Drawing.Point(22, 179);
            this.rdBlue.Name = "rdBlue";
            this.rdBlue.Size = new System.Drawing.Size(66, 28);
            this.rdBlue.TabIndex = 3;
            this.rdBlue.TabStop = true;
            this.rdBlue.Text = "Blue";
            this.rdBlue.UseVisualStyleBackColor = true;
            this.rdBlue.CheckedChanged += new System.EventHandler(this.rdBlue_CheckedChanged);
            // 
            // rdGreen
            // 
            this.rdGreen.AutoSize = true;
            this.rdGreen.Location = new System.Drawing.Point(22, 127);
            this.rdGreen.Name = "rdGreen";
            this.rdGreen.Size = new System.Drawing.Size(81, 28);
            this.rdGreen.TabIndex = 2;
            this.rdGreen.TabStop = true;
            this.rdGreen.Text = "Green";
            this.rdGreen.UseVisualStyleBackColor = true;
            this.rdGreen.CheckedChanged += new System.EventHandler(this.rdGreen_CheckedChanged);
            // 
            // rdRed
            // 
            this.rdRed.AutoSize = true;
            this.rdRed.Location = new System.Drawing.Point(22, 82);
            this.rdRed.Name = "rdRed";
            this.rdRed.Size = new System.Drawing.Size(63, 28);
            this.rdRed.TabIndex = 1;
            this.rdRed.TabStop = true;
            this.rdRed.Text = "Red";
            this.rdRed.UseVisualStyleBackColor = true;
            this.rdRed.CheckedChanged += new System.EventHandler(this.rdRed_CheckedChanged);
            // 
            // rdAutoColor
            // 
            this.rdAutoColor.AutoSize = true;
            this.rdAutoColor.Location = new System.Drawing.Point(22, 38);
            this.rdAutoColor.Name = "rdAutoColor";
            this.rdAutoColor.Size = new System.Drawing.Size(112, 28);
            this.rdAutoColor.TabIndex = 0;
            this.rdAutoColor.TabStop = true;
            this.rdAutoColor.Text = "AutoColor";
            this.rdAutoColor.UseVisualStyleBackColor = true;
            this.rdAutoColor.CheckedChanged += new System.EventHandler(this.rdAutoColor_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "E&xit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 628);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chRegular;
        private System.Windows.Forms.CheckBox chBold;
        private System.Windows.Forms.CheckBox chItalic;
        private System.Windows.Forms.CheckBox chBI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdBlue;
        private System.Windows.Forms.RadioButton rdGreen;
        private System.Windows.Forms.RadioButton rdRed;
        private System.Windows.Forms.RadioButton rdAutoColor;
        private System.Windows.Forms.Button button1;
    }
}

