namespace dbms_project
{
    partial class searchform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchform));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dRUGIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mFDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRUGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new dbms_project.DataSet1();
            this.dRUGTableAdapter = new dbms_project.DataSet1TableAdapters.DRUGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dRUGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(197, 23);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 23);
            this.searchbutton.TabIndex = 1;
            this.searchbutton.Text = "search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dRUGIDDataGridViewTextBoxColumn,
            this.dNAMEDataGridViewTextBoxColumn,
            this.mFDDataGridViewTextBoxColumn,
            this.eXPDataGridViewTextBoxColumn,
            this.cOSTDataGridViewTextBoxColumn,
            this.qUANTITYDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dRUGBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 98);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dRUGIDDataGridViewTextBoxColumn
            // 
            this.dRUGIDDataGridViewTextBoxColumn.DataPropertyName = "DRUG_ID";
            this.dRUGIDDataGridViewTextBoxColumn.HeaderText = "DRUG_ID";
            this.dRUGIDDataGridViewTextBoxColumn.Name = "dRUGIDDataGridViewTextBoxColumn";
            // 
            // dNAMEDataGridViewTextBoxColumn
            // 
            this.dNAMEDataGridViewTextBoxColumn.DataPropertyName = "D_NAME";
            this.dNAMEDataGridViewTextBoxColumn.HeaderText = "D_NAME";
            this.dNAMEDataGridViewTextBoxColumn.Name = "dNAMEDataGridViewTextBoxColumn";
            // 
            // mFDDataGridViewTextBoxColumn
            // 
            this.mFDDataGridViewTextBoxColumn.DataPropertyName = "MFD";
            this.mFDDataGridViewTextBoxColumn.HeaderText = "MFD";
            this.mFDDataGridViewTextBoxColumn.Name = "mFDDataGridViewTextBoxColumn";
            // 
            // eXPDataGridViewTextBoxColumn
            // 
            this.eXPDataGridViewTextBoxColumn.DataPropertyName = "EXP";
            this.eXPDataGridViewTextBoxColumn.HeaderText = "EXP";
            this.eXPDataGridViewTextBoxColumn.Name = "eXPDataGridViewTextBoxColumn";
            // 
            // cOSTDataGridViewTextBoxColumn
            // 
            this.cOSTDataGridViewTextBoxColumn.DataPropertyName = "COST";
            this.cOSTDataGridViewTextBoxColumn.HeaderText = "COST";
            this.cOSTDataGridViewTextBoxColumn.Name = "cOSTDataGridViewTextBoxColumn";
            // 
            // qUANTITYDataGridViewTextBoxColumn
            // 
            this.qUANTITYDataGridViewTextBoxColumn.DataPropertyName = "QUANTITY";
            this.qUANTITYDataGridViewTextBoxColumn.HeaderText = "QUANTITY";
            this.qUANTITYDataGridViewTextBoxColumn.Name = "qUANTITYDataGridViewTextBoxColumn";
            // 
            // dRUGBindingSource
            // 
            this.dRUGBindingSource.DataMember = "DRUG";
            this.dRUGBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dRUGTableAdapter
            // 
            this.dRUGTableAdapter.ClearBeforeFill = true;
            // 
            // searchform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(719, 272);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.textBox1);
            this.Name = "searchform";
            this.Text = "searchform";
            this.Load += new System.EventHandler(this.searchform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dRUGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dRUGBindingSource;
        private DataSet1TableAdapters.DRUGTableAdapter dRUGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRUGIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mFDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTITYDataGridViewTextBoxColumn;
    }
}