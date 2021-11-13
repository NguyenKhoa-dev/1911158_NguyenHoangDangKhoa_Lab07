namespace Lab7_Advanced_Command
{
    partial class OrdersForm
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tsSummary = new System.Windows.Forms.ToolStrip();
            this.tsrSummary = new System.Windows.Forms.ToolStripLabel();
            this.dgvBills = new System.Windows.Forms.DataGridView();
            this.tsSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(95, 12);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(132, 21);
            this.dtpDate.TabIndex = 0;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn ngày:";
            // 
            // tsSummary
            // 
            this.tsSummary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsSummary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrSummary});
            this.tsSummary.Location = new System.Drawing.Point(0, 468);
            this.tsSummary.Name = "tsSummary";
            this.tsSummary.Size = new System.Drawing.Size(967, 25);
            this.tsSummary.TabIndex = 2;
            this.tsSummary.Text = "Tổng doanh thu trong ngày là:";
            // 
            // tsrSummary
            // 
            this.tsrSummary.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsrSummary.Name = "tsrSummary";
            this.tsrSummary.Size = new System.Drawing.Size(182, 22);
            this.tsrSummary.Text = "Tổng doanh thu trong ngày là:";
            // 
            // dgvBills
            // 
            this.dgvBills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBills.Location = new System.Drawing.Point(12, 40);
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.Size = new System.Drawing.Size(943, 425);
            this.dgvBills.TabIndex = 3;
            this.dgvBills.DoubleClick += new System.EventHandler(this.dgvBills_DoubleClick);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 493);
            this.Controls.Add(this.dgvBills);
            this.Controls.Add(this.tsSummary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrdersForm";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.tsSummary.ResumeLayout(false);
            this.tsSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip tsSummary;
        private System.Windows.Forms.ToolStripLabel tsrSummary;
        private System.Windows.Forms.DataGridView dgvBills;
    }
}