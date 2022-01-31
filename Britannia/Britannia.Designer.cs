
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
            this.tpgFleetOrders = new System.Windows.Forms.TabPage();
            this.tlpOrders = new System.Windows.Forms.TableLayoutPanel();
            this.grpVan = new System.Windows.Forms.GroupBox();
            this.tlpVanFlt = new System.Windows.Forms.TableLayoutPanel();
            this.lblVan = new System.Windows.Forms.Label();
            this.lbxVan = new System.Windows.Forms.ListBox();
            this.picVanFlt1 = new System.Windows.Forms.PictureBox();
            this.picVanFlt2 = new System.Windows.Forms.PictureBox();
            this.picVanFlt3 = new System.Windows.Forms.PictureBox();
            this.btnVanFlt1 = new System.Windows.Forms.Button();
            this.btnVanFlt2 = new System.Windows.Forms.Button();
            this.btnVanFlt3 = new System.Windows.Forms.Button();
            this.grpMainFlt = new System.Windows.Forms.GroupBox();
            this.tlpMainFlt = new System.Windows.Forms.TableLayoutPanel();
            this.picMainFlt1 = new System.Windows.Forms.PictureBox();
            this.picMainFlt2 = new System.Windows.Forms.PictureBox();
            this.picMainFlt3 = new System.Windows.Forms.PictureBox();
            this.btnMainFlt1 = new System.Windows.Forms.Button();
            this.btnMainFlt2 = new System.Windows.Forms.Button();
            this.btnMainFlt3 = new System.Windows.Forms.Button();
            this.lbxMain = new System.Windows.Forms.ListBox();
            this.lblMain = new System.Windows.Forms.Label();
            this.grpSubFlt = new System.Windows.Forms.GroupBox();
            this.tlpSubFlt = new System.Windows.Forms.TableLayoutPanel();
            this.lblSub = new System.Windows.Forms.Label();
            this.lbxSub = new System.Windows.Forms.ListBox();
            this.picSubFlt1 = new System.Windows.Forms.PictureBox();
            this.picSubFlt2 = new System.Windows.Forms.PictureBox();
            this.picSubFlt3 = new System.Windows.Forms.PictureBox();
            this.btnSubFlt1 = new System.Windows.Forms.Button();
            this.btnSubFlt2 = new System.Windows.Forms.Button();
            this.btnSubFlt3 = new System.Windows.Forms.Button();
            this.tpgDryDock = new System.Windows.Forms.TabPage();
            this.splShipGear = new System.Windows.Forms.SplitContainer();
            this.txtShipSearch = new System.Windows.Forms.TextBox();
            this.dgvShips = new System.Windows.Forms.DataGridView();
            this.btnAddShip = new System.Windows.Forms.Button();
            this.lblShips = new System.Windows.Forms.Label();
            this.txtGearSearch = new System.Windows.Forms.TextBox();
            this.dgvGear = new System.Windows.Forms.DataGridView();
            this.btnAddGear = new System.Windows.Forms.Button();
            this.lblGear = new System.Windows.Forms.Label();
            this.tclDockFleet = new System.Windows.Forms.TabControl();
            this.tpgFleetOrders.SuspendLayout();
            this.tlpOrders.SuspendLayout();
            this.grpVan.SuspendLayout();
            this.tlpVanFlt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVanFlt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVanFlt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVanFlt3)).BeginInit();
            this.grpMainFlt.SuspendLayout();
            this.tlpMainFlt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainFlt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainFlt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainFlt3)).BeginInit();
            this.grpSubFlt.SuspendLayout();
            this.tlpSubFlt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSubFlt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSubFlt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSubFlt3)).BeginInit();
            this.tpgDryDock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splShipGear)).BeginInit();
            this.splShipGear.Panel1.SuspendLayout();
            this.splShipGear.Panel2.SuspendLayout();
            this.splShipGear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGear)).BeginInit();
            this.tclDockFleet.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpgFleetOrders
            // 
            this.tpgFleetOrders.Controls.Add(this.tlpOrders);
            this.tpgFleetOrders.Location = new System.Drawing.Point(4, 29);
            this.tpgFleetOrders.Name = "tpgFleetOrders";
            this.tpgFleetOrders.Padding = new System.Windows.Forms.Padding(10);
            this.tpgFleetOrders.Size = new System.Drawing.Size(1016, 598);
            this.tpgFleetOrders.TabIndex = 1;
            this.tpgFleetOrders.Text = "Fleet Orders";
            this.tpgFleetOrders.UseVisualStyleBackColor = true;
            // 
            // tlpOrders
            // 
            this.tlpOrders.ColumnCount = 1;
            this.tlpOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOrders.Controls.Add(this.grpVan, 0, 1);
            this.tlpOrders.Controls.Add(this.grpMainFlt, 0, 0);
            this.tlpOrders.Controls.Add(this.grpSubFlt, 0, 2);
            this.tlpOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOrders.Location = new System.Drawing.Point(10, 10);
            this.tlpOrders.Name = "tlpOrders";
            this.tlpOrders.RowCount = 3;
            this.tlpOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpOrders.Size = new System.Drawing.Size(996, 578);
            this.tlpOrders.TabIndex = 4;
            this.tlpOrders.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpOrders_Paint);
            // 
            // grpVan
            // 
            this.grpVan.Controls.Add(this.tlpVanFlt);
            this.grpVan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpVan.Location = new System.Drawing.Point(0, 192);
            this.grpVan.Margin = new System.Windows.Forms.Padding(0);
            this.grpVan.Name = "grpVan";
            this.grpVan.Padding = new System.Windows.Forms.Padding(5);
            this.grpVan.Size = new System.Drawing.Size(996, 192);
            this.grpVan.TabIndex = 1;
            this.grpVan.TabStop = false;
            this.grpVan.Text = "Vanguard";
            // 
            // tlpVanFlt
            // 
            this.tlpVanFlt.ColumnCount = 4;
            this.tlpVanFlt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpVanFlt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpVanFlt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpVanFlt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpVanFlt.Controls.Add(this.lblVan, 3, 1);
            this.tlpVanFlt.Controls.Add(this.lbxVan, 3, 0);
            this.tlpVanFlt.Controls.Add(this.picVanFlt1, 0, 0);
            this.tlpVanFlt.Controls.Add(this.picVanFlt2, 1, 0);
            this.tlpVanFlt.Controls.Add(this.picVanFlt3, 2, 0);
            this.tlpVanFlt.Controls.Add(this.btnVanFlt1, 0, 1);
            this.tlpVanFlt.Controls.Add(this.btnVanFlt2, 1, 1);
            this.tlpVanFlt.Controls.Add(this.btnVanFlt3, 2, 1);
            this.tlpVanFlt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVanFlt.Location = new System.Drawing.Point(5, 25);
            this.tlpVanFlt.Name = "tlpVanFlt";
            this.tlpVanFlt.RowCount = 2;
            this.tlpVanFlt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVanFlt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpVanFlt.Size = new System.Drawing.Size(986, 162);
            this.tlpVanFlt.TabIndex = 1;
            // 
            // lblVan
            // 
            this.lblVan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVan.Location = new System.Drawing.Point(743, 127);
            this.lblVan.Margin = new System.Windows.Forms.Padding(5);
            this.lblVan.Name = "lblVan";
            this.lblVan.Size = new System.Drawing.Size(238, 30);
            this.lblVan.TabIndex = 8;
            this.lblVan.Text = "0";
            this.lblVan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxVan
            // 
            this.lbxVan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxVan.FormattingEnabled = true;
            this.lbxVan.ItemHeight = 20;
            this.lbxVan.Items.AddRange(new object[] {
            "Firepower",
            "Air Power",
            "Torpedo",
            "Evasion",
            "AA",
            "Recon"});
            this.lbxVan.Location = new System.Drawing.Point(743, 5);
            this.lbxVan.Margin = new System.Windows.Forms.Padding(5);
            this.lbxVan.Name = "lbxVan";
            this.lbxVan.Size = new System.Drawing.Size(238, 112);
            this.lbxVan.TabIndex = 7;
            this.lbxVan.SelectedIndexChanged += new System.EventHandler(this.lbxVan_SelectedIndexChanged);
            // 
            // picVanFlt1
            // 
            this.picVanFlt1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picVanFlt1.ErrorImage = global::Britannia.Properties.Resources._96px_Unknown_Ships;
            this.picVanFlt1.Image = global::Britannia.Properties.Resources._96px_Unknown_Ships;
            this.picVanFlt1.InitialImage = global::Britannia.Properties.Resources._96px_Unknown_Ships;
            this.picVanFlt1.Location = new System.Drawing.Point(5, 5);
            this.picVanFlt1.Margin = new System.Windows.Forms.Padding(5);
            this.picVanFlt1.Name = "picVanFlt1";
            this.picVanFlt1.Size = new System.Drawing.Size(236, 112);
            this.picVanFlt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVanFlt1.TabIndex = 0;
            this.picVanFlt1.TabStop = false;
            // 
            // picVanFlt2
            // 
            this.picVanFlt2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picVanFlt2.ErrorImage = global::Britannia.Properties.Resources._96px_Unknown_Ships;
            this.picVanFlt2.Image = global::Britannia.Properties.Resources._96px_Unknown_Ships;
            this.picVanFlt2.InitialImage = global::Britannia.Properties.Resources._96px_Unknown_Ships;
            this.picVanFlt2.Location = new System.Drawing.Point(251, 5);
            this.picVanFlt2.Margin = new System.Windows.Forms.Padding(5);
            this.picVanFlt2.Name = "picVanFlt2";
            this.picVanFlt2.Size = new System.Drawing.Size(236, 112);
            this.picVanFlt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVanFlt2.TabIndex = 1;
            this.picVanFlt2.TabStop = false;
            // 
            // picVanFlt3
            // 
            this.picVanFlt3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picVanFlt3.ErrorImage = global::Britannia.Properties.Resources._96px_Unknown_Ships;
            this.picVanFlt3.Image = global::Britannia.Properties.Resources._96px_Unknown_Ships;
            this.picVanFlt3.InitialImage = global::Britannia.Properties.Resources._96px_Unknown_Ships;
            this.picVanFlt3.Location = new System.Drawing.Point(497, 5);
            this.picVanFlt3.Margin = new System.Windows.Forms.Padding(5);
            this.picVanFlt3.Name = "picVanFlt3";
            this.picVanFlt3.Size = new System.Drawing.Size(236, 112);
            this.picVanFlt3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVanFlt3.TabIndex = 2;
            this.picVanFlt3.TabStop = false;
            // 
            // btnVanFlt1
            // 
            this.btnVanFlt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnVanFlt1.Location = new System.Drawing.Point(73, 127);
            this.btnVanFlt1.Margin = new System.Windows.Forms.Padding(5);
            this.btnVanFlt1.Name = "btnVanFlt1";
            this.btnVanFlt1.Size = new System.Drawing.Size(100, 30);
            this.btnVanFlt1.TabIndex = 3;
            this.btnVanFlt1.Text = "Select";
            this.btnVanFlt1.UseVisualStyleBackColor = true;
            this.btnVanFlt1.Click += new System.EventHandler(this.btnVanFlt1_Click);
            // 
            // btnVanFlt2
            // 
            this.btnVanFlt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnVanFlt2.Location = new System.Drawing.Point(319, 127);
            this.btnVanFlt2.Margin = new System.Windows.Forms.Padding(5);
            this.btnVanFlt2.Name = "btnVanFlt2";
            this.btnVanFlt2.Size = new System.Drawing.Size(100, 30);
            this.btnVanFlt2.TabIndex = 4;
            this.btnVanFlt2.Text = "Select";
            this.btnVanFlt2.UseVisualStyleBackColor = true;
            this.btnVanFlt2.Click += new System.EventHandler(this.btnVanFlt2_Click);
            // 
            // btnVanFlt3
            // 
            this.btnVanFlt3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnVanFlt3.Location = new System.Drawing.Point(565, 127);
            this.btnVanFlt3.Margin = new System.Windows.Forms.Padding(5);
            this.btnVanFlt3.Name = "btnVanFlt3";
            this.btnVanFlt3.Size = new System.Drawing.Size(100, 30);
            this.btnVanFlt3.TabIndex = 5;
            this.btnVanFlt3.Text = "Select";
            this.btnVanFlt3.UseVisualStyleBackColor = true;
            this.btnVanFlt3.Click += new System.EventHandler(this.btnVanFlt3_Click);
            // 
            // grpMainFlt
            // 
            this.grpMainFlt.BackColor = System.Drawing.Color.Transparent;
            this.grpMainFlt.Controls.Add(this.tlpMainFlt);
            this.grpMainFlt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMainFlt.Location = new System.Drawing.Point(0, 0);
            this.grpMainFlt.Margin = new System.Windows.Forms.Padding(0);
            this.grpMainFlt.Name = "grpMainFlt";
            this.grpMainFlt.Padding = new System.Windows.Forms.Padding(5);
            this.grpMainFlt.Size = new System.Drawing.Size(996, 192);
            this.grpMainFlt.TabIndex = 0;
            this.grpMainFlt.TabStop = false;
            this.grpMainFlt.Text = "Main Fleet";
            // 
            // tlpMainFlt
            // 
            this.tlpMainFlt.ColumnCount = 4;
            this.tlpMainFlt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMainFlt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMainFlt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMainFlt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMainFlt.Controls.Add(this.picMainFlt1, 0, 0);
            this.tlpMainFlt.Controls.Add(this.picMainFlt2, 1, 0);
            this.tlpMainFlt.Controls.Add(this.picMainFlt3, 2, 0);
            this.tlpMainFlt.Controls.Add(this.btnMainFlt1, 0, 1);
            this.tlpMainFlt.Controls.Add(this.btnMainFlt2, 1, 1);
            this.tlpMainFlt.Controls.Add(this.btnMainFlt3, 2, 1);
            this.tlpMainFlt.Controls.Add(this.lbxMain, 3, 0);
            this.tlpMainFlt.Controls.Add(this.lblMain, 3, 1);
            this.tlpMainFlt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainFlt.Location = new System.Drawing.Point(5, 25);
            this.tlpMainFlt.Name = "tlpMainFlt";
            this.tlpMainFlt.RowCount = 2;
            this.tlpMainFlt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainFlt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMainFlt.Size = new System.Drawing.Size(986, 162);
            this.tlpMainFlt.TabIndex = 0;
            // 
            // picMainFlt1
            // 
            this.picMainFlt1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picMainFlt1.ErrorImage = global::Britannia.Properties.Resources._96px_Unknown_Ships;
            this.picMainFlt1.Image = global::Britannia.Properties.Resources._96px_Unknown_Ships;
            this.picMainFlt1.InitialImage = global::Britannia.Properties.Resources._96px_Unknown_Ships;
            this.picMainFlt1.Location = new System.Drawing.Point(5, 5);
            this.picMainFlt1.Margin = new System.Windows.Forms.Padding(5);
            this.picMainFlt1.Name = "picMainFlt1";
            this.picMainFlt1.Size = new System.Drawing.Size(236, 112);
            this.picMainFlt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMainFlt1.TabIndex = 0;
            this.picMainFlt1.TabStop = false;
            // 
            // picMainFlt2
            // 
            this.picMainFlt2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picMainFlt2.ErrorImage = global::Britannia.Properties.Resources._96px_Unknown_Ships;
            this.picMainFlt2.Image = global::Britannia.Properties.Resources._96px_Unknown_Ships;
            this.picMainFlt2.InitialImage = global::Britannia.Properties.Resources._96px_Unknown_Ships;
            this.picMainFlt2.Location = new System.Drawing.Point(251, 5);
            this.picMainFlt2.Margin = new System.Windows.Forms.Padding(5);
            this.picMainFlt2.Name = "picMainFlt2";
            this.picMainFlt2.Size = new System.Drawing.Size(236, 112);
            this.picMainFlt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMainFlt2.TabIndex = 1;
            this.picMainFlt2.TabStop = false;
            // 
            // picMainFlt3
            // 
            this.picMainFlt3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picMainFlt3.ErrorImage = global::Britannia.Properties.Resources._96px_Unknown_Ships;
            this.picMainFlt3.Image = global::Britannia.Properties.Resources._96px_Unknown_Ships;
            this.picMainFlt3.InitialImage = global::Britannia.Properties.Resources._96px_Unknown_Ships;
            this.picMainFlt3.Location = new System.Drawing.Point(497, 5);
            this.picMainFlt3.Margin = new System.Windows.Forms.Padding(5);
            this.picMainFlt3.Name = "picMainFlt3";
            this.picMainFlt3.Size = new System.Drawing.Size(236, 112);
            this.picMainFlt3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMainFlt3.TabIndex = 2;
            this.picMainFlt3.TabStop = false;
            // 
            // btnMainFlt1
            // 
            this.btnMainFlt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnMainFlt1.Location = new System.Drawing.Point(73, 127);
            this.btnMainFlt1.Margin = new System.Windows.Forms.Padding(5);
            this.btnMainFlt1.Name = "btnMainFlt1";
            this.btnMainFlt1.Size = new System.Drawing.Size(100, 30);
            this.btnMainFlt1.TabIndex = 3;
            this.btnMainFlt1.Text = "Select";
            this.btnMainFlt1.UseVisualStyleBackColor = true;
            this.btnMainFlt1.Click += new System.EventHandler(this.btnMainFlt1_Click);
            // 
            // btnMainFlt2
            // 
            this.btnMainFlt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnMainFlt2.Location = new System.Drawing.Point(319, 127);
            this.btnMainFlt2.Margin = new System.Windows.Forms.Padding(5);
            this.btnMainFlt2.Name = "btnMainFlt2";
            this.btnMainFlt2.Size = new System.Drawing.Size(100, 30);
            this.btnMainFlt2.TabIndex = 4;
            this.btnMainFlt2.Text = "Select";
            this.btnMainFlt2.UseVisualStyleBackColor = true;
            this.btnMainFlt2.Click += new System.EventHandler(this.btnMainFlt2_Click);
            // 
            // btnMainFlt3
            // 
            this.btnMainFlt3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnMainFlt3.Location = new System.Drawing.Point(565, 127);
            this.btnMainFlt3.Margin = new System.Windows.Forms.Padding(5);
            this.btnMainFlt3.Name = "btnMainFlt3";
            this.btnMainFlt3.Size = new System.Drawing.Size(100, 30);
            this.btnMainFlt3.TabIndex = 5;
            this.btnMainFlt3.Text = "Select";
            this.btnMainFlt3.UseVisualStyleBackColor = true;
            this.btnMainFlt3.Click += new System.EventHandler(this.btnMainFlt3_Click);
            // 
            // lbxMain
            // 
            this.lbxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxMain.FormattingEnabled = true;
            this.lbxMain.ItemHeight = 20;
            this.lbxMain.Items.AddRange(new object[] {
            "Firepower",
            "Air Power",
            "Torpedo",
            "Evasion",
            "AA",
            "Recon"});
            this.lbxMain.Location = new System.Drawing.Point(743, 5);
            this.lbxMain.Margin = new System.Windows.Forms.Padding(5);
            this.lbxMain.Name = "lbxMain";
            this.lbxMain.Size = new System.Drawing.Size(238, 112);
            this.lbxMain.TabIndex = 6;
            this.lbxMain.SelectedIndexChanged += new System.EventHandler(this.lbxMain_SelectedIndexChanged);
            // 
            // lblMain
            // 
            this.lblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMain.Location = new System.Drawing.Point(743, 127);
            this.lblMain.Margin = new System.Windows.Forms.Padding(5);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(238, 30);
            this.lblMain.TabIndex = 7;
            this.lblMain.Text = "0";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpSubFlt
            // 
            this.grpSubFlt.Controls.Add(this.tlpSubFlt);
            this.grpSubFlt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSubFlt.Location = new System.Drawing.Point(0, 384);
            this.grpSubFlt.Margin = new System.Windows.Forms.Padding(0);
            this.grpSubFlt.Name = "grpSubFlt";
            this.grpSubFlt.Padding = new System.Windows.Forms.Padding(5);
            this.grpSubFlt.Size = new System.Drawing.Size(996, 194);
            this.grpSubFlt.TabIndex = 2;
            this.grpSubFlt.TabStop = false;
            this.grpSubFlt.Text = "Submarine Fleet";
            // 
            // tlpSubFlt
            // 
            this.tlpSubFlt.ColumnCount = 4;
            this.tlpSubFlt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSubFlt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSubFlt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSubFlt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSubFlt.Controls.Add(this.lblSub, 3, 1);
            this.tlpSubFlt.Controls.Add(this.lbxSub, 3, 0);
            this.tlpSubFlt.Controls.Add(this.picSubFlt1, 0, 0);
            this.tlpSubFlt.Controls.Add(this.picSubFlt2, 1, 0);
            this.tlpSubFlt.Controls.Add(this.picSubFlt3, 2, 0);
            this.tlpSubFlt.Controls.Add(this.btnSubFlt1, 0, 1);
            this.tlpSubFlt.Controls.Add(this.btnSubFlt2, 1, 1);
            this.tlpSubFlt.Controls.Add(this.btnSubFlt3, 2, 1);
            this.tlpSubFlt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSubFlt.Location = new System.Drawing.Point(5, 25);
            this.tlpSubFlt.Name = "tlpSubFlt";
            this.tlpSubFlt.RowCount = 2;
            this.tlpSubFlt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSubFlt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpSubFlt.Size = new System.Drawing.Size(986, 164);
            this.tlpSubFlt.TabIndex = 1;
            // 
            // lblSub
            // 
            this.lblSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSub.Location = new System.Drawing.Point(743, 129);
            this.lblSub.Margin = new System.Windows.Forms.Padding(5);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(238, 30);
            this.lblSub.TabIndex = 9;
            this.lblSub.Text = "0";
            this.lblSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxSub
            // 
            this.lbxSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxSub.FormattingEnabled = true;
            this.lbxSub.ItemHeight = 20;
            this.lbxSub.Items.AddRange(new object[] {
            "Firepower",
            "Air Power",
            "Torpedo",
            "Evasion",
            "AA",
            "Recon"});
            this.lbxSub.Location = new System.Drawing.Point(743, 5);
            this.lbxSub.Margin = new System.Windows.Forms.Padding(5);
            this.lbxSub.Name = "lbxSub";
            this.lbxSub.Size = new System.Drawing.Size(238, 114);
            this.lbxSub.TabIndex = 8;
            this.lbxSub.SelectedIndexChanged += new System.EventHandler(this.lbxSub_SelectedIndexChanged);
            // 
            // picSubFlt1
            // 
            this.picSubFlt1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picSubFlt1.ErrorImage = global::Britannia.Properties.Resources._96px_Unknown_Ships;
            this.picSubFlt1.Image = global::Britannia.Properties.Resources._96px_Unknown_Ships;
            this.picSubFlt1.InitialImage = global::Britannia.Properties.Resources._96px_Unknown_Ships;
            this.picSubFlt1.Location = new System.Drawing.Point(5, 5);
            this.picSubFlt1.Margin = new System.Windows.Forms.Padding(5);
            this.picSubFlt1.Name = "picSubFlt1";
            this.picSubFlt1.Size = new System.Drawing.Size(236, 114);
            this.picSubFlt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSubFlt1.TabIndex = 0;
            this.picSubFlt1.TabStop = false;
            // 
            // picSubFlt2
            // 
            this.picSubFlt2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picSubFlt2.ErrorImage = global::Britannia.Properties.Resources._96px_Unknown_Ships;
            this.picSubFlt2.Image = global::Britannia.Properties.Resources._96px_Unknown_Ships;
            this.picSubFlt2.InitialImage = global::Britannia.Properties.Resources._96px_Unknown_Ships;
            this.picSubFlt2.Location = new System.Drawing.Point(251, 5);
            this.picSubFlt2.Margin = new System.Windows.Forms.Padding(5);
            this.picSubFlt2.Name = "picSubFlt2";
            this.picSubFlt2.Size = new System.Drawing.Size(236, 114);
            this.picSubFlt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSubFlt2.TabIndex = 1;
            this.picSubFlt2.TabStop = false;
            // 
            // picSubFlt3
            // 
            this.picSubFlt3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picSubFlt3.ErrorImage = global::Britannia.Properties.Resources._96px_Unknown_Ships;
            this.picSubFlt3.Image = global::Britannia.Properties.Resources._96px_Unknown_Ships;
            this.picSubFlt3.InitialImage = global::Britannia.Properties.Resources._96px_Unknown_Ships;
            this.picSubFlt3.Location = new System.Drawing.Point(497, 5);
            this.picSubFlt3.Margin = new System.Windows.Forms.Padding(5);
            this.picSubFlt3.Name = "picSubFlt3";
            this.picSubFlt3.Size = new System.Drawing.Size(236, 114);
            this.picSubFlt3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSubFlt3.TabIndex = 2;
            this.picSubFlt3.TabStop = false;
            // 
            // btnSubFlt1
            // 
            this.btnSubFlt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSubFlt1.Location = new System.Drawing.Point(73, 129);
            this.btnSubFlt1.Margin = new System.Windows.Forms.Padding(5);
            this.btnSubFlt1.Name = "btnSubFlt1";
            this.btnSubFlt1.Size = new System.Drawing.Size(100, 30);
            this.btnSubFlt1.TabIndex = 3;
            this.btnSubFlt1.Text = "Select";
            this.btnSubFlt1.UseVisualStyleBackColor = true;
            this.btnSubFlt1.Click += new System.EventHandler(this.btnSubFlt1_Click);
            // 
            // btnSubFlt2
            // 
            this.btnSubFlt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSubFlt2.Location = new System.Drawing.Point(319, 129);
            this.btnSubFlt2.Margin = new System.Windows.Forms.Padding(5);
            this.btnSubFlt2.Name = "btnSubFlt2";
            this.btnSubFlt2.Size = new System.Drawing.Size(100, 30);
            this.btnSubFlt2.TabIndex = 4;
            this.btnSubFlt2.Text = "Select";
            this.btnSubFlt2.UseVisualStyleBackColor = true;
            this.btnSubFlt2.Click += new System.EventHandler(this.btnSubFlt2_Click);
            // 
            // btnSubFlt3
            // 
            this.btnSubFlt3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSubFlt3.Location = new System.Drawing.Point(565, 129);
            this.btnSubFlt3.Margin = new System.Windows.Forms.Padding(5);
            this.btnSubFlt3.Name = "btnSubFlt3";
            this.btnSubFlt3.Size = new System.Drawing.Size(100, 30);
            this.btnSubFlt3.TabIndex = 5;
            this.btnSubFlt3.Text = "Select";
            this.btnSubFlt3.UseVisualStyleBackColor = true;
            this.btnSubFlt3.Click += new System.EventHandler(this.btnSubFlt3_Click);
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
            // splShipGear
            // 
            this.splShipGear.BackColor = System.Drawing.Color.Transparent;
            this.splShipGear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splShipGear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splShipGear.Location = new System.Drawing.Point(10, 10);
            this.splShipGear.Name = "splShipGear";
            // 
            // splShipGear.Panel1
            // 
            this.splShipGear.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splShipGear.Panel1.Controls.Add(this.txtShipSearch);
            this.splShipGear.Panel1.Controls.Add(this.dgvShips);
            this.splShipGear.Panel1.Controls.Add(this.btnAddShip);
            this.splShipGear.Panel1.Controls.Add(this.lblShips);
            this.splShipGear.Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.splShipGear.Panel1MinSize = 150;
            // 
            // splShipGear.Panel2
            // 
            this.splShipGear.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splShipGear.Panel2.Controls.Add(this.txtGearSearch);
            this.splShipGear.Panel2.Controls.Add(this.dgvGear);
            this.splShipGear.Panel2.Controls.Add(this.btnAddGear);
            this.splShipGear.Panel2.Controls.Add(this.lblGear);
            this.splShipGear.Panel2.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splShipGear.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splShipGear.Panel2MinSize = 150;
            this.splShipGear.Size = new System.Drawing.Size(996, 578);
            this.splShipGear.SplitterDistance = 489;
            this.splShipGear.SplitterWidth = 3;
            this.splShipGear.TabIndex = 3;
            this.splShipGear.TabStop = false;
            // 
            // txtShipSearch
            // 
            this.txtShipSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShipSearch.Location = new System.Drawing.Point(10, 55);
            this.txtShipSearch.Margin = new System.Windows.Forms.Padding(10);
            this.txtShipSearch.Name = "txtShipSearch";
            this.txtShipSearch.Size = new System.Drawing.Size(467, 27);
            this.txtShipSearch.TabIndex = 4;
            // 
            // dgvShips
            // 
            this.dgvShips.AllowUserToAddRows = false;
            this.dgvShips.AllowUserToDeleteRows = false;
            this.dgvShips.AllowUserToOrderColumns = true;
            this.dgvShips.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShips.Location = new System.Drawing.Point(10, 95);
            this.dgvShips.Margin = new System.Windows.Forms.Padding(10);
            this.dgvShips.Name = "dgvShips";
            this.dgvShips.RowHeadersVisible = false;
            this.dgvShips.Size = new System.Drawing.Size(467, 427);
            this.dgvShips.TabIndex = 3;
            this.dgvShips.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShips_CellContentClick);
            // 
            // btnAddShip
            // 
            this.btnAddShip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddShip.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShip.Location = new System.Drawing.Point(186, 532);
            this.btnAddShip.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddShip.Name = "btnAddShip";
            this.btnAddShip.Size = new System.Drawing.Size(115, 35);
            this.btnAddShip.TabIndex = 2;
            this.btnAddShip.Text = "Add Ship";
            this.btnAddShip.UseVisualStyleBackColor = true;
            this.btnAddShip.Click += new System.EventHandler(this.btnAddShip_Click);
            // 
            // lblShips
            // 
            this.lblShips.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblShips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblShips.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShips.Location = new System.Drawing.Point(10, 10);
            this.lblShips.Margin = new System.Windows.Forms.Padding(0);
            this.lblShips.Name = "lblShips";
            this.lblShips.Size = new System.Drawing.Size(467, 35);
            this.lblShips.TabIndex = 0;
            this.lblShips.Text = "Ships";
            this.lblShips.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGearSearch
            // 
            this.txtGearSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGearSearch.Location = new System.Drawing.Point(10, 55);
            this.txtGearSearch.Margin = new System.Windows.Forms.Padding(10);
            this.txtGearSearch.Name = "txtGearSearch";
            this.txtGearSearch.Size = new System.Drawing.Size(483, 27);
            this.txtGearSearch.TabIndex = 3;
            // 
            // dgvGear
            // 
            this.dgvGear.AllowUserToAddRows = false;
            this.dgvGear.AllowUserToDeleteRows = false;
            this.dgvGear.AllowUserToOrderColumns = true;
            this.dgvGear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGear.Location = new System.Drawing.Point(10, 95);
            this.dgvGear.Margin = new System.Windows.Forms.Padding(10);
            this.dgvGear.Name = "dgvGear";
            this.dgvGear.RowHeadersVisible = false;
            this.dgvGear.Size = new System.Drawing.Size(483, 427);
            this.dgvGear.TabIndex = 2;
            // 
            // btnAddGear
            // 
            this.btnAddGear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddGear.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGear.Location = new System.Drawing.Point(206, 532);
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
            this.lblGear.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGear.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGear.Location = new System.Drawing.Point(10, 10);
            this.lblGear.Margin = new System.Windows.Forms.Padding(0);
            this.lblGear.Name = "lblGear";
            this.lblGear.Size = new System.Drawing.Size(482, 35);
            this.lblGear.TabIndex = 0;
            this.lblGear.Text = "Gear";
            this.lblGear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tclDockFleet
            // 
            this.tclDockFleet.Controls.Add(this.tpgDryDock);
            this.tclDockFleet.Controls.Add(this.tpgFleetOrders);
            this.tclDockFleet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tclDockFleet.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tclDockFleet.Location = new System.Drawing.Point(5, 5);
            this.tclDockFleet.Name = "tclDockFleet";
            this.tclDockFleet.SelectedIndex = 0;
            this.tclDockFleet.Size = new System.Drawing.Size(1024, 631);
            this.tclDockFleet.TabIndex = 4;
            // 
            // Britannia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 641);
            this.Controls.Add(this.tclDockFleet);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Britannia";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Britannia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Britannia_FormClosing);
            this.Load += new System.EventHandler(this.Britannia_Load);
            this.tpgFleetOrders.ResumeLayout(false);
            this.tlpOrders.ResumeLayout(false);
            this.grpVan.ResumeLayout(false);
            this.tlpVanFlt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picVanFlt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVanFlt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVanFlt3)).EndInit();
            this.grpMainFlt.ResumeLayout(false);
            this.tlpMainFlt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMainFlt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainFlt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainFlt3)).EndInit();
            this.grpSubFlt.ResumeLayout(false);
            this.tlpSubFlt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSubFlt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSubFlt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSubFlt3)).EndInit();
            this.tpgDryDock.ResumeLayout(false);
            this.splShipGear.Panel1.ResumeLayout(false);
            this.splShipGear.Panel1.PerformLayout();
            this.splShipGear.Panel2.ResumeLayout(false);
            this.splShipGear.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splShipGear)).EndInit();
            this.splShipGear.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGear)).EndInit();
            this.tclDockFleet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpgFleetOrders;
        private System.Windows.Forms.TableLayoutPanel tlpOrders;
        private System.Windows.Forms.GroupBox grpVan;
        private System.Windows.Forms.TableLayoutPanel tlpVanFlt;
        private System.Windows.Forms.Label lblVan;
        private System.Windows.Forms.ListBox lbxVan;
        private System.Windows.Forms.PictureBox picVanFlt1;
        private System.Windows.Forms.PictureBox picVanFlt2;
        private System.Windows.Forms.PictureBox picVanFlt3;
        private System.Windows.Forms.Button btnVanFlt1;
        private System.Windows.Forms.Button btnVanFlt2;
        private System.Windows.Forms.Button btnVanFlt3;
        private System.Windows.Forms.GroupBox grpMainFlt;
        private System.Windows.Forms.TableLayoutPanel tlpMainFlt;
        private System.Windows.Forms.PictureBox picMainFlt1;
        private System.Windows.Forms.PictureBox picMainFlt2;
        private System.Windows.Forms.PictureBox picMainFlt3;
        private System.Windows.Forms.Button btnMainFlt1;
        private System.Windows.Forms.Button btnMainFlt2;
        private System.Windows.Forms.Button btnMainFlt3;
        private System.Windows.Forms.ListBox lbxMain;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.GroupBox grpSubFlt;
        private System.Windows.Forms.TableLayoutPanel tlpSubFlt;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.ListBox lbxSub;
        private System.Windows.Forms.PictureBox picSubFlt1;
        private System.Windows.Forms.PictureBox picSubFlt2;
        private System.Windows.Forms.PictureBox picSubFlt3;
        private System.Windows.Forms.Button btnSubFlt1;
        private System.Windows.Forms.Button btnSubFlt2;
        private System.Windows.Forms.Button btnSubFlt3;
        private System.Windows.Forms.TabPage tpgDryDock;
        private System.Windows.Forms.SplitContainer splShipGear;
        private System.Windows.Forms.DataGridView dgvShips;
        private System.Windows.Forms.Button btnAddShip;
        private System.Windows.Forms.Label lblShips;
        private System.Windows.Forms.DataGridView dgvGear;
        private System.Windows.Forms.Button btnAddGear;
        private System.Windows.Forms.Label lblGear;
        private System.Windows.Forms.TabControl tclDockFleet;
        private System.Windows.Forms.TextBox txtShipSearch;
        private System.Windows.Forms.TextBox txtGearSearch;
    }
}

