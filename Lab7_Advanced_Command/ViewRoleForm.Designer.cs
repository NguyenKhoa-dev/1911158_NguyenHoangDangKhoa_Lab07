namespace Lab7_Advanced_Command
{
    partial class ViewRoleForm
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
            this.lvRole = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UpdateRoleAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddNewRole = new System.Windows.Forms.Button();
            this.btnUpdateRole = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtRoleID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRolePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ReloadViewRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvRole
            // 
            this.lvRole.CheckBoxes = true;
            this.lvRole.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvRole.ContextMenuStrip = this.contextMenuStrip1;
            this.lvRole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvRole.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvRole.FullRowSelect = true;
            this.lvRole.GridLines = true;
            this.lvRole.Location = new System.Drawing.Point(0, 152);
            this.lvRole.MultiSelect = false;
            this.lvRole.Name = "lvRole";
            this.lvRole.Size = new System.Drawing.Size(684, 307);
            this.lvRole.TabIndex = 1;
            this.lvRole.UseCompatibleStateImageBehavior = false;
            this.lvRole.View = System.Windows.Forms.View.Details;
            this.lvRole.SelectedIndexChanged += new System.EventHandler(this.lvRole_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã số";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên vai trò";
            this.columnHeader2.Width = 255;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đường dẫn";
            this.columnHeader3.Width = 166;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ghi chú";
            this.columnHeader4.Width = 161;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateRoleAccountToolStripMenuItem,
            this.ReloadViewRoleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(200, 70);
            // 
            // UpdateRoleAccountToolStripMenuItem
            // 
            this.UpdateRoleAccountToolStripMenuItem.Name = "UpdateRoleAccountToolStripMenuItem";
            this.UpdateRoleAccountToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.UpdateRoleAccountToolStripMenuItem.Text = "Cập nhật vai trò tài khoản";
            this.UpdateRoleAccountToolStripMenuItem.Click += new System.EventHandler(this.UpdateRoleAccountToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên tài khoản:";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountName.Location = new System.Drawing.Point(109, 7);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.ReadOnly = true;
            this.txtAccountName.Size = new System.Drawing.Size(231, 21);
            this.txtAccountName.TabIndex = 9;
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(426, 7);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(246, 21);
            this.txtFullName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Họ tên:";
            // 
            // btnAddNewRole
            // 
            this.btnAddNewRole.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewRole.Location = new System.Drawing.Point(426, 115);
            this.btnAddNewRole.Name = "btnAddNewRole";
            this.btnAddNewRole.Size = new System.Drawing.Size(78, 31);
            this.btnAddNewRole.TabIndex = 16;
            this.btnAddNewRole.Text = "Thêm mới";
            this.btnAddNewRole.UseVisualStyleBackColor = true;
            this.btnAddNewRole.Click += new System.EventHandler(this.btnAddNewRole_Click);
            // 
            // btnUpdateRole
            // 
            this.btnUpdateRole.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRole.Location = new System.Drawing.Point(510, 115);
            this.btnUpdateRole.Name = "btnUpdateRole";
            this.btnUpdateRole.Size = new System.Drawing.Size(78, 31);
            this.btnUpdateRole.TabIndex = 17;
            this.btnUpdateRole.Text = "Cập nhật";
            this.btnUpdateRole.UseVisualStyleBackColor = true;
            this.btnUpdateRole.Click += new System.EventHandler(this.btnUpdateRole_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(594, 115);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 31);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtRoleID
            // 
            this.txtRoleID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoleID.Location = new System.Drawing.Point(109, 34);
            this.txtRoleID.Name = "txtRoleID";
            this.txtRoleID.ReadOnly = true;
            this.txtRoleID.Size = new System.Drawing.Size(231, 21);
            this.txtRoleID.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mã vai trò:";
            // 
            // txtRoleName
            // 
            this.txtRoleName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoleName.Location = new System.Drawing.Point(109, 61);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(231, 21);
            this.txtRoleName.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tên vai trò:";
            // 
            // txtRolePath
            // 
            this.txtRolePath.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRolePath.Location = new System.Drawing.Point(109, 88);
            this.txtRolePath.Name = "txtRolePath";
            this.txtRolePath.Size = new System.Drawing.Size(231, 21);
            this.txtRolePath.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Đường dẫn:";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtNotes.Location = new System.Drawing.Point(426, 34);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(246, 75);
            this.rtxtNotes.TabIndex = 25;
            this.rtxtNotes.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(364, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Chi chú:";
            // 
            // ReloadViewRoleToolStripMenuItem
            // 
            this.ReloadViewRoleToolStripMenuItem.Name = "ReloadViewRoleToolStripMenuItem";
            this.ReloadViewRoleToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.ReloadViewRoleToolStripMenuItem.Text = "Tải lại danh sách vai trò";
            this.ReloadViewRoleToolStripMenuItem.Click += new System.EventHandler(this.ReloadViewRoleToolStripMenuItem_Click);
            // 
            // ViewRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 459);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.txtRolePath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRoleName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRoleID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdateRole);
            this.Controls.Add(this.btnAddNewRole);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvRole);
            this.Name = "ViewRoleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách các vai trò";
            this.Load += new System.EventHandler(this.ViewRoleForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvRole;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNewRole;
        private System.Windows.Forms.Button btnUpdateRole;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtRoleID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRolePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UpdateRoleAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReloadViewRoleToolStripMenuItem;
    }
}