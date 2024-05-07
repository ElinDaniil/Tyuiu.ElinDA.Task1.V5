
namespace LaboratoryWorkBasicDataBase
{
    partial class SearchForm_EDA
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
            this.ButtonSearch_EDA = new System.Windows.Forms.Button();
            this.BusinessDataView_EDA = new System.Windows.Forms.DataGridView();
            this.OrderCodeTextBox_EDA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BusinessDataView_EDA)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSearch_EDA
            // 
            this.ButtonSearch_EDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonSearch_EDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSearch_EDA.Location = new System.Drawing.Point(313, 37);
            this.ButtonSearch_EDA.Name = "ButtonSearch_EDA";
            this.ButtonSearch_EDA.Size = new System.Drawing.Size(136, 57);
            this.ButtonSearch_EDA.TabIndex = 0;
            this.ButtonSearch_EDA.Text = "Найти доставщиков";
            this.ButtonSearch_EDA.UseVisualStyleBackColor = false;
            this.ButtonSearch_EDA.Click += new System.EventHandler(this.ButtonSearch_EDA_Click);
            // 
            // BusinessDataView_EDA
            // 
            this.BusinessDataView_EDA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BusinessDataView_EDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BusinessDataView_EDA.Location = new System.Drawing.Point(12, 151);
            this.BusinessDataView_EDA.Name = "BusinessDataView_EDA";
            this.BusinessDataView_EDA.RowHeadersWidth = 62;
            this.BusinessDataView_EDA.RowTemplate.Height = 28;
            this.BusinessDataView_EDA.Size = new System.Drawing.Size(776, 287);
            this.BusinessDataView_EDA.TabIndex = 1;
            // 
            // OrderCodeTextBox_EDA
            // 
            this.OrderCodeTextBox_EDA.Location = new System.Drawing.Point(293, 109);
            this.OrderCodeTextBox_EDA.Name = "OrderCodeTextBox_EDA";
            this.OrderCodeTextBox_EDA.Size = new System.Drawing.Size(174, 26);
            this.OrderCodeTextBox_EDA.TabIndex = 2;
            // 
            // SearchForm_EDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrderCodeTextBox_EDA);
            this.Controls.Add(this.BusinessDataView_EDA);
            this.Controls.Add(this.ButtonSearch_EDA);
            this.Name = "SearchForm_EDA";
            this.Text = "Форма поиска";
            this.Load += new System.EventHandler(this.SearchForm_EDA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BusinessDataView_EDA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSearch_EDA;
        private System.Windows.Forms.DataGridView BusinessDataView_EDA;
        private System.Windows.Forms.TextBox OrderCodeTextBox_EDA;
    }
}