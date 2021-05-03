﻿namespace Final_project
{
    partial class View_working_period
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.hospitallDataSet24 = new Final_project.hospitallDataSet24();
            this.workPeriodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workPeriodsTableAdapter = new Final_project.hospitallDataSet24TableAdapters.WorkPeriodsTableAdapter();
            this.periodnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situationidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayAndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workPeriodsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.periodnumberDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.situationidDataGridViewTextBoxColumn,
            this.dayAndDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workPeriodsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 24;
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
            this.panel1.TabIndex = 3;
            // 
            // hospitallDataSet24
            // 
            this.hospitallDataSet24.DataSetName = "hospitallDataSet24";
            this.hospitallDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workPeriodsBindingSource
            // 
            this.workPeriodsBindingSource.DataMember = "WorkPeriods";
            this.workPeriodsBindingSource.DataSource = this.hospitallDataSet24;
            // 
            // workPeriodsTableAdapter
            // 
            this.workPeriodsTableAdapter.ClearBeforeFill = true;
            // 
            // periodnumberDataGridViewTextBoxColumn
            // 
            this.periodnumberDataGridViewTextBoxColumn.DataPropertyName = "periodnumber";
            this.periodnumberDataGridViewTextBoxColumn.HeaderText = "periodnumber";
            this.periodnumberDataGridViewTextBoxColumn.Name = "periodnumberDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // situationidDataGridViewTextBoxColumn
            // 
            this.situationidDataGridViewTextBoxColumn.DataPropertyName = "Situationid";
            this.situationidDataGridViewTextBoxColumn.HeaderText = "Situationid";
            this.situationidDataGridViewTextBoxColumn.Name = "situationidDataGridViewTextBoxColumn";
            // 
            // dayAndDateDataGridViewTextBoxColumn
            // 
            this.dayAndDateDataGridViewTextBoxColumn.DataPropertyName = "DayAndDate";
            this.dayAndDateDataGridViewTextBoxColumn.HeaderText = "DayAndDate";
            this.dayAndDateDataGridViewTextBoxColumn.Name = "dayAndDateDataGridViewTextBoxColumn";
            // 
            // View_working_period
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "View_working_period";
            this.Text = "Working_period";
            this.Load += new System.EventHandler(this.View_working_period_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hospitallDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workPeriodsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private hospitallDataSet24 hospitallDataSet24;
        private System.Windows.Forms.BindingSource workPeriodsBindingSource;
        private hospitallDataSet24TableAdapters.WorkPeriodsTableAdapter workPeriodsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situationidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayAndDateDataGridViewTextBoxColumn;
    }
}