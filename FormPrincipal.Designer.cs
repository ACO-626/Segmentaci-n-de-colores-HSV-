namespace Segmentación_de_colores__HSV_
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.pictureBoxOrigin = new System.Windows.Forms.PictureBox();
            this.pictureBoxHue = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segmentaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frutasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackHueMax = new System.Windows.Forms.TrackBar();
            this.trackSatMax = new System.Windows.Forms.TrackBar();
            this.lbSimpleH = new System.Windows.Forms.Label();
            this.lbSimpleSat = new System.Windows.Forms.Label();
            this.pictureBoxSat = new System.Windows.Forms.PictureBox();
            this.pictureBoxVal = new System.Windows.Forms.PictureBox();
            this.lbSimpleVal = new System.Windows.Forms.Label();
            this.trackValMac = new System.Windows.Forms.TrackBar();
            this.panelFlotante = new System.Windows.Forms.Panel();
            this.btnBorde = new System.Windows.Forms.Button();
            this.btnBlobs = new System.Windows.Forms.Button();
            this.btnActuHsv = new System.Windows.Forms.Button();
            this.lbHue = new System.Windows.Forms.Label();
            this.lbSat = new System.Windows.Forms.Label();
            this.lbVal = new System.Windows.Forms.Label();
            this.panelInf = new System.Windows.Forms.Panel();
            this.pictureOmin = new System.Windows.Forms.PictureBox();
            this.btnHue = new System.Windows.Forms.Button();
            this.lbIntervalo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackInter2 = new System.Windows.Forms.TrackBar();
            this.lbSimpleInterval = new System.Windows.Forms.Label();
            this.trackInter1 = new System.Windows.Forms.TrackBar();
            this.numericFil1 = new System.Windows.Forms.NumericUpDown();
            this.numericFil2 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnORG = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHue)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackHueMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSatMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackValMac)).BeginInit();
            this.panelFlotante.SuspendLayout();
            this.panelInf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackInter2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackInter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFil1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFil2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOrigin
            // 
            this.pictureBoxOrigin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxOrigin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pictureBoxOrigin.Location = new System.Drawing.Point(22, 54);
            this.pictureBoxOrigin.Name = "pictureBoxOrigin";
            this.pictureBoxOrigin.Size = new System.Drawing.Size(818, 539);
            this.pictureBoxOrigin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOrigin.TabIndex = 0;
            this.pictureBoxOrigin.TabStop = false;
            // 
            // pictureBoxHue
            // 
            this.pictureBoxHue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxHue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pictureBoxHue.Location = new System.Drawing.Point(948, 74);
            this.pictureBoxHue.Name = "pictureBoxHue";
            this.pictureBoxHue.Size = new System.Drawing.Size(198, 117);
            this.pictureBoxHue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHue.TabIndex = 1;
            this.pictureBoxHue.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.imagenToolStripMenuItem,
            this.segmentaciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1342, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.importarToolStripMenuItem.Text = "Importar";
            this.importarToolStripMenuItem.Click += new System.EventHandler(this.importarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(117, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // imagenToolStripMenuItem
            // 
            this.imagenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limpiarToolStripMenuItem});
            this.imagenToolStripMenuItem.Name = "imagenToolStripMenuItem";
            this.imagenToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.imagenToolStripMenuItem.Text = "Imagen";
            // 
            // limpiarToolStripMenuItem
            // 
            this.limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            this.limpiarToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.limpiarToolStripMenuItem.Text = "Limpiar";
            // 
            // segmentaciónToolStripMenuItem
            // 
            this.segmentaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frutasToolStripMenuItem});
            this.segmentaciónToolStripMenuItem.Name = "segmentaciónToolStripMenuItem";
            this.segmentaciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.segmentaciónToolStripMenuItem.Text = "Segmentación";
            // 
            // frutasToolStripMenuItem
            // 
            this.frutasToolStripMenuItem.Name = "frutasToolStripMenuItem";
            this.frutasToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.frutasToolStripMenuItem.Text = "Frutas";
            // 
            // trackHueMax
            // 
            this.trackHueMax.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trackHueMax.Location = new System.Drawing.Point(948, 197);
            this.trackHueMax.Maximum = 360;
            this.trackHueMax.Name = "trackHueMax";
            this.trackHueMax.Size = new System.Drawing.Size(198, 45);
            this.trackHueMax.TabIndex = 5;
            this.trackHueMax.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackHueMax.Value = 360;
            this.trackHueMax.Scroll += new System.EventHandler(this.trackHueMax_Scroll);
            this.trackHueMax.ValueChanged += new System.EventHandler(this.trackHueMax_ValueChanged);
            // 
            // trackSatMax
            // 
            this.trackSatMax.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trackSatMax.Location = new System.Drawing.Point(948, 383);
            this.trackSatMax.Maximum = 255;
            this.trackSatMax.Name = "trackSatMax";
            this.trackSatMax.Size = new System.Drawing.Size(198, 45);
            this.trackSatMax.TabIndex = 7;
            this.trackSatMax.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackSatMax.Value = 255;
            this.trackSatMax.Scroll += new System.EventHandler(this.trackSatMax_Scroll);
            this.trackSatMax.ValueChanged += new System.EventHandler(this.trackSatMax_ValueChanged);
            // 
            // lbSimpleH
            // 
            this.lbSimpleH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSimpleH.AutoSize = true;
            this.lbSimpleH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSimpleH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSimpleH.Location = new System.Drawing.Point(894, 123);
            this.lbSimpleH.Name = "lbSimpleH";
            this.lbSimpleH.Size = new System.Drawing.Size(48, 25);
            this.lbSimpleH.TabIndex = 10;
            this.lbSimpleH.Text = "Hue";
            // 
            // lbSimpleSat
            // 
            this.lbSimpleSat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSimpleSat.AutoSize = true;
            this.lbSimpleSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSimpleSat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSimpleSat.Location = new System.Drawing.Point(900, 311);
            this.lbSimpleSat.Name = "lbSimpleSat";
            this.lbSimpleSat.Size = new System.Drawing.Size(42, 25);
            this.lbSimpleSat.TabIndex = 11;
            this.lbSimpleSat.Text = "Sat";
            // 
            // pictureBoxSat
            // 
            this.pictureBoxSat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxSat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pictureBoxSat.Location = new System.Drawing.Point(948, 260);
            this.pictureBoxSat.Name = "pictureBoxSat";
            this.pictureBoxSat.Size = new System.Drawing.Size(198, 117);
            this.pictureBoxSat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSat.TabIndex = 12;
            this.pictureBoxSat.TabStop = false;
            // 
            // pictureBoxVal
            // 
            this.pictureBoxVal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pictureBoxVal.Location = new System.Drawing.Point(948, 434);
            this.pictureBoxVal.Name = "pictureBoxVal";
            this.pictureBoxVal.Size = new System.Drawing.Size(198, 117);
            this.pictureBoxVal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVal.TabIndex = 16;
            this.pictureBoxVal.TabStop = false;
            // 
            // lbSimpleVal
            // 
            this.lbSimpleVal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSimpleVal.AutoSize = true;
            this.lbSimpleVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSimpleVal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSimpleVal.Location = new System.Drawing.Point(900, 485);
            this.lbSimpleVal.Name = "lbSimpleVal";
            this.lbSimpleVal.Size = new System.Drawing.Size(41, 25);
            this.lbSimpleVal.TabIndex = 15;
            this.lbSimpleVal.Text = "Val";
            // 
            // trackValMac
            // 
            this.trackValMac.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trackValMac.Location = new System.Drawing.Point(948, 557);
            this.trackValMac.Maximum = 255;
            this.trackValMac.Name = "trackValMac";
            this.trackValMac.Size = new System.Drawing.Size(198, 45);
            this.trackValMac.TabIndex = 14;
            this.trackValMac.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackValMac.Value = 255;
            this.trackValMac.Scroll += new System.EventHandler(this.trackValMac_Scroll);
            this.trackValMac.ValueChanged += new System.EventHandler(this.trackValMac_ValueChanged);
            // 
            // panelFlotante
            // 
            this.panelFlotante.Controls.Add(this.numericFil2);
            this.panelFlotante.Controls.Add(this.numericFil1);
            this.panelFlotante.Controls.Add(this.btnBorde);
            this.panelFlotante.Controls.Add(this.btnBlobs);
            this.panelFlotante.Controls.Add(this.btnActuHsv);
            this.panelFlotante.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFlotante.Location = new System.Drawing.Point(1195, 24);
            this.panelFlotante.Name = "panelFlotante";
            this.panelFlotante.Size = new System.Drawing.Size(147, 721);
            this.panelFlotante.TabIndex = 17;
            // 
            // btnBorde
            // 
            this.btnBorde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorde.Location = new System.Drawing.Point(37, 584);
            this.btnBorde.Name = "btnBorde";
            this.btnBorde.Size = new System.Drawing.Size(75, 32);
            this.btnBorde.TabIndex = 28;
            this.btnBorde.Text = "BIN";
            this.btnBorde.UseVisualStyleBackColor = true;
            this.btnBorde.Click += new System.EventHandler(this.btnBorde_Click);
            // 
            // btnBlobs
            // 
            this.btnBlobs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlobs.Location = new System.Drawing.Point(37, 105);
            this.btnBlobs.Name = "btnBlobs";
            this.btnBlobs.Size = new System.Drawing.Size(75, 32);
            this.btnBlobs.TabIndex = 27;
            this.btnBlobs.Text = "BLOB\'S";
            this.btnBlobs.UseVisualStyleBackColor = true;
            this.btnBlobs.Click += new System.EventHandler(this.btnBlobs_Click);
            // 
            // btnActuHsv
            // 
            this.btnActuHsv.Location = new System.Drawing.Point(37, 67);
            this.btnActuHsv.Name = "btnActuHsv";
            this.btnActuHsv.Size = new System.Drawing.Size(75, 32);
            this.btnActuHsv.TabIndex = 0;
            this.btnActuHsv.Text = "HSV";
            this.btnActuHsv.UseVisualStyleBackColor = true;
            this.btnActuHsv.Click += new System.EventHandler(this.btnActuHsv_Click);
            // 
            // lbHue
            // 
            this.lbHue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbHue.AutoSize = true;
            this.lbHue.BackColor = System.Drawing.Color.Transparent;
            this.lbHue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbHue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbHue.Location = new System.Drawing.Point(1113, 166);
            this.lbHue.Name = "lbHue";
            this.lbHue.Size = new System.Drawing.Size(33, 25);
            this.lbHue.TabIndex = 18;
            this.lbHue.Text = "---";
            // 
            // lbSat
            // 
            this.lbSat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSat.AutoSize = true;
            this.lbSat.BackColor = System.Drawing.Color.Transparent;
            this.lbSat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSat.Location = new System.Drawing.Point(1113, 352);
            this.lbSat.Name = "lbSat";
            this.lbSat.Size = new System.Drawing.Size(33, 25);
            this.lbSat.TabIndex = 19;
            this.lbSat.Text = "---";
            // 
            // lbVal
            // 
            this.lbVal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbVal.AutoSize = true;
            this.lbVal.BackColor = System.Drawing.Color.Transparent;
            this.lbVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbVal.Location = new System.Drawing.Point(1113, 526);
            this.lbVal.Name = "lbVal";
            this.lbVal.Size = new System.Drawing.Size(33, 25);
            this.lbVal.TabIndex = 20;
            this.lbVal.Text = "---";
            // 
            // panelInf
            // 
            this.panelInf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelInf.Controls.Add(this.btnORG);
            this.panelInf.Controls.Add(this.pictureBox1);
            this.panelInf.Controls.Add(this.pictureOmin);
            this.panelInf.Controls.Add(this.btnHue);
            this.panelInf.Controls.Add(this.lbIntervalo);
            this.panelInf.Controls.Add(this.label2);
            this.panelInf.Controls.Add(this.label1);
            this.panelInf.Controls.Add(this.trackInter2);
            this.panelInf.Controls.Add(this.lbSimpleInterval);
            this.panelInf.Controls.Add(this.trackInter1);
            this.panelInf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInf.Location = new System.Drawing.Point(0, 608);
            this.panelInf.Name = "panelInf";
            this.panelInf.Size = new System.Drawing.Size(1195, 137);
            this.panelInf.TabIndex = 21;
            // 
            // pictureOmin
            // 
            this.pictureOmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureOmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pictureOmin.Location = new System.Drawing.Point(22, 31);
            this.pictureOmin.Name = "pictureOmin";
            this.pictureOmin.Size = new System.Drawing.Size(113, 76);
            this.pictureOmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOmin.TabIndex = 22;
            this.pictureOmin.TabStop = false;
            // 
            // btnHue
            // 
            this.btnHue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHue.Location = new System.Drawing.Point(566, 39);
            this.btnHue.Name = "btnHue";
            this.btnHue.Size = new System.Drawing.Size(25, 68);
            this.btnHue.TabIndex = 1;
            this.btnHue.Text = "HUE";
            this.btnHue.UseVisualStyleBackColor = true;
            this.btnHue.Click += new System.EventHandler(this.btnHue_Click);
            // 
            // lbIntervalo
            // 
            this.lbIntervalo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbIntervalo.AutoSize = true;
            this.lbIntervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIntervalo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbIntervalo.Location = new System.Drawing.Point(274, 8);
            this.lbIntervalo.Name = "lbIntervalo";
            this.lbIntervalo.Size = new System.Drawing.Size(65, 24);
            this.lbIntervalo.TabIndex = 25;
            this.lbIntervalo.Text = "[0,360]";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(149, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cs";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(150, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ci";
            // 
            // trackInter2
            // 
            this.trackInter2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackInter2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackInter2.Location = new System.Drawing.Point(192, 81);
            this.trackInter2.Maximum = 360;
            this.trackInter2.Minimum = 1;
            this.trackInter2.Name = "trackInter2";
            this.trackInter2.Size = new System.Drawing.Size(354, 45);
            this.trackInter2.TabIndex = 23;
            this.trackInter2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackInter2.Value = 360;
            this.trackInter2.Scroll += new System.EventHandler(this.trackInter2_Scroll);
            // 
            // lbSimpleInterval
            // 
            this.lbSimpleInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSimpleInterval.AutoSize = true;
            this.lbSimpleInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSimpleInterval.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSimpleInterval.Location = new System.Drawing.Point(182, 7);
            this.lbSimpleInterval.Name = "lbSimpleInterval";
            this.lbSimpleInterval.Size = new System.Drawing.Size(86, 25);
            this.lbSimpleInterval.TabIndex = 22;
            this.lbSimpleInterval.Text = "Intervalo";
            // 
            // trackInter1
            // 
            this.trackInter1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackInter1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackInter1.Location = new System.Drawing.Point(187, 39);
            this.trackInter1.Maximum = 359;
            this.trackInter1.Name = "trackInter1";
            this.trackInter1.Size = new System.Drawing.Size(359, 45);
            this.trackInter1.TabIndex = 0;
            this.trackInter1.Scroll += new System.EventHandler(this.trackInter1_Scroll);
            // 
            // numericFil1
            // 
            this.numericFil1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericFil1.Location = new System.Drawing.Point(37, 631);
            this.numericFil1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericFil1.Name = "numericFil1";
            this.numericFil1.Size = new System.Drawing.Size(75, 20);
            this.numericFil1.TabIndex = 29;
            this.numericFil1.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // numericFil2
            // 
            this.numericFil2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericFil2.Location = new System.Drawing.Point(37, 675);
            this.numericFil2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericFil2.Name = "numericFil2";
            this.numericFil2.Size = new System.Drawing.Size(75, 20);
            this.numericFil2.TabIndex = 30;
            this.numericFil2.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(200, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btnORG
            // 
            this.btnORG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnORG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnORG.Location = new System.Drawing.Point(608, 39);
            this.btnORG.Name = "btnORG";
            this.btnORG.Size = new System.Drawing.Size(25, 68);
            this.btnORG.TabIndex = 28;
            this.btnORG.Text = "ORG";
            this.btnORG.UseVisualStyleBackColor = true;
            this.btnORG.Click += new System.EventHandler(this.btnORG_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1342, 745);
            this.Controls.Add(this.panelInf);
            this.Controls.Add(this.lbVal);
            this.Controls.Add(this.lbSat);
            this.Controls.Add(this.lbHue);
            this.Controls.Add(this.panelFlotante);
            this.Controls.Add(this.pictureBoxVal);
            this.Controls.Add(this.lbSimpleVal);
            this.Controls.Add(this.trackValMac);
            this.Controls.Add(this.pictureBoxSat);
            this.Controls.Add(this.lbSimpleSat);
            this.Controls.Add(this.lbSimpleH);
            this.Controls.Add(this.trackSatMax);
            this.Controls.Add(this.trackHueMax);
            this.Controls.Add(this.pictureBoxHue);
            this.Controls.Add(this.pictureBoxOrigin);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPrincipal";
            this.Text = "Segmentado HSV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHue)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackHueMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSatMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackValMac)).EndInit();
            this.panelFlotante.ResumeLayout(false);
            this.panelInf.ResumeLayout(false);
            this.panelInf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackInter2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackInter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFil1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFil2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOrigin;
        private System.Windows.Forms.PictureBox pictureBoxHue;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segmentaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frutasToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackHueMax;
        private System.Windows.Forms.TrackBar trackSatMax;
        private System.Windows.Forms.Label lbSimpleH;
        private System.Windows.Forms.Label lbSimpleSat;
        private System.Windows.Forms.PictureBox pictureBoxSat;
        private System.Windows.Forms.PictureBox pictureBoxVal;
        private System.Windows.Forms.Label lbSimpleVal;
        private System.Windows.Forms.TrackBar trackValMac;
        private System.Windows.Forms.Panel panelFlotante;
        private System.Windows.Forms.Button btnActuHsv;
        private System.Windows.Forms.Label lbHue;
        private System.Windows.Forms.Label lbSat;
        private System.Windows.Forms.Label lbVal;
        private System.Windows.Forms.Panel panelInf;
        private System.Windows.Forms.TrackBar trackInter2;
        private System.Windows.Forms.Label lbSimpleInterval;
        private System.Windows.Forms.TrackBar trackInter1;
        private System.Windows.Forms.Label lbIntervalo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHue;
        private System.Windows.Forms.PictureBox pictureOmin;
        private System.Windows.Forms.Button btnBlobs;
        private System.Windows.Forms.Button btnBorde;
        private System.Windows.Forms.NumericUpDown numericFil2;
        private System.Windows.Forms.NumericUpDown numericFil1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnORG;
    }
}

