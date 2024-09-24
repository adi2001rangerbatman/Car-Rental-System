namespace Car_Rental_System
{
    partial class Return
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Return));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rentCarDGV = new System.Windows.Forms.DataGridView();
            this.btn_return_back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btb_return_delete = new System.Windows.Forms.Button();
            this.btn_return_add = new System.Windows.Forms.Button();
            this.returnID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.returnCustomerName = new System.Windows.Forms.TextBox();
            this.returnCarRegNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.returnDelay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.returnFine = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.returnCarDGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnCarDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 106);
            this.panel1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Return Manage";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 768);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1246, 28);
            this.panel2.TabIndex = 24;
            // 
            // rentCarDGV
            // 
            this.rentCarDGV.AllowUserToAddRows = false;
            this.rentCarDGV.AllowUserToDeleteRows = false;
            this.rentCarDGV.AllowUserToResizeColumns = false;
            this.rentCarDGV.AllowUserToResizeRows = false;
            this.rentCarDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rentCarDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.rentCarDGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rentCarDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rentCarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rentCarDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.rentCarDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.rentCarDGV.Location = new System.Drawing.Point(514, 186);
            this.rentCarDGV.Name = "rentCarDGV";
            this.rentCarDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rentCarDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.rentCarDGV.RowHeadersWidth = 51;
            this.rentCarDGV.RowTemplate.Height = 30;
            this.rentCarDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rentCarDGV.Size = new System.Drawing.Size(705, 224);
            this.rentCarDGV.TabIndex = 50;
            this.rentCarDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rentCarDGV_CellContentClick);
            // 
            // btn_return_back
            // 
            this.btn_return_back.BackColor = System.Drawing.Color.DarkGray;
            this.btn_return_back.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return_back.Location = new System.Drawing.Point(314, 619);
            this.btn_return_back.Name = "btn_return_back";
            this.btn_return_back.Size = new System.Drawing.Size(127, 54);
            this.btn_return_back.TabIndex = 39;
            this.btn_return_back.Text = "Back";
            this.btn_return_back.UseVisualStyleBackColor = false;
            this.btn_return_back.Click += new System.EventHandler(this.btn_return_back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(795, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 27);
            this.label3.TabIndex = 49;
            this.label3.Text = "Cars On Rent";
            // 
            // btb_return_delete
            // 
            this.btb_return_delete.BackColor = System.Drawing.Color.IndianRed;
            this.btb_return_delete.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btb_return_delete.Location = new System.Drawing.Point(174, 619);
            this.btb_return_delete.Name = "btb_return_delete";
            this.btb_return_delete.Size = new System.Drawing.Size(127, 54);
            this.btb_return_delete.TabIndex = 47;
            this.btb_return_delete.Text = "Delete";
            this.btb_return_delete.UseVisualStyleBackColor = false;
            this.btb_return_delete.Click += new System.EventHandler(this.btb_return_delete_Click);
            // 
            // btn_return_add
            // 
            this.btn_return_add.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_return_add.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return_add.Location = new System.Drawing.Point(34, 619);
            this.btn_return_add.Name = "btn_return_add";
            this.btn_return_add.Size = new System.Drawing.Size(127, 54);
            this.btn_return_add.TabIndex = 46;
            this.btn_return_add.Text = "Add";
            this.btn_return_add.UseVisualStyleBackColor = false;
            this.btn_return_add.Click += new System.EventHandler(this.btn_return_add_Click);
            // 
            // returnID
            // 
            this.returnID.BackColor = System.Drawing.SystemColors.Control;
            this.returnID.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnID.Location = new System.Drawing.Point(179, 146);
            this.returnID.Multiline = true;
            this.returnID.Name = "returnID";
            this.returnID.Size = new System.Drawing.Size(253, 40);
            this.returnID.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 27);
            this.label2.TabIndex = 44;
            this.label2.Text = "ID";
            // 
            // returnCustomerName
            // 
            this.returnCustomerName.BackColor = System.Drawing.SystemColors.Control;
            this.returnCustomerName.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnCustomerName.Location = new System.Drawing.Point(181, 298);
            this.returnCustomerName.Multiline = true;
            this.returnCustomerName.Name = "returnCustomerName";
            this.returnCustomerName.Size = new System.Drawing.Size(251, 40);
            this.returnCustomerName.TabIndex = 43;
            // 
            // returnCarRegNo
            // 
            this.returnCarRegNo.BackColor = System.Drawing.SystemColors.Control;
            this.returnCarRegNo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnCarRegNo.Location = new System.Drawing.Point(181, 222);
            this.returnCarRegNo.Multiline = true;
            this.returnCarRegNo.Name = "returnCarRegNo";
            this.returnCarRegNo.Size = new System.Drawing.Size(251, 40);
            this.returnCarRegNo.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(29, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 27);
            this.label7.TabIndex = 41;
            this.label7.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(29, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 27);
            this.label6.TabIndex = 40;
            this.label6.Text = "Car Reg No";
            // 
            // returnDate
            // 
            this.returnDate.Location = new System.Drawing.Point(181, 388);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(251, 22);
            this.returnDate.TabIndex = 76;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(29, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 27);
            this.label9.TabIndex = 75;
            this.label9.Text = "Return Date";
            // 
            // returnDelay
            // 
            this.returnDelay.BackColor = System.Drawing.SystemColors.Control;
            this.returnDelay.Enabled = false;
            this.returnDelay.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDelay.Location = new System.Drawing.Point(181, 457);
            this.returnDelay.Multiline = true;
            this.returnDelay.Name = "returnDelay";
            this.returnDelay.Size = new System.Drawing.Size(251, 40);
            this.returnDelay.TabIndex = 77;
            this.returnDelay.TextChanged += new System.EventHandler(this.returnDelay_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(29, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 27);
            this.label4.TabIndex = 78;
            this.label4.Text = "Delay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(29, 542);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 27);
            this.label5.TabIndex = 79;
            this.label5.Text = "Fine";
            // 
            // returnFine
            // 
            this.returnFine.BackColor = System.Drawing.SystemColors.Control;
            this.returnFine.Enabled = false;
            this.returnFine.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnFine.Location = new System.Drawing.Point(181, 542);
            this.returnFine.Multiline = true;
            this.returnFine.Name = "returnFine";
            this.returnFine.Size = new System.Drawing.Size(251, 40);
            this.returnFine.TabIndex = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(795, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 27);
            this.label8.TabIndex = 81;
            this.label8.Text = "Return Cars List";
            // 
            // returnCarDGV
            // 
            this.returnCarDGV.AllowUserToAddRows = false;
            this.returnCarDGV.AllowUserToDeleteRows = false;
            this.returnCarDGV.AllowUserToResizeColumns = false;
            this.returnCarDGV.AllowUserToResizeRows = false;
            this.returnCarDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.returnCarDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.returnCarDGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.returnCarDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.returnCarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.returnCarDGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.returnCarDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.returnCarDGV.Location = new System.Drawing.Point(514, 500);
            this.returnCarDGV.Name = "returnCarDGV";
            this.returnCarDGV.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.returnCarDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.returnCarDGV.RowHeadersWidth = 51;
            this.returnCarDGV.RowTemplate.Height = 30;
            this.returnCarDGV.Size = new System.Drawing.Size(705, 223);
            this.returnCarDGV.TabIndex = 82;
            this.returnCarDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 796);
            this.Controls.Add(this.returnCarDGV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.returnFine);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.returnDelay);
            this.Controls.Add(this.returnDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rentCarDGV);
            this.Controls.Add(this.btn_return_back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btb_return_delete);
            this.Controls.Add(this.btn_return_add);
            this.Controls.Add(this.returnID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.returnCustomerName);
            this.Controls.Add(this.returnCarRegNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Return";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return";
            this.Load += new System.EventHandler(this.Return_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnCarDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView rentCarDGV;
        private System.Windows.Forms.Button btn_return_back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btb_return_delete;
        private System.Windows.Forms.Button btn_return_add;
        private System.Windows.Forms.TextBox returnID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox returnCustomerName;
        private System.Windows.Forms.TextBox returnCarRegNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker returnDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox returnDelay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox returnFine;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView returnCarDGV;
    }
}