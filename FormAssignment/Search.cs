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
    public partial class Search : Form
    {
        // instancating the HeavyLifting Class
        HeavyLifting hl = new HeavyLifting();

        // creating a search list
        List<Student> ss = new List<Student>();
        List<Teacher> st = new List<Teacher>();
        List<Person> sp = new List<Person>();

        // delcaring the file path
        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + Path.DirectorySeparatorChar + "DBSDataBase.csv";

        // declaring variable
        int sCheck;

        public Search()
        {
            InitializeComponent();
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

        private void btnSStudents_Click(object sender, EventArgs e)
        {
            // clear previous search item
            ss.Clear();

            // declaring variables
            bool foundMatch = false;
            string search = txtSearch.Text.ToUpper();

            // check search input
            sCheck = CheckSearchItem(search);
            SearchPrint(sCheck);

            if (sCheck == 0)
            {
                // loop through Student list for match
                foreach (Student s in hl.PassStudentList())
                {
                    if (s.Name == search)
                    {
                        foundMatch = true;
                        ss.Add(s);
                    }
                }

                // if no match found
                if (!foundMatch)
                {
                    MessageBox.Show("No Matches Found.");
                }
            
                dgdDisplaySearch.DataSource = ss;
                txtSearch.Clear();
            }
        }

        private void btnSAll_Click(object sender, EventArgs e)
        {
            // Search All from CSV file
            SearchCSVFile();
        }

        public void SearchCSVFile()
        {
            // clear previous search item
            sp.Clear();

            // declaring variables
            string search = txtSearch.Text.ToUpper();

            // check search input
            sCheck = CheckSearchItem(search);
            SearchPrint(sCheck);

            if (sCheck == 0)
            {

                string delimiter = ",";
                string tableName = "SearchTable";
                int count = 0;

                DataSet dataset = new DataSet();
                StreamReader sr = new StreamReader(filePath);

                dataset.Tables.Add(tableName);
                dataset.Tables[tableName].Columns.Add("Person Type");
                dataset.Tables[tableName].Columns.Add("Name");
                dataset.Tables[tableName].Columns.Add("Phone");
                dataset.Tables[tableName].Columns.Add("Email");
                dataset.Tables[tableName].Columns.Add("Status");
                dataset.Tables[tableName].Columns.Add("Student ID");
                dataset.Tables[tableName].Columns.Add("Salary");
                dataset.Tables[tableName].Columns.Add("Subject Taught");

                string allData = sr.ReadToEnd();
                string[] rows = allData.Split("\r".ToCharArray());

                // go through each row
                foreach (string r in rows)
                {
                    // split the row into items
                    string[] items = r.Split(delimiter.ToCharArray());

                    // check if one item matches the search item
                    if (Array.Exists(items, s => s.Equals(search)))
                    {
                        dataset.Tables[tableName].Rows.Add(items);
                        count++;
                    }
                }

                this.dgdDisplaySearch.DataSource = dataset.Tables[0].DefaultView;


                // check for duplicates
                if (count >= 2)
                {
                    string s1 = "", s2 = "", s3 = "";
                    foreach (DataGridViewRow dr in dgdDisplaySearch.Rows)
                    {
                        // add person to list, if not a new line
                        if (!dr.IsNewRow)
                        {
                            s1 = dr.Cells["Name"].Value.ToString();
                            s2 = dr.Cells["Phone"].Value.ToString();
                            s3 = dr.Cells["Email"].Value.ToString();
                            Person p = new Person(s1, s2, s3);

                            sp.Add(p);
                        }
                        else
                            break;
                    }

                    // resetting count to zero to use later
                    count = 0;
                    foreach (Person p in sp)
                    {
                        if (p.Phone == s2)
                        {
                            count++;
                        }
                    }

                    if (count == 2)
                    {
                        MessageBox.Show("This is the same person.");
                    }
                }

                sr.Close();
                txtSearch.Clear();
            }
        }

        private void btnSTeachers_Click(object sender, EventArgs e)
        {
            // clear previous search item
            st.Clear();

            // search teachers
            // declaring variables
            bool foundMatch = false;
            string search = txtSearch.Text.ToUpper();

            // check search input
            sCheck = CheckSearchItem(search);
            SearchPrint(sCheck);

            if (sCheck == 0)
            {
                // loop through teacher list for match
                foreach (Teacher t in hl.PassTeacherList())
                {
                    if (t.Name == search)
                    {
                        foundMatch = true;
                        st.Add(t);
                    }
                }

                // if no match found
                if (!foundMatch)
                {
                    MessageBox.Show("No Matches Found.");
                }

                dgdDisplaySearch.DataSource = st;
                txtSearch.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgdDisplaySearch.DataSource = null;
        }

        // method to check entered search item
        public int CheckSearchItem(string ch1)
        {
            int result = 0;

            // if the string contains numbers that are not allowed
            string numsChar = @"123456789";
            char[] numsArray = numsChar.ToCharArray();

            int index1 = ch1.IndexOfAny(numsArray);
            // when index != -1, numbers are present
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
        public void SearchPrint(int n)
        {
            if (n == 1)
                MessageBox.Show("Error in Search field - This is a letters only field. Numbers were detected. Please remove to Search.");
            if (n == 10)
                MessageBox.Show(@"Error in Search field - This is a numbers only field. Forbidden Symbol dectected. Please remove any of the following symbols %!#$%^&*()?/><,:;'\|}]{[_~`+=-");
            if (n == 11)
                MessageBox.Show(@"Error in Search field - This is a numbers only field. Numbers and Forbidden Symbol dectected. Please remove any of the following symbols %!#$%^&*()?/><,:;'\|}]{[_~`+=-");
        }
    }
}
