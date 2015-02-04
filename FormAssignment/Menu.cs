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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // load the Add Contact Form
            // instanciate the Add Contact Form
            AddContact ac = new AddContact();
            // call the form to show
            ac.Show();
            // hide this window
            this.Hide();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // load the Search Form
            // instanciate the Search Form
            Search sr = new Search();
            // call the form to show
            sr.Show();
            // hide this window
            this.Hide();
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
    }
}
