namespace App9
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
            this.records_view = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Roll_No = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.add_record = new System.Windows.Forms.Button();
            this.edit_record = new System.Windows.Forms.Button();
            this.delete_record = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.records_view)).BeginInit();
            this.SuspendLayout();
            // 
            // records_view
            // 
            this.records_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.records_view.Location = new System.Drawing.Point(200, 135);
            this.records_view.Name = "records_view";
            this.records_view.Size = new System.Drawing.Size(401, 183);
            this.records_view.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Records";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Roll No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Age";
            // 
            // Roll_No
            // 
            this.Roll_No.Location = new System.Drawing.Point(200, 84);
            this.Roll_No.Name = "Roll_No";
            this.Roll_No.Size = new System.Drawing.Size(100, 20);
            this.Roll_No.TabIndex = 5;
            this.Roll_No.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(355, 84);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 20);
            this.Name.TabIndex = 6;
            this.Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(501, 84);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(100, 20);
            this.Age.TabIndex = 7;
            this.Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // add_record
            // 
            this.add_record.BackColor = System.Drawing.Color.Chartreuse;
            this.add_record.Location = new System.Drawing.Point(646, 77);
            this.add_record.Name = "add_record";
            this.add_record.Size = new System.Drawing.Size(75, 30);
            this.add_record.TabIndex = 8;
            this.add_record.Text = "Add";
            this.add_record.UseVisualStyleBackColor = false;
            this.add_record.Click += new System.EventHandler(this.add_record_Click);
            // 
            // edit_record
            // 
            this.edit_record.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.edit_record.Location = new System.Drawing.Point(646, 145);
            this.edit_record.Name = "edit_record";
            this.edit_record.Size = new System.Drawing.Size(75, 30);
            this.edit_record.TabIndex = 9;
            this.edit_record.Text = "Edit";
            this.edit_record.UseVisualStyleBackColor = false;
            this.edit_record.Click += new System.EventHandler(this.edit_record_Click);
            // 
            // delete_record
            // 
            this.delete_record.BackColor = System.Drawing.Color.IndianRed;
            this.delete_record.Location = new System.Drawing.Point(646, 211);
            this.delete_record.Name = "delete_record";
            this.delete_record.Size = new System.Drawing.Size(75, 30);
            this.delete_record.TabIndex = 10;
            this.delete_record.Text = "Delete";
            this.delete_record.UseVisualStyleBackColor = false;
            this.delete_record.Click += new System.EventHandler(this.delete_record_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete_record);
            this.Controls.Add(this.edit_record);
            this.Controls.Add(this.add_record);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Roll_No);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.records_view);
            //this.Name = "Form1";
            this.Text = "Records";
            ((System.ComponentModel.ISupportInitialize)(this.records_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView records_view;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Roll_No;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.Button add_record;
        private System.Windows.Forms.Button edit_record;
        private System.Windows.Forms.Button delete_record;
    }
}

