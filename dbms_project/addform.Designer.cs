namespace dbms_project
{
    partial class addform
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
            this.drug_id = new System.Windows.Forms.Label();
            this.drug_id_text = new System.Windows.Forms.TextBox();
            this.drugname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.costlabel = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // drug_id
            // 
            this.drug_id.AutoSize = true;
            this.drug_id.Location = new System.Drawing.Point(24, 36);
            this.drug_id.Name = "drug_id";
            this.drug_id.Size = new System.Drawing.Size(47, 13);
            this.drug_id.TabIndex = 0;
            this.drug_id.Text = "Drug_ID";
            // 
            // drug_id_text
            // 
            this.drug_id_text.Location = new System.Drawing.Point(89, 28);
            this.drug_id_text.Name = "drug_id_text";
            this.drug_id_text.Size = new System.Drawing.Size(131, 20);
            this.drug_id_text.TabIndex = 1;
            this.drug_id_text.TextChanged += new System.EventHandler(this.drug_id_text_TextChanged);
            // 
            // drugname
            // 
            this.drugname.AutoSize = true;
            this.drugname.Location = new System.Drawing.Point(24, 70);
            this.drugname.Name = "drugname";
            this.drugname.Size = new System.Drawing.Size(61, 13);
            this.drugname.TabIndex = 2;
            this.drugname.Text = "Drug Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mfd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Expiry dt";
            // 
            // costlabel
            // 
            this.costlabel.AutoSize = true;
            this.costlabel.Location = new System.Drawing.Point(27, 169);
            this.costlabel.Name = "costlabel";
            this.costlabel.Size = new System.Drawing.Size(28, 13);
            this.costlabel.TabIndex = 8;
            this.costlabel.Text = "Cost";
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(89, 169);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(131, 20);
            this.cost.TabIndex = 9;
            this.cost.TextChanged += new System.EventHandler(this.cost_TextChanged);
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(185, 246);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 23);
            this.addbutton.TabIndex = 10;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(89, 133);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(131, 20);
            this.textBox3.TabIndex = 14;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "mm/dd/yyyy";
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Quantity";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(89, 204);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(131, 20);
            this.quantity.TabIndex = 16;
            this.quantity.TextChanged += new System.EventHandler(this.quantity_TextChanged);
            // 
            // addform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(307, 291);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.costlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.drugname);
            this.Controls.Add(this.drug_id_text);
            this.Controls.Add(this.drug_id);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Name = "addform";
            this.Text = "addform";
            this.Load += new System.EventHandler(this.addform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label drug_id;
        private System.Windows.Forms.TextBox drug_id_text;
        private System.Windows.Forms.Label drugname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label costlabel;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantity;
    }
}