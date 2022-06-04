namespace whole_project
{
    partial class ListOfTypes
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
            this.wholeprojectDataSet1 = new whole_project.wholeprojectDataSet1();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loanTableAdapter = new whole_project.wholeprojectDataSet1TableAdapters.loanTableAdapter();
            this.loanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusSSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeprojectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loanIDDataGridViewTextBoxColumn,
            this.loanTypeDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.cusSSNDataGridViewTextBoxColumn,
            this.empSSNDataGridViewTextBoxColumn,
            this.branchIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loanBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // wholeprojectDataSet1
            // 
            this.wholeprojectDataSet1.DataSetName = "wholeprojectDataSet1";
            this.wholeprojectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loanBindingSource
            // 
            this.loanBindingSource.DataMember = "loan";
            this.loanBindingSource.DataSource = this.wholeprojectDataSet1;
            // 
            // loanTableAdapter
            // 
            this.loanTableAdapter.ClearBeforeFill = true;
            // 
            // loanIDDataGridViewTextBoxColumn
            // 
            this.loanIDDataGridViewTextBoxColumn.DataPropertyName = "loanID";
            this.loanIDDataGridViewTextBoxColumn.HeaderText = "loanID";
            this.loanIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loanIDDataGridViewTextBoxColumn.Name = "loanIDDataGridViewTextBoxColumn";
            this.loanIDDataGridViewTextBoxColumn.Visible = false;
            this.loanIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // loanTypeDataGridViewTextBoxColumn
            // 
            this.loanTypeDataGridViewTextBoxColumn.DataPropertyName = "loanType";
            this.loanTypeDataGridViewTextBoxColumn.HeaderText = "loanType";
            this.loanTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loanTypeDataGridViewTextBoxColumn.Name = "loanTypeDataGridViewTextBoxColumn";
            this.loanTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Visible = false;
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // cusSSNDataGridViewTextBoxColumn
            // 
            this.cusSSNDataGridViewTextBoxColumn.DataPropertyName = "cusSSN";
            this.cusSSNDataGridViewTextBoxColumn.HeaderText = "cusSSN";
            this.cusSSNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cusSSNDataGridViewTextBoxColumn.Name = "cusSSNDataGridViewTextBoxColumn";
            this.cusSSNDataGridViewTextBoxColumn.Visible = false;
            this.cusSSNDataGridViewTextBoxColumn.Width = 125;
            // 
            // empSSNDataGridViewTextBoxColumn
            // 
            this.empSSNDataGridViewTextBoxColumn.DataPropertyName = "empSSN";
            this.empSSNDataGridViewTextBoxColumn.HeaderText = "empSSN";
            this.empSSNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empSSNDataGridViewTextBoxColumn.Name = "empSSNDataGridViewTextBoxColumn";
            this.empSSNDataGridViewTextBoxColumn.Visible = false;
            this.empSSNDataGridViewTextBoxColumn.Width = 125;
            // 
            // branchIDDataGridViewTextBoxColumn
            // 
            this.branchIDDataGridViewTextBoxColumn.DataPropertyName = "branchID";
            this.branchIDDataGridViewTextBoxColumn.HeaderText = "branchID";
            this.branchIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.branchIDDataGridViewTextBoxColumn.Name = "branchIDDataGridViewTextBoxColumn";
            this.branchIDDataGridViewTextBoxColumn.Visible = false;
            this.branchIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ListOfTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListOfTypes";
            this.Text = "ListOfTypes";
            this.Load += new System.EventHandler(this.ListOfTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeprojectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private wholeprojectDataSet1 wholeprojectDataSet1;
        private System.Windows.Forms.BindingSource loanBindingSource;
        private wholeprojectDataSet1TableAdapters.loanTableAdapter loanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusSSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIDDataGridViewTextBoxColumn;
    }
}