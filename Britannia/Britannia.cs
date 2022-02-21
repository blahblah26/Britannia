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
        // when the im PASTA is SUS!
        public static ImmutableList<Ship> shipCatalogue;
        public static ImmutableList<Gear> gearCatalogue;
        public static SortableBL<Ship> ships;
        public static SortableBL<Gear> gears;
        public static BindingList<Ship> availableShips;
        public static Ship[][] fleets;
        private static int[][] stats; // AP stats
        
        // op
        private string cataloguePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\catalogue.txt";
        private string gCataloguePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\gcatalogue.txt";
        private string shipPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ships.txt";
        private string gearPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\gears.txt";
        private string availablePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\available.txt";
        private string fleetPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\fleets.txt";
        private string statPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\stats.txt";

        private static JsonSerializerOptions options = new JsonSerializerOptions
        {
            IncludeFields = true,
            PropertyNameCaseInsensitive = true
            // yeet
        };
        
        public Britannia()
        {
            // initialize components
            InitializeComponent();
           
            

            // imayine
        }

        private void btnAddShip_Click(object sender, EventArgs e)
        {

            AddShip addShip = new AddShip(availableShips);
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateShips);
            addShip.ShowDialog();
        }

        private void updateShips(object sender, UpdateShipEventArgs e)
        {
            if (!ships.Contains(e.getShip()))
            {
                ships.Add(e.getShip());
                
                //MessageBox.Show("Added " + e.getShip().ToString());
                SortableBL<Ship> tmp = new SortableBL<Ship>();
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
            AddGear addGear = new AddGear(gearCatalogue);
            addGear.UpdateGear += new AddGear.UpdateGearHandler(updateGear);
            addGear.ShowDialog();

            //MessageBox.Show("Thish shectiawn washn't impwwemented nyeet~\r\npwweashe be pwatient nyaa~");
        }

        private void updateGear(object sender, UpdateGearEventArgs e)
        {
            if (!gears.Contains(e.getGear()))
            {
                gears.Add(e.getGear());
            }
        }

        private void dgvShips_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // aya am ded uwu
            // --babus
        }

        private void Britannia_Load(object sender, EventArgs e)
        {
            dgvGear.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvShips.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvGear.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvShips.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
            /*
            if (!File.Exists(gCataloguePath))
            {
                throw new FileNotFoundException("jag aelskar min flickvaen, ingen tid att hitta din fil");
            }
            string gCatalogueJSON = File.ReadAllText(gCataloguePath);
            try
            {
                gearCatalogue = JsonSerializer.Deserialize<ImmutableList<Gear>>(gCatalogueJSON, options);
            }
            catch
            {
                MessageBox.Show("json aer inte lika trevlig som min flickvaen", "Unable to read data",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
                return;
            }

            // Good code
            */
            if (File.Exists(shipPath))
            {
                string shipJSON = File.ReadAllText(shipPath);
                try
                {
                    ships = JsonSerializer.Deserialize<SortableBL<Ship>>(shipJSON, options);
                }
                catch (JsonException)
                {
                    MessageBox.Show("json aer inte lika trevlig som min flickvaen", "Unable to weed data",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ships = new SortableBL<Ship>(); //mayday
                }
            }
            else
            {
                ships = new SortableBL<Ship>();
            }

            if (File.Exists(gearPath))
            {
                string gearJSON = File.ReadAllText(gearPath);
                try
                {
                    gears = JsonSerializer.Deserialize<SortableBL<Gear>>(gearJSON, options);
                }
                catch (JsonException)
                {
                    MessageBox.Show("json aer inte lika trevlig som min flickvaen", "Unable to read data",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gears = new SortableBL<Gear>();
                }
            }
            else
            {
                gears = new SortableBL<Gear>();
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
                availableShips = new BindingList<Ship>(shipCatalogue); //boop
            }

            if (File.Exists(fleetPath))
            {
                string fleetJSON = File.ReadAllText(fleetPath);
                try
                {
                    fleets = JsonSerializer.Deserialize<Ship[][]>(fleetJSON, options);
                }
                catch (JsonException)
                {
                    MessageBox.Show("json aer inte lika trevlig som min flickvaen", "Unable to read data",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fleets = new Ship[3][];
                    fleets[0] = new Ship[3];
                    fleets[1] = new Ship[3];
                    fleets[2] = new Ship[3];

                }
            }
            else
            {
                fleets = new Ship[3][];
                fleets[0] = new Ship[3];
                fleets[1] = new Ship[3];
                fleets[2] = new Ship[3];
            }

            if (File.Exists(statPath))
            {
                string statJSON = File.ReadAllText(statPath);
                try
                {
                    stats = JsonSerializer.Deserialize<int[][]>(statJSON, options);
                }
                catch (JsonException)
                {
                    MessageBox.Show("json aer inte lika trevlig som min flickvaen", "Unable to read data",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    stats = new int[3][];
                    stats[0] = new int[6];//kekw
                    stats[1] = new int[6];
                    stats[2] = new int[6];

                }
            }
            else
            {
                stats = new int[3][];
                stats[0] = new int[6];
                stats[1] = new int[6];
                stats[2] = new int[6];
            }

            if (availableShips.Count == 0)
            {
                btnAddShip.Enabled = false;
            }
            dgvShips.DataSource = ships;
            dgvGear.DataSource = gears;
            lbxMain.SelectedIndex = 0;
            lbxVan.SelectedIndex = 0;
            lbxSub.SelectedIndex = 0;

            dgvShips.Columns[11].HeaderText = "Slot 1";
            dgvShips.Columns[12].HeaderText = "Slot 2";
            dgvShips.Columns[13].HeaderText = "Slot 3";

         
        }

        private void Britannia_FormClosing(object sender, EventArgs e)
        {
            string tmp = JsonSerializer.Serialize(shipCatalogue, options);
            File.WriteAllText(cataloguePath, tmp);
            tmp = JsonSerializer.Serialize(ships, options);
            File.WriteAllText(shipPath, tmp);
            tmp = JsonSerializer.Serialize(gears, options);
            File.WriteAllText(gearPath, tmp);
            tmp = JsonSerializer.Serialize(availableShips, options);
            File.WriteAllText(availablePath, tmp);
            tmp = JsonSerializer.Serialize(fleets, options);
            File.WriteAllText(fleetPath, tmp);
            tmp = JsonSerializer.Serialize(stats, options);
            File.WriteAllText(statPath, tmp);
        }

        private void btnMainFlt1_Click(object sender, EventArgs e)
        {
            AddShip addShip = new AddShip(new BindingList<Ship>(ships.Where(s => (s.Type &
            (ShipTypes.AR | ShipTypes.BB | ShipTypes.BC | ShipTypes.BBV | ShipTypes.BM | ShipTypes.CV | ShipTypes.CVL)) != ShipTypes.NA).ToList()));
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleets(0, 0));
            
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleetData(0));
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleetPics);
            addShip.ShowDialog();
            
        }

        private void updateFleetPics(object sender, UpdateShipEventArgs e)
        {
            if (fleets[0][0] != null)
            {
                try
                {
                    picMainFlt1.ImageLocation = fleets[0][0].Image;
                } catch
                {
                    picMainFlt1.Image = picMainFlt1.ErrorImage;
                }
            }
            if (fleets[0][1] != null)
            {
                try
                {
                    picMainFlt2.ImageLocation = fleets[0][1].Image;
                }
                catch
                {
                    picMainFlt2.Image = picMainFlt2.ErrorImage;
                }
            }
            if (fleets[0][2] != null)
            {
                try
                {
                    picMainFlt3.ImageLocation = fleets[0][2].Image;
                }
                catch
                {
                    picMainFlt3.Image = picMainFlt3.ErrorImage;
                }
            }
            if (fleets[1][0] != null)
            {
                try
                {
                    picVanFlt1.ImageLocation = fleets[1][0].Image;
                }
                catch
                {
                    picVanFlt1.Image = picVanFlt1.ErrorImage;
                }
            }
            if (fleets[1][1] != null)
            {
                try
                {
                    picVanFlt2.ImageLocation = fleets[1][1].Image;
                }
                catch
                {
                    picVanFlt2.Image = picVanFlt2.ErrorImage;
                }
            }
            if (fleets[1][2] != null)
            {
                try
                {
                    picVanFlt3.ImageLocation = fleets[1][2].Image;
                }
                catch
                {
                    picVanFlt3.Image = picVanFlt3.ErrorImage;
                }
            }
            if (fleets[2][0] != null)
            {
                try
                {
                    picSubFlt1.ImageLocation = fleets[2][0].Image;
                }
                catch
                {
                    picSubFlt1.Image = picSubFlt1.ErrorImage;
                }
            }
            if (fleets[2][1] != null)
            {
                try
                {
                    picSubFlt2.ImageLocation = fleets[2][1].Image;
                }
                catch
                {
                    picSubFlt2.Image = picSubFlt2.ErrorImage;
                }
            }
            if (fleets[2][2] != null)
            {
                try
                {
                    picSubFlt3.ImageLocation = fleets[2][2].Image;
                }
                catch
                {
                    picSubFlt3.Image = picSubFlt3.ErrorImage;
                }
            }

        }

        private Action<object, UpdateShipEventArgs> updateFleetData(int fleet)
        {
            return (object sender, UpdateShipEventArgs e) =>
            {
                stats[fleet][0] = 0;
                stats[fleet][1] = 0;
                stats[fleet][2] = 0;
                stats[fleet][3] = 0;
                stats[fleet][4] = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (fleets[fleet][i] != null) {

                        stats[fleet][0] += fleets[fleet][i].Firepower;
                        stats[fleet][1] += fleets[fleet][i].AirPower;
                        stats[fleet][2] += fleets[fleet][i].Torpedo;
                        stats[fleet][3] += fleets[fleet][i].Evasion;
                        stats[fleet][4] += fleets[fleet][i].AA;

                    }
                }
                stats[fleet][5] = (int) Math.Round(Math.Pow(stats[fleet][1] + stats[fleet][3], 2.0 / 3.0));
                lbxVan_SelectedIndexChanged(sender, e);
                lbxMain_SelectedIndexChanged(sender, e);
                lbxSub_SelectedIndexChanged(sender, e);
            };
        }
        private Action<object, UpdateShipEventArgs> updateFleets(int fleet, int idx)
        {
            return (object sender, UpdateShipEventArgs e) =>
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (!(i == fleet && j == idx) && e.getShip().Equals(fleets[i][j]))
                        {
                            DialogResult yn = MessageBox.Show("jag aer upptagen just nu... vill du fortsaetta?", "Ship occupied",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (yn == DialogResult.Yes)
                            {
                                fleets[fleet][idx] = e.getShip();
                                fleets[i][j] = null;
                            }
                            return;
                        }
                    }
                }
                fleets[fleet][idx] = e.getShip();
                
            };
        }

        private void btnMainFlt2_Click(object sender, EventArgs e)
        {
            AddShip addShip = new AddShip(new BindingList<Ship>(ships.Where(s => (s.Type &
            (ShipTypes.AR | ShipTypes.BB | ShipTypes.BC | ShipTypes.BBV | ShipTypes.BM | ShipTypes.CV | ShipTypes.CVL)) != ShipTypes.NA).ToList()));
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleets(0, 1));
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleetData(0));
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleetPics);
            addShip.ShowDialog();
        }

        private void btnMainFlt3_Click(object sender, EventArgs e)
        {
            AddShip addShip = new AddShip(new BindingList<Ship>(ships.Where(s => (s.Type &
            (ShipTypes.AR | ShipTypes.BB | ShipTypes.BC | ShipTypes.BBV | ShipTypes.BM | ShipTypes.CV | ShipTypes.CVL)) != ShipTypes.NA).ToList()));
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleets(0, 2));
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleetData(0));
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleetPics);
            addShip.ShowDialog();
        }

        private void btnVanFlt1_Click(object sender, EventArgs e)
        {
            AddShip addShip = new AddShip(new BindingList<Ship>(ships.Where(s => (s.Type &
            (ShipTypes.AE | ShipTypes.CA | ShipTypes.CB | ShipTypes.CL | ShipTypes.DD)) != ShipTypes.NA).ToList()));
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleets(1, 0));
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleetData(1));
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleetPics);
            addShip.ShowDialog();
        }

        private void btnVanFlt2_Click(object sender, EventArgs e)
        {
            AddShip addShip = new AddShip(new BindingList<Ship>(ships.Where(s => (s.Type &
            (ShipTypes.AE | ShipTypes.CA | ShipTypes.CB | ShipTypes.CL | ShipTypes.DD)) != ShipTypes.NA).ToList()));
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleets(1, 1));
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleetData(1));
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleetPics);
            addShip.ShowDialog();
        }

        private void btnVanFlt3_Click(object sender, EventArgs e)
        {
            AddShip addShip = new AddShip(new BindingList<Ship>(ships.Where(s => (s.Type &
            (ShipTypes.AE | ShipTypes.CA | ShipTypes.CB | ShipTypes.CL | ShipTypes.DD)) != ShipTypes.NA).ToList()));
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleets(1, 2));
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleetData(1));
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleetPics);
            addShip.ShowDialog();
        }

        private void btnSubFlt1_Click(object sender, EventArgs e)
        {
            AddShip addShip = new AddShip(new BindingList<Ship>(ships.Where(s => (s.Type &
            (ShipTypes.SS | ShipTypes.SSV)) != ShipTypes.NA).ToList()));
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleets(2, 0));
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleetData(2));
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleetPics);
            addShip.ShowDialog();
        }

        private void btnSubFlt2_Click(object sender, EventArgs e)
        {
            AddShip addShip = new AddShip(new BindingList<Ship>(ships.Where(s => (s.Type &
            (ShipTypes.SS | ShipTypes.SSV)) != ShipTypes.NA).ToList()));
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleets(2, 1));
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleetData(2));
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleetPics);
            addShip.ShowDialog();
        }

        private void btnSubFlt3_Click(object sender, EventArgs e)
        {
            AddShip addShip = new AddShip(new BindingList<Ship>(ships.Where(s => (s.Type &
            (ShipTypes.SS | ShipTypes.SSV)) != ShipTypes.NA).ToList()));
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleets(2, 2));
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleetData(2));
            addShip.UpdateShip += new AddShip.UpdateShipHandler(updateFleetPics);
            addShip.ShowDialog();
        }

        private void tlpOrders_Paint(object sender, PaintEventArgs e)
        {
            // sus!!!!!
        }

        private void lbxMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMain.Text = stats[0][lbxMain.SelectedIndex].ToString();
        }

        private void lbxVan_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblVan.Text = stats[1][lbxVan.SelectedIndex].ToString();
        }

        private void lbxSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSub.Text = stats[2][lbxSub.SelectedIndex].ToString();
        }
    }
}
