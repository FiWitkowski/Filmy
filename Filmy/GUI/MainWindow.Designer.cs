namespace Filmy.GUI
{
    partial class MainWindow
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
            this.lbZalogujSIe = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btZaloguj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbZalogujSIe
            // 
            this.lbZalogujSIe.AutoSize = true;
            this.lbZalogujSIe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbZalogujSIe.Location = new System.Drawing.Point(12, 9);
            this.lbZalogujSIe.Name = "lbZalogujSIe";
            this.lbZalogujSIe.Size = new System.Drawing.Size(108, 22);
            this.lbZalogujSIe.TabIndex = 0;
            this.lbZalogujSIe.Text = "Zaloguj sie";
            this.lbZalogujSIe.Click += new System.EventHandler(this.lbZalogujSIe_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.SystemColors.Window;
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbUserName.Location = new System.Drawing.Point(15, 34);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 27);
            this.tbUserName.TabIndex = 1;
            this.tbUserName.Text = "Username";
            this.tbUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbUserName.Enter += new System.EventHandler(this.tbUserName_Enter);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.Window;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbPassword.Location = new System.Drawing.Point(15, 67);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 27);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Text = "Password";
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            // 
            // btZaloguj
            // 
            this.btZaloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btZaloguj.Location = new System.Drawing.Point(16, 101);
            this.btZaloguj.Name = "btZaloguj";
            this.btZaloguj.Size = new System.Drawing.Size(99, 36);
            this.btZaloguj.TabIndex = 3;
            this.btZaloguj.Text = "ZALOGUJ";
            this.btZaloguj.UseVisualStyleBackColor = true;
            this.btZaloguj.Click += new System.EventHandler(this.btZaloguj_Click);
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(133, 155);
            this.Controls.Add(this.btZaloguj);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lbZalogujSIe);
            this.Name = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label lbZalogujSIe;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btZaloguj;
    }
}