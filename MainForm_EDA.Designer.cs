
namespace LaboratoryWorkBasicDataBase
{
    partial class MainForm_EDA
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ButtonFileOpen_EDA = new System.Windows.Forms.Button();
            this.ButtonFileSave_EDA = new System.Windows.Forms.Button();
            this.ButtonAddRow_EDA = new System.Windows.Forms.Button();
            this.ButtonSort_EDA = new System.Windows.Forms.Button();
            this.ButtonTableFilter_EDA = new System.Windows.Forms.Button();
            this.ButtonOpenCalculationsForm_EDA = new System.Windows.Forms.Button();
            this.ButtonGraphBuild_EDA = new System.Windows.Forms.Button();
            this.ButtonDeleteRow_EDA = new System.Windows.Forms.Button();
            this.ButtonOpenSuppliers_EDA = new System.Windows.Forms.Button();
            this.ButtonSearch_EDA = new System.Windows.Forms.Button();
            this.TextBoxSearch_EDA = new System.Windows.Forms.TextBox();
            this.BusinessDataView_EDA = new System.Windows.Forms.DataGridView();
            this.ChartAmount_EDA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartCost_EDA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.BusinessDataView_EDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartAmount_EDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartCost_EDA)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonFileOpen_EDA
            // 
            this.ButtonFileOpen_EDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonFileOpen_EDA.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonFileOpen_EDA.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.ButtonFileOpen_EDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonFileOpen_EDA.Location = new System.Drawing.Point(12, 12);
            this.ButtonFileOpen_EDA.Name = "ButtonFileOpen_EDA";
            this.ButtonFileOpen_EDA.Size = new System.Drawing.Size(131, 81);
            this.ButtonFileOpen_EDA.TabIndex = 0;
            this.ButtonFileOpen_EDA.Text = "Открыть файл";
            this.ButtonFileOpen_EDA.UseVisualStyleBackColor = false;
            this.ButtonFileOpen_EDA.Click += new System.EventHandler(this.ButtonFileOpen_EDA_Click);
            // 
            // ButtonFileSave_EDA
            // 
            this.ButtonFileSave_EDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonFileSave_EDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonFileSave_EDA.Location = new System.Drawing.Point(149, 12);
            this.ButtonFileSave_EDA.Name = "ButtonFileSave_EDA";
            this.ButtonFileSave_EDA.Size = new System.Drawing.Size(142, 81);
            this.ButtonFileSave_EDA.TabIndex = 1;
            this.ButtonFileSave_EDA.Text = "Сохранить файл";
            this.ButtonFileSave_EDA.UseVisualStyleBackColor = false;
            this.ButtonFileSave_EDA.Click += new System.EventHandler(this.ButtonFileSave_EDA_Click);
            // 
            // ButtonAddRow_EDA
            // 
            this.ButtonAddRow_EDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonAddRow_EDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAddRow_EDA.Location = new System.Drawing.Point(457, 12);
            this.ButtonAddRow_EDA.Name = "ButtonAddRow_EDA";
            this.ButtonAddRow_EDA.Size = new System.Drawing.Size(121, 81);
            this.ButtonAddRow_EDA.TabIndex = 3;
            this.ButtonAddRow_EDA.Text = "Добавить строку";
            this.ButtonAddRow_EDA.UseVisualStyleBackColor = false;
            this.ButtonAddRow_EDA.Click += new System.EventHandler(this.ButtonAddRow_EDA_Click);
            // 
            // ButtonSort_EDA
            // 
            this.ButtonSort_EDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonSort_EDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSort_EDA.Location = new System.Drawing.Point(297, 12);
            this.ButtonSort_EDA.Name = "ButtonSort_EDA";
            this.ButtonSort_EDA.Size = new System.Drawing.Size(154, 81);
            this.ButtonSort_EDA.TabIndex = 2;
            this.ButtonSort_EDA.Text = "Отсортировать таблицу";
            this.ButtonSort_EDA.UseVisualStyleBackColor = false;
            this.ButtonSort_EDA.Click += new System.EventHandler(this.ButtonSort_EDA_Click);
            // 
            // ButtonTableFilter_EDA
            // 
            this.ButtonTableFilter_EDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonTableFilter_EDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonTableFilter_EDA.Location = new System.Drawing.Point(987, 12);
            this.ButtonTableFilter_EDA.Name = "ButtonTableFilter_EDA";
            this.ButtonTableFilter_EDA.Size = new System.Drawing.Size(156, 81);
            this.ButtonTableFilter_EDA.TabIndex = 7;
            this.ButtonTableFilter_EDA.Text = "Отфильтровать таблицу";
            this.ButtonTableFilter_EDA.UseVisualStyleBackColor = false;
            this.ButtonTableFilter_EDA.Click += new System.EventHandler(this.ButtonTableFilter_EDA_Click);
            // 
            // ButtonOpenCalculationsForm_EDA
            // 
            this.ButtonOpenCalculationsForm_EDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonOpenCalculationsForm_EDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonOpenCalculationsForm_EDA.Location = new System.Drawing.Point(838, 12);
            this.ButtonOpenCalculationsForm_EDA.Name = "ButtonOpenCalculationsForm_EDA";
            this.ButtonOpenCalculationsForm_EDA.Size = new System.Drawing.Size(143, 81);
            this.ButtonOpenCalculationsForm_EDA.TabIndex = 6;
            this.ButtonOpenCalculationsForm_EDA.Text = "Провести вычисления";
            this.ButtonOpenCalculationsForm_EDA.UseVisualStyleBackColor = false;
            this.ButtonOpenCalculationsForm_EDA.Click += new System.EventHandler(this.ButtonOpenCalculationsForm_EDA_Click);
            // 
            // ButtonGraphBuild_EDA
            // 
            this.ButtonGraphBuild_EDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonGraphBuild_EDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonGraphBuild_EDA.Location = new System.Drawing.Point(700, 12);
            this.ButtonGraphBuild_EDA.Name = "ButtonGraphBuild_EDA";
            this.ButtonGraphBuild_EDA.Size = new System.Drawing.Size(132, 81);
            this.ButtonGraphBuild_EDA.TabIndex = 5;
            this.ButtonGraphBuild_EDA.Text = "Построить графы";
            this.ButtonGraphBuild_EDA.UseVisualStyleBackColor = false;
            this.ButtonGraphBuild_EDA.Click += new System.EventHandler(this.ButtonGraphBuild_EDA_Click);
            // 
            // ButtonDeleteRow_EDA
            // 
            this.ButtonDeleteRow_EDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonDeleteRow_EDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDeleteRow_EDA.Location = new System.Drawing.Point(584, 12);
            this.ButtonDeleteRow_EDA.Name = "ButtonDeleteRow_EDA";
            this.ButtonDeleteRow_EDA.Size = new System.Drawing.Size(110, 81);
            this.ButtonDeleteRow_EDA.TabIndex = 4;
            this.ButtonDeleteRow_EDA.Text = "Убрать строку";
            this.ButtonDeleteRow_EDA.UseVisualStyleBackColor = false;
            this.ButtonDeleteRow_EDA.Click += new System.EventHandler(this.ButtonDeleteRow_EDA_Click);
            // 
            // ButtonOpenSuppliers_EDA
            // 
            this.ButtonOpenSuppliers_EDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonOpenSuppliers_EDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonOpenSuppliers_EDA.Location = new System.Drawing.Point(1149, 12);
            this.ButtonOpenSuppliers_EDA.Name = "ButtonOpenSuppliers_EDA";
            this.ButtonOpenSuppliers_EDA.Size = new System.Drawing.Size(140, 81);
            this.ButtonOpenSuppliers_EDA.TabIndex = 8;
            this.ButtonOpenSuppliers_EDA.Text = "Открыть доставщиков";
            this.ButtonOpenSuppliers_EDA.UseVisualStyleBackColor = false;
            this.ButtonOpenSuppliers_EDA.Click += new System.EventHandler(this.ButtonOpenSuppliers_EDA_Click);
            // 
            // ButtonSearch_EDA
            // 
            this.ButtonSearch_EDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonSearch_EDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSearch_EDA.Location = new System.Drawing.Point(1295, 12);
            this.ButtonSearch_EDA.Name = "ButtonSearch_EDA";
            this.ButtonSearch_EDA.Size = new System.Drawing.Size(142, 81);
            this.ButtonSearch_EDA.TabIndex = 10;
            this.ButtonSearch_EDA.Text = "Найти в таблице";
            this.ButtonSearch_EDA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonSearch_EDA.UseVisualStyleBackColor = false;
            this.ButtonSearch_EDA.Click += new System.EventHandler(this.ButtonSearch_EDA_Click);
            // 
            // TextBoxSearch_EDA
            // 
            this.TextBoxSearch_EDA.Location = new System.Drawing.Point(1443, 12);
            this.TextBoxSearch_EDA.Name = "TextBoxSearch_EDA";
            this.TextBoxSearch_EDA.Size = new System.Drawing.Size(152, 26);
            this.TextBoxSearch_EDA.TabIndex = 11;
            // 
            // BusinessDataView_EDA
            // 
            this.BusinessDataView_EDA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BusinessDataView_EDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BusinessDataView_EDA.Location = new System.Drawing.Point(12, 99);
            this.BusinessDataView_EDA.Name = "BusinessDataView_EDA";
            this.BusinessDataView_EDA.RowHeadersWidth = 62;
            this.BusinessDataView_EDA.RowTemplate.Height = 28;
            this.BusinessDataView_EDA.Size = new System.Drawing.Size(859, 596);
            this.BusinessDataView_EDA.TabIndex = 12;
            // 
            // ChartAmount_EDA
            // 
            this.ChartAmount_EDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            chartArea5.Name = "ChartArea1";
            this.ChartAmount_EDA.ChartAreas.Add(chartArea5);
            this.ChartAmount_EDA.Location = new System.Drawing.Point(877, 99);
            this.ChartAmount_EDA.Name = "ChartAmount_EDA";
            series5.ChartArea = "ChartArea1";
            series5.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series5.Name = "Amount of production";
            this.ChartAmount_EDA.Series.Add(series5);
            this.ChartAmount_EDA.Size = new System.Drawing.Size(718, 295);
            this.ChartAmount_EDA.TabIndex = 13;
            this.ChartAmount_EDA.Text = "chart1";
            // 
            // ChartCost_EDA
            // 
            this.ChartCost_EDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            chartArea6.Name = "ChartArea1";
            this.ChartCost_EDA.ChartAreas.Add(chartArea6);
            this.ChartCost_EDA.Location = new System.Drawing.Point(877, 400);
            this.ChartCost_EDA.Name = "ChartCost_EDA";
            series6.ChartArea = "ChartArea1";
            series6.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series6.Name = "Cost of production";
            this.ChartCost_EDA.Series.Add(series6);
            this.ChartCost_EDA.Size = new System.Drawing.Size(718, 295);
            this.ChartCost_EDA.TabIndex = 14;
            this.ChartCost_EDA.Text = "chart1";
            // 
            // MainForm_EDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1607, 744);
            this.Controls.Add(this.ChartCost_EDA);
            this.Controls.Add(this.ChartAmount_EDA);
            this.Controls.Add(this.BusinessDataView_EDA);
            this.Controls.Add(this.TextBoxSearch_EDA);
            this.Controls.Add(this.ButtonSearch_EDA);
            this.Controls.Add(this.ButtonOpenSuppliers_EDA);
            this.Controls.Add(this.ButtonTableFilter_EDA);
            this.Controls.Add(this.ButtonOpenCalculationsForm_EDA);
            this.Controls.Add(this.ButtonGraphBuild_EDA);
            this.Controls.Add(this.ButtonDeleteRow_EDA);
            this.Controls.Add(this.ButtonAddRow_EDA);
            this.Controls.Add(this.ButtonSort_EDA);
            this.Controls.Add(this.ButtonFileSave_EDA);
            this.Controls.Add(this.ButtonFileOpen_EDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm_EDA";
            this.Text = "Основная форма проекта";
            this.Load += new System.EventHandler(this.MainForm_EDA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BusinessDataView_EDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartAmount_EDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartCost_EDA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonFileOpen_EDA;
        private System.Windows.Forms.Button ButtonFileSave_EDA;
        private System.Windows.Forms.Button ButtonAddRow_EDA;
        private System.Windows.Forms.Button ButtonSort_EDA;
        private System.Windows.Forms.Button ButtonTableFilter_EDA;
        private System.Windows.Forms.Button ButtonOpenCalculationsForm_EDA;
        private System.Windows.Forms.Button ButtonGraphBuild_EDA;
        private System.Windows.Forms.Button ButtonDeleteRow_EDA;
        private System.Windows.Forms.Button ButtonOpenSuppliers_EDA;
        private System.Windows.Forms.Button ButtonSearch_EDA;
        private System.Windows.Forms.TextBox TextBoxSearch_EDA;
        private System.Windows.Forms.DataGridView BusinessDataView_EDA;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartAmount_EDA;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartCost_EDA;
    }
}

