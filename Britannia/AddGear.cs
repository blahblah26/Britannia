using Britannia.Events;
using Britannia.Objects;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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
        public delegate void UpdateGearHandler(object sender, UpdateGearEventArgs e);

        public event UpdateGearHandler UpdateGear;
        public AddGear(ImmutableList<Gear> source)
        {
            InitializeComponent();

            lbxAddedGear.DataSource = source;
            
            lbxAddedGear.DisplayMember = "Name";
            lbxAddedGear.ValueMember = "ID";
        }

        private void btnAddShip_Click(object sender, EventArgs e)
        {
            if (lbxAddedGear.SelectedItem == null)
            {
                this.Dispose();
                return;
            }
            UpdateGearEventArgs args = new UpdateGearEventArgs(Britannia.gearCatalogue.Find(g =>
                g.ID == lbxAddedGear.SelectedValue.ToString()));
            UpdateGear(this, args);

            this.Dispose();
        }
        private void lbxAddedShips_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddGear_Load(object sender, EventArgs e)
        {

        }
    }
}
