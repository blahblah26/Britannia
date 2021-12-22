using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Britannia.Events;
using Britannia.Objects;
using System.Text.Json;
using System.Collections.Immutable;

namespace Britannia
{
    public partial class Britannia : Form
    {
        public static readonly ImmutableList<Ship> shipCatalogue;
        public static readonly BindingList<Ship> ships;
        public static readonly BindingList<Gear> gears;
        static Britannia()
        {
            string cataloguePath = @"C:\Users\Melly\source\repos\Britannia\Britannia\Utils\catalogue.txt";
            string shipPath = @"C:\Users\Melly\source\repos\Britannia\Britannia\Utils\ships.txt";
            string gearPath = @"C:\Users\Melly\source\repos\Britannia\Britannia\Utils\gears.txt";

            var options = new JsonSerializerOptions
            {
                IncludeFields = true,
                PropertyNameCaseInsensitive = true
            };

            if (!File.Exists(cataloguePath))
            {
                throw new FileNotFoundException("jag aelskar min flickvaen, ingen tid att hitta din fil");
            }
            string catalogueJSON = File.ReadAllText(cataloguePath);
            shipCatalogue = JsonSerializer.Deserialize<ImmutableList<Ship>>(catalogueJSON, options);

            if (File.Exists(shipPath))
            {
                string shipJSON = File.ReadAllText(shipPath);
                ships = JsonSerializer.Deserialize<BindingList<Ship>>(shipJSON, options);
            } else
            {
                ships = new BindingList<Ship>();
            }
            
            if (File.Exists(gearPath))
            {
                string gearJSON = File.ReadAllText(gearPath);
                gears = JsonSerializer.Deserialize<BindingList<Gear>>(gearJSON, options);
            } else
            {
                gears = new BindingList<Gear>();
            }
        }
        public Britannia()
        {
            InitializeComponent();
            dgvShips.DataSource = ships;
            dgvGear.DataSource = gears;
        }

        private void btnAddShip_Click(object sender, EventArgs e)
        {

            AddShip addShip = new AddShip();
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateShips);
            addShip.ShowDialog();
        }

        private void updateShips(object sender, UpdateShipEventArgs e)
        {
            if (!ships.Contains(e.getShip()))
            {
                ships.Add(e.getShip());
                //MessageBox.Show("Added " + e.getShip().ToString());

            }
        }

        private void btnAddGear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thish shectiawn washn't impwwemented nyeet~\r\n" +
                "pwweashe be pwatient nyaa~");
        }

        private void dgvShips_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Britannia_Load(object sender, EventArgs e)
        {
            
        }
    }
}
