
namespace LaboratoryWorkBasicDataBase
{
    partial class SortForm_EDA
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
            this.ButtonSort_EDA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonStorageAmount = new System.Windows.Forms.CheckBox();
            this.radioButtonCostPerOrder = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ButtonSort_EDA
            // 
            this.ButtonSort_EDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonSort_EDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSort_EDA.Location = new System.Drawing.Point(148, 136);
            this.ButtonSort_EDA.Name = "ButtonSort_EDA";
            this.ButtonSort_EDA.Size = new System.Drawing.Size(232, 41);
            this.ButtonSort_EDA.TabIndex = 0;
            this.ButtonSort_EDA.Text = "Отсортировать по цене";
            this.ButtonSort_EDA.UseVisualStyleBackColor = false;
            this.ButtonSort_EDA.Click += new System.EventHandler(this.ButtonSort_EDA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите способ, которым список будет сортироваться";
            // 
            // radioButtonStorageAmount
            // 
            this.radioButtonStorageAmount.AutoSize = true;
            this.radioButtonStorageAmount.Location = new System.Drawing.Point(70, 106);
            this.radioButtonStorageAmount.Name = "radioButtonStorageAmount";
            this.radioButtonStorageAmount.Size = new System.Drawing.Size(147, 24);
            this.radioButtonStorageAmount.TabIndex = 3;
            this.radioButtonStorageAmount.Text = "По количеству";
            this.radioButtonStorageAmount.UseVisualStyleBackColor = true;
            // 
            // radioButtonCostPerOrder
            // 
            this.radioButtonCostPerOrder.AutoSize = true;
            this.radioButtonCostPerOrder.Location = new System.Drawing.Point(345, 106);
            this.radioButtonCostPerOrder.Name = "radioButtonCostPerOrder";
            this.radioButtonCostPerOrder.Size = new System.Drawing.Size(96, 24);
            this.radioButtonCostPerOrder.TabIndex = 4;
            this.radioButtonCostPerOrder.Text = "По цене";
            this.radioButtonCostPerOrder.UseVisualStyleBackColor = true;
            // 
            // SortForm_EDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(552, 189);
            this.Controls.Add(this.radioButtonCostPerOrder);
            this.Controls.Add(this.radioButtonStorageAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSort_EDA);
            this.Name = "SortForm_EDA";
            this.Text = "SortForm_EDA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSort_EDA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox radioButtonStorageAmount;
        private System.Windows.Forms.CheckBox radioButtonCostPerOrder;
    }
}