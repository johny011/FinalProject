namespace Final_project
{
    partial class Laboratory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laboratory));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_title = new System.Windows.Forms.Panel();
            this.panel_hospital_name = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.maxBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.exitBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.minBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_button = new System.Windows.Forms.Panel();
            this.btn_send_resultanalyz = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_view_requierd_analyzes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_form = new System.Windows.Forms.Panel();
            this.btn_Add_Analyzes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_title.SuspendLayout();
            this.panel_hospital_name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).BeginInit();
            this.panel_button.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel_title
            // 
            this.panel_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.panel_title.Controls.Add(this.panel_hospital_name);
            this.panel_title.Controls.Add(this.maxBtn);
            this.panel_title.Controls.Add(this.exitBtn);
            this.panel_title.Controls.Add(this.minBtn);
            this.panel_title.Location = new System.Drawing.Point(-1, -1);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(888, 68);
            this.panel_title.TabIndex = 5;
            this.panel_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseDown);
            this.panel_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseMove);
            this.panel_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseUp);
            // 
            // panel_hospital_name
            // 
            this.panel_hospital_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_hospital_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panel_hospital_name.Controls.Add(this.Title);
            this.panel_hospital_name.Location = new System.Drawing.Point(707, 1);
            this.panel_hospital_name.Name = "panel_hospital_name";
            this.panel_hospital_name.Size = new System.Drawing.Size(179, 67);
            this.panel_hospital_name.TabIndex = 2;
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Gainsboro;
            this.Title.Location = new System.Drawing.Point(25, 22);
            this.Title.Name = "Title";
            this.Title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Title.Size = new System.Drawing.Size(131, 23);
            this.Title.TabIndex = 2;
            this.Title.Text = "Our Hospital";
            // 
            // maxBtn
            // 
            this.maxBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.maxBtn.Image = ((System.Drawing.Image)(resources.GetObject("maxBtn.Image")));
            this.maxBtn.ImageActive = null;
            this.maxBtn.Location = new System.Drawing.Point(59, 14);
            this.maxBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.Size = new System.Drawing.Size(40, 40);
            this.maxBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maxBtn.TabIndex = 6;
            this.maxBtn.TabStop = false;
            this.maxBtn.Zoom = 10;
            this.maxBtn.Click += new System.EventHandler(this.maxBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.ImageActive = null;
            this.exitBtn.Location = new System.Drawing.Point(13, 14);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(40, 40);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBtn.TabIndex = 4;
            this.exitBtn.TabStop = false;
            this.exitBtn.Zoom = 10;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // minBtn
            // 
            this.minBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.minBtn.Image = ((System.Drawing.Image)(resources.GetObject("minBtn.Image")));
            this.minBtn.ImageActive = null;
            this.minBtn.Location = new System.Drawing.Point(105, 14);
            this.minBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(40, 40);
            this.minBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minBtn.TabIndex = 5;
            this.minBtn.TabStop = false;
            this.minBtn.Zoom = 10;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // panel_button
            // 
            this.panel_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.panel_button.Controls.Add(this.bunifuFlatButton2);
            this.panel_button.Controls.Add(this.btn_Add_Analyzes);
            this.panel_button.Controls.Add(this.btn_send_resultanalyz);
            this.panel_button.Controls.Add(this.btn_view_requierd_analyzes);
            this.panel_button.Location = new System.Drawing.Point(706, 66);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(181, 575);
            this.panel_button.TabIndex = 6;
            // 
            // btn_send_resultanalyz
            // 
            this.btn_send_resultanalyz.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_send_resultanalyz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_send_resultanalyz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_send_resultanalyz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_send_resultanalyz.BorderRadius = 0;
            this.btn_send_resultanalyz.ButtonText = "إرسال نتيجة تحليل";
            this.btn_send_resultanalyz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_send_resultanalyz.DisabledColor = System.Drawing.Color.Gray;
            this.btn_send_resultanalyz.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_send_resultanalyz.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_send_resultanalyz.Iconimage = null;
            this.btn_send_resultanalyz.Iconimage_right = null;
            this.btn_send_resultanalyz.Iconimage_right_Selected = null;
            this.btn_send_resultanalyz.Iconimage_Selected = null;
            this.btn_send_resultanalyz.IconMarginLeft = 0;
            this.btn_send_resultanalyz.IconMarginRight = 0;
            this.btn_send_resultanalyz.IconRightVisible = true;
            this.btn_send_resultanalyz.IconRightZoom = 0D;
            this.btn_send_resultanalyz.IconVisible = true;
            this.btn_send_resultanalyz.IconZoom = 40D;
            this.btn_send_resultanalyz.IsTab = false;
            this.btn_send_resultanalyz.Location = new System.Drawing.Point(1, 3);
            this.btn_send_resultanalyz.Margin = new System.Windows.Forms.Padding(5);
            this.btn_send_resultanalyz.Name = "btn_send_resultanalyz";
            this.btn_send_resultanalyz.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_send_resultanalyz.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_send_resultanalyz.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_send_resultanalyz.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_send_resultanalyz.selected = false;
            this.btn_send_resultanalyz.Size = new System.Drawing.Size(178, 40);
            this.btn_send_resultanalyz.TabIndex = 24;
            this.btn_send_resultanalyz.Text = "إرسال نتيجة تحليل";
            this.btn_send_resultanalyz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_send_resultanalyz.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_send_resultanalyz.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_send_resultanalyz.Click += new System.EventHandler(this.btn_add_analyz_Click);
            // 
            // btn_view_requierd_analyzes
            // 
            this.btn_view_requierd_analyzes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_view_requierd_analyzes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_view_requierd_analyzes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_view_requierd_analyzes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_view_requierd_analyzes.BorderRadius = 0;
            this.btn_view_requierd_analyzes.ButtonText = "عرض التحاليل المطلوبة";
            this.btn_view_requierd_analyzes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_view_requierd_analyzes.DisabledColor = System.Drawing.Color.Gray;
            this.btn_view_requierd_analyzes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_view_requierd_analyzes.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_view_requierd_analyzes.Iconimage = null;
            this.btn_view_requierd_analyzes.Iconimage_right = null;
            this.btn_view_requierd_analyzes.Iconimage_right_Selected = null;
            this.btn_view_requierd_analyzes.Iconimage_Selected = null;
            this.btn_view_requierd_analyzes.IconMarginLeft = 0;
            this.btn_view_requierd_analyzes.IconMarginRight = 0;
            this.btn_view_requierd_analyzes.IconRightVisible = true;
            this.btn_view_requierd_analyzes.IconRightZoom = 0D;
            this.btn_view_requierd_analyzes.IconVisible = true;
            this.btn_view_requierd_analyzes.IconZoom = 40D;
            this.btn_view_requierd_analyzes.IsTab = false;
            this.btn_view_requierd_analyzes.Location = new System.Drawing.Point(1, 53);
            this.btn_view_requierd_analyzes.Margin = new System.Windows.Forms.Padding(5);
            this.btn_view_requierd_analyzes.Name = "btn_view_requierd_analyzes";
            this.btn_view_requierd_analyzes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_view_requierd_analyzes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_view_requierd_analyzes.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_view_requierd_analyzes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_view_requierd_analyzes.selected = false;
            this.btn_view_requierd_analyzes.Size = new System.Drawing.Size(178, 40);
            this.btn_view_requierd_analyzes.TabIndex = 25;
            this.btn_view_requierd_analyzes.Text = "عرض التحاليل المطلوبة";
            this.btn_view_requierd_analyzes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_view_requierd_analyzes.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_view_requierd_analyzes.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_view_requierd_analyzes.Click += new System.EventHandler(this.btn_add_result_of_an_analysis_Click);
            // 
            // panel_form
            // 
            this.panel_form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_form.Location = new System.Drawing.Point(0, 66);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(706, 539);
            this.panel_form.TabIndex = 7;
            // 
            // btn_Add_Analyzes
            // 
            this.btn_Add_Analyzes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_Add_Analyzes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add_Analyzes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_Add_Analyzes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Add_Analyzes.BorderRadius = 0;
            this.btn_Add_Analyzes.ButtonText = "اضافة انواع تحاليل";
            this.btn_Add_Analyzes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add_Analyzes.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Add_Analyzes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Add_Analyzes.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Add_Analyzes.Iconimage = null;
            this.btn_Add_Analyzes.Iconimage_right = null;
            this.btn_Add_Analyzes.Iconimage_right_Selected = null;
            this.btn_Add_Analyzes.Iconimage_Selected = null;
            this.btn_Add_Analyzes.IconMarginLeft = 0;
            this.btn_Add_Analyzes.IconMarginRight = 0;
            this.btn_Add_Analyzes.IconRightVisible = true;
            this.btn_Add_Analyzes.IconRightZoom = 0D;
            this.btn_Add_Analyzes.IconVisible = true;
            this.btn_Add_Analyzes.IconZoom = 40D;
            this.btn_Add_Analyzes.IsTab = false;
            this.btn_Add_Analyzes.Location = new System.Drawing.Point(-2, 103);
            this.btn_Add_Analyzes.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Add_Analyzes.Name = "btn_Add_Analyzes";
            this.btn_Add_Analyzes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_Add_Analyzes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_Add_Analyzes.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Add_Analyzes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Add_Analyzes.selected = false;
            this.btn_Add_Analyzes.Size = new System.Drawing.Size(178, 40);
            this.btn_Add_Analyzes.TabIndex = 26;
            this.btn_Add_Analyzes.Text = "اضافة انواع تحاليل";
            this.btn_Add_Analyzes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Add_Analyzes.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_Add_Analyzes.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Add_Analyzes.Click += new System.EventHandler(this.btn_Add_Analyzes_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.bunifuFlatButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "تعديل انواع التحاليل";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 40D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(-2, 153);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(178, 40);
            this.bunifuFlatButton2.TabIndex = 27;
            this.bunifuFlatButton2.Text = "تعديل انواع التحاليل";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // Laboratory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 606);
            this.Controls.Add(this.panel_form);
            this.Controls.Add(this.panel_button);
            this.Controls.Add(this.panel_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Laboratory";
            this.Text = "Laboratory";
            this.panel_title.ResumeLayout(false);
            this.panel_hospital_name.ResumeLayout(false);
            this.panel_hospital_name.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).EndInit();
            this.panel_button.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Panel panel_hospital_name;
        protected System.Windows.Forms.Label Title;
        private Bunifu.Framework.UI.BunifuImageButton maxBtn;
        private Bunifu.Framework.UI.BunifuImageButton exitBtn;
        private Bunifu.Framework.UI.BunifuImageButton minBtn;
        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.Panel panel_form;
        private Bunifu.Framework.UI.BunifuFlatButton btn_send_resultanalyz;
        private Bunifu.Framework.UI.BunifuFlatButton btn_view_requierd_analyzes;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Add_Analyzes;
    }
}