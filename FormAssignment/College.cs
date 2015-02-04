// Student: Emma Jane Heneghan
// Student Number: 10204278

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FormAssignment
{
    public partial class College : Form
    {
        public College()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // instanciante the hashcode class
            HashCode hs = new HashCode();

            // I used the following to display the numerical value of the Password "password"
            // txtDisplay.Text = hs.PassHash("password");

            // set the username and password
            string userName = "admin";
            string password = "91170972282011856363613037111082485127126230143216";

            // get input from user
            string user = txtUsername.Text;
            string pass = hs.PassHash(txtPassword.Text);

            if (user == userName)
            {
                if (pass == password)
                {
                    // create CSV file
                    // delcaring the file path
                    string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + Path.DirectorySeparatorChar + "DBSDataBase.csv";

                    // instanciatne the Contacts List class, and Read, Write File Class
                    ReadWriteFile rwf = new ReadWriteFile();
                    HeavyLifting hl = new HeavyLifting();

                    // create the file, if it does not exist on the system
                    if (!File.Exists(filePath))
                    {
                        // create file
                        rwf.CreateFile();
                        // add test people to CSV and lists - DEMO
                        hl.CreateTestPeople();
                    }
                    // just load CSV information into Student and Teacher lists
                    else
                    {
                        hl.CreateLists();
                    }

                    // load Menu Form
                    // instanciate the Menu Form
                    Menu m = new Menu();
                    // call the form to show
                    m.Show();
                    // hide this window
                    this.Hide();
                }
                else
                    MessageBox.Show("Wrong password.", "Error");
            }
            else
                MessageBox.Show("The username is incorrect.", "Error");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void chkHint_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHint.Checked)
            {
                MessageBox.Show("Username = admin, Password = password", "Log in Details");
            }
        }
    }
}
