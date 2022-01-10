using Britannia.Events;
using Britannia.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Britannia
{
    public partial class AddGear : Form
    {
        public delegate void UpdateShipHandler(object sender, UpdateShipEventArgs e);

        public event UpdateShipHandler UpdateShip;
        public AddGear(BindingList<Ship> source)
        {
            InitializeComponent();

            lbxAddedShips.DataSource = source;

            lbxAddedShips.DisplayMember = "Name";
            lbxAddedShips.ValueMember = "ID";
        }

        private void btnAddShip_Click(object sender, EventArgs e)
        {
            if (lbxAddedShips.SelectedItem == null)
            {
                this.Dispose();
                return;
            }
            UpdateShipEventArgs args = new UpdateShipEventArgs(Britannia.shipCatalogue.Find(s =>
                s.ID == lbxAddedShips.SelectedValue.ToString()));
            UpdateShip(this, args);

            this.Dispose();
        }
        private void lbxAddedShips_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
