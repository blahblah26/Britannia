
namespace Britannia
{
    partial class Britannia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblShips = new System.Windows.Forms.Label();
            this.splShipGear = new System.Windows.Forms.SplitContainer();
            this.btnAddShip = new System.Windows.Forms.Button();
            this.btnAddGear = new System.Windows.Forms.Button();
            this.lblGear = new System.Windows.Forms.Label();
            this.tclDockFleet = new System.Windows.Forms.TabControl();
            this.tpgDryDock = new System.Windows.Forms.TabPage();
            this.tpgFleetOrders = new System.Windows.Forms.TabPage();
            this.tlpFleets = new System.Windows.Forms.TableLayoutPanel();
            this.grpMainFlt = new System.Windows.Forms.GroupBox();
            this.grpSubFlt = new System.Windows.Forms.GroupBox();
            this.grpVan = new System.Windows.Forms.GroupBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splShipGear)).BeginInit();
            this.splShipGear.Panel1.SuspendLayout();
            this.splShipGear.Panel2.SuspendLayout();
            this.splShipGear.SuspendLayout();
            this.tclDockFleet.SuspendLayout();
            this.tpgDryDock.SuspendLayout();
            this.tpgFleetOrders.SuspendLayout();
            this.tlpFleets.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblShips
            // 
            this.lblShips.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShips.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblShips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblShips.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShips.Location = new System.Drawing.Point(10, 10);
            this.lblShips.Margin = new System.Windows.Forms.Padding(0);
            this.lblShips.Name = "lblShips";
            this.lblShips.Size = new System.Drawing.Size(977, 35);
            this.lblShips.TabIndex = 0;
            this.lblShips.Text = "Ships";
            this.lblShips.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splShipGear
            // 
            this.splShipGear.BackColor = System.Drawing.SystemColors.Desktop;
            this.splShipGear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splShipGear.Location = new System.Drawing.Point(10, 10);
            this.splShipGear.Name = "splShipGear";
            this.splShipGear.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splShipGear.Panel1
            // 
            this.splShipGear.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splShipGear.Panel1.Controls.Add(this.btnAddShip);
            this.splShipGear.Panel1.Controls.Add(this.lblShips);
            this.splShipGear.Panel1.Margin = new System.Windows.Forms.Padding(3);
            this.splShipGear.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splShipGear.Panel2
            // 
            this.splShipGear.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splShipGear.Panel2.Controls.Add(this.btnAddGear);
            this.splShipGear.Panel2.Controls.Add(this.lblGear);
            this.splShipGear.Panel2.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splShipGear.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splShipGear.Size = new System.Drawing.Size(997, 580);
            this.splShipGear.SplitterDistance = 289;
            this.splShipGear.SplitterWidth = 5;
            this.splShipGear.TabIndex = 3;
            this.splShipGear.TabStop = false;
            // 
            // btnAddShip
            // 
            this.btnAddShip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddShip.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShip.Location = new System.Drawing.Point(441, 244);
            this.btnAddShip.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddShip.Name = "btnAddShip";
            this.btnAddShip.Size = new System.Drawing.Size(115, 35);
            this.btnAddShip.TabIndex = 2;
            this.btnAddShip.Text = "Add Ship";
            this.btnAddShip.UseVisualStyleBackColor = true;
            this.btnAddShip.Click += new System.EventHandler(this.btnAddShip_Click);
            // 
            // btnAddGear
            // 
            this.btnAddGear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddGear.Location = new System.Drawing.Point(441, 241);
            this.btnAddGear.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddGear.Name = "btnAddGear";
            this.btnAddGear.Size = new System.Drawing.Size(115, 35);
            this.btnAddGear.TabIndex = 1;
            this.btnAddGear.Text = "Add Gear";
            this.btnAddGear.UseVisualStyleBackColor = true;
            this.btnAddGear.Click += new System.EventHandler(this.btnAddGear_Click);
            // 
            // lblGear
            // 
            this.lblGear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGear.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGear.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGear.Location = new System.Drawing.Point(10, 10);
            this.lblGear.Margin = new System.Windows.Forms.Padding(0);
            this.lblGear.Name = "lblGear";
            this.lblGear.Size = new System.Drawing.Size(977, 35);
            this.lblGear.TabIndex = 0;
            this.lblGear.Text = "Gear";
            this.lblGear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tclDockFleet
            // 
            this.tclDockFleet.Controls.Add(this.tpgDryDock);
            this.tclDockFleet.Controls.Add(this.tpgFleetOrders);
            this.tclDockFleet.Controls.Add(this.tabPage1);
            this.tclDockFleet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tclDockFleet.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tclDockFleet.Location = new System.Drawing.Point(5, 5);
            this.tclDockFleet.Name = "tclDockFleet";
            this.tclDockFleet.SelectedIndex = 0;
            this.tclDockFleet.Size = new System.Drawing.Size(1025, 633);
            this.tclDockFleet.TabIndex = 4;
            // 
            // tpgDryDock
            // 
            this.tpgDryDock.Controls.Add(this.splShipGear);
            this.tpgDryDock.Location = new System.Drawing.Point(4, 29);
            this.tpgDryDock.Name = "tpgDryDock";
            this.tpgDryDock.Padding = new System.Windows.Forms.Padding(10);
            this.tpgDryDock.Size = new System.Drawing.Size(1017, 600);
            this.tpgDryDock.TabIndex = 0;
            this.tpgDryDock.Text = "Dry Dock";
            this.tpgDryDock.UseVisualStyleBackColor = true;
            // 
            // tpgFleetOrders
            // 
            this.tpgFleetOrders.Controls.Add(this.tlpFleets);
            this.tpgFleetOrders.Location = new System.Drawing.Point(4, 29);
            this.tpgFleetOrders.Name = "tpgFleetOrders";
            this.tpgFleetOrders.Padding = new System.Windows.Forms.Padding(10);
            this.tpgFleetOrders.Size = new System.Drawing.Size(1017, 600);
            this.tpgFleetOrders.TabIndex = 1;
            this.tpgFleetOrders.Text = "Fleet Orders";
            this.tpgFleetOrders.UseVisualStyleBackColor = true;
            // 
            // tlpFleets
            // 
            this.tlpFleets.BackColor = System.Drawing.SystemColors.Control;
            this.tlpFleets.ColumnCount = 1;
            this.tlpFleets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFleets.Controls.Add(this.grpMainFlt, 0, 0);
            this.tlpFleets.Controls.Add(this.grpSubFlt, 0, 2);
            this.tlpFleets.Controls.Add(this.grpVan, 0, 1);
            this.tlpFleets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFleets.Location = new System.Drawing.Point(10, 10);
            this.tlpFleets.Margin = new System.Windows.Forms.Padding(0);
            this.tlpFleets.Name = "tlpFleets";
            this.tlpFleets.Padding = new System.Windows.Forms.Padding(10);
            this.tlpFleets.RowCount = 3;
            this.tlpFleets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.334F));
            this.tlpFleets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.333F));
            this.tlpFleets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.333F));
            this.tlpFleets.Size = new System.Drawing.Size(997, 580);
            this.tlpFleets.TabIndex = 3;
            // 
            // grpMainFlt
            // 
            this.grpMainFlt.BackColor = System.Drawing.Color.Transparent;
            this.grpMainFlt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMainFlt.Location = new System.Drawing.Point(10, 10);
            this.grpMainFlt.Margin = new System.Windows.Forms.Padding(0);
            this.grpMainFlt.Name = "grpMainFlt";
            this.grpMainFlt.Size = new System.Drawing.Size(977, 186);
            this.grpMainFlt.TabIndex = 0;
            this.grpMainFlt.TabStop = false;
            this.grpMainFlt.Text = "Main Fleet";
            // 
            // grpSubFlt
            // 
            this.grpSubFlt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSubFlt.Location = new System.Drawing.Point(10, 382);
            this.grpSubFlt.Margin = new System.Windows.Forms.Padding(0);
            this.grpSubFlt.Name = "grpSubFlt";
            this.grpSubFlt.Size = new System.Drawing.Size(977, 188);
            this.grpSubFlt.TabIndex = 2;
            this.grpSubFlt.TabStop = false;
            this.grpSubFlt.Text = "Submarine Fleet";
            // 
            // grpVan
            // 
            this.grpVan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpVan.Location = new System.Drawing.Point(10, 196);
            this.grpVan.Margin = new System.Windows.Forms.Padding(0);
            this.grpVan.Name = "grpVan";
            this.grpVan.Size = new System.Drawing.Size(977, 186);
            this.grpVan.TabIndex = 1;
            this.grpVan.TabStop = false;
            this.grpVan.Text = "Vanguard";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1017, 600);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Britannia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 643);
            this.Controls.Add(this.tclDockFleet);
            this.Name = "Britannia";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Britannia";
            this.splShipGear.Panel1.ResumeLayout(false);
            this.splShipGear.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splShipGear)).EndInit();
            this.splShipGear.ResumeLayout(false);
            this.tclDockFleet.ResumeLayout(false);
            this.tpgDryDock.ResumeLayout(false);
            this.tpgFleetOrders.ResumeLayout(false);
            this.tlpFleets.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblShips;
        private System.Windows.Forms.SplitContainer splShipGear;
        private System.Windows.Forms.TabControl tclDockFleet;
        private System.Windows.Forms.TabPage tpgDryDock;
        private System.Windows.Forms.TabPage tpgFleetOrders;
        private System.Windows.Forms.Label lblGear;
        private System.Windows.Forms.GroupBox grpMainFlt;
        private System.Windows.Forms.GroupBox grpSubFlt;
        private System.Windows.Forms.GroupBox grpVan;
        private System.Windows.Forms.Button btnAddShip;
        private System.Windows.Forms.Button btnAddGear;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tlpFleets;
    }
}

