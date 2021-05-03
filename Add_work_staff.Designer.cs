namespace Final_project
{
    partial class Add_work_staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_work_staff));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combox_typeid = new System.Windows.Forms.ComboBox();
            this.btn_add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.combox_deptid = new System.Windows.Forms.ComboBox();
            this.txt_NO_number = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_father_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_mother_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.hospitallDataSet17 = new Final_project.hospitallDataSet17();
            this.typeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeeTableAdapter = new Final_project.hospitallDataSet17TableAdapters.TypeeTableAdapter();
            this.hospitallDataSet18 = new Final_project.hospitallDataSet18();
            this.deptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deptTableAdapter = new Final_project.hospitallDataSet18TableAdapters.DeptTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.combox_typeid);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.combox_deptid);
            this.panel1.Controls.Add(this.txt_NO_number);
            this.panel1.Controls.Add(this.txt_father_name);
            this.panel1.Controls.Add(this.txt_mother_name);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "النوع";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(612, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "القسم";
            // 
            // combox_typeid
            // 
            this.combox_typeid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combox_typeid.BackColor = System.Drawing.Color.White;
            this.combox_typeid.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.deptBindingSource, "deptid", true));
            this.combox_typeid.DataSource = this.typeeBindingSource;
            this.combox_typeid.DisplayMember = "typename";
            this.combox_typeid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_typeid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combox_typeid.FormattingEnabled = true;
            this.combox_typeid.Location = new System.Drawing.Point(149, 273);
            this.combox_typeid.Name = "combox_typeid";
            this.combox_typeid.Size = new System.Drawing.Size(220, 27);
            this.combox_typeid.TabIndex = 23;
            this.combox_typeid.ValueMember = "typeid";
            // 
            // btn_add
            // 
            this.btn_add.ActiveBorderThickness = 1;
            this.btn_add.ActiveCornerRadius = 20;
            this.btn_add.ActiveFillColor = System.Drawing.Color.Silver;
            this.btn_add.ActiveForecolor = System.Drawing.Color.White;
            this.btn_add.ActiveLineColor = System.Drawing.Color.White;
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.btn_add.Location = new System.Drawing.Point(287, 345);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(211, 66);
            this.btn_add.TabIndex = 22;
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // combox_deptid
            // 
            this.combox_deptid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combox_deptid.BackColor = System.Drawing.Color.White;
            this.combox_deptid.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.deptBindingSource, "deptid", true));
            this.combox_deptid.DataSource = this.deptBindingSource;
            this.combox_deptid.DisplayMember = "deptname";
            this.combox_deptid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_deptid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combox_deptid.FormattingEnabled = true;
            this.combox_deptid.Location = new System.Drawing.Point(431, 273);
            this.combox_deptid.Name = "combox_deptid";
            this.combox_deptid.Size = new System.Drawing.Size(220, 27);
            this.combox_deptid.TabIndex = 21;
            this.combox_deptid.ValueMember = "deptid";
            this.combox_deptid.SelectedIndexChanged += new System.EventHandler(this.combox_deptid_SelectedIndexChanged);
            // 
            // txt_NO_number
            // 
            this.txt_NO_number.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_NO_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NO_number.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NO_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_NO_number.HintForeColor = System.Drawing.Color.Empty;
            this.txt_NO_number.HintText = "";
            this.txt_NO_number.isPassword = false;
            this.txt_NO_number.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_NO_number.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_NO_number.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_NO_number.LineThickness = 4;
            this.txt_NO_number.Location = new System.Drawing.Point(149, 133);
            this.txt_NO_number.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_NO_number.Name = "txt_NO_number";
            this.txt_NO_number.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_NO_number.Size = new System.Drawing.Size(220, 60);
            this.txt_NO_number.TabIndex = 20;
            this.txt_NO_number.Text = "الرقم الوطني";
            this.txt_NO_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_father_name
            // 
            this.txt_father_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_father_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_father_name.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_father_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_father_name.HintForeColor = System.Drawing.Color.Empty;
            this.txt_father_name.HintText = "";
            this.txt_father_name.isPassword = false;
            this.txt_father_name.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_father_name.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_father_name.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_father_name.LineThickness = 4;
            this.txt_father_name.Location = new System.Drawing.Point(149, 39);
            this.txt_father_name.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_father_name.Name = "txt_father_name";
            this.txt_father_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_father_name.Size = new System.Drawing.Size(220, 60);
            this.txt_father_name.TabIndex = 19;
            this.txt_father_name.Text = "اسم الأب";
            this.txt_father_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_mother_name
            // 
            this.txt_mother_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_mother_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mother_name.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mother_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_mother_name.HintForeColor = System.Drawing.Color.Empty;
            this.txt_mother_name.HintText = "";
            this.txt_mother_name.isPassword = false;
            this.txt_mother_name.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_mother_name.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_mother_name.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_mother_name.LineThickness = 4;
            this.txt_mother_name.Location = new System.Drawing.Point(431, 133);
            this.txt_mother_name.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_mother_name.Name = "txt_mother_name";
            this.txt_mother_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_mother_name.Size = new System.Drawing.Size(220, 60);
            this.txt_mother_name.TabIndex = 18;
            this.txt_mother_name.Text = "اسم الأم";
            this.txt_mother_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_name
            // 
            this.txt_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_name.HintForeColor = System.Drawing.Color.Empty;
            this.txt_name.HintText = "";
            this.txt_name.isPassword = false;
            this.txt_name.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_name.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_name.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_name.LineThickness = 4;
            this.txt_name.Location = new System.Drawing.Point(431, 39);
            this.txt_name.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_name.Name = "txt_name";
            this.txt_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_name.Size = new System.Drawing.Size(220, 60);
            this.txt_name.TabIndex = 17;
            this.txt_name.Text = "اسم الموظف";
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hospitallDataSet17
            // 
            this.hospitallDataSet17.DataSetName = "hospitallDataSet17";
            this.hospitallDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeeBindingSource
            // 
            this.typeeBindingSource.DataMember = "Typee";
            this.typeeBindingSource.DataSource = this.hospitallDataSet17;
            // 
            // typeeTableAdapter
            // 
            this.typeeTableAdapter.ClearBeforeFill = true;
            // 
            // hospitallDataSet18
            // 
            this.hospitallDataSet18.DataSetName = "hospitallDataSet18";
            this.hospitallDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deptBindingSource
            // 
            this.deptBindingSource.DataMember = "Dept";
            this.deptBindingSource.DataSource = this.hospitallDataSet18;
            // 
            // deptTableAdapter
            // 
            this.deptTableAdapter.ClearBeforeFill = true;
            // 
            // Add_work_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_work_staff";
            this.Text = "Add_work_staff";
            this.Load += new System.EventHandler(this.Add_work_staff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox combox_typeid;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_add;
        private System.Windows.Forms.ComboBox combox_deptid;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_NO_number;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_father_name;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_mother_name;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private hospitallDataSet17 hospitallDataSet17;
        private System.Windows.Forms.BindingSource typeeBindingSource;
        private hospitallDataSet17TableAdapters.TypeeTableAdapter typeeTableAdapter;
        private hospitallDataSet18 hospitallDataSet18;
        private System.Windows.Forms.BindingSource deptBindingSource;
        private hospitallDataSet18TableAdapters.DeptTableAdapter deptTableAdapter;
    }
}