namespace Filmy.GUI
{
    partial class UserConsole
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
            this.tbLista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTytulOcen = new System.Windows.Forms.TextBox();
            this.tbOcena = new System.Windows.Forms.TextBox();
            this.btOcen = new System.Windows.Forms.Button();
            this.btWyloguj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTytulUsun = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btUsunOcene = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbLista
            // 
            this.tbLista.Location = new System.Drawing.Point(260, 32);
            this.tbLista.Multiline = true;
            this.tbLista.Name = "tbLista";
            this.tbLista.ReadOnly = true;
            this.tbLista.Size = new System.Drawing.Size(227, 302);
            this.tbLista.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista Filmow";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ocen Film";
            // 
            // tbTytulOcen
            // 
            this.tbTytulOcen.Location = new System.Drawing.Point(12, 52);
            this.tbTytulOcen.Name = "tbTytulOcen";
            this.tbTytulOcen.Size = new System.Drawing.Size(100, 20);
            this.tbTytulOcen.TabIndex = 3;
            // 
            // tbOcena
            // 
            this.tbOcena.Location = new System.Drawing.Point(120, 52);
            this.tbOcena.Name = "tbOcena";
            this.tbOcena.Size = new System.Drawing.Size(35, 20);
            this.tbOcena.TabIndex = 4;
            // 
            // btOcen
            // 
            this.btOcen.Location = new System.Drawing.Point(162, 52);
            this.btOcen.Name = "btOcen";
            this.btOcen.Size = new System.Drawing.Size(75, 23);
            this.btOcen.TabIndex = 5;
            this.btOcen.Text = "Ocen!";
            this.btOcen.UseVisualStyleBackColor = true;
            this.btOcen.Click += new System.EventHandler(this.btOcen_Click);
            // 
            // btWyloguj
            // 
            this.btWyloguj.Location = new System.Drawing.Point(12, 309);
            this.btWyloguj.Name = "btWyloguj";
            this.btWyloguj.Size = new System.Drawing.Size(225, 25);
            this.btWyloguj.TabIndex = 6;
            this.btWyloguj.Text = "Wyloguj sie";
            this.btWyloguj.UseVisualStyleBackColor = true;
            this.btWyloguj.Click += new System.EventHandler(this.btWyloguj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tytul";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ocena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tytul";
            // 
            // tbTytulUsun
            // 
            this.tbTytulUsun.Location = new System.Drawing.Point(12, 144);
            this.tbTytulUsun.Name = "tbTytulUsun";
            this.tbTytulUsun.Size = new System.Drawing.Size(100, 20);
            this.tbTytulUsun.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Usun ocene";
            // 
            // btUsunOcene
            // 
            this.btUsunOcene.Location = new System.Drawing.Point(162, 142);
            this.btUsunOcene.Name = "btUsunOcene";
            this.btUsunOcene.Size = new System.Drawing.Size(75, 23);
            this.btUsunOcene.TabIndex = 12;
            this.btUsunOcene.Text = "Usun!";
            this.btUsunOcene.UseVisualStyleBackColor = true;
            this.btUsunOcene.Click += new System.EventHandler(this.btUsunOcene_Click);
            // 
            // UserConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 346);
            this.Controls.Add(this.btUsunOcene);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTytulUsun);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btWyloguj);
            this.Controls.Add(this.btOcen);
            this.Controls.Add(this.tbOcena);
            this.Controls.Add(this.tbTytulOcen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLista);
            this.Name = "UserConsole";
            this.Text = "UserConsole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTytulOcen;
        private System.Windows.Forms.TextBox tbOcena;
        private System.Windows.Forms.Button btOcen;
        private System.Windows.Forms.Button btWyloguj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTytulUsun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btUsunOcene;
    }
}