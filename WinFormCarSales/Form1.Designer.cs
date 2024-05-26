namespace WinFormCarSales
{
    partial class FormCarSales
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxModel = new TextBox();
            label3 = new Label();
            textBoxMake = new TextBox();
            label4 = new Label();
            textBoxCost = new TextBox();
            label5 = new Label();
            textBoxSales = new TextBox();
            buttonSubmit = new Button();
            buttonShow = new Button();
            SuspendLayout();
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(122, 44);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(206, 23);
            textBoxID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(64, 44);
            label1.Name = "label1";
            label1.Size = new Size(25, 21);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(53, 199);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 3;
            label2.Text = "Model";
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(122, 197);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(206, 23);
            textBoxModel.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(53, 122);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 5;
            label3.Text = "Make";
            // 
            // textBoxMake
            // 
            textBoxMake.Location = new Point(122, 120);
            textBoxMake.Name = "textBoxMake";
            textBoxMake.Size = new Size(206, 23);
            textBoxMake.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(427, 46);
            label4.Name = "label4";
            label4.Size = new Size(41, 21);
            label4.TabIndex = 7;
            label4.Text = "Cost";
            label4.Click += label4_Click;
            // 
            // textBoxCost
            // 
            textBoxCost.Location = new Point(507, 42);
            textBoxCost.Name = "textBoxCost";
            textBoxCost.Size = new Size(206, 23);
            textBoxCost.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(427, 118);
            label5.Name = "label5";
            label5.Size = new Size(77, 21);
            label5.TabIndex = 9;
            label5.Text = "Sale Price";
            // 
            // textBoxSales
            // 
            textBoxSales.Location = new Point(507, 116);
            textBoxSales.Name = "textBoxSales";
            textBoxSales.Size = new Size(206, 23);
            textBoxSales.TabIndex = 8;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSubmit.Location = new Point(109, 289);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(240, 63);
            buttonSubmit.TabIndex = 10;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // buttonShow
            // 
            buttonShow.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonShow.Location = new Point(473, 289);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(240, 63);
            buttonShow.TabIndex = 11;
            buttonShow.Text = "Show";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // FormCarSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonShow);
            Controls.Add(buttonSubmit);
            Controls.Add(label5);
            Controls.Add(textBoxSales);
            Controls.Add(label4);
            Controls.Add(textBoxCost);
            Controls.Add(label3);
            Controls.Add(textBoxMake);
            Controls.Add(label2);
            Controls.Add(textBoxModel);
            Controls.Add(label1);
            Controls.Add(textBoxID);
            Name = "FormCarSales";
            Text = "Car Sales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxID;
        private Label label1;
        private Label label2;
        private TextBox textBoxModel;
        private Label label3;
        private TextBox textBoxMake;
        private Label label4;
        private TextBox textBoxCost;
        private Label label5;
        private TextBox textBoxSales;
        private Button buttonSubmit;
        private Button buttonShow;
    }
}
