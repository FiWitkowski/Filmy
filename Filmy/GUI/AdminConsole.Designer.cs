namespace Filmy.GUI
{
    partial class AdminConsole
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbImie = new System.Windows.Forms.TextBox();
            this.btDodajUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btUsunUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btDodajFilm = new System.Windows.Forms.Button();
            this.btUsunFilm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btLogout = new System.Windows.Forms.Button();
            this.tbNazwisko = new System.Windows.Forms.TextBox();
            this.tbWiek = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbNazwa = new System.Windows.Forms.TextBox();
            this.tbDataWydania = new System.Windows.Forms.TextBox();
            this.tbNazwa2 = new System.Windows.Forms.TextBox();
            this.tbUserName2 = new System.Windows.Forms.TextBox();
            this.tbUsers = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFilmy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adding User";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbImie
            // 
            this.tbImie.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbImie.Location = new System.Drawing.Point(15, 25);
            this.tbImie.Name = "tbImie";
            this.tbImie.Size = new System.Drawing.Size(100, 20);
            this.tbImie.TabIndex = 1;
            this.tbImie.Text = "imie";
            this.tbImie.Enter += new System.EventHandler(this.tbImie_Enter);
            // 
            // btDodajUser
            // 
            this.btDodajUser.Location = new System.Drawing.Point(27, 155);
            this.btDodajUser.Name = "btDodajUser";
            this.btDodajUser.Size = new System.Drawing.Size(75, 23);
            this.btDodajUser.TabIndex = 6;
            this.btDodajUser.Text = "Dodaj";
            this.btDodajUser.UseVisualStyleBackColor = true;
            this.btDodajUser.Click += new System.EventHandler(this.btDodajUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Deleting User";
            // 
            // btUsunUser
            // 
            this.btUsunUser.Location = new System.Drawing.Point(27, 233);
            this.btUsunUser.Name = "btUsunUser";
            this.btUsunUser.Size = new System.Drawing.Size(75, 23);
            this.btUsunUser.TabIndex = 9;
            this.btUsunUser.Text = "Usun";
            this.btUsunUser.UseVisualStyleBackColor = true;
            this.btUsunUser.Click += new System.EventHandler(this.btUsunUser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Adding Movie";
            // 
            // btDodajFilm
            // 
            this.btDodajFilm.Location = new System.Drawing.Point(220, 77);
            this.btDodajFilm.Name = "btDodajFilm";
            this.btDodajFilm.Size = new System.Drawing.Size(75, 23);
            this.btDodajFilm.TabIndex = 13;
            this.btDodajFilm.Text = "Dodaj";
            this.btDodajFilm.UseVisualStyleBackColor = true;
            this.btDodajFilm.Click += new System.EventHandler(this.btDodajFilm_Click);
            // 
            // btUsunFilm
            // 
            this.btUsunFilm.Location = new System.Drawing.Point(220, 233);
            this.btUsunFilm.Name = "btUsunFilm";
            this.btUsunFilm.Size = new System.Drawing.Size(75, 23);
            this.btUsunFilm.TabIndex = 14;
            this.btUsunFilm.Text = "Usun";
            this.btUsunFilm.UseVisualStyleBackColor = true;
            this.btUsunFilm.Click += new System.EventHandler(this.btUsunFilm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Deleting Movie";
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(61, 287);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(198, 23);
            this.btLogout.TabIndex = 17;
            this.btLogout.Text = "Wyloguj";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // tbNazwisko
            // 
            this.tbNazwisko.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbNazwisko.Location = new System.Drawing.Point(15, 51);
            this.tbNazwisko.Name = "tbNazwisko";
            this.tbNazwisko.Size = new System.Drawing.Size(100, 20);
            this.tbNazwisko.TabIndex = 18;
            this.tbNazwisko.Text = "nazwisko";
            this.tbNazwisko.Enter += new System.EventHandler(this.tbNazwisko_Enter);
            // 
            // tbWiek
            // 
            this.tbWiek.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbWiek.Location = new System.Drawing.Point(15, 80);
            this.tbWiek.Name = "tbWiek";
            this.tbWiek.Size = new System.Drawing.Size(100, 20);
            this.tbWiek.TabIndex = 19;
            this.tbWiek.Text = "wiek";
            this.tbWiek.Enter += new System.EventHandler(this.tbWiek_Enter);
            // 
            // tbUserName
            // 
            this.tbUserName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbUserName.Location = new System.Drawing.Point(15, 106);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 20);
            this.tbUserName.TabIndex = 20;
            this.tbUserName.Text = "username";
            this.tbUserName.Enter += new System.EventHandler(this.tbUserName_Enter);
            // 
            // tbPassword
            // 
            this.tbPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbPassword.Location = new System.Drawing.Point(15, 132);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 21;
            this.tbPassword.Text = "password";
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            // 
            // tbNazwa
            // 
            this.tbNazwa.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbNazwa.Location = new System.Drawing.Point(208, 25);
            this.tbNazwa.Name = "tbNazwa";
            this.tbNazwa.Size = new System.Drawing.Size(100, 20);
            this.tbNazwa.TabIndex = 22;
            this.tbNazwa.Text = "Nazwa";
            this.tbNazwa.Enter += new System.EventHandler(this.tbNazwa_Enter);
            // 
            // tbDataWydania
            // 
            this.tbDataWydania.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbDataWydania.Location = new System.Drawing.Point(208, 51);
            this.tbDataWydania.Name = "tbDataWydania";
            this.tbDataWydania.Size = new System.Drawing.Size(100, 20);
            this.tbDataWydania.TabIndex = 23;
            this.tbDataWydania.Text = "Data Wydania";
            this.tbDataWydania.Enter += new System.EventHandler(this.tbDataWydania_Enter);
            // 
            // tbNazwa2
            // 
            this.tbNazwa2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbNazwa2.Location = new System.Drawing.Point(208, 207);
            this.tbNazwa2.Name = "tbNazwa2";
            this.tbNazwa2.Size = new System.Drawing.Size(100, 20);
            this.tbNazwa2.TabIndex = 24;
            this.tbNazwa2.Text = "Nazwa";
            this.tbNazwa2.Enter += new System.EventHandler(this.tbNazwa2_Enter);
            // 
            // tbUserName2
            // 
            this.tbUserName2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbUserName2.Location = new System.Drawing.Point(15, 207);
            this.tbUserName2.Name = "tbUserName2";
            this.tbUserName2.Size = new System.Drawing.Size(100, 20);
            this.tbUserName2.TabIndex = 25;
            this.tbUserName2.Text = "username";
            this.tbUserName2.Enter += new System.EventHandler(this.tbUserName2_Enter);
            // 
            // tbUsers
            // 
            this.tbUsers.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbUsers.Location = new System.Drawing.Point(330, 25);
            this.tbUsers.Multiline = true;
            this.tbUsers.Name = "tbUsers";
            this.tbUsers.Size = new System.Drawing.Size(100, 244);
            this.tbUsers.TabIndex = 26;
            this.tbUsers.TextChanged += new System.EventHandler(this.tbUsers_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Uzytkownicy";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbFilmy
            // 
            this.tbFilmy.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbFilmy.Location = new System.Drawing.Point(436, 25);
            this.tbFilmy.Multiline = true;
            this.tbFilmy.Name = "tbFilmy";
            this.tbFilmy.Size = new System.Drawing.Size(100, 244);
            this.tbFilmy.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(433, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Filmy";
            // 
            // AdminConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 335);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbFilmy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbUsers);
            this.Controls.Add(this.tbUserName2);
            this.Controls.Add(this.tbNazwa2);
            this.Controls.Add(this.tbDataWydania);
            this.Controls.Add(this.tbNazwa);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.tbWiek);
            this.Controls.Add(this.tbNazwisko);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btUsunFilm);
            this.Controls.Add(this.btDodajFilm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btUsunUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btDodajUser);
            this.Controls.Add(this.tbImie);
            this.Controls.Add(this.label1);
            this.Name = "AdminConsole";
            this.Text = "AdminConsole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbImie;
        private System.Windows.Forms.Button btDodajUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btUsunUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btDodajFilm;
        private System.Windows.Forms.Button btUsunFilm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.TextBox tbNazwisko;
        private System.Windows.Forms.TextBox tbWiek;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbNazwa;
        private System.Windows.Forms.TextBox tbDataWydania;
        private System.Windows.Forms.TextBox tbNazwa2;
        private System.Windows.Forms.TextBox tbUserName2;
        private System.Windows.Forms.TextBox tbUsers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFilmy;
        private System.Windows.Forms.Label label6;
    }
}