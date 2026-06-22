namespace Practicaentornosvisuales3
{
    partial class FrmProductos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDatosproductos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.te = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxPreciodeventa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxStockActual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnGUARDAR = new System.Windows.Forms.Button();
            this.BtnEDITAR = new System.Windows.Forms.Button();
            this.BtnELIMINAR = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnBUSCAR = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.BtnELIMINAR);
            this.panel1.Controls.Add(this.BtnEDITAR);
            this.panel1.Controls.Add(this.BtnGUARDAR);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtboxStockActual);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtboxPreciodeventa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.te);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDatosproductos);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 426);
            this.panel1.TabIndex = 0;
            // 
            // lblDatosproductos
            // 
            this.lblDatosproductos.AutoSize = true;
            this.lblDatosproductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosproductos.Location = new System.Drawing.Point(18, 11);
            this.lblDatosproductos.Name = "lblDatosproductos";
            this.lblDatosproductos.Size = new System.Drawing.Size(162, 20);
            this.lblDatosproductos.TabIndex = 0;
            this.lblDatosproductos.Text = "Datos del producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Producto";
            // 
            // te
            // 
            this.te.Location = new System.Drawing.Point(22, 81);
            this.te.Name = "te";
            this.te.Size = new System.Drawing.Size(278, 20);
            this.te.TabIndex = 0;
            this.te.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio de Venta";
            // 
            // txtboxPreciodeventa
            // 
            this.txtboxPreciodeventa.Location = new System.Drawing.Point(22, 231);
            this.txtboxPreciodeventa.Name = "txtboxPreciodeventa";
            this.txtboxPreciodeventa.Size = new System.Drawing.Size(278, 20);
            this.txtboxPreciodeventa.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stock Actual";
            // 
            // txtboxStockActual
            // 
            this.txtboxStockActual.Location = new System.Drawing.Point(22, 308);
            this.txtboxStockActual.Name = "txtboxStockActual";
            this.txtboxStockActual.Size = new System.Drawing.Size(278, 20);
            this.txtboxStockActual.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(15, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(330, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "ADVERTENCIA STOCK BAJO - Requiere reposicion";
            // 
            // BtnGUARDAR
            // 
            this.BtnGUARDAR.BackColor = System.Drawing.Color.Lime;
            this.BtnGUARDAR.ForeColor = System.Drawing.Color.White;
            this.BtnGUARDAR.Location = new System.Drawing.Point(18, 373);
            this.BtnGUARDAR.Name = "BtnGUARDAR";
            this.BtnGUARDAR.Size = new System.Drawing.Size(94, 35);
            this.BtnGUARDAR.TabIndex = 9;
            this.BtnGUARDAR.Text = "GUARDAR";
            this.BtnGUARDAR.UseVisualStyleBackColor = false;
            // 
            // BtnEDITAR
            // 
            this.BtnEDITAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnEDITAR.ForeColor = System.Drawing.Color.White;
            this.BtnEDITAR.Location = new System.Drawing.Point(130, 373);
            this.BtnEDITAR.Name = "BtnEDITAR";
            this.BtnEDITAR.Size = new System.Drawing.Size(94, 35);
            this.BtnEDITAR.TabIndex = 10;
            this.BtnEDITAR.Text = "EDITAR";
            this.BtnEDITAR.UseVisualStyleBackColor = false;
            // 
            // BtnELIMINAR
            // 
            this.BtnELIMINAR.BackColor = System.Drawing.Color.Red;
            this.BtnELIMINAR.ForeColor = System.Drawing.Color.White;
            this.BtnELIMINAR.Location = new System.Drawing.Point(240, 373);
            this.BtnELIMINAR.Name = "BtnELIMINAR";
            this.BtnELIMINAR.Size = new System.Drawing.Size(94, 35);
            this.BtnELIMINAR.TabIndex = 11;
            this.BtnELIMINAR.Text = "ELIMINAR";
            this.BtnELIMINAR.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.BtnBUSCAR);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(387, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 423);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Listado de Productos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 20);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lacteos"});
            this.comboBox1.Location = new System.Drawing.Point(284, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BtnBUSCAR
            // 
            this.BtnBUSCAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnBUSCAR.ForeColor = System.Drawing.Color.White;
            this.BtnBUSCAR.Location = new System.Drawing.Point(385, 39);
            this.BtnBUSCAR.Name = "BtnBUSCAR";
            this.BtnBUSCAR.Size = new System.Drawing.Size(93, 27);
            this.BtnBUSCAR.TabIndex = 4;
            this.BtnBUSCAR.Text = "BUSCAR";
            this.BtnBUSCAR.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Lacteos"});
            this.comboBox2.Location = new System.Drawing.Point(22, 159);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(278, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 274);
            this.dataGridView1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(320, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "6 productos - Verde: stock nornal - Rojo: stock bajo (< 5 unidades)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(361, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exportar a Excel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProductos";
            this.Text = "FrmProductos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox te;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDatosproductos;
        private System.Windows.Forms.Button BtnELIMINAR;
        private System.Windows.Forms.Button BtnEDITAR;
        private System.Windows.Forms.Button BtnGUARDAR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxStockActual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxPreciodeventa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnBUSCAR;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
    }
}