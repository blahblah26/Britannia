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
        public static ImmutableList<Ship> shipCatalogue;
        public static BindingList<Ship> ships;
        public static BindingList<Gear> gears;
        public static BindingList<Ship> availableShips;
        public static Ship[,] fleets;

        public Britannia()
        {
            InitializeComponent();
        }

        private void btnAddShip_Click(object sender, EventArgs e)
        {

            AddShip addShip = new AddShip(false);
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateShips);
            addShip.ShowDialog();
        }

        private void updateShips(object sender, UpdateShipEventArgs e)
        {
            if (!ships.Contains(e.getShip()))
            {
                ships.Add(e.getShip());
                //MessageBox.Show("Added " + e.getShip().ToString());
                BindingList<Ship> tmp = new BindingList<Ship>();
                foreach (Ship s in availableShips)
                {
                    if (!s.Equals(e.getShip()))
                    {
                        tmp.Add(s);
                    }
                }
                availableShips = tmp;

                if (availableShips.Count == 0)
                {
                    btnAddShip.Enabled = false;
                }
                //int idx = availableShips.IndexOf(e.getShip());
                //availableShips.RemoveAt(idx);
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
            string cataloguePath = @"C:\Users\Melly\source\repos\Britannia\Britannia\Utils\catalogue.txt";
            string shipPath = @"C:\Users\Melly\source\repos\Britannia\Britannia\Utils\ships.txt";
            string gearPath = @"C:\Users\Melly\source\repos\Britannia\Britannia\Utils\gears.txt";
            string availablePath = @"C:\Users\Melly\source\repos\Britannia\Britannia\Utils\available.txt";
            string fleetPath = @"C:\Users\Melly\source\repos\Britannia\Britannia\Utils\fleets.txt";

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
            try
            {
                shipCatalogue = JsonSerializer.Deserialize<ImmutableList<Ship>>(catalogueJSON, options);
            }
            catch
            {
                MessageBox.Show("json aer inte lika trevlig som min flickvaen", "Unable to read data",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
                return;
            }
            if (File.Exists(shipPath))
            {
                string shipJSON = File.ReadAllText(shipPath);
                try
                {
                    ships = JsonSerializer.Deserialize<BindingList<Ship>>(shipJSON, options);
                }
                catch (JsonException)
                {
                    MessageBox.Show("json aer inte lika trevlig som min flickvaen", "Unable to read data",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ships = new BindingList<Ship>();
                }
            }
            else
            {
                ships = new BindingList<Ship>();
            }

            if (File.Exists(gearPath))
            {
                string gearJSON = File.ReadAllText(gearPath);
                try
                {
                    gears = JsonSerializer.Deserialize<BindingList<Gear>>(gearJSON, options);
                }
                catch (JsonException)
                {
                    MessageBox.Show("json aer inte lika trevlig som min flickvaen", "Unable to read data",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gears = new BindingList<Gear>();
                }
            }
            else
            {
                gears = new BindingList<Gear>();
            }

            if (File.Exists(availablePath))
            {
                string availableJSON = File.ReadAllText(availablePath);
                try
                {
                    availableShips = JsonSerializer.Deserialize<BindingList<Ship>>(availableJSON, options);
                }
                catch (JsonException)
                {
                    MessageBox.Show("json aer inte lika trevlig som min flickvaen", "Unable to read data",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    availableShips = new BindingList<Ship>(shipCatalogue);
                }
            }
            else
            {
                availableShips = new BindingList<Ship>(shipCatalogue);
            }

            if (File.Exists(fleetPath))
            {
                string fleetJSON = File.ReadAllText(fleetPath);
                try
                {
                    fleets = JsonSerializer.Deserialize<Ship[,]>(fleetJSON, options);
                }
                catch (JsonException)
                {
                    MessageBox.Show("json aer inte lika trevlig som min flickvaen", "Unable to read data",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fleets = new Ship[3, 3];
                }
            }
            else
            {
                fleets = new Ship[3, 3];
            }

            if (availableShips.Count == 0)
            {
                btnAddShip.Enabled = false;
            }
            dgvShips.DataSource = ships;
            dgvGear.DataSource = gears;
        }

        private void btnMainFlt1_Click(object sender, EventArgs e)
        {
            AddShip addShip = new AddShip(true);
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleets(0, 0));
            addShip.ShowDialog();
        }

        private Action<object, UpdateShipEventArgs> updateFleets(int fleet, int idx)
        {
            return (object sender, UpdateShipEventArgs e) =>
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (!(i == fleet && j == idx) && e.getShip().Equals(fleets[i, j]))
                        {
                            DialogResult yn = MessageBox.Show("jag aer upptagen just nu... vill du fortsaetta?", "Ship occupied",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (yn == DialogResult.Yes)
                            {
                                fleets[fleet, idx] = e.getShip();
                                fleets[i, j] = null;
                            }
                            return;
                        }
                    }
                }
                fleets[fleet, idx] = e.getShip();
                string s = "";
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        s += fleets[i, j] == null ? "null " : fleets[i, j].Name + " ";
                    }
                    s += "\r\n";
                }
                MessageBox.Show(s);
            };
        }

        private void btnMainFlt2_Click(object sender, EventArgs e)
        {
            AddShip addShip = new AddShip(true);
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleets(0, 1));
            addShip.ShowDialog();
        }

        private void btnMainFlt3_Click(object sender, EventArgs e)
        {
            AddShip addShip = new AddShip(true);
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleets(0, 2));
            addShip.ShowDialog();
        }

        private void btnVanFlt1_Click(object sender, EventArgs e)
        {
            AddShip addShip = new AddShip(true);
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleets(1, 0));
            addShip.ShowDialog();
        }

        private void btnVanFlt2_Click(object sender, EventArgs e)
        {
            AddShip addShip = new AddShip(true);
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleets(1, 1));
            addShip.ShowDialog();
        }

        private void btnVanFlt3_Click(object sender, EventArgs e)
        {
            AddShip addShip = new AddShip(true);
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleets(1, 2));
            addShip.ShowDialog();
        }

        private void btnSubFlt1_Click(object sender, EventArgs e)
        {
            AddShip addShip = new AddShip(true);
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleets(2, 0));
            addShip.ShowDialog();
        }

        private void btnSubFlt2_Click(object sender, EventArgs e)
        {
            AddShip addShip = new AddShip(true);
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleets(2, 1));
            addShip.ShowDialog();
        }

        private void btnSubFlt3_Click(object sender, EventArgs e)
        {
            AddShip addShip = new AddShip(true);
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleets(2, 2));
            addShip.ShowDialog();
        }
    }
}
