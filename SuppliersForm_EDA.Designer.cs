
namespace LaboratoryWorkBasicDataBase
{
    partial class SuppliersForm_EDA
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
            this.BusinessDataView_EDA = new System.Windows.Forms.DataGridView();
            this.ButtonDeleteRow_EDA = new System.Windows.Forms.Button();
            this.ButtonAddRow_EDA = new System.Windows.Forms.Button();
            this.ButtonFileSave_EDA = new System.Windows.Forms.Button();
            this.ButtonFileOpen_EDA = new System.Windows.Forms.Button();
            this.ButtonSeekThroughSuppliers_EDA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BusinessDataView_EDA)).BeginInit();
            this.SuspendLayout();
            // 
            // BusinessDataView_EDA
            // 
            this.BusinessDataView_EDA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BusinessDataView_EDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BusinessDataView_EDA.Location = new System.Drawing.Point(12, 89);
            this.BusinessDataView_EDA.Name = "BusinessDataView_EDA";
            this.BusinessDataView_EDA.RowHeadersWidth = 62;
            this.BusinessDataView_EDA.RowTemplate.Height = 28;
            this.BusinessDataView_EDA.Size = new System.Drawing.Size(1009, 372);
            this.BusinessDataView_EDA.TabIndex = 25;
            // 
            // ButtonDeleteRow_EDA
            // 
            this.ButtonDeleteRow_EDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonDeleteRow_EDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDeleteRow_EDA.Location = new System.Drawing.Point(433, 12);
            this.ButtonDeleteRow_EDA.Name = "ButtonDeleteRow_EDA";
            this.ButtonDeleteRow_EDA.Size = new System.Drawing.Size(134, 71);
            this.ButtonDeleteRow_EDA.TabIndex = 17;
            this.ButtonDeleteRow_EDA.Text = "Удалить строку";
            this.ButtonDeleteRow_EDA.UseVisualStyleBackColor = false;
            this.ButtonDeleteRow_EDA.Click += new System.EventHandler(this.ButtonDeleteRow_EDA_Click);
            // 
            // ButtonAddRow_EDA
            // 
            this.ButtonAddRow_EDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonAddRow_EDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAddRow_EDA.Location = new System.Drawing.Point(286, 12);
            this.ButtonAddRow_EDA.Name = "ButtonAddRow_EDA";
            this.ButtonAddRow_EDA.Size = new System.Drawing.Size(141, 71);
            this.ButtonAddRow_EDA.TabIndex = 16;
            this.ButtonAddRow_EDA.Text = "Добавить строку";
            this.ButtonAddRow_EDA.UseVisualStyleBackColor = false;
            this.ButtonAddRow_EDA.Click += new System.EventHandler(this.ButtonAddRow_EDA_Click);
            // 
            // ButtonFileSave_EDA
            // 
            this.ButtonFileSave_EDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonFileSave_EDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonFileSave_EDA.Location = new System.Drawing.Point(140, 12);
            this.ButtonFileSave_EDA.Name = "ButtonFileSave_EDA";
            this.ButtonFileSave_EDA.Size = new System.Drawing.Size(140, 71);
            this.ButtonFileSave_EDA.TabIndex = 14;
            this.ButtonFileSave_EDA.Text = "Сохранить файл";
            this.ButtonFileSave_EDA.UseVisualStyleBackColor = false;
            this.ButtonFileSave_EDA.Click += new System.EventHandler(this.ButtonFileSave_EDA_Click);
            // 
            // ButtonFileOpen_EDA
            // 
            this.ButtonFileOpen_EDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonFileOpen_EDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonFileOpen_EDA.Location = new System.Drawing.Point(12, 12);
            this.ButtonFileOpen_EDA.Name = "ButtonFileOpen_EDA";
            this.ButtonFileOpen_EDA.Size = new System.Drawing.Size(122, 71);
            this.ButtonFileOpen_EDA.TabIndex = 13;
            this.ButtonFileOpen_EDA.Text = "Открыть файл";
            this.ButtonFileOpen_EDA.UseVisualStyleBackColor = false;
            this.ButtonFileOpen_EDA.Click += new System.EventHandler(this.ButtonFileOpen_EDA_Click);
            // 
            // ButtonSeekThroughSuppliers_EDA
            // 
            this.ButtonSeekThroughSuppliers_EDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonSeekThroughSuppliers_EDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSeekThroughSuppliers_EDA.Location = new System.Drawing.Point(573, 12);
            this.ButtonSeekThroughSuppliers_EDA.Name = "ButtonSeekThroughSuppliers_EDA";
            this.ButtonSeekThroughSuppliers_EDA.Size = new System.Drawing.Size(134, 71);
            this.ButtonSeekThroughSuppliers_EDA.TabIndex = 26;
            this.ButtonSeekThroughSuppliers_EDA.Text = "Найти товар по айди";
            this.ButtonSeekThroughSuppliers_EDA.UseVisualStyleBackColor = false;
            this.ButtonSeekThroughSuppliers_EDA.Click += new System.EventHandler(this.ButtonSeekThroughSuppliers_EDA_Click);
            // 
            // SuppliersForm_EDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1038, 517);
            this.Controls.Add(this.ButtonSeekThroughSuppliers_EDA);
            this.Controls.Add(this.BusinessDataView_EDA);
            this.Controls.Add(this.ButtonDeleteRow_EDA);
            this.Controls.Add(this.ButtonAddRow_EDA);
            this.Controls.Add(this.ButtonFileSave_EDA);
            this.Controls.Add(this.ButtonFileOpen_EDA);
            this.Name = "SuppliersForm_EDA";
            this.Text = "Поставщики";
            this.Load += new System.EventHandler(this.SuppliersForm_EDA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BusinessDataView_EDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BusinessDataView_EDA;
        private System.Windows.Forms.Button ButtonDeleteRow_EDA;
        private System.Windows.Forms.Button ButtonAddRow_EDA;
        private System.Windows.Forms.Button ButtonFileSave_EDA;
        private System.Windows.Forms.Button ButtonFileOpen_EDA;
        private System.Windows.Forms.Button ButtonSeekThroughSuppliers_EDA;
    }
}