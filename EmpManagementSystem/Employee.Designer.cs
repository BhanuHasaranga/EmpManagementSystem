namespace EmpManagementSystem
{
    partial class Employee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.EmpPassTb = new System.Windows.Forms.RichTextBox();
            this.EmpDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.EmpEduCb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.EmpGenCb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EmpDob = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.EmpPosCb = new System.Windows.Forms.ComboBox();
            this.EmpPhoneTb = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EmpAddTb = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmpNameTb = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpIdTb = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manage Employee";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.EmpPassTb);
            this.panel1.Controls.Add(this.EmpDGV);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.EmpEduCb);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.EmpGenCb);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.EmpDob);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.EmpPosCb);
            this.panel1.Controls.Add(this.EmpPhoneTb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.EmpAddTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.EmpNameTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.EmpIdTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1289, 547);
            this.panel1.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label11.Location = new System.Drawing.Point(79, 400);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 25);
            this.label11.TabIndex = 27;
            this.label11.Text = "Employee Password";
            // 
            // EmpPassTb
            // 
            this.EmpPassTb.Location = new System.Drawing.Point(79, 436);
            this.EmpPassTb.Name = "EmpPassTb";
            this.EmpPassTb.Size = new System.Drawing.Size(157, 26);
            this.EmpPassTb.TabIndex = 26;
            this.EmpPassTb.Text = "";
            // 
            // EmpDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.EmpDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmpDGV.ColumnHeadersHeight = 25;
            this.EmpDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmpDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmpDGV.GridColor = System.Drawing.Color.White;
            this.EmpDGV.Location = new System.Drawing.Point(484, 10);
            this.EmpDGV.Name = "EmpDGV";
            this.EmpDGV.RowHeadersVisible = false;
            this.EmpDGV.RowTemplate.Height = 25;
            this.EmpDGV.Size = new System.Drawing.Size(792, 452);
            this.EmpDGV.TabIndex = 25;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmpDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EmpDGV.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.EmpDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.RoyalBlue;
            this.EmpDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmpDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmpDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmpDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmpDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.EmpDGV.ThemeStyle.ReadOnly = false;
            this.EmpDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EmpDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmpDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmpDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmpDGV.ThemeStyle.RowsStyle.Height = 25;
            this.EmpDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.EmpDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.EmpDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpDGV_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(1154, 501);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 31);
            this.button4.TabIndex = 24;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(372, 502);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 31);
            this.button3.TabIndex = 23;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(224, 502);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 31);
            this.button2.TabIndex = 22;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(78, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 31);
            this.button1.TabIndex = 21;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmpEduCb
            // 
            this.EmpEduCb.FormattingEnabled = true;
            this.EmpEduCb.Items.AddRange(new object[] {
            "BTech",
            "MTech",
            "BBA",
            "BCA",
            "MBA",
            "BCom",
            "MCom"});
            this.EmpEduCb.Location = new System.Drawing.Point(291, 349);
            this.EmpEduCb.Name = "EmpEduCb";
            this.EmpEduCb.Size = new System.Drawing.Size(167, 23);
            this.EmpEduCb.TabIndex = 20;
            this.EmpEduCb.SelectedIndexChanged += new System.EventHandler(this.EmpEduCb_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(291, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Employee Education";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // EmpGenCb
            // 
            this.EmpGenCb.FormattingEnabled = true;
            this.EmpGenCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.EmpGenCb.Location = new System.Drawing.Point(291, 150);
            this.EmpGenCb.Name = "EmpGenCb";
            this.EmpGenCb.Size = new System.Drawing.Size(167, 23);
            this.EmpGenCb.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(291, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Employee Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(77, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Employee Phone";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // EmpDob
            // 
            this.EmpDob.Location = new System.Drawing.Point(291, 252);
            this.EmpDob.Name = "EmpDob";
            this.EmpDob.Size = new System.Drawing.Size(186, 23);
            this.EmpDob.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(291, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Employee DOB";
            // 
            // EmpPosCb
            // 
            this.EmpPosCb.FormattingEnabled = true;
            this.EmpPosCb.Items.AddRange(new object[] {
            "Manager",
            "Senior Developer",
            "Junior Developer",
            "Accountant"});
            this.EmpPosCb.Location = new System.Drawing.Point(79, 255);
            this.EmpPosCb.Name = "EmpPosCb";
            this.EmpPosCb.Size = new System.Drawing.Size(167, 23);
            this.EmpPosCb.TabIndex = 13;
            // 
            // EmpPhoneTb
            // 
            this.EmpPhoneTb.Location = new System.Drawing.Point(77, 349);
            this.EmpPhoneTb.Name = "EmpPhoneTb";
            this.EmpPhoneTb.Size = new System.Drawing.Size(157, 26);
            this.EmpPhoneTb.TabIndex = 12;
            this.EmpPhoneTb.Text = "";
            this.EmpPhoneTb.TextChanged += new System.EventHandler(this.EmpPhoneTb_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(79, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Employee Position";
            // 
            // EmpAddTb
            // 
            this.EmpAddTb.Location = new System.Drawing.Point(77, 150);
            this.EmpAddTb.Name = "EmpAddTb";
            this.EmpAddTb.Size = new System.Drawing.Size(171, 26);
            this.EmpAddTb.TabIndex = 10;
            this.EmpAddTb.Text = "";
            this.EmpAddTb.TextChanged += new System.EventHandler(this.EmpAddTb_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(77, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Employee Address";
            // 
            // EmpNameTb
            // 
            this.EmpNameTb.Location = new System.Drawing.Point(291, 38);
            this.EmpNameTb.Name = "EmpNameTb";
            this.EmpNameTb.Size = new System.Drawing.Size(165, 26);
            this.EmpNameTb.TabIndex = 8;
            this.EmpNameTb.Text = "";
            this.EmpNameTb.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(291, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Employee Name";
            // 
            // EmpIdTb
            // 
            this.EmpIdTb.Location = new System.Drawing.Point(79, 38);
            this.EmpIdTb.Name = "EmpIdTb";
            this.EmpIdTb.Size = new System.Drawing.Size(122, 26);
            this.EmpIdTb.TabIndex = 6;
            this.EmpIdTb.Text = "";
            this.EmpIdTb.TextChanged += new System.EventHandler(this.EmpIdTb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(79, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Employee ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.RoyalBlue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1252, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 24);
            this.label10.TabIndex = 5;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmpManagementSystem.Properties.Resources.employee;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1288, 637);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DateTimePicker EmpDob;
        private Label label6;
        private ComboBox EmpPosCb;
        private RichTextBox EmpPhoneTb;
        private Label label5;
        private RichTextBox EmpAddTb;
        private Label label4;
        private RichTextBox EmpNameTb;
        private Label label3;
        private RichTextBox EmpIdTb;
        private Label label2;
        private Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView EmpDGV;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private ComboBox EmpEduCb;
        private Label label9;
        private ComboBox EmpGenCb;
        private Label label8;
        private Label label10;
        private PictureBox pictureBox1;
        private Label label11;
        private RichTextBox EmpPassTb;
    }
}