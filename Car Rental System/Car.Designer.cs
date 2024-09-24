namespace Car_Rental_System
{
    partial class Car
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Car));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CarDGV = new System.Windows.Forms.DataGridView();
            this.btn_car_back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_car_edit = new System.Windows.Forms.Button();
            this.btb_car_delete = new System.Windows.Forms.Button();
            this.btn_car_add = new System.Windows.Forms.Button();
            this.carRegNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.carModel = new System.Windows.Forms.TextBox();
            this.carBrand = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.carPrize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.availableCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.ComboBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarDGV)).BeginInit();
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
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Cars";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CarDGV
            // 
            this.CarDGV.AllowUserToAddRows = false;
            this.CarDGV.AllowUserToDeleteRows = false;
            this.CarDGV.AllowUserToResizeColumns = false;
            this.CarDGV.AllowUserToResizeRows = false;
            this.CarDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CarDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.CarDGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CarDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.CarDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.CarDGV.Location = new System.Drawing.Point(509, 236);
            this.CarDGV.Name = "CarDGV";
            this.CarDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CarDGV.RowHeadersWidth = 51;
            this.CarDGV.RowTemplate.Height = 30;
            this.CarDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CarDGV.Size = new System.Drawing.Size(705, 512);
            this.CarDGV.TabIndex = 34;
            this.CarDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarDGV_CellContentClick);
            // 
            // btn_car_back
            // 
            this.btn_car_back.BackColor = System.Drawing.Color.DarkGray;
            this.btn_car_back.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_car_back.Location = new System.Drawing.Point(174, 643);
            this.btn_car_back.Name = "btn_car_back";
            this.btn_car_back.Size = new System.Drawing.Size(127, 54);
            this.btn_car_back.TabIndex = 22;
            this.btn_car_back.Text = "Back";
            this.btn_car_back.UseVisualStyleBackColor = false;
            this.btn_car_back.Click += new System.EventHandler(this.btn_car_back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(504, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 27);
            this.label3.TabIndex = 33;
            this.label3.Text = "Car List";
            // 
            // btn_car_edit
            // 
            this.btn_car_edit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_car_edit.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_car_edit.Location = new System.Drawing.Point(174, 563);
            this.btn_car_edit.Name = "btn_car_edit";
            this.btn_car_edit.Size = new System.Drawing.Size(127, 54);
            this.btn_car_edit.TabIndex = 32;
            this.btn_car_edit.Text = "Edit";
            this.btn_car_edit.UseVisualStyleBackColor = false;
            this.btn_car_edit.Click += new System.EventHandler(this.btn_car_edit_Click);
            // 
            // btb_car_delete
            // 
            this.btb_car_delete.BackColor = System.Drawing.Color.IndianRed;
            this.btb_car_delete.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btb_car_delete.Location = new System.Drawing.Point(316, 563);
            this.btb_car_delete.Name = "btb_car_delete";
            this.btb_car_delete.Size = new System.Drawing.Size(127, 54);
            this.btb_car_delete.TabIndex = 31;
            this.btb_car_delete.Text = "Delete";
            this.btb_car_delete.UseVisualStyleBackColor = false;
            this.btb_car_delete.Click += new System.EventHandler(this.btb_car_delete_Click);
            // 
            // btn_car_add
            // 
            this.btn_car_add.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_car_add.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_car_add.Location = new System.Drawing.Point(32, 563);
            this.btn_car_add.Name = "btn_car_add";
            this.btn_car_add.Size = new System.Drawing.Size(127, 54);
            this.btn_car_add.TabIndex = 30;
            this.btn_car_add.Text = "Add";
            this.btn_car_add.UseVisualStyleBackColor = false;
            this.btn_car_add.Click += new System.EventHandler(this.btn_car_add_Click);
            // 
            // carRegNo
            // 
            this.carRegNo.BackColor = System.Drawing.SystemColors.Control;
            this.carRegNo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carRegNo.Location = new System.Drawing.Point(174, 160);
            this.carRegNo.Multiline = true;
            this.carRegNo.Name = "carRegNo";
            this.carRegNo.Size = new System.Drawing.Size(235, 40);
            this.carRegNo.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 27);
            this.label2.TabIndex = 28;
            this.label2.Text = "Register No";
            // 
            // carModel
            // 
            this.carModel.BackColor = System.Drawing.SystemColors.Control;
            this.carModel.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carModel.Location = new System.Drawing.Point(176, 312);
            this.carModel.Multiline = true;
            this.carModel.Name = "carModel";
            this.carModel.Size = new System.Drawing.Size(235, 40);
            this.carModel.TabIndex = 27;
            // 
            // carBrand
            // 
            this.carBrand.BackColor = System.Drawing.SystemColors.Control;
            this.carBrand.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carBrand.Location = new System.Drawing.Point(176, 236);
            this.carBrand.Multiline = true;
            this.carBrand.Name = "carBrand";
            this.carBrand.Size = new System.Drawing.Size(235, 40);
            this.carBrand.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(29, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 27);
            this.label7.TabIndex = 25;
            this.label7.Text = "Model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(29, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 27);
            this.label6.TabIndex = 24;
            this.label6.Text = "Brand";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 768);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1246, 28);
            this.panel2.TabIndex = 23;
            // 
            // carPrize
            // 
            this.carPrize.BackColor = System.Drawing.SystemColors.Control;
            this.carPrize.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carPrize.Location = new System.Drawing.Point(176, 388);
            this.carPrize.Multiline = true;
            this.carPrize.Name = "carPrize";
            this.carPrize.Size = new System.Drawing.Size(235, 40);
            this.carPrize.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(29, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 27);
            this.label4.TabIndex = 35;
            this.label4.Text = "Prize";
            // 
            // availableCB
            // 
            this.availableCB.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableCB.FormattingEnabled = true;
            this.availableCB.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.availableCB.Location = new System.Drawing.Point(174, 464);
            this.availableCB.Name = "availableCB";
            this.availableCB.Size = new System.Drawing.Size(237, 35);
            this.availableCB.TabIndex = 37;
            this.availableCB.SelectedIndexChanged += new System.EventHandler(this.availableCB_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(29, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 27);
            this.label5.TabIndex = 38;
            this.label5.Text = "Available";
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.FormattingEnabled = true;
            this.Search.Items.AddRange(new object[] {
            "Available",
            "Rented"});
            this.Search.Location = new System.Drawing.Point(977, 152);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(237, 35);
            this.Search.TabIndex = 39;
            this.Search.SelectedIndexChanged += new System.EventHandler(this.Search_SelectedIndexChanged);
            this.Search.SelectionChangeCommitted += new System.EventHandler(this.Search_SelectionChangeCommitted);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(850, 152);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(121, 35);
            this.btn_refresh.TabIndex = 40;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1246, 796);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.availableCB);
            this.Controls.Add(this.carPrize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CarDGV);
            this.Controls.Add(this.btn_car_back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_car_edit);
            this.Controls.Add(this.btb_car_delete);
            this.Controls.Add(this.btn_car_add);
            this.Controls.Add(this.carRegNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.carModel);
            this.Controls.Add(this.carBrand);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Car";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAR RENTAL";
            this.Load += new System.EventHandler(this.Car_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CarDGV;
        private System.Windows.Forms.Button btn_car_back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_car_edit;
        private System.Windows.Forms.Button btb_car_delete;
        private System.Windows.Forms.Button btn_car_add;
        private System.Windows.Forms.TextBox carRegNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox carModel;
        private System.Windows.Forms.TextBox carBrand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox carPrize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox availableCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Search;
        private System.Windows.Forms.Button btn_refresh;
    }
}