using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Filmy.Movie;
using Filmy.Systems;
using Filmy.User;

namespace Filmy.GUI
{
    public partial class MainWindow : Form
    {

        Administrator admin = Administrator.Create("admin", "admin");
        BazaUzytkownikow baza = BazaUzytkownikow.Instance.Deserialize("test.bin") as BazaUzytkownikow;
        Biblioteka bibliotekaFilmow = Biblioteka.Instance;
        Uzytkownik currentUser;
        public MainWindow()
        {
            
            InitializeComponent();
            baza = BazaUzytkownikow.Instance.Deserialize("test.bin") as BazaUzytkownikow;
            bibliotekaFilmow = Biblioteka.Instance.Deserialize("filmy.bin") as Biblioteka;
            
        }

        private void lbZalogujSIe_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUserName_Enter(object sender, EventArgs e)
        {
            if (tbUserName.Text == "Username")
            {
                tbUserName.Text = "";
                tbUserName.ForeColor = Color.Black;
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Password")
            {
                tbPassword.Text = "";
                tbPassword.ForeColor = Color.Black;
            }
        }

        private void btZaloguj_Click(object sender, EventArgs e)
        {
            string username = tbUserName.Text;
            string password = tbPassword.Text;
            tbPassword.Text = "";
            tbUserName.Text = "";
            if(admin.UserName==username)
            {
                currentUser = admin;
                if (admin.checkPassword(password))
                {
                    this.Hide();
                    AdminConsole ac = new AdminConsole(this);
                    ac.Show();
                    
                }
                else {
                    Form ex = new ExceptionWindow("Incorrect password");
                    ex.ShowDialog();
                }
            }
            else
            {
                try
                {
                    currentUser = baza.ListaUzytkownikow.First(u => u.UserName == username);
                    if (currentUser.checkPassword(password))
                    {
                        this.Hide();
                        UserConsole ac = new UserConsole(this,baza.ListaUzytkownikow.First(u=>u.UserName==username) as NormalnyUzywtkownik);
                        ac.Show();
                    }
                    else
                    {
                        Form ex = new ExceptionWindow("Incorrect password");
                        ex.ShowDialog();
                    }
                }
                catch(Exception ex)
                {
                    Form exWindow = new ExceptionWindow("Such user doesn't exist");
                    exWindow.ShowDialog();
                }
            }
        }
    }
}
