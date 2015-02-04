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

namespace FormAssignment
{
    public partial class AddContact : Form
    {
        // instancating the Heavey Listing Class
        HeavyLifting hl = new HeavyLifting();
        
        // declaring variables
        string name, phone, email, status, id, salary, subject;
        int checkFields, checkEmails, checkPhone, checkNumbers;

        public AddContact()
        {
            InitializeComponent();
            // using Enum to populate the values in the combo box
            cboSubjects.DataSource = Enum.GetValues(typeof(StaffSubjects));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // load the Menu Form
            // instanciate the Menu Form
            Menu mu = new Menu();
            // call the form to show
            mu.Show();
            // hide this window
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // back to first form - logout
            // load the College Form
            // instanciate the College Form
            College cl = new College();
            // call the form to show
            cl.Show();
            // hide this window
            this.Close();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // load the Display Form
            // instanciate the Display Form
            Display ds = new Display();
            // call the form to show
            ds.Show();
            // hide this window
            this.Hide();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // Add Student Button on Add Contact Page
            // declaring variables

            name = txtSName.Text.ToUpper();
            phone = txtSPhone.Text;
            email = txtSEmail.Text;
            status = "";
            if (rdoPostgrad.Checked)
            {
                status = "POSTRGAD";
            }
            else if (rdoUndergrad.Checked)
            {
                status = "UNDERGAD";
            }
            id = txtSID.Text;

            // check phone number entered correctly
            checkPhone = NumberCheck(phone);
            NumberPrint(checkPhone, "Phone");

            // check emails entered correctly
            checkEmails = EmailCheck(email);
            // if errors detected print out error
            EmailPrint(checkEmails);

            // check student id entered correctly
            checkNumbers = NumberCheck(id);
            NumberPrint(checkNumbers, "StudentID");

            // validation check
            checkFields = (InputCheck(name, phone, email, status, id));
            if (checkFields == 0 && checkEmails == 0 && checkPhone == 0 && checkNumbers ==0)
            {
                // use AddStudent method in Heavylifting class
                hl.AddStudent(name, phone, email, status, id);

                // clear entry point boxes
                txtSName.Clear();
                txtSPhone.Clear();
                txtSEmail.Clear();
                rdoPostgrad.Checked = false;
                rdoUndergrad.Checked = false;
                txtSID.Clear();

                MessageBox.Show("Student Contact was added sucessfully.");
            }
            else if (checkFields == 1)
                MessageBox.Show("Whoops, you forgot to enter 1 field. Please enter all the infomation for the Student Contact.");
            else if (checkFields > 1)
                MessageBox.Show(string.Format("Whoops, you forgot to enter {0} fields. Please enter all the infomation for the Student Contact.", checkFields));
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            // Add Teacher Button
            // declaring variables
            name = txtTName.Text.ToUpper();
            phone = txtTPhone.Text;
            email = txtTEmail.Text;
            salary = txtTSalary.Text;

            // check phone number entered correctly
            checkPhone = NumberCheck(phone);
            NumberPrint(checkPhone, "Phone");

            // check emails entered correctly
            checkEmails = EmailCheck(email);
            // if errors detected print out error
            EmailPrint(checkEmails);

            // check salary entered correctly
            checkNumbers = NumberCheck(salary);
            NumberPrint(checkNumbers, "Salary");

            // validation check on combo box
            try
            {
                subject = cboSubjects.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a Subject Taught.");
            }

            // validation check for the rest of the infomation entered
            checkFields = (InputCheck(name, phone, email, salary, subject));
            if (checkFields == 0 && checkEmails == 0 && checkPhone == 0 && checkNumbers == 0)
            {
                hl.AddTeacher(name, phone, email, salary, subject);

                // clear entry point boxes
                txtTName.Clear();
                txtTPhone.Clear();
                txtTEmail.Clear();
                txtTSalary.Clear();
                cboSubjects.SelectedIndex = -1;

                MessageBox.Show("Teacher Contact was added sucessfully.");
            }
            else if (checkFields == 1)
                MessageBox.Show("Whoops, you forgot to enter 1 field. Please enter all the infomation for the Teacher Contact.");
            else if (checkFields > 1)
                MessageBox.Show(string.Format("Whoops, you forgot to enter {0} fields. Please enter all the infomation for the Teacher Contact.", checkFields));
        }

        // method to validate contact entry fields
        public int InputCheck(string ch1, string ch2, string ch3, string ch4, string ch5)
        {
            // results initalised at 0
            int result = 0;

            // everything a string is empty +1
            if (String.IsNullOrWhiteSpace(ch1))
                result++;
            if (String.IsNullOrWhiteSpace(ch2))
                result++;
            if (String.IsNullOrWhiteSpace(ch3))
                result++;
            if (String.IsNullOrWhiteSpace(ch4))
                result++;
            if (String.IsNullOrWhiteSpace(ch5))
                result++;

            return result;
        }

        // method to check emails
        public int EmailCheck(string ch1)
        {
            // results initalised at 0
            int result = 0;

            // if there is a space in the email
            if (ch1.Contains(" "))
                result = 1;

            // if the email is missing an at symbol
            string checkAt = @"@";
            char[] checkAtArray = checkAt.ToCharArray();

            int index1 = ch1.IndexOfAny(checkAtArray);
            // when index == -1, there is no @ symbol
            if (index1 == -1)
                result = result + 10;

            // if the email contains characters that are not allowed
            string forbiddenChar = @"%!#$£€%^&*()?/><,:;'\|}]{[_~`+=-";
            char[] forCharArray = forbiddenChar.ToCharArray();

            int index2 = ch1.IndexOfAny(forCharArray);
            // when index != -1, forbidden characters are present
            if (index2 != -1)
                result = result + 100;

            return result;
        }

        //  method to print out email errors
        public void EmailPrint(int n)
        {
            if (n == 1)
                MessageBox.Show("Error in email field - Blank Space detected.");
            if (n == 10)
                MessageBox.Show("Error in email field - Missing @ Symbol in email address.");
            if (n == 11)
                MessageBox.Show("Error in email field - Missing @ Symbol and Blank Space detected.");
            if (n == 100)
                MessageBox.Show(@"Error in email field - Forbidden Symbol dectected. Please remove any of these symbols %!#$%^&*()?/><,:;'\|}]{[_~`+=-");
            if (n == 101)
                MessageBox.Show(@"Error in email field - Blank Space and Forbidden Symbol dectected. Please remove any of these symbols %!#$%^&*()?/><,:;'\|}]{[_~`+=-");
            if (n == 110)
                MessageBox.Show(@"Error in email field - Missing @ Symbol and Forbidden Symbol dectected. Please remove any of these symbols %!#$%^&*()?/><,:;'\|}]{[_~`+=-");
            if (n == 111)
                MessageBox.Show(@"Error in email field - Blank Space, Missing @ Symbol and Forbidden Symbol dectected. Please remove any of these symbols %!#$%^&*()?/><,:;'\|}]{[_~`+=-");
        }

        // method to check phone number and student number are only numbers
        public int NumberCheck(string ch1)
        {
            int result = 0;

            // if the string contains letters that are not allowed
            string lettersChar = @"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] lettersArray = lettersChar.ToCharArray();

            int index1 = ch1.IndexOfAny(lettersArray);
            // when index != -1, letters are present
            if (index1 != -1)
                result = result + 1;

            // if the string contains characters that are not allowed
            string forbiddenChar = @"%!#$£€%^&*()?/><,:;'\|}]{[_~`+=-";
            char[] forCharArray = forbiddenChar.ToCharArray();

            int index2 = ch1.IndexOfAny(forCharArray);
            // when index != -1, forbidden characters are present
            if (index2 != -1)
                result = result + 10;

            return result;
        }

        //  method to print out string errors
        public void NumberPrint(int n, string s)
        {
            if (n == 1)
                MessageBox.Show(string.Format("Error in {0}", s + @" field - This is a numbers only field. Letters were detected."));
            if (n == 10)
                MessageBox.Show(string.Format("Error in {0}", s + @" field - This is a numbers only field. Forbidden Symbol dectected. Please remove any of the following symbols %!#$%^&*()?/><,:;'\|}]{[_~`+=-"));
            if (n == 11)
                MessageBox.Show(string.Format("Error in {0}", s + @" field - This is a numbers only field. Letters and Forbidden Symbol dectected. Please remove any of the following symbols %!#$%^&*()?/><,:;'\|}]{[_~`+=-"));
        }
    }
}
