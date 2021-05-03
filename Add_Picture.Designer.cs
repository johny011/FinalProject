namespace Final_project
{
    partial class Add_Picture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Picture));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_Add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_processing = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_price_picture = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_name_picture = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btn_Add
            // 
            this.btn_Add.ActiveBorderThickness = 1;
            this.btn_Add.ActiveCornerRadius = 20;
            this.btn_Add.ActiveFillColor = System.Drawing.Color.Silver;
            this.btn_Add.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Add.ActiveLineColor = System.Drawing.Color.White;
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Add.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Add.BackgroundImage")));
            this.btn_Add.ButtonText = "اضافة";
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Add.ForeColor = System.Drawing.Color.Black;
            this.btn_Add.IdleBorderThickness = 1;
            this.btn_Add.IdleCornerRadius = 20;
            this.btn_Add.IdleFillColor = System.Drawing.Color.White;
            this.btn_Add.IdleForecolor = System.Drawing.Color.Black;
            this.btn_Add.IdleLineColor = System.Drawing.Color.Black;
            this.btn_Add.Location = new System.Drawing.Point(292, 298);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(220, 66);
            this.btn_Add.TabIndex = 32;
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_processing
            // 
            this.txt_processing.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_processing.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_processing.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_processing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_processing.HintForeColor = System.Drawing.Color.Empty;
            this.txt_processing.HintText = "";
            this.txt_processing.isPassword = false;
            this.txt_processing.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_processing.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_processing.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_processing.LineThickness = 4;
            this.txt_processing.Location = new System.Drawing.Point(52, 67);
            this.txt_processing.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_processing.Name = "txt_processing";
            this.txt_processing.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_processing.Size = new System.Drawing.Size(220, 60);
            this.txt_processing.TabIndex = 31;
            this.txt_processing.Text = "مدة التجهيز";
            this.txt_processing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_price_picture
            // 
            this.txt_price_picture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_price_picture.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_price_picture.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price_picture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_price_picture.HintForeColor = System.Drawing.Color.Empty;
            this.txt_price_picture.HintText = "";
            this.txt_price_picture.isPassword = false;
            this.txt_price_picture.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_price_picture.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_price_picture.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_price_picture.LineThickness = 4;
            this.txt_price_picture.Location = new System.Drawing.Point(288, 67);
            this.txt_price_picture.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_price_picture.Name = "txt_price_picture";
            this.txt_price_picture.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_price_picture.Size = new System.Drawing.Size(220, 60);
            this.txt_price_picture.TabIndex = 30;
            this.txt_price_picture.Text = "سعر الصورة";
            this.txt_price_picture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_name_picture
            // 
            this.txt_name_picture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_name_picture.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name_picture.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_picture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_name_picture.HintForeColor = System.Drawing.Color.Empty;
            this.txt_name_picture.HintText = "";
            this.txt_name_picture.isPassword = false;
            this.txt_name_picture.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_name_picture.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_name_picture.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_name_picture.LineThickness = 4;
            this.txt_name_picture.Location = new System.Drawing.Point(520, 67);
            this.txt_name_picture.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_name_picture.Name = "txt_name_picture";
            this.txt_name_picture.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_name_picture.Size = new System.Drawing.Size(220, 60);
            this.txt_name_picture.TabIndex = 29;
            this.txt_name_picture.Text = "اسم الصورة";
            this.txt_name_picture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Add_Picture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_processing);
            this.Controls.Add(this.txt_price_picture);
            this.Controls.Add(this.txt_name_picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Picture";
            this.Text = "Add_Picture";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Add;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_processing;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_price_picture;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_name_picture;
    }
}