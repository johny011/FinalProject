namespace Final_project
{
    partial class Add_account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_account));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.combox_deptid = new System.Windows.Forms.ComboBox();
            this.deptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitallDataSet20 = new Final_project.hospitallDataSet20();
            this.btn_add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_user_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.deptTableAdapter = new Final_project.hospitallDataSet20TableAdapters.DeptTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallDataSet20)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.combox_deptid);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.txt_user_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "القسم";
            // 
            // combox_deptid
            // 
            this.combox_deptid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combox_deptid.BackColor = System.Drawing.Color.White;
            this.combox_deptid.DataSource = this.deptBindingSource;
            this.combox_deptid.DisplayMember = "deptname";
            this.combox_deptid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_deptid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combox_deptid.FormattingEnabled = true;
            this.combox_deptid.Location = new System.Drawing.Point(278, 309);
            this.combox_deptid.Name = "combox_deptid";
            this.combox_deptid.Size = new System.Drawing.Size(220, 27);
            this.combox_deptid.TabIndex = 23;
            this.combox_deptid.ValueMember = "deptname";
            // 
            // deptBindingSource
            // 
            this.deptBindingSource.DataMember = "Dept";
            this.deptBindingSource.DataSource = this.hospitallDataSet20;
            // 
            // hospitallDataSet20
            // 
            this.hospitallDataSet20.DataSetName = "hospitallDataSet20";
            this.hospitallDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_add
            // 
            this.btn_add.ActiveBorderThickness = 1;
            this.btn_add.ActiveCornerRadius = 20;
            this.btn_add.ActiveFillColor = System.Drawing.Color.Silver;
            this.btn_add.ActiveForecolor = System.Drawing.Color.White;
            this.btn_add.ActiveLineColor = System.Drawing.Color.White;
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.BackColor = System.Drawing.SystemColors.Control;
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.ButtonText = "إضافة";
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.IdleBorderThickness = 1;
            this.btn_add.IdleCornerRadius = 20;
            this.btn_add.IdleFillColor = System.Drawing.Color.White;
            this.btn_add.IdleForecolor = System.Drawing.Color.Black;
            this.btn_add.IdleLineColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(278, 355);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(220, 60);
            this.btn_add.TabIndex = 22;
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_password
            // 
            this.txt_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_password.HintForeColor = System.Drawing.Color.Empty;
            this.txt_password.HintText = "";
            this.txt_password.isPassword = false;
            this.txt_password.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_password.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_password.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_password.LineThickness = 4;
            this.txt_password.Location = new System.Drawing.Point(278, 187);
            this.txt_password.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_password.Name = "txt_password";
            this.txt_password.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_password.Size = new System.Drawing.Size(220, 60);
            this.txt_password.TabIndex = 19;
            this.txt_password.Text = "كلمة المرور";
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_user_name
            // 
            this.txt_user_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_user_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user_name.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_user_name.HintForeColor = System.Drawing.Color.Empty;
            this.txt_user_name.HintText = "";
            this.txt_user_name.isPassword = false;
            this.txt_user_name.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_user_name.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_user_name.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_user_name.LineThickness = 4;
            this.txt_user_name.Location = new System.Drawing.Point(278, 98);
            this.txt_user_name.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_user_name.Size = new System.Drawing.Size(220, 60);
            this.txt_user_name.TabIndex = 17;
            this.txt_user_name.Text = "اسم المستخدم";
            this.txt_user_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // deptTableAdapter
            // 
            this.deptTableAdapter.ClearBeforeFill = true;
            // 
            // Add_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_account";
            this.Text = "Add_account";
            this.Load += new System.EventHandler(this.Add_account_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallDataSet20)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_add;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_user_name;
        private System.Windows.Forms.ComboBox combox_deptid;
        private System.Windows.Forms.Label label1;
        private hospitallDataSet20 hospitallDataSet20;
        private System.Windows.Forms.BindingSource deptBindingSource;
        private hospitallDataSet20TableAdapters.DeptTableAdapter deptTableAdapter;
    }
}