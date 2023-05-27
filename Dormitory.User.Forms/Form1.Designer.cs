namespace Dormitory.User.Forms
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label42 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label39 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbMaxAge = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.tbSearchStudentSurname = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label43 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label44 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lbSalaryExpenses = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.tbSearchWorkerSurname = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControl1.Location = new System.Drawing.Point(5, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1157, 734);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label42);
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Controls.Add(this.label39);
            this.tabPage1.Controls.Add(this.panel8);
            this.tabPage1.Controls.Add(this.label40);
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1149, 705);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Students";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label42.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label42.Location = new System.Drawing.Point(5, 109);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(244, 25);
            this.label42.TabIndex = 20;
            this.label42.Text = "Grouped by Room Number";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 137);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1140, 248);
            this.dataGridView3.TabIndex = 19;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label39.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label39.Location = new System.Drawing.Point(223, 6);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(91, 25);
            this.label39.TabIndex = 18;
            this.label39.Text = "Max Age";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.lbMaxAge);
            this.panel8.Controls.Add(this.label41);
            this.panel8.Location = new System.Drawing.Point(221, 34);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(136, 68);
            this.panel8.TabIndex = 17;
            // 
            // lbMaxAge
            // 
            this.lbMaxAge.AutoSize = true;
            this.lbMaxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbMaxAge.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMaxAge.Location = new System.Drawing.Point(70, 5);
            this.lbMaxAge.Name = "lbMaxAge";
            this.lbMaxAge.Size = new System.Drawing.Size(61, 17);
            this.lbMaxAge.TabIndex = 5;
            this.lbMaxAge.Text = "Max age";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label41.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label41.Location = new System.Drawing.Point(3, 5);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(61, 17);
            this.label41.TabIndex = 4;
            this.label41.Text = "Max age";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label40.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label40.Location = new System.Drawing.Point(5, 6);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(75, 25);
            this.label40.TabIndex = 16;
            this.label40.Text = "Search";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.button7);
            this.panel7.Controls.Add(this.tbSearchStudentSurname);
            this.panel7.Controls.Add(this.label45);
            this.panel7.Location = new System.Drawing.Point(3, 34);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(212, 68);
            this.panel7.TabIndex = 15;
            // 
            // button7
            // 
            this.button7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button7.Location = new System.Drawing.Point(129, 34);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "Search";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tbSearchStudentSurname
            // 
            this.tbSearchStudentSurname.Location = new System.Drawing.Point(74, 5);
            this.tbSearchStudentSurname.Name = "tbSearchStudentSurname";
            this.tbSearchStudentSurname.Size = new System.Drawing.Size(130, 23);
            this.tbSearchStudentSurname.TabIndex = 5;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label45.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label45.Location = new System.Drawing.Point(3, 8);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(65, 17);
            this.label45.TabIndex = 4;
            this.label45.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(3, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Students";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 416);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1143, 248);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label43);
            this.tabPage2.Controls.Add(this.dataGridView4);
            this.tabPage2.Controls.Add(this.label44);
            this.tabPage2.Controls.Add(this.panel9);
            this.tabPage2.Controls.Add(this.label48);
            this.tabPage2.Controls.Add(this.panel10);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1149, 705);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Workers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(499, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 68);
            this.button2.TabIndex = 10;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 415);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1140, 248);
            this.dataGridView2.TabIndex = 8;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label43.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label43.Location = new System.Drawing.Point(5, 107);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(188, 25);
            this.label43.TabIndex = 29;
            this.label43.Text = "Grouped by Position";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(2, 135);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(1144, 248);
            this.dataGridView4.TabIndex = 28;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label44.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label44.Location = new System.Drawing.Point(223, 4);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(160, 25);
            this.label44.TabIndex = 27;
            this.label44.Text = "Salary Expenses";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.lbSalaryExpenses);
            this.panel9.Controls.Add(this.label47);
            this.panel9.Location = new System.Drawing.Point(221, 32);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(236, 68);
            this.panel9.TabIndex = 26;
            // 
            // lbSalaryExpenses
            // 
            this.lbSalaryExpenses.AutoSize = true;
            this.lbSalaryExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSalaryExpenses.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbSalaryExpenses.Location = new System.Drawing.Point(122, 5);
            this.lbSalaryExpenses.Name = "lbSalaryExpenses";
            this.lbSalaryExpenses.Size = new System.Drawing.Size(113, 17);
            this.lbSalaryExpenses.TabIndex = 5;
            this.lbSalaryExpenses.Text = "Salary Expenses";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label47.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label47.Location = new System.Drawing.Point(3, 5);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(113, 17);
            this.label47.TabIndex = 4;
            this.label47.Text = "Salary Expenses";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label48.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label48.Location = new System.Drawing.Point(5, 4);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(75, 25);
            this.label48.TabIndex = 25;
            this.label48.Text = "Search";
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.button8);
            this.panel10.Controls.Add(this.tbSearchWorkerSurname);
            this.panel10.Controls.Add(this.label49);
            this.panel10.Location = new System.Drawing.Point(3, 32);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(212, 68);
            this.panel10.TabIndex = 24;
            // 
            // button8
            // 
            this.button8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button8.Location = new System.Drawing.Point(129, 34);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 6;
            this.button8.Text = "Search";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // tbSearchWorkerSurname
            // 
            this.tbSearchWorkerSurname.Location = new System.Drawing.Point(74, 5);
            this.tbSearchWorkerSurname.Name = "tbSearchWorkerSurname";
            this.tbSearchWorkerSurname.Size = new System.Drawing.Size(130, 23);
            this.tbSearchWorkerSurname.TabIndex = 5;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label49.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label49.Location = new System.Drawing.Point(3, 8);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(65, 17);
            this.label49.TabIndex = 4;
            this.label49.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(5, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Workers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 726);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Dormitoty(User)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbMaxAge;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox tbSearchStudentSurname;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lbSalaryExpenses;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox tbSearchWorkerSurname;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label1;
    }
}

