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
            AddShip addShip = new AddShip();
            addShip.ShowDialog();
        }

        private void btnAddGear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("More Clicked!");
        }

        private void dgvShips_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Britannia_Load(object sender, EventArgs e)
        {

        }
    }
}
