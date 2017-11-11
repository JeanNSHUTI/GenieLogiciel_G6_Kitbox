using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KitboxClassLibrary;

namespace Kitbox
{
    public partial class SudoLogin : System.Windows.Forms.Form
    {
        //Fields
        DbManager db;
        static public Employee current_employee = new Employee();


        //Constructors
        public SudoLogin()
        {
            InitializeComponent();
        }
        public SudoLogin(DbManager db)
        {
            this.db = db;
            InitializeComponent();
        }


        //Event handlers
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_adminlogin_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            Home.Current.Show();
        }

        private void btn_login_sudo_Click(object sender, EventArgs e)
        {
            Employee new_employeelogin = new Employee(txtBx_email_sudo.Text, txtBx_password_sudo.Text);
            if (db.VerifyEmployee(new_employeelogin))
            {
                new_employeelogin = db.List_of_employees.Find(x => x.Email == new_employeelogin.Email && x.Password == new_employeelogin.Password);
                current_employee = new_employeelogin;
                this.Close();
                this.Dispose();
                SudoForm1 sudo1 = new SudoForm1(db);
                sudo1.ShowDialog();
            }
            else
            {
                // On ajoute une icône : celle d'une erreur. On change aussi les boutons.
                MessageBox.Show("This is not a valid username and/or password", "Titre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SudoLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
