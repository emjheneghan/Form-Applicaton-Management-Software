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
    public partial class Display : Form
    {
        // instancating HeavyLifting Class
        HeavyLifting hl = new HeavyLifting();

        // delcaring the file path
        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + Path.DirectorySeparatorChar + "DBSDataBase.csv";

        public Display()
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
            // load the College Form
            // instanciate the College Form
            College cl = new College();
            // call the form to show
            cl.Show();
            // hide this window
            this.Close();
        }

        private void btnDStudents_Click(object sender, EventArgs e)
        {
            // display students list
            dgdDisplayAll.DataSource = hl.PassStudentList();
        }

        private void btnDTeachers_Click(object sender, EventArgs e)
        {
            // display teachers list
            dgdDisplayAll.DataSource = hl.PassTeacherList();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear datagrid view
            dgdDisplayAll.DataSource = String.Empty;
        }

        private void btnDAll_Click(object sender, EventArgs e)
        {
            // display all contacts
            LoadCSVFile();
        }

        public void LoadCSVFile()
        {
            string delimiter = ",";
            string tableName = "ContactsTable";

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

            foreach (string r in rows)
            {
                string[] items = r.Split(delimiter.ToCharArray());
                dataset.Tables[tableName].Rows.Add(items);
            }
            this.dgdDisplayAll.DataSource = dataset.Tables[0].DefaultView;

            sr.Close();
        }
    }

    
}
