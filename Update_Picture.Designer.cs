namespace Final_project
{
    partial class Update_Picture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Picture));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hospitallDataSet39 = new Final_project.hospitallDataSet39();
            this.picturesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.picturesTableAdapter = new Final_project.hospitallDataSet39TableAdapters.picturesTableAdapter();
            this.picturesidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picturesnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Edit = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallDataSet39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.picturesidDataGridViewTextBoxColumn,
            this.picturesnameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.processingDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.picturesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // hospitallDataSet39
            // 
            this.hospitallDataSet39.DataSetName = "hospitallDataSet39";
            this.hospitallDataSet39.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // picturesBindingSource
            // 
            this.picturesBindingSource.DataMember = "pictures";
            this.picturesBindingSource.DataSource = this.hospitallDataSet39;
            // 
            // picturesTableAdapter
            // 
            this.picturesTableAdapter.ClearBeforeFill = true;
            // 
            // picturesidDataGridViewTextBoxColumn
            // 
            this.picturesidDataGridViewTextBoxColumn.DataPropertyName = "picturesid";
            this.picturesidDataGridViewTextBoxColumn.HeaderText = "picturesid";
            this.picturesidDataGridViewTextBoxColumn.Name = "picturesidDataGridViewTextBoxColumn";
            this.picturesidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // picturesnameDataGridViewTextBoxColumn
            // 
            this.picturesnameDataGridViewTextBoxColumn.DataPropertyName = "picturesname";
            this.picturesnameDataGridViewTextBoxColumn.HeaderText = "picturesname";
            this.picturesnameDataGridViewTextBoxColumn.Name = "picturesnameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // processingDataGridViewTextBoxColumn
            // 
            this.processingDataGridViewTextBoxColumn.DataPropertyName = "processing";
            this.processingDataGridViewTextBoxColumn.HeaderText = "processing";
            this.processingDataGridViewTextBoxColumn.Name = "processingDataGridViewTextBoxColumn";
            // 
            // btn_Edit
            // 
            this.btn_Edit.ActiveBorderThickness = 1;
            this.btn_Edit.ActiveCornerRadius = 20;
            this.btn_Edit.ActiveFillColor = System.Drawing.Color.Silver;
            this.btn_Edit.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Edit.ActiveLineColor = System.Drawing.Color.White;
            this.btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Edit.BackgroundImage")));
            this.btn_Edit.ButtonText = "تعديل";
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Edit.ForeColor = System.Drawing.Color.Black;
            this.btn_Edit.IdleBorderThickness = 1;
            this.btn_Edit.IdleCornerRadius = 20;
            this.btn_Edit.IdleFillColor = System.Drawing.Color.White;
            this.btn_Edit.IdleForecolor = System.Drawing.Color.Black;
            this.btn_Edit.IdleLineColor = System.Drawing.Color.Black;
            this.btn_Edit.Location = new System.Drawing.Point(306, 311);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(220, 66);
            this.btn_Edit.TabIndex = 30;
            this.btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // Update_Picture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Update_Picture";
            this.Text = "Update_Picture";
            this.Load += new System.EventHandler(this.Update_Picture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallDataSet39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private hospitallDataSet39 hospitallDataSet39;
        private System.Windows.Forms.BindingSource picturesBindingSource;
        private hospitallDataSet39TableAdapters.picturesTableAdapter picturesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn picturesidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn picturesnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processingDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Edit;
    }
}