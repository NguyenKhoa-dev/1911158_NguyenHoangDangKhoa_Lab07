namespace Lab7_Restaurant_Bonus
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fpnlTable = new System.Windows.Forms.FlowLayoutPanel();
            this.TableCapacityToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.cbbFood = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddFoodBill = new System.Windows.Forms.Button();
            this.lvFoodTable = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.FoodCancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nmrQuantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSummary = new System.Windows.Forms.Button();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdminToolStripMenuItem,
            this.AccountInfoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(904, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AdminToolStripMenuItem
            // 
            this.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem";
            this.AdminToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.AdminToolStripMenuItem.Text = "Admin";
            // 
            // AccountInfoToolStripMenuItem
            // 
            this.AccountInfoToolStripMenuItem.Name = "AccountInfoToolStripMenuItem";
            this.AccountInfoToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.AccountInfoToolStripMenuItem.Text = "Thông tin tài khoản";
            this.AccountInfoToolStripMenuItem.Click += new System.EventHandler(this.AccountInfoToolStripMenuItem_Click);
            // 
            // fpnlTable
            // 
            this.fpnlTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fpnlTable.AutoScroll = true;
            this.fpnlTable.BackColor = System.Drawing.SystemColors.Control;
            this.fpnlTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpnlTable.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpnlTable.Location = new System.Drawing.Point(12, 27);
            this.fpnlTable.Name = "fpnlTable";
            this.fpnlTable.Size = new System.Drawing.Size(388, 466);
            this.fpnlTable.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhóm món ăn";
            // 
            // cbbCategory
            // 
            this.cbbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategory.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(503, 36);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(227, 23);
            this.cbbCategory.TabIndex = 4;
            this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
            // 
            // cbbFood
            // 
            this.cbbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFood.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFood.FormattingEnabled = true;
            this.cbbFood.Location = new System.Drawing.Point(503, 65);
            this.cbbFood.Name = "cbbFood";
            this.cbbFood.Size = new System.Drawing.Size(227, 23);
            this.cbbFood.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên món ăn";
            // 
            // btnAddFoodBill
            // 
            this.btnAddFoodBill.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFoodBill.Location = new System.Drawing.Point(801, 36);
            this.btnAddFoodBill.Name = "btnAddFoodBill";
            this.btnAddFoodBill.Size = new System.Drawing.Size(94, 52);
            this.btnAddFoodBill.TabIndex = 8;
            this.btnAddFoodBill.Text = "Thêm";
            this.btnAddFoodBill.UseVisualStyleBackColor = true;
            this.btnAddFoodBill.Click += new System.EventHandler(this.btnAddFoodBill_Click);
            // 
            // lvFoodTable
            // 
            this.lvFoodTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvFoodTable.ContextMenuStrip = this.contextMenuStrip1;
            this.lvFoodTable.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvFoodTable.FullRowSelect = true;
            this.lvFoodTable.GridLines = true;
            this.lvFoodTable.Location = new System.Drawing.Point(406, 94);
            this.lvFoodTable.Name = "lvFoodTable";
            this.lvFoodTable.Size = new System.Drawing.Size(489, 334);
            this.lvFoodTable.TabIndex = 9;
            this.lvFoodTable.UseCompatibleStateImageBehavior = false;
            this.lvFoodTable.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món ăn";
            this.columnHeader1.Width = 184;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 78;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 122;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FoodCancelToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 26);
            // 
            // FoodCancelToolStripMenuItem
            // 
            this.FoodCancelToolStripMenuItem.Name = "FoodCancelToolStripMenuItem";
            this.FoodCancelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.FoodCancelToolStripMenuItem.Text = "Hủy món";
            this.FoodCancelToolStripMenuItem.Click += new System.EventHandler(this.FoodCancelToolStripMenuItem_Click);
            // 
            // nmrQuantity
            // 
            this.nmrQuantity.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrQuantity.Location = new System.Drawing.Point(736, 67);
            this.nmrQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrQuantity.Name = "nmrQuantity";
            this.nmrQuantity.Size = new System.Drawing.Size(59, 21);
            this.nmrQuantity.TabIndex = 10;
            this.nmrQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(406, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tổng tiền thanh toán";
            // 
            // btnSummary
            // 
            this.btnSummary.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummary.Location = new System.Drawing.Point(801, 437);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(94, 56);
            this.btnSummary.TabIndex = 13;
            this.btnSummary.Text = "Thanh toán";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(540, 437);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(101, 25);
            this.txtDiscount.TabIndex = 15;
            this.txtDiscount.Text = "0.05";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(463, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Chiết khấu";
            // 
            // txtTax
            // 
            this.txtTax.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(691, 437);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(104, 25);
            this.txtTax.TabIndex = 17;
            this.txtTax.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(647, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Thuế";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(540, 468);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(255, 25);
            this.txtAmount.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 500);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmrQuantity);
            this.Controls.Add(this.lvFoodTable);
            this.Controls.Add(this.btnAddFoodBill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbFood);
            this.Controls.Add(this.cbbCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fpnlTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý nhà hàng";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccountInfoToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel fpnlTable;
        private System.Windows.Forms.ToolTip TableCapacityToolTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.ComboBox cbbFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddFoodBill;
        private System.Windows.Forms.ListView lvFoodTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.NumericUpDown nmrQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FoodCancelToolStripMenuItem;
    }
}

