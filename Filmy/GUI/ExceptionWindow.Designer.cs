namespace Filmy.GUI
{
    partial class ExceptionWindow
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
            this.lbException = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbException
            // 
            this.lbException.AutoSize = true;
            this.lbException.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbException.Location = new System.Drawing.Point(12, 9);
            this.lbException.Name = "lbException";
            this.lbException.Size = new System.Drawing.Size(20, 17);
            this.lbException.TabIndex = 0;
            this.lbException.Text = "...";
            this.lbException.Click += new System.EventHandler(this.lbException_Click);
            // 
            // ExceptionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 85);
            this.Controls.Add(this.lbException);
            this.Name = "ExceptionWindow";
            this.Text = "Exception";
            this.Load += new System.EventHandler(this.Exception_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbException;
    }
}