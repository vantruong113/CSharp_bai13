namespace CSharp_bai13
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
            this.groupcolor = new System.Windows.Forms.GroupBox();
            this.txtNhapTen = new System.Windows.Forms.TextBox();
            this.groupFont = new System.Windows.Forms.GroupBox();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLapTrinh = new System.Windows.Forms.TextBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkitalic = new System.Windows.Forms.CheckBox();
            this.chkUnderline = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupcolor.SuspendLayout();
            this.groupFont.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(77, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Tên :";
            // 
            // groupcolor
            // 
            this.groupcolor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupcolor.Controls.Add(this.radBlack);
            this.groupcolor.Controls.Add(this.radBlue);
            this.groupcolor.Controls.Add(this.radGreen);
            this.groupcolor.Controls.Add(this.radRed);
            this.groupcolor.Location = new System.Drawing.Point(43, 96);
            this.groupcolor.Name = "groupcolor";
            this.groupcolor.Size = new System.Drawing.Size(200, 146);
            this.groupcolor.TabIndex = 1;
            this.groupcolor.TabStop = false;
            this.groupcolor.Text = "color";
            // 
            // txtNhapTen
            // 
            this.txtNhapTen.Location = new System.Drawing.Point(169, 46);
            this.txtNhapTen.Name = "txtNhapTen";
            this.txtNhapTen.Size = new System.Drawing.Size(209, 20);
            this.txtNhapTen.TabIndex = 2;
            this.txtNhapTen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupFont
            // 
            this.groupFont.BackColor = System.Drawing.Color.Wheat;
            this.groupFont.Controls.Add(this.chkUnderline);
            this.groupFont.Controls.Add(this.chkitalic);
            this.groupFont.Controls.Add(this.chkBold);
            this.groupFont.Location = new System.Drawing.Point(275, 96);
            this.groupFont.Name = "groupFont";
            this.groupFont.Size = new System.Drawing.Size(200, 146);
            this.groupFont.TabIndex = 2;
            this.groupFont.TabStop = false;
            this.groupFont.Text = "Font";
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRed.ForeColor = System.Drawing.Color.Red;
            this.radRed.Location = new System.Drawing.Point(6, 30);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(60, 24);
            this.radRed.TabIndex = 3;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGreen.ForeColor = System.Drawing.Color.Lime;
            this.radGreen.Location = new System.Drawing.Point(6, 53);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(77, 24);
            this.radGreen.TabIndex = 4;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlue.ForeColor = System.Drawing.Color.Blue;
            this.radBlue.Location = new System.Drawing.Point(6, 76);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(63, 24);
            this.radBlue.TabIndex = 5;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlack.Location = new System.Drawing.Point(6, 97);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(71, 24);
            this.radBlack.TabIndex = 6;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(53, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lập Trình Bởi:";
            // 
            // lblLapTrinh
            // 
            this.lblLapTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLapTrinh.Location = new System.Drawing.Point(169, 338);
            this.lblLapTrinh.Name = "lblLapTrinh";
            this.lblLapTrinh.Size = new System.Drawing.Size(209, 30);
            this.lblLapTrinh.TabIndex = 4;
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBold.ForeColor = System.Drawing.Color.Blue;
            this.chkBold.Location = new System.Drawing.Point(6, 30);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(80, 17);
            this.chkBold.TabIndex = 0;
            this.chkBold.Text = "Đậm Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            // 
            // chkitalic
            // 
            this.chkitalic.AutoSize = true;
            this.chkitalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkitalic.ForeColor = System.Drawing.Color.Blue;
            this.chkitalic.Location = new System.Drawing.Point(6, 64);
            this.chkitalic.Name = "chkitalic";
            this.chkitalic.Size = new System.Drawing.Size(97, 17);
            this.chkitalic.TabIndex = 1;
            this.chkitalic.Text = "Nghiên italic";
            this.chkitalic.UseVisualStyleBackColor = true;
            // 
            // chkUnderline
            // 
            this.chkUnderline.AutoSize = true;
            this.chkUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUnderline.ForeColor = System.Drawing.Color.Blue;
            this.chkUnderline.Location = new System.Drawing.Point(6, 97);
            this.chkUnderline.Name = "chkUnderline";
            this.chkUnderline.Size = new System.Drawing.Size(93, 17);
            this.chkUnderline.TabIndex = 2;
            this.chkUnderline.Text = "Gạch Chân ";
            this.chkUnderline.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(384, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblLapTrinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupFont);
            this.Controls.Add(this.txtNhapTen);
            this.Controls.Add(this.groupcolor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupcolor.ResumeLayout(false);
            this.groupcolor.PerformLayout();
            this.groupFont.ResumeLayout(false);
            this.groupFont.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupcolor;
        private System.Windows.Forms.TextBox txtNhapTen;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.GroupBox groupFont;
        private System.Windows.Forms.CheckBox chkUnderline;
        private System.Windows.Forms.CheckBox chkitalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblLapTrinh;
        private System.Windows.Forms.Button button1;
    }
}

