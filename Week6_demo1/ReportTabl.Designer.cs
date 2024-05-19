namespace Week6_demo1
{
    partial class ReportTabl
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
            this.label1 = new System.Windows.Forms.Label();
            this.studentDataSet = new Week6_demo1.StudentDataSet();
            this.studdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stud_detailsTableAdapter = new Week6_demo1.StudentDataSetTableAdapters.Stud_detailsTableAdapter();
            this.studdetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studdetailsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Preview";
            // 
            // studentDataSet
            // 
            this.studentDataSet.DataSetName = "StudentDataSet";
            this.studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studdetailsBindingSource
            // 
            this.studdetailsBindingSource.DataMember = "Stud_details";
            this.studdetailsBindingSource.DataSource = this.studentDataSet;
            // 
            // stud_detailsTableAdapter
            // 
            this.stud_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // studdetailsBindingSource1
            // 
            this.studdetailsBindingSource1.DataMember = "Stud_details";
            this.studdetailsBindingSource1.DataSource = this.studentDataSet;
            // 
            // ReportTabl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Name = "ReportTabl";
            this.Text = "ReportTabl";
            this.Load += new System.EventHandler(this.ReportTabl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studdetailsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private StudentDataSet studentDataSet;
        private System.Windows.Forms.BindingSource studdetailsBindingSource;
        private StudentDataSetTableAdapters.Stud_detailsTableAdapter stud_detailsTableAdapter;
        private System.Windows.Forms.BindingSource studdetailsBindingSource1;
    }
}