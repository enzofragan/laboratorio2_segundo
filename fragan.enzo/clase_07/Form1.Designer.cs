namespace clase_07
{
  partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPaletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpPaleta = new System.Windows.Forms.GroupBox();
            this.lstPaleta = new System.Windows.Forms.ListBox();
            this.btnmas = new System.Windows.Forms.Button();
            this.btnmenos = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpPaleta.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(590, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearPaletaToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administracionToolStripMenuItem.Text = "Administracion";
            // 
            // crearPaletaToolStripMenuItem
            // 
            this.crearPaletaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temperaToolStripMenuItem});
            this.crearPaletaToolStripMenuItem.Name = "crearPaletaToolStripMenuItem";
            this.crearPaletaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.crearPaletaToolStripMenuItem.Text = "Crear Paleta";
            this.crearPaletaToolStripMenuItem.Click += new System.EventHandler(this.crearPaletaToolStripMenuItem_Click);
            // 
            // temperaToolStripMenuItem
            // 
            this.temperaToolStripMenuItem.Name = "temperaToolStripMenuItem";
            this.temperaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.temperaToolStripMenuItem.Text = "Tempera";
            this.temperaToolStripMenuItem.Click += new System.EventHandler(this.temperaToolStripMenuItem_Click);
            // 
            // grpPaleta
            // 
            this.grpPaleta.Controls.Add(this.btnModificar);
            this.grpPaleta.Controls.Add(this.btnmenos);
            this.grpPaleta.Controls.Add(this.btnmas);
            this.grpPaleta.Controls.Add(this.lstPaleta);
            this.grpPaleta.Location = new System.Drawing.Point(12, 27);
            this.grpPaleta.Name = "grpPaleta";
            this.grpPaleta.Size = new System.Drawing.Size(424, 240);
            this.grpPaleta.TabIndex = 1;
            this.grpPaleta.TabStop = false;
            this.grpPaleta.Text = "Paleta";
            // 
            // lstPaleta
            // 
            this.lstPaleta.FormattingEnabled = true;
            this.lstPaleta.Location = new System.Drawing.Point(6, 19);
            this.lstPaleta.Name = "lstPaleta";
            this.lstPaleta.Size = new System.Drawing.Size(412, 134);
            this.lstPaleta.TabIndex = 0;
            // 
            // btnmas
            // 
            this.btnmas.Location = new System.Drawing.Point(44, 159);
            this.btnmas.Name = "btnmas";
            this.btnmas.Size = new System.Drawing.Size(75, 23);
            this.btnmas.TabIndex = 1;
            this.btnmas.Text = "+";
            this.btnmas.UseVisualStyleBackColor = true;
            this.btnmas.Click += new System.EventHandler(this.btnmas_Click);
            // 
            // btnmenos
            // 
            this.btnmenos.Location = new System.Drawing.Point(187, 159);
            this.btnmenos.Name = "btnmenos";
            this.btnmenos.Size = new System.Drawing.Size(75, 23);
            this.btnmenos.TabIndex = 2;
            this.btnmenos.Text = "-";
            this.btnmenos.UseVisualStyleBackColor = true;
            this.btnmenos.Click += new System.EventHandler(this.btnmenos_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(117, 188);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 376);
            this.Controls.Add(this.grpPaleta);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpPaleta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem crearPaletaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem temperaToolStripMenuItem;
    private System.Windows.Forms.GroupBox grpPaleta;
    private System.Windows.Forms.ListBox lstPaleta;
        private System.Windows.Forms.Button btnmenos;
        private System.Windows.Forms.Button btnmas;
        private System.Windows.Forms.Button btnModificar;
    }
}

