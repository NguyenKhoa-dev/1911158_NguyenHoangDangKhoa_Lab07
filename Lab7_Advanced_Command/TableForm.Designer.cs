namespace Lab7_Advanced_Command
{
    partial class TableForm
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
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTableCapacity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTableStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTableID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvTable = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewListBillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewSumaryBillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(489, 66);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(96, 29);
            this.btnCapNhat.TabIndex = 22;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(388, 66);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 29);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTableCapacity
            // 
            this.txtTableCapacity.Location = new System.Drawing.Point(388, 40);
            this.txtTableCapacity.Name = "txtTableCapacity";
            this.txtTableCapacity.Size = new System.Drawing.Size(197, 20);
            this.txtTableCapacity.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Số chỗ:";
            // 
            // txtTableStatus
            // 
            this.txtTableStatus.Location = new System.Drawing.Point(388, 14);
            this.txtTableStatus.Name = "txtTableStatus";
            this.txtTableStatus.ReadOnly = true;
            this.txtTableStatus.Size = new System.Drawing.Size(197, 20);
            this.txtTableStatus.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Trạng thái:";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(88, 40);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(196, 20);
            this.txtTableName.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên bàn:";
            // 
            // txtTableID
            // 
            this.txtTableID.Location = new System.Drawing.Point(88, 14);
            this.txtTableID.Name = "txtTableID";
            this.txtTableID.Size = new System.Drawing.Size(196, 20);
            this.txtTableID.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã bàn:";
            // 
            // lvTable
            // 
            this.lvTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvTable.ContextMenuStrip = this.contextMenuStrip1;
            this.lvTable.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTable.FullRowSelect = true;
            this.lvTable.GridLines = true;
            this.lvTable.Location = new System.Drawing.Point(12, 101);
            this.lvTable.Name = "lvTable";
            this.lvTable.Size = new System.Drawing.Size(573, 369);
            this.lvTable.TabIndex = 12;
            this.lvTable.UseCompatibleStateImageBehavior = false;
            this.lvTable.View = System.Windows.Forms.View.Details;
            this.lvTable.SelectedIndexChanged += new System.EventHandler(this.lvTable_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã bàn";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên bàn";
            this.columnHeader2.Width = 211;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Trạng thái";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số chỗ";
            this.columnHeader4.Width = 86;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteTableToolStripMenuItem,
            this.ViewListBillsToolStripMenuItem,
            this.ViewSumaryBillsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(188, 70);
            // 
            // DeleteTableToolStripMenuItem
            // 
            this.DeleteTableToolStripMenuItem.Name = "DeleteTableToolStripMenuItem";
            this.DeleteTableToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.DeleteTableToolStripMenuItem.Text = "Xóa bàn";
            this.DeleteTableToolStripMenuItem.Click += new System.EventHandler(this.DeleteTableToolStripMenuItem_Click);
            // 
            // ViewListBillsToolStripMenuItem
            // 
            this.ViewListBillsToolStripMenuItem.Name = "ViewListBillsToolStripMenuItem";
            this.ViewListBillsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ViewListBillsToolStripMenuItem.Text = "Xem danh mục hóa đơn";
            // 
            // ViewSumaryBillsToolStripMenuItem
            // 
            this.ViewSumaryBillsToolStripMenuItem.Name = "ViewSumaryBillsToolStripMenuItem";
            this.ViewSumaryBillsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ViewSumaryBillsToolStripMenuItem.Text = "Xem nhật ký hóa đơn";
            this.ViewSumaryBillsToolStripMenuItem.Click += new System.EventHandler(this.ViewSumaryBillsToolStripMenuItem_Click);
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 482);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTableCapacity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTableStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTableID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvTable);
            this.Name = "TableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableForm";
            this.Load += new System.EventHandler(this.TableForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTableCapacity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTableStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTableID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DeleteTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewListBillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewSumaryBillsToolStripMenuItem;
    }
}