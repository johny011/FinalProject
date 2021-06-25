namespace Final_project
{
    partial class Add_room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_room));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combox_room_type = new System.Windows.Forms.ComboBox();
            this.btn_add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.combox_section = new System.Windows.Forms.ComboBox();
            this.deptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitallDataSet15 = new Final_project.hospitallDataSet15();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.deptTableAdapter = new Final_project.hospitallDataSet15TableAdapters.DeptTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallDataSet15)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.combox_room_type);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.combox_section);
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
            this.label2.Location = new System.Drawing.Point(427, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "نوع الغرفة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(462, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "القسم";
            // 
            // combox_room_type
            // 
            this.combox_room_type.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combox_room_type.BackColor = System.Drawing.Color.White;
            this.combox_room_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_room_type.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combox_room_type.FormattingEnabled = true;
            this.combox_room_type.Items.AddRange(new object[] {
            "operations",
            "visit"});
            this.combox_room_type.Location = new System.Drawing.Point(281, 172);
            this.combox_room_type.Name = "combox_room_type";
            this.combox_room_type.Size = new System.Drawing.Size(220, 27);
            this.combox_room_type.Sorted = true;
            this.combox_room_type.TabIndex = 26;
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
            this.btn_add.Location = new System.Drawing.Point(281, 351);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(220, 66);
            this.btn_add.TabIndex = 25;
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // combox_section
            // 
            this.combox_section.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combox_section.BackColor = System.Drawing.Color.White;
            this.combox_section.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.deptBindingSource, "deptid", true));
            this.combox_section.DataSource = this.deptBindingSource;
            this.combox_section.DisplayMember = "deptname";
            this.combox_section.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_section.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combox_section.FormattingEnabled = true;
            this.combox_section.Location = new System.Drawing.Point(281, 83);
            this.combox_section.Name = "combox_section";
            this.combox_section.Size = new System.Drawing.Size(220, 27);
            this.combox_section.TabIndex = 24;
            this.combox_section.ValueMember = "deptid";
            // 
            // deptBindingSource
            // 
            this.deptBindingSource.DataMember = "Dept";
            this.deptBindingSource.DataSource = this.hospitallDataSet15;
            // 
            // hospitallDataSet15
            // 
            this.hospitallDataSet15.DataSetName = "hospitallDataSet15";
            this.hospitallDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // deptTableAdapter
            // 
            this.deptTableAdapter.ClearBeforeFill = true;
            // 
            // Add_room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_room";
            this.Text = "Add_room";
            this.Load += new System.EventHandler(this.Add_room_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallDataSet15)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ComboBox combox_room_type;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_add;
        private System.Windows.Forms.ComboBox combox_section;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private hospitallDataSet15 hospitallDataSet15;
        private System.Windows.Forms.BindingSource deptBindingSource;
        private hospitallDataSet15TableAdapters.DeptTableAdapter deptTableAdapter;
    }
}