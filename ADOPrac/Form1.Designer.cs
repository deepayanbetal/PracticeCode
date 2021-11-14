namespace PracticeProgramms.ADOPrac
{
    partial class Form1
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
            this.employeeDataSet = new PracticeProgramms.employeeDataSet();
            this.empInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empInfoTableAdapter = new PracticeProgramms.employeeDataSetTableAdapters.empInfoTableAdapter();
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empidDataGridViewTextBoxColumn,
            this.enameDataGridViewTextBoxColumn,
            this.deptDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.empInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(446, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // employeeDataSet
            // 
            this.employeeDataSet.DataSetName = "employeeDataSet";
            this.employeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empInfoBindingSource
            // 
            this.empInfoBindingSource.DataMember = "empInfo";
            this.empInfoBindingSource.DataSource = this.employeeDataSet;
            // 
            // empInfoTableAdapter
            // 
            this.empInfoTableAdapter.ClearBeforeFill = true;
            // 
            // empidDataGridViewTextBoxColumn
            // 
            this.empidDataGridViewTextBoxColumn.DataPropertyName = "empid";
            this.empidDataGridViewTextBoxColumn.HeaderText = "empid";
            this.empidDataGridViewTextBoxColumn.Name = "empidDataGridViewTextBoxColumn";
            // 
            // enameDataGridViewTextBoxColumn
            // 
            this.enameDataGridViewTextBoxColumn.DataPropertyName = "ename";
            this.enameDataGridViewTextBoxColumn.HeaderText = "ename";
            this.enameDataGridViewTextBoxColumn.Name = "enameDataGridViewTextBoxColumn";
            // 
            // deptDataGridViewTextBoxColumn
            // 
            this.deptDataGridViewTextBoxColumn.DataPropertyName = "dept";
            this.deptDataGridViewTextBoxColumn.HeaderText = "dept";
            this.deptDataGridViewTextBoxColumn.Name = "deptDataGridViewTextBoxColumn";
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private employeeDataSet employeeDataSet;
        private System.Windows.Forms.BindingSource empInfoBindingSource;
        private employeeDataSetTableAdapters.empInfoTableAdapter empInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}