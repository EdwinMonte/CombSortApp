namespace CombSortApp
{
    partial class Form1
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
            btnSort = new Button();
            dataGridViewSteps = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSteps).BeginInit();
            SuspendLayout();
            // 
            // btnSort
            // 
            btnSort.Location = new Point(58, 554);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(203, 55);
            btnSort.TabIndex = 2;
            btnSort.Text = "Ordenar";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // dataGridViewSteps
            // 
            dataGridViewSteps.AllowUserToOrderColumns = true;
            dataGridViewSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSteps.Location = new Point(58, 34);
            dataGridViewSteps.Name = "dataGridViewSteps";
            dataGridViewSteps.RowHeadersWidth = 51;
            dataGridViewSteps.Size = new Size(1003, 498);
            dataGridViewSteps.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 725);
            Controls.Add(dataGridViewSteps);
            Controls.Add(btnSort);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSteps).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSort;
        private DataGridView dataGridViewSteps;
    }
}
