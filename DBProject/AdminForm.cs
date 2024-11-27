using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProject
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }


        bool isSidebarVisible = false;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (isSidebarVisible)
            {
                sidebar.Hide();
                isSidebarVisible = false;
            }
            else
            {
                sidebar.Show();
                isSidebarVisible = true;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

            if (isSidebarVisible)
            {
                sidebar.Hide();
                isSidebarVisible = false;
            }
            else
            {
                sidebar.Show();
                isSidebarVisible = true;
            }
        }
    }
}
