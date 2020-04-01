using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TexaggFormsApp1
{
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }

        private void Ticketsbutton_Click(object sender, EventArgs e)
        {
            Tickets Ti = new Tickets();
            Ti.ShowDialog();
        }

        private void Materialsbutton_Click(object sender, EventArgs e)
        {
            Materials Mat = new Materials();
            Mat.ShowDialog();
        }

        private void Customersbutton_Click(object sender, EventArgs e)
        {
            Customers Cus = new Customers();
            Cus.ShowDialog();
        }
        
        private void Reportsbutton_Click(object sender, EventArgs e)
        {
            Reports Rpt = new Reports();
            Rpt.ShowDialog();
        }

        private void Optionsbutton_Click(object sender, EventArgs e)
        {
            Options Opt = new Options();
            Opt.ShowDialog();
        }
    }
}
