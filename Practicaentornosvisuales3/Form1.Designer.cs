namespace Practicaentornosvisuales3
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
            this.aRCHIVOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fACTURARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aYUDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.eMPLEADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRCHIVOSToolStripMenuItem,
            this.fACTURARToolStripMenuItem,
            this.aYUDAToolStripMenuItem,
            this.eMPLEADOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aRCHIVOSToolStripMenuItem
            // 
            this.aRCHIVOSToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.aRCHIVOSToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.aRCHIVOSToolStripMenuItem.Name = "aRCHIVOSToolStripMenuItem";
            this.aRCHIVOSToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.aRCHIVOSToolStripMenuItem.Text = "INICIO";
            // 
            // fACTURARToolStripMenuItem
            // 
            this.fACTURARToolStripMenuItem.Name = "fACTURARToolStripMenuItem";
            this.fACTURARToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.fACTURARToolStripMenuItem.Text = "CLIENTES";
            this.fACTURARToolStripMenuItem.Click += new System.EventHandler(this.fACTURARToolStripMenuItem_Click);
            // 
            // aYUDAToolStripMenuItem
            // 
            this.aYUDAToolStripMenuItem.Name = "aYUDAToolStripMenuItem";
            this.aYUDAToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.aYUDAToolStripMenuItem.Text = "PRODUCTOS";
            this.aYUDAToolStripMenuItem.Click += new System.EventHandler(this.aYUDAToolStripMenuItem_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 24);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(800, 426);
            this.panelContenedor.TabIndex = 1;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // eMPLEADOSToolStripMenuItem
            // 
            this.eMPLEADOSToolStripMenuItem.Name = "eMPLEADOSToolStripMenuItem";
            this.eMPLEADOSToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.eMPLEADOSToolStripMenuItem.Text = "EMPLEADOS";
            this.eMPLEADOSToolStripMenuItem.Click += new System.EventHandler(this.eMPLEADOSToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aRCHIVOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fACTURARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aYUDAToolStripMenuItem;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.ToolStripMenuItem eMPLEADOSToolStripMenuItem;
    }
}

