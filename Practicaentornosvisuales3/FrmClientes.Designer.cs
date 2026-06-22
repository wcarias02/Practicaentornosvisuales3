namespace Practicaentornosvisuales3
{
    partial class FrmClientes
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
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.lblDatosdelCliente = new System.Windows.Forms.Label();
            this.lblNombrecompleto = new System.Windows.Forms.Label();
            this.txtboxNombreCompleto = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtboxTelefono = new System.Windows.Forms.TextBox();
            this.lblCorreoelectronico = new System.Windows.Forms.Label();
            this.txtboxCorreo = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtboxDireccion = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblListadodeclientes = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnMODIFICAR);
            this.panel1.Controls.Add(this.btnELIMINAR);
            this.panel1.Controls.Add(this.txtboxDireccion);
            this.panel1.Controls.Add(this.lblDireccion);
            this.panel1.Controls.Add(this.txtboxCorreo);
            this.panel1.Controls.Add(this.lblCorreoelectronico);
            this.panel1.Controls.Add(this.txtboxTelefono);
            this.panel1.Controls.Add(this.lblTelefono);
            this.panel1.Controls.Add(this.txtboxNombreCompleto);
            this.panel1.Controls.Add(this.lblNombrecompleto);
            this.panel1.Controls.Add(this.lblDatosdelCliente);
            this.panel1.Controls.Add(this.btnGUARDAR);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 426);
            this.panel1.TabIndex = 0;
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.BackColor = System.Drawing.Color.Lime;
            this.btnGUARDAR.Location = new System.Drawing.Point(16, 381);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(81, 32);
            this.btnGUARDAR.TabIndex = 1;
            this.btnGUARDAR.Text = "GUARDAR";
            this.btnGUARDAR.UseVisualStyleBackColor = false;
            // 
            // lblDatosdelCliente
            // 
            this.lblDatosdelCliente.AutoSize = true;
            this.lblDatosdelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosdelCliente.Location = new System.Drawing.Point(12, 11);
            this.lblDatosdelCliente.Name = "lblDatosdelCliente";
            this.lblDatosdelCliente.Size = new System.Drawing.Size(147, 20);
            this.lblDatosdelCliente.TabIndex = 2;
            this.lblDatosdelCliente.Text = "Datos del Cliente";
            // 
            // lblNombrecompleto
            // 
            this.lblNombrecompleto.AutoSize = true;
            this.lblNombrecompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrecompleto.Location = new System.Drawing.Point(13, 47);
            this.lblNombrecompleto.Name = "lblNombrecompleto";
            this.lblNombrecompleto.Size = new System.Drawing.Size(108, 15);
            this.lblNombrecompleto.TabIndex = 3;
            this.lblNombrecompleto.Text = "Nombre Completo";
            this.lblNombrecompleto.Click += new System.EventHandler(this.lblNombrecompleto_Click);
            // 
            // txtboxNombreCompleto
            // 
            this.txtboxNombreCompleto.Location = new System.Drawing.Point(16, 76);
            this.txtboxNombreCompleto.Name = "txtboxNombreCompleto";
            this.txtboxNombreCompleto.Size = new System.Drawing.Size(314, 20);
            this.txtboxNombreCompleto.TabIndex = 4;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(13, 126);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(55, 15);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtboxTelefono
            // 
            this.txtboxTelefono.Location = new System.Drawing.Point(16, 154);
            this.txtboxTelefono.Name = "txtboxTelefono";
            this.txtboxTelefono.Size = new System.Drawing.Size(314, 20);
            this.txtboxTelefono.TabIndex = 6;
            // 
            // lblCorreoelectronico
            // 
            this.lblCorreoelectronico.AutoSize = true;
            this.lblCorreoelectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoelectronico.Location = new System.Drawing.Point(13, 203);
            this.lblCorreoelectronico.Name = "lblCorreoelectronico";
            this.lblCorreoelectronico.Size = new System.Drawing.Size(108, 15);
            this.lblCorreoelectronico.TabIndex = 7;
            this.lblCorreoelectronico.Text = "Correo Electronico";
            // 
            // txtboxCorreo
            // 
            this.txtboxCorreo.Location = new System.Drawing.Point(16, 231);
            this.txtboxCorreo.Name = "txtboxCorreo";
            this.txtboxCorreo.Size = new System.Drawing.Size(314, 20);
            this.txtboxCorreo.TabIndex = 8;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(13, 282);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(59, 15);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtboxDireccion
            // 
            this.txtboxDireccion.Location = new System.Drawing.Point(16, 312);
            this.txtboxDireccion.Name = "txtboxDireccion";
            this.txtboxDireccion.Size = new System.Drawing.Size(314, 20);
            this.txtboxDireccion.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnExportar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.btnBUSCAR);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.lblListadodeclientes);
            this.panel2.Location = new System.Drawing.Point(365, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 423);
            this.panel2.TabIndex = 1;
            // 
            // lblListadodeclientes
            // 
            this.lblListadodeclientes.AutoSize = true;
            this.lblListadodeclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadodeclientes.Location = new System.Drawing.Point(23, 9);
            this.lblListadodeclientes.Name = "lblListadodeclientes";
            this.lblListadodeclientes.Size = new System.Drawing.Size(206, 20);
            this.lblListadodeclientes.TabIndex = 0;
            this.lblListadodeclientes.Text = "LISTADO DE CLIENTES";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnELIMINAR.Location = new System.Drawing.Point(125, 381);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(81, 32);
            this.btnELIMINAR.TabIndex = 11;
            this.btnELIMINAR.Text = "ELIMINAR";
            this.btnELIMINAR.UseVisualStyleBackColor = false;
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.BackColor = System.Drawing.Color.Red;
            this.btnMODIFICAR.Location = new System.Drawing.Point(234, 381);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(81, 32);
            this.btnMODIFICAR.TabIndex = 12;
            this.btnMODIFICAR.Text = "MODIFICAR";
            this.btnMODIFICAR.UseVisualStyleBackColor = false;
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBUSCAR.Location = new System.Drawing.Point(379, 40);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(81, 32);
            this.btnBUSCAR.TabIndex = 12;
            this.btnBUSCAR.Text = "BUSCAR";
            this.btnBUSCAR.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(416, 229);
            this.dataGridView1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "5 clientes registrados";
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.Lime;
            this.btnExportar.ForeColor = System.Drawing.Color.Black;
            this.btnExportar.Location = new System.Drawing.Point(355, 334);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(105, 32);
            this.btnExportar.TabIndex = 15;
            this.btnExportar.Text = "Exportar a Excel";
            this.btnExportar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(74, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "(Formato: XXXX-XXXX)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(127, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "(debe contener @)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(13, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Correo invalido - falta @dominio.com";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.TextBox txtboxNombreCompleto;
        private System.Windows.Forms.Label lblNombrecompleto;
        private System.Windows.Forms.Label lblDatosdelCliente;
        private System.Windows.Forms.TextBox txtboxTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCorreoelectronico;
        private System.Windows.Forms.TextBox txtboxDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtboxCorreo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblListadodeclientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}