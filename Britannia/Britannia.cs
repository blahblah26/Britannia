using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Britannia
{
    public partial class Britannia : Form
    {
        public Britannia()
        {
            InitializeComponent();
        }

        private void btnAddShip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked!");
        }

        private void btnAddGear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("More Clicked!");
        }
    }
}
