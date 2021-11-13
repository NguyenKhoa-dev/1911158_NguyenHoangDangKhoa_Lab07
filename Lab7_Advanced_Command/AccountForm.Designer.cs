namespace Lab7_Advanced_Command
{
    partial class AccountForm
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
            this.lvAccount = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ViewRoleNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewDiaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvAccount
            // 
            this.lvAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAccount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvAccount.ContextMenuStrip = this.contextMenuStrip1;
            this.lvAccount.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAccount.FullRowSelect = true;
            this.lvAccount.GridLines = true;
            this.lvAccount.Location = new System.Drawing.Point(0, 25);
            this.lvAccount.Name = "lvAccount";
            this.lvAccount.Size = new System.Drawing.Size(669, 387);
            this.lvAccount.TabIndex = 0;
            this.lvAccount.UseCompatibleStateImageBehavior = false;
            this.lvAccount.View = System.Windows.Forms.View.Details;
            this.lvAccount.DoubleClick += new System.EventHandler(this.lvAccount_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên tài khoản";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ và tên";
            this.columnHeader2.Width = 225;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            this.columnHeader3.Width = 161;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tell";
            this.columnHeader4.Width = 140;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewRoleNameToolStripMenuItem,
            this.ViewDiaryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(200, 48);
            // 
            // ViewRoleNameToolStripMenuItem
            // 
            this.ViewRoleNameToolStripMenuItem.Name = "ViewRoleNameToolStripMenuItem";
            this.ViewRoleNameToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.ViewRoleNameToolStripMenuItem.Text = "Xem danh sách các vai trò";
            this.ViewRoleNameToolStripMenuItem.Click += new System.EventHandler(this.ViewRoleNameToolStripMenuItem_Click);
            // 
            // ViewDiaryToolStripMenuItem
            // 
            this.ViewDiaryToolStripMenuItem.Name = "ViewDiaryToolStripMenuItem";
            this.ViewDiaryToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.ViewDiaryToolStripMenuItem.Text = "Xem nhật ký hoạt động";
            this.ViewDiaryToolStripMenuItem.Click += new System.EventHandler(this.ViewDiaryToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddAccountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(669, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddAccountToolStripMenuItem
            // 
            this.AddAccountToolStripMenuItem.Name = "AddAccountToolStripMenuItem";
            this.AddAccountToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.AddAccountToolStripMenuItem.Text = "Thêm tài khoản";
            this.AddAccountToolStripMenuItem.Click += new System.EventHandler(this.AddAccountToolStripMenuItem_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 412);
            this.Controls.Add(this.lvAccount);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountForm";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvAccount;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddAccountToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ViewRoleNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewDiaryToolStripMenuItem;
    }
}