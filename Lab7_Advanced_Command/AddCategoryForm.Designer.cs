namespace Lab7_Advanced_Command
{
    partial class AddCategoryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameCat = new System.Windows.Forms.TextBox();
            this.rdTypeFood = new System.Windows.Forms.RadioButton();
            this.rdTypeDrink = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhóm món ăn:";
            // 
            // txtNameCat
            // 
            this.txtNameCat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCat.Location = new System.Drawing.Point(135, 9);
            this.txtNameCat.Name = "txtNameCat";
            this.txtNameCat.Size = new System.Drawing.Size(206, 21);
            this.txtNameCat.TabIndex = 1;
            // 
            // rdTypeFood
            // 
            this.rdTypeFood.AutoSize = true;
            this.rdTypeFood.Checked = true;
            this.rdTypeFood.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTypeFood.Location = new System.Drawing.Point(135, 41);
            this.rdTypeFood.Name = "rdTypeFood";
            this.rdTypeFood.Size = new System.Drawing.Size(62, 21);
            this.rdTypeFood.TabIndex = 2;
            this.rdTypeFood.TabStop = true;
            this.rdTypeFood.Text = "Đồ ăn";
            this.rdTypeFood.UseVisualStyleBackColor = true;
            // 
            // rdTypeDrink
            // 
            this.rdTypeDrink.AutoSize = true;
            this.rdTypeDrink.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTypeDrink.Location = new System.Drawing.Point(265, 41);
            this.rdTypeDrink.Name = "rdTypeDrink";
            this.rdTypeDrink.Size = new System.Drawing.Size(76, 21);
            this.rdTypeDrink.TabIndex = 3;
            this.rdTypeDrink.TabStop = true;
            this.rdTypeDrink.Text = "Đồ uống";
            this.rdTypeDrink.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Loại:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(135, 75);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 32);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 119);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdTypeDrink);
            this.Controls.Add(this.rdTypeFood);
            this.Controls.Add(this.txtNameCat);
            this.Controls.Add(this.label1);
            this.Name = "AddCategoryForm";
            this.Text = "Thêm nhóm món ăn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameCat;
        private System.Windows.Forms.RadioButton rdTypeFood;
        private System.Windows.Forms.RadioButton rdTypeDrink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
    }
}