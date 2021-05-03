namespace Final_project
{
    partial class View_staff
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fathernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mothernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theIdNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitallDataSet22 = new Final_project.hospitallDataSet22();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.theStaffTableAdapter = new Final_project.hospitallDataSet22TableAdapters.TheStaffTableAdapter();
            this.hospitallDataSet23 = new Final_project.hospitallDataSet23();
            this.deptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deptTableAdapter = new Final_project.hospitallDataSet23TableAdapters.DeptTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theStaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallDataSet22)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.fathernameDataGridViewTextBoxColumn,
            this.mothernameDataGridViewTextBoxColumn,
            this.theIdNumberDataGridViewTextBoxColumn,
            this.typeidDataGridViewTextBoxColumn,
            this.deptidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.theStaffBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 24;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "Sname";
            this.snameDataGridViewTextBoxColumn.HeaderText = "Sname";
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            // 
            // fathernameDataGridViewTextBoxColumn
            // 
            this.fathernameDataGridViewTextBoxColumn.DataPropertyName = "Fathername";
            this.fathernameDataGridViewTextBoxColumn.HeaderText = "Fathername";
            this.fathernameDataGridViewTextBoxColumn.Name = "fathernameDataGridViewTextBoxColumn";
            // 
            // mothernameDataGridViewTextBoxColumn
            // 
            this.mothernameDataGridViewTextBoxColumn.DataPropertyName = "mothername";
            this.mothernameDataGridViewTextBoxColumn.HeaderText = "mothername";
            this.mothernameDataGridViewTextBoxColumn.Name = "mothernameDataGridViewTextBoxColumn";
            // 
            // theIdNumberDataGridViewTextBoxColumn
            // 
            this.theIdNumberDataGridViewTextBoxColumn.DataPropertyName = "TheIdNumber";
            this.theIdNumberDataGridViewTextBoxColumn.HeaderText = "TheIdNumber";
            this.theIdNumberDataGridViewTextBoxColumn.Name = "theIdNumberDataGridViewTextBoxColumn";
            // 
            // typeidDataGridViewTextBoxColumn
            // 
            this.typeidDataGridViewTextBoxColumn.DataPropertyName = "typeid";
            this.typeidDataGridViewTextBoxColumn.HeaderText = "typeid";
            this.typeidDataGridViewTextBoxColumn.Name = "typeidDataGridViewTextBoxColumn";
            // 
            // deptidDataGridViewTextBoxColumn
            // 
            this.deptidDataGridViewTextBoxColumn.DataPropertyName = "deptid";
            this.deptidDataGridViewTextBoxColumn.HeaderText = "deptid";
            this.deptidDataGridViewTextBoxColumn.Name = "deptidDataGridViewTextBoxColumn";
            this.deptidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // theStaffBindingSource
            // 
            this.theStaffBindingSource.DataMember = "TheStaff";
            this.theStaffBindingSource.DataSource = this.hospitallDataSet22;
            // 
            // hospitallDataSet22
            // 
            this.hospitallDataSet22.DataSetName = "hospitallDataSet22";
            this.hospitallDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 2;
            // 
            // theStaffTableAdapter
            // 
            this.theStaffTableAdapter.ClearBeforeFill = true;
            // 
            // hospitallDataSet23
            // 
            this.hospitallDataSet23.DataSetName = "hospitallDataSet23";
            this.hospitallDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deptBindingSource
            // 
            this.deptBindingSource.DataMember = "Dept";
            this.deptBindingSource.DataSource = this.hospitallDataSet23;
            // 
            // deptTableAdapter
            // 
            this.deptTableAdapter.ClearBeforeFill = true;
            // 
            // View_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "View_staff";
            this.Text = "View_staff";
            this.Load += new System.EventHandler(this.View_staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theStaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallDataSet22)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hospitallDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private hospitallDataSet22 hospitallDataSet22;
        private System.Windows.Forms.BindingSource theStaffBindingSource;
        private hospitallDataSet22TableAdapters.TheStaffTableAdapter theStaffTableAdapter;
        private hospitallDataSet23 hospitallDataSet23;
        private System.Windows.Forms.BindingSource deptBindingSource;
        private hospitallDataSet23TableAdapters.DeptTableAdapter deptTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fathernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mothernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn theIdNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptidDataGridViewTextBoxColumn;
    }
}