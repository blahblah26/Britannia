
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
            this.tpgOffice = new System.Windows.Forms.TabPage();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvShips = new System.Windows.Forms.DataGridView();
            this.dgvGear = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splShipGear)).BeginInit();
            this.splShipGear.Panel1.SuspendLayout();
            this.splShipGear.Panel2.SuspendLayout();
            this.splShipGear.SuspendLayout();
            this.tclDockFleet.SuspendLayout();
            this.tpgDryDock.SuspendLayout();
            this.tpgFleetOrders.SuspendLayout();
            this.tlpFleets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGear)).BeginInit();
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
            this.lblShips.Size = new System.Drawing.Size(468, 35);
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
            // 
            // splShipGear.Panel1
            // 
            this.splShipGear.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splShipGear.Panel1.Controls.Add(this.dgvShips);
            this.splShipGear.Panel1.Controls.Add(this.btnAddShip);
            this.splShipGear.Panel1.Controls.Add(this.lblShips);
            this.splShipGear.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splShipGear.Panel2
            // 
            this.splShipGear.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splShipGear.Panel2.Controls.Add(this.dgvGear);
            this.splShipGear.Panel2.Controls.Add(this.btnAddGear);
            this.splShipGear.Panel2.Controls.Add(this.lblGear);
            this.splShipGear.Panel2.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splShipGear.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splShipGear.Size = new System.Drawing.Size(996, 578);
            this.splShipGear.SplitterDistance = 488;
            this.splShipGear.SplitterWidth = 3;
            this.splShipGear.TabIndex = 3;
            this.splShipGear.TabStop = false;
            // 
            // btnAddShip
            // 
            this.btnAddShip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddShip.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShip.Location = new System.Drawing.Point(187, 534);
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
            this.btnAddGear.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGear.Location = new System.Drawing.Point(195, 534);
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
            this.lblGear.Size = new System.Drawing.Size(485, 35);
            this.lblGear.TabIndex = 0;
            this.lblGear.Text = "Gear";
            this.lblGear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tclDockFleet
            // 
            this.tclDockFleet.Controls.Add(this.tpgDryDock);
            this.tclDockFleet.Controls.Add(this.tpgFleetOrders);
            this.tclDockFleet.Controls.Add(this.tpgOffice);
            this.tclDockFleet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tclDockFleet.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tclDockFleet.Location = new System.Drawing.Point(5, 5);
            this.tclDockFleet.Name = "tclDockFleet";
            this.tclDockFleet.SelectedIndex = 0;
            this.tclDockFleet.Size = new System.Drawing.Size(1024, 631);
            this.tclDockFleet.TabIndex = 4;
            // 
            // tpgDryDock
            // 
            this.tpgDryDock.Controls.Add(this.splShipGear);
            this.tpgDryDock.Location = new System.Drawing.Point(4, 29);
            this.tpgDryDock.Name = "tpgDryDock";
            this.tpgDryDock.Padding = new System.Windows.Forms.Padding(10);
            this.tpgDryDock.Size = new System.Drawing.Size(1016, 598);
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
            // tpgOffice
            // 
            this.tpgOffice.Location = new System.Drawing.Point(4, 29);
            this.tpgOffice.Name = "tpgOffice";
            this.tpgOffice.Padding = new System.Windows.Forms.Padding(3);
            this.tpgOffice.Size = new System.Drawing.Size(1017, 600);
            this.tpgOffice.TabIndex = 2;
            this.tpgOffice.Text = "Office";
            this.tpgOffice.UseVisualStyleBackColor = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // haha
            // 
            this.haha.HeaderText = "Column1";
            this.haha.Name = "haha";
            // 
            // dgvShips
            // 
            this.dgvShips.AllowUserToAddRows = false;
            this.dgvShips.AllowUserToDeleteRows = false;
            this.dgvShips.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShips.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.haha,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvShips.Location = new System.Drawing.Point(10, 55);
            this.dgvShips.Margin = new System.Windows.Forms.Padding(10);
            this.dgvShips.Name = "dgvShips";
            this.dgvShips.Size = new System.Drawing.Size(468, 469);
            this.dgvShips.TabIndex = 3;
            this.dgvShips.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShips_CellContentClick);
            // 
            // dgvGear
            // 
            this.dgvGear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGear.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvGear.Location = new System.Drawing.Point(10, 55);
            this.dgvGear.Margin = new System.Windows.Forms.Padding(10);
            this.dgvGear.Name = "dgvGear";
            this.dgvGear.Size = new System.Drawing.Size(485, 469);
            this.dgvGear.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            // 
            // Britannia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 641);
            this.Controls.Add(this.tclDockFleet);
            this.MinimumSize = new System.Drawing.Size(400, 400);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvShips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGear)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tlpFleets;
        private System.Windows.Forms.TabPage tpgOffice;
        private System.Windows.Forms.DataGridView dgvShips;
        private System.Windows.Forms.DataGridViewTextBoxColumn haha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView dgvGear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}

