namespace WinFormCarSales
{
    partial class Preview
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
            dataGridViewPrev = new DataGridView();
            textBoxMake = new TextBox();
            label1 = new Label();
            buttonFilter = new Button();
            buttonProfit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrev).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPrev
            // 
            dataGridViewPrev.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPrev.Location = new Point(12, 204);
            dataGridViewPrev.Name = "dataGridViewPrev";
            dataGridViewPrev.RowTemplate.Height = 25;
            dataGridViewPrev.Size = new Size(861, 422);
            dataGridViewPrev.TabIndex = 0;
            // 
            // textBoxMake
            // 
            textBoxMake.Location = new Point(183, 31);
            textBoxMake.Name = "textBoxMake";
            textBoxMake.Size = new Size(226, 23);
            textBoxMake.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(97, 31);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 2;
            label1.Text = "Make";
            // 
            // buttonFilter
            // 
            buttonFilter.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonFilter.Location = new Point(456, 17);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(130, 39);
            buttonFilter.TabIndex = 3;
            buttonFilter.Text = "Filter";
            buttonFilter.UseVisualStyleBackColor = true;
            buttonFilter.Click += buttonFilter_Click;
            // 
            // buttonProfit
            // 
            buttonProfit.Location = new Point(701, 638);
            buttonProfit.Name = "buttonProfit";
            buttonProfit.Size = new Size(150, 36);
            buttonProfit.TabIndex = 4;
            buttonProfit.Text = "Profit";
            buttonProfit.UseVisualStyleBackColor = true;
            buttonProfit.Click += buttonProfit_Click;
            // 
            // Preview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 681);
            Controls.Add(buttonProfit);
            Controls.Add(buttonFilter);
            Controls.Add(label1);
            Controls.Add(textBoxMake);
            Controls.Add(dataGridViewPrev);
            Name = "Preview";
            Text = "Preview";
            Load += Preview_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrev).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPrev;
        private TextBox textBoxMake;
        private Label label1;
        private Button buttonFilter;
        private Button buttonProfit;
    }
}