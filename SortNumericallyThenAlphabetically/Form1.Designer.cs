namespace SortNumericallyThenAlphabetically
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
            this.rTxbOutput = new System.Windows.Forms.RichTextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rTxbOutput
            // 
            this.rTxbOutput.Location = new System.Drawing.Point(12, 12);
            this.rTxbOutput.Name = "rTxbOutput";
            this.rTxbOutput.Size = new System.Drawing.Size(360, 426);
            this.rTxbOutput.TabIndex = 0;
            this.rTxbOutput.Text = "";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(496, 201);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(195, 74);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "SORT";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.rTxbOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rTxbOutput;
        private Button btnSort;
    }
}