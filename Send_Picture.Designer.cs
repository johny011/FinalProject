namespace Final_project
{
    partial class Send_Picture
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Send_Picture));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_Admissionid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_ٍSelectpicture = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_sendpicture = new Bunifu.Framework.UI.BunifuThinButton2();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txt_Admissionid
            // 
            this.txt_Admissionid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Admissionid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Admissionid.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Admissionid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Admissionid.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Admissionid.HintText = "رقم دخولية المريض";
            this.txt_Admissionid.isPassword = false;
            this.txt_Admissionid.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_Admissionid.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Admissionid.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_Admissionid.LineThickness = 4;
            this.txt_Admissionid.Location = new System.Drawing.Point(542, 31);
            this.txt_Admissionid.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_Admissionid.Name = "txt_Admissionid";
            this.txt_Admissionid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Admissionid.Size = new System.Drawing.Size(220, 60);
            this.txt_Admissionid.TabIndex = 31;
            this.txt_Admissionid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Admissionid.OnValueChanged += new System.EventHandler(this.txt_Admissionid_OnValueChanged);
            // 
            // btn_ٍSelectpicture
            // 
            this.btn_ٍSelectpicture.ActiveBorderThickness = 1;
            this.btn_ٍSelectpicture.ActiveCornerRadius = 20;
            this.btn_ٍSelectpicture.ActiveFillColor = System.Drawing.Color.Silver;
            this.btn_ٍSelectpicture.ActiveForecolor = System.Drawing.Color.White;
            this.btn_ٍSelectpicture.ActiveLineColor = System.Drawing.Color.White;
            this.btn_ٍSelectpicture.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_ٍSelectpicture.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ٍSelectpicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ٍSelectpicture.BackgroundImage")));
            this.btn_ٍSelectpicture.ButtonText = "اختيار الصورة";
            this.btn_ٍSelectpicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ٍSelectpicture.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ٍSelectpicture.ForeColor = System.Drawing.Color.Black;
            this.btn_ٍSelectpicture.IdleBorderThickness = 1;
            this.btn_ٍSelectpicture.IdleCornerRadius = 20;
            this.btn_ٍSelectpicture.IdleFillColor = System.Drawing.Color.White;
            this.btn_ٍSelectpicture.IdleForecolor = System.Drawing.Color.Black;
            this.btn_ٍSelectpicture.IdleLineColor = System.Drawing.Color.Black;
            this.btn_ٍSelectpicture.Location = new System.Drawing.Point(542, 193);
            this.btn_ٍSelectpicture.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ٍSelectpicture.Name = "btn_ٍSelectpicture";
            this.btn_ٍSelectpicture.Size = new System.Drawing.Size(220, 66);
            this.btn_ٍSelectpicture.TabIndex = 30;
            this.btn_ٍSelectpicture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ٍSelectpicture.Click += new System.EventHandler(this.btn_ٍSelectpicture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_sendpicture
            // 
            this.btn_sendpicture.ActiveBorderThickness = 1;
            this.btn_sendpicture.ActiveCornerRadius = 20;
            this.btn_sendpicture.ActiveFillColor = System.Drawing.Color.Silver;
            this.btn_sendpicture.ActiveForecolor = System.Drawing.Color.White;
            this.btn_sendpicture.ActiveLineColor = System.Drawing.Color.White;
            this.btn_sendpicture.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_sendpicture.BackColor = System.Drawing.SystemColors.Control;
            this.btn_sendpicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sendpicture.BackgroundImage")));
            this.btn_sendpicture.ButtonText = "إرسال النتيجة";
            this.btn_sendpicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sendpicture.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_sendpicture.ForeColor = System.Drawing.Color.Black;
            this.btn_sendpicture.IdleBorderThickness = 1;
            this.btn_sendpicture.IdleCornerRadius = 20;
            this.btn_sendpicture.IdleFillColor = System.Drawing.Color.White;
            this.btn_sendpicture.IdleForecolor = System.Drawing.Color.Black;
            this.btn_sendpicture.IdleLineColor = System.Drawing.Color.Black;
            this.btn_sendpicture.Location = new System.Drawing.Point(167, 354);
            this.btn_sendpicture.Margin = new System.Windows.Forms.Padding(5);
            this.btn_sendpicture.Name = "btn_sendpicture";
            this.btn_sendpicture.Size = new System.Drawing.Size(220, 66);
            this.btn_sendpicture.TabIndex = 33;
            this.btn_sendpicture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_sendpicture.Click += new System.EventHandler(this.btn_sendpicture_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Send_Picture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sendpicture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_Admissionid);
            this.Controls.Add(this.btn_ٍSelectpicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Send_Picture";
            this.Text = "Sen_Picture";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Admissionid;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_ٍSelectpicture;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_sendpicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}