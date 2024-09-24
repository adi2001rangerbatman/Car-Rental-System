namespace Car_Rental_System
{
    partial class Rental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rental));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rentFee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rentalDGV = new System.Windows.Forms.DataGridView();
            this.btn_customerr_back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_customer_edit = new System.Windows.Forms.Button();
            this.btb_customer_delete = new System.Windows.Forms.Button();
            this.btn_customer_add = new System.Windows.Forms.Button();
            this.rentID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rentCusName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.carRegCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rentalDate = new System.Windows.Forms.DateTimePicker();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.rentCustID = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalDGV)).BeginInit();
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
            this.panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = " Rental";
            // 
            // rentFee
            // 
            this.rentFee.BackColor = System.Drawing.SystemColors.Control;
            this.rentFee.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentFee.Location = new System.Drawing.Point(222, 523);
            this.rentFee.Multiline = true;
            this.rentFee.Name = "rentFee";
            this.rentFee.Size = new System.Drawing.Size(249, 40);
            this.rentFee.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(37, 536);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 27);
            this.label4.TabIndex = 65;
            this.label4.Text = "Rent Fee (Rs.)";
            // 
            // rentalDGV
            // 
            this.rentalDGV.AllowUserToAddRows = false;
            this.rentalDGV.AllowUserToDeleteRows = false;
            this.rentalDGV.AllowUserToResizeColumns = false;
            this.rentalDGV.AllowUserToResizeRows = false;
            this.rentalDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rentalDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.rentalDGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rentalDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rentalDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rentalDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.rentalDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.rentalDGV.Location = new System.Drawing.Point(519, 184);
            this.rentalDGV.Name = "rentalDGV";
            this.rentalDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rentalDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.rentalDGV.RowHeadersWidth = 51;
            this.rentalDGV.RowTemplate.Height = 30;
            this.rentalDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rentalDGV.Size = new System.Drawing.Size(705, 548);
            this.rentalDGV.TabIndex = 64;
            this.rentalDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rentalDGV_CellContentClick);
            // 
            // btn_customerr_back
            // 
            this.btn_customerr_back.BackColor = System.Drawing.Color.DarkGray;
            this.btn_customerr_back.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customerr_back.Location = new System.Drawing.Point(184, 678);
            this.btn_customerr_back.Name = "btn_customerr_back";
            this.btn_customerr_back.Size = new System.Drawing.Size(127, 54);
            this.btn_customerr_back.TabIndex = 53;
            this.btn_customerr_back.Text = "Back";
            this.btn_customerr_back.UseVisualStyleBackColor = false;
            this.btn_customerr_back.Click += new System.EventHandler(this.btn_customerr_back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(798, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 27);
            this.label3.TabIndex = 63;
            this.label3.Text = "Cars on Rent";
            // 
            // btn_customer_edit
            // 
            this.btn_customer_edit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_customer_edit.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer_edit.Location = new System.Drawing.Point(184, 615);
            this.btn_customer_edit.Name = "btn_customer_edit";
            this.btn_customer_edit.Size = new System.Drawing.Size(127, 54);
            this.btn_customer_edit.TabIndex = 62;
            this.btn_customer_edit.Text = "Edit";
            this.btn_customer_edit.UseVisualStyleBackColor = false;
            this.btn_customer_edit.Click += new System.EventHandler(this.btn_customer_edit_Click);
            // 
            // btb_customer_delete
            // 
            this.btb_customer_delete.BackColor = System.Drawing.Color.IndianRed;
            this.btb_customer_delete.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btb_customer_delete.Location = new System.Drawing.Point(330, 615);
            this.btb_customer_delete.Name = "btb_customer_delete";
            this.btb_customer_delete.Size = new System.Drawing.Size(127, 54);
            this.btb_customer_delete.TabIndex = 61;
            this.btb_customer_delete.Text = "Delete";
            this.btb_customer_delete.UseVisualStyleBackColor = false;
            this.btb_customer_delete.Click += new System.EventHandler(this.btb_customer_delete_Click);
            // 
            // btn_customer_add
            // 
            this.btn_customer_add.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_customer_add.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer_add.Location = new System.Drawing.Point(42, 615);
            this.btn_customer_add.Name = "btn_customer_add";
            this.btn_customer_add.Size = new System.Drawing.Size(127, 54);
            this.btn_customer_add.TabIndex = 60;
            this.btn_customer_add.Text = "Add";
            this.btn_customer_add.UseVisualStyleBackColor = false;
            this.btn_customer_add.Click += new System.EventHandler(this.btn_customer_add_Click);
            // 
            // rentID
            // 
            this.rentID.BackColor = System.Drawing.SystemColors.Control;
            this.rentID.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentID.Location = new System.Drawing.Point(222, 144);
            this.rentID.Multiline = true;
            this.rentID.Name = "rentID";
            this.rentID.Size = new System.Drawing.Size(251, 40);
            this.rentID.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(37, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 27);
            this.label2.TabIndex = 58;
            this.label2.Text = "ID";
            // 
            // rentCusName
            // 
            this.rentCusName.BackColor = System.Drawing.SystemColors.Control;
            this.rentCusName.Enabled = false;
            this.rentCusName.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentCusName.Location = new System.Drawing.Point(222, 349);
            this.rentCusName.Multiline = true;
            this.rentCusName.Name = "rentCusName";
            this.rentCusName.Size = new System.Drawing.Size(249, 40);
            this.rentCusName.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(37, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 27);
            this.label7.TabIndex = 55;
            this.label7.Text = "Customer ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(37, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 27);
            this.label6.TabIndex = 54;
            this.label6.Text = "Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 768);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1246, 28);
            this.panel2.TabIndex = 67;
            // 
            // carRegCB
            // 
            this.carRegCB.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carRegCB.FormattingEnabled = true;
            this.carRegCB.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.carRegCB.Location = new System.Drawing.Point(222, 214);
            this.carRegCB.Name = "carRegCB";
            this.carRegCB.Size = new System.Drawing.Size(251, 35);
            this.carRegCB.TabIndex = 68;
            this.carRegCB.SelectionChangeCommitted += new System.EventHandler(this.carRegCB_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(37, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 27);
            this.label5.TabIndex = 69;
            this.label5.Text = "Car Reg No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(37, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 27);
            this.label8.TabIndex = 70;
            this.label8.Text = "Rental Date";
            // 
            // rentalDate
            // 
            this.rentalDate.Location = new System.Drawing.Point(222, 419);
            this.rentalDate.Name = "rentalDate";
            this.rentalDate.Size = new System.Drawing.Size(251, 22);
            this.rentalDate.TabIndex = 71;
            // 
            // returnDate
            // 
            this.returnDate.Location = new System.Drawing.Point(222, 471);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(251, 22);
            this.returnDate.TabIndex = 73;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(37, 471);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 27);
            this.label9.TabIndex = 72;
            this.label9.Text = "Return Date";
            // 
            // rentCustID
            // 
            this.rentCustID.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentCustID.FormattingEnabled = true;
            this.rentCustID.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.rentCustID.Location = new System.Drawing.Point(222, 284);
            this.rentCustID.Name = "rentCustID";
            this.rentCustID.Size = new System.Drawing.Size(251, 35);
            this.rentCustID.TabIndex = 74;
            this.rentCustID.SelectionChangeCommitted += new System.EventHandler(this.rentCustID_SelectionChangeCommitted);
            // 
            // Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1246, 796);
            this.Controls.Add(this.rentCustID);
            this.Controls.Add(this.returnDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rentalDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.carRegCB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rentFee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rentalDGV);
            this.Controls.Add(this.btn_customerr_back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_customer_edit);
            this.Controls.Add(this.btb_customer_delete);
            this.Controls.Add(this.btn_customer_add);
            this.Controls.Add(this.rentID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rentCusName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rental";
            this.Text = "CAR RENTAL";
            this.Load += new System.EventHandler(this.Rental_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rentFee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView rentalDGV;
        private System.Windows.Forms.Button btn_customerr_back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_customer_edit;
        private System.Windows.Forms.Button btb_customer_delete;
        private System.Windows.Forms.Button btn_customer_add;
        private System.Windows.Forms.TextBox rentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rentCusName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox carRegCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker rentalDate;
        private System.Windows.Forms.DateTimePicker returnDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox rentCustID;
    }
}