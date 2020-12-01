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
            this.btnActuHsv = new System.Windows.Forms.Button();
            this.lbHue = new System.Windows.Forms.Label();
            this.lbSat = new System.Windows.Forms.Label();
            this.lbVal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHue)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackHueMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSatMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackValMac)).BeginInit();
            this.panelFlotante.SuspendLayout();
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
            this.panelFlotante.Controls.Add(this.btnActuHsv);
            this.panelFlotante.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFlotante.Location = new System.Drawing.Point(1195, 24);
            this.panelFlotante.Name = "panelFlotante";
            this.panelFlotante.Size = new System.Drawing.Size(147, 721);
            this.panelFlotante.TabIndex = 17;
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
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1342, 745);
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
    }
}

