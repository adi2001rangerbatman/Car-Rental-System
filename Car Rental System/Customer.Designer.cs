namespace Car_Rental_System
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.custPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customerDGV = new System.Windows.Forms.DataGridView();
            this.btn_customerr_back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_customer_edit = new System.Windows.Forms.Button();
            this.btb_customer_delete = new System.Windows.Forms.Button();
            this.btn_customer_add = new System.Windows.Forms.Button();
            this.custID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.custAddress = new System.Windows.Forms.TextBox();
            this.custName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDGV)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(365, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Customers";
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
            // custPhone
            // 
            this.custPhone.BackColor = System.Drawing.SystemColors.Control;
            this.custPhone.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custPhone.Location = new System.Drawing.Point(171, 376);
            this.custPhone.Multiline = true;
            this.custPhone.Name = "custPhone";
            this.custPhone.Size = new System.Drawing.Size(235, 40);
            this.custPhone.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(29, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 27);
            this.label4.TabIndex = 51;
            this.label4.Text = "Address";
            // 
            // customerDGV
            // 
            this.customerDGV.AllowUserToAddRows = false;
            this.customerDGV.AllowUserToDeleteRows = false;
            this.customerDGV.AllowUserToResizeColumns = false;
            this.customerDGV.AllowUserToResizeRows = false;
            this.customerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.customerDGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.customerDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.customerDGV.Location = new System.Drawing.Point(504, 188);
            this.customerDGV.Name = "customerDGV";
            this.customerDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.customerDGV.RowHeadersWidth = 51;
            this.customerDGV.RowTemplate.Height = 30;
            this.customerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDGV.Size = new System.Drawing.Size(705, 548);
            this.customerDGV.TabIndex = 50;
            this.customerDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDGV_CellContentClick);
            // 
            // btn_customerr_back
            // 
            this.btn_customerr_back.BackColor = System.Drawing.Color.DarkGray;
            this.btn_customerr_back.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customerr_back.Location = new System.Drawing.Point(169, 631);
            this.btn_customerr_back.Name = "btn_customerr_back";
            this.btn_customerr_back.Size = new System.Drawing.Size(127, 54);
            this.btn_customerr_back.TabIndex = 39;
            this.btn_customerr_back.Text = "Back";
            this.btn_customerr_back.UseVisualStyleBackColor = false;
            this.btn_customerr_back.Click += new System.EventHandler(this.btn_customerr_back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(783, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 27);
            this.label3.TabIndex = 49;
            this.label3.Text = "Customer List";
            // 
            // btn_customer_edit
            // 
            this.btn_customer_edit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_customer_edit.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer_edit.Location = new System.Drawing.Point(169, 551);
            this.btn_customer_edit.Name = "btn_customer_edit";
            this.btn_customer_edit.Size = new System.Drawing.Size(127, 54);
            this.btn_customer_edit.TabIndex = 48;
            this.btn_customer_edit.Text = "Edit";
            this.btn_customer_edit.UseVisualStyleBackColor = false;
            this.btn_customer_edit.Click += new System.EventHandler(this.btn_customer_edit_Click);
            // 
            // btb_customer_delete
            // 
            this.btb_customer_delete.BackColor = System.Drawing.Color.IndianRed;
            this.btb_customer_delete.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btb_customer_delete.Location = new System.Drawing.Point(311, 551);
            this.btb_customer_delete.Name = "btb_customer_delete";
            this.btb_customer_delete.Size = new System.Drawing.Size(127, 54);
            this.btb_customer_delete.TabIndex = 47;
            this.btb_customer_delete.Text = "Delete";
            this.btb_customer_delete.UseVisualStyleBackColor = false;
            this.btb_customer_delete.Click += new System.EventHandler(this.btb_customer_delete_Click);
            // 
            // btn_customer_add
            // 
            this.btn_customer_add.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_customer_add.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer_add.Location = new System.Drawing.Point(27, 551);
            this.btn_customer_add.Name = "btn_customer_add";
            this.btn_customer_add.Size = new System.Drawing.Size(127, 54);
            this.btn_customer_add.TabIndex = 46;
            this.btn_customer_add.Text = "Add";
            this.btn_customer_add.UseVisualStyleBackColor = false;
            this.btn_customer_add.Click += new System.EventHandler(this.btn_customer_add_Click);
            // 
            // custID
            // 
            this.custID.BackColor = System.Drawing.SystemColors.Control;
            this.custID.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custID.Location = new System.Drawing.Point(169, 148);
            this.custID.Multiline = true;
            this.custID.Name = "custID";
            this.custID.Size = new System.Drawing.Size(235, 40);
            this.custID.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 27);
            this.label2.TabIndex = 44;
            this.label2.Text = "ID";
            // 
            // custAddress
            // 
            this.custAddress.BackColor = System.Drawing.SystemColors.Control;
            this.custAddress.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custAddress.Location = new System.Drawing.Point(171, 300);
            this.custAddress.Multiline = true;
            this.custAddress.Name = "custAddress";
            this.custAddress.Size = new System.Drawing.Size(235, 40);
            this.custAddress.TabIndex = 43;
            // 
            // custName
            // 
            this.custName.BackColor = System.Drawing.SystemColors.Control;
            this.custName.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custName.Location = new System.Drawing.Point(171, 224);
            this.custName.Multiline = true;
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(235, 40);
            this.custName.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(29, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 27);
            this.label7.TabIndex = 41;
            this.label7.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(29, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 27);
            this.label6.TabIndex = 40;
            this.label6.Text = "Name";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 796);
            this.Controls.Add(this.custPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customerDGV);
            this.Controls.Add(this.btn_customerr_back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_customer_edit);
            this.Controls.Add(this.btb_customer_delete);
            this.Controls.Add(this.btn_customer_add);
            this.Controls.Add(this.custID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.custAddress);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAR RENTAL";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox custPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView customerDGV;
        private System.Windows.Forms.Button btn_customerr_back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_customer_edit;
        private System.Windows.Forms.Button btb_customer_delete;
        private System.Windows.Forms.Button btn_customer_add;
        private System.Windows.Forms.TextBox custID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox custAddress;
        private System.Windows.Forms.TextBox custName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}