namespace Lab05_Report
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.northWindDataSet1 = new Lab05_Report.NorthWindDataSet();
            this.categoryProductsDataTableTableAdapter1 = new Lab05_Report.NorthWindDataSetTableAdapters.CategoryProductsDataTableTableAdapter();
            this.tableAdapterManager1 = new Lab05_Report.NorthWindDataSetTableAdapters.TableAdapterManager();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NorthWindDataSet = new Lab05_Report.NorthWindDataSet();
            this.CategoryProductsDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CategoryProductsDataTableTableAdapter = new Lab05_Report.NorthWindDataSetTableAdapters.CategoryProductsDataTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northWindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NorthWindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryProductsDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(119, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(413, 163);
            this.dataGridView1.TabIndex = 1;
            // 
            // northWindDataSet1
            // 
            this.northWindDataSet1.DataSetName = "NorthWindDataSet";
            this.northWindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryProductsDataTableTableAdapter1
            // 
            this.categoryProductsDataTableTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = Lab05_Report.NorthWindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Lab05_Report.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(136, 213);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 2;
            // 
            // NorthWindDataSet
            // 
            this.NorthWindDataSet.DataSetName = "NorthWindDataSet";
            this.NorthWindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CategoryProductsDataTableBindingSource
            // 
            this.CategoryProductsDataTableBindingSource.DataMember = "CategoryProductsDataTable";
            this.CategoryProductsDataTableBindingSource.DataSource = this.NorthWindDataSet;
            // 
            // CategoryProductsDataTableTableAdapter
            // 
            this.CategoryProductsDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 471);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northWindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NorthWindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryProductsDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NorthWindDataSet northWindDataSet1;
        private NorthWindDataSetTableAdapters.CategoryProductsDataTableTableAdapter categoryProductsDataTableTableAdapter1;
        private NorthWindDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CategoryProductsDataTableBindingSource;
        private NorthWindDataSet NorthWindDataSet;
        private NorthWindDataSetTableAdapters.CategoryProductsDataTableTableAdapter CategoryProductsDataTableTableAdapter;
    }
}