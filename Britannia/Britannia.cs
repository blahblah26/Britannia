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
            InitComponents();
        }

        private void InitComponents()
        {
            lblTest.Text = "This is cool";
            lblTest.Size = new Size(500, 500);
            lblTest.Visible = true;
            lblTest.ForeColor = Color.Firebrick;
            lblTest.Enabled = true;
            lblTest.BackColor = Color.Aqua;
            lblTest.Refresh();
            ArrayList ar = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                ar.Add(i);
            }
            cmbTest.DataSource = ar;
        }

        private void lblTest_Click(object sender, EventArgs e)
        {
            lblTest.Text = "clicked!";
            lblTest.Size = new Size(1000, 1000);
            lblTest.Font = new Font(FontFamily.GenericMonospace, 30);
            lblTest.Refresh();
        }
    }
}
