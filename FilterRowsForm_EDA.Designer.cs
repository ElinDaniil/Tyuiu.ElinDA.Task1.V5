
namespace LaboratoryWorkBasicDataBase
{
    partial class FilterRowsForm_EDA
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
            this.InputCostTextBox_EDA = new System.Windows.Forms.TextBox();
            this.InputStorageTextBox_EDA = new System.Windows.Forms.TextBox();
            this.ButtonDeleteRows_EDA = new System.Windows.Forms.Button();
            this.labelcost_EDA = new System.Windows.Forms.Label();
            this.labelamount_EDA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputCostTextBox_EDA
            // 
            this.InputCostTextBox_EDA.Location = new System.Drawing.Point(16, 32);
            this.InputCostTextBox_EDA.Name = "InputCostTextBox_EDA";
            this.InputCostTextBox_EDA.Size = new System.Drawing.Size(100, 26);
            this.InputCostTextBox_EDA.TabIndex = 0;
            // 
            // InputStorageTextBox_EDA
            // 
            this.InputStorageTextBox_EDA.Location = new System.Drawing.Point(278, 32);
            this.InputStorageTextBox_EDA.Name = "InputStorageTextBox_EDA";
            this.InputStorageTextBox_EDA.Size = new System.Drawing.Size(100, 26);
            this.InputStorageTextBox_EDA.TabIndex = 1;
            // 
            // ButtonDeleteRows_EDA
            // 
            this.ButtonDeleteRows_EDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonDeleteRows_EDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDeleteRows_EDA.Location = new System.Drawing.Point(122, 32);
            this.ButtonDeleteRows_EDA.Name = "ButtonDeleteRows_EDA";
            this.ButtonDeleteRows_EDA.Size = new System.Drawing.Size(150, 44);
            this.ButtonDeleteRows_EDA.TabIndex = 4;
            this.ButtonDeleteRows_EDA.Text = "Отфильтровать";
            this.ButtonDeleteRows_EDA.UseVisualStyleBackColor = false;
            this.ButtonDeleteRows_EDA.Click += new System.EventHandler(this.ButtonDeleteRows_EDA_Click);
            // 
            // labelcost_EDA
            // 
            this.labelcost_EDA.AutoSize = true;
            this.labelcost_EDA.Location = new System.Drawing.Point(12, 9);
            this.labelcost_EDA.Name = "labelcost_EDA";
            this.labelcost_EDA.Size = new System.Drawing.Size(48, 20);
            this.labelcost_EDA.TabIndex = 5;
            this.labelcost_EDA.Text = "Цена";
            this.labelcost_EDA.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelamount_EDA
            // 
            this.labelamount_EDA.AutoSize = true;
            this.labelamount_EDA.Location = new System.Drawing.Point(274, 9);
            this.labelamount_EDA.Name = "labelamount_EDA";
            this.labelamount_EDA.Size = new System.Drawing.Size(100, 20);
            this.labelamount_EDA.TabIndex = 6;
            this.labelamount_EDA.Text = "Количество";
            // 
            // FilterRowsForm_EDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelamount_EDA);
            this.Controls.Add(this.labelcost_EDA);
            this.Controls.Add(this.ButtonDeleteRows_EDA);
            this.Controls.Add(this.InputStorageTextBox_EDA);
            this.Controls.Add(this.InputCostTextBox_EDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FilterRowsForm_EDA";
            this.Text = "Форма фильтрации";
            this.Load += new System.EventHandler(this.FilterRowsForm_EDA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputCostTextBox_EDA;
        private System.Windows.Forms.TextBox InputStorageTextBox_EDA;
        private System.Windows.Forms.Button ButtonDeleteRows_EDA;
        private System.Windows.Forms.Label labelcost_EDA;
        private System.Windows.Forms.Label labelamount_EDA;
    }
}