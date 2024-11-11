using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Laboratorio141
{
    partial class frmProductos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            tsbBuscar = new Button();
            tsbCancelar = new Button();
            tsbEliminar = new Button();
            tsbGuardar = new Button();
            tsbNuevo = new Button();
            label1 = new Label();
            tstId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // tsbBuscar
            // 
            tsbBuscar.Image = (System.Drawing.Image)resources.GetObject("tsbBuscar.Image");
            tsbBuscar.Location = new Point(478, 7);
            tsbBuscar.Margin = new Padding(2, 2, 2, 2);
            tsbBuscar.Name = "tsbBuscar";
            tsbBuscar.Size = new Size(50, 44);
            tsbBuscar.TabIndex = 0;
            tsbBuscar.UseVisualStyleBackColor = true;
            tsbBuscar.Click += tsbBuscar_Click;
            // 
            // tsbCancelar
            // 
            tsbCancelar.Image = (System.Drawing.Image)resources.GetObject("tsbCancelar.Image");
            tsbCancelar.Location = new Point(118, 7);
            tsbCancelar.Margin = new Padding(2, 2, 2, 2);
            tsbCancelar.Name = "tsbCancelar";
            tsbCancelar.Size = new Size(50, 44);
            tsbCancelar.TabIndex = 1;
            tsbCancelar.UseVisualStyleBackColor = true;
            tsbCancelar.Click += tsbCancelar_Click;
            // 
            // tsbEliminar
            // 
            tsbEliminar.Image = (System.Drawing.Image)resources.GetObject("tsbEliminar.Image");
            tsbEliminar.Location = new Point(172, 7);
            tsbEliminar.Margin = new Padding(2, 2, 2, 2);
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Size = new Size(50, 44);
            tsbEliminar.TabIndex = 2;
            tsbEliminar.UseVisualStyleBackColor = true;
            tsbEliminar.Click += tsbEliminar_Click;
            // 
            // tsbGuardar
            // 
            tsbGuardar.Image = (System.Drawing.Image)resources.GetObject("tsbGuardar.Image");
            tsbGuardar.Location = new Point(63, 7);
            tsbGuardar.Margin = new Padding(2, 2, 2, 2);
            tsbGuardar.Name = "tsbGuardar";
            tsbGuardar.Size = new Size(50, 44);
            tsbGuardar.TabIndex = 3;
            tsbGuardar.UseVisualStyleBackColor = true;
            tsbGuardar.Click += tsbGuardar_Click;
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = (System.Drawing.Image)resources.GetObject("tsbNuevo.Image");
            tsbNuevo.Location = new Point(8, 7);
            tsbNuevo.Margin = new Padding(2, 2, 2, 2);
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(50, 44);
            tsbNuevo.TabIndex = 4;
            tsbNuevo.UseVisualStyleBackColor = true;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(244, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 5;
            label1.Text = "Buscar por id:";
            // 
            // tstId
            // 
            tstId.Location = new Point(345, 21);
            tstId.Margin = new Padding(2, 2, 2, 2);
            tstId.Name = "tstId";
            tstId.Size = new Size(106, 23);
            tstId.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 92);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 7;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 92);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 8;
            label3.Text = "Nombre";
            // 
            // txtId
            // 
            txtId.Location = new Point(74, 116);
            txtId.Margin = new Padding(2, 2, 2, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(121, 23);
            txtId.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(274, 116);
            txtNombre.Margin = new Padding(2, 2, 2, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(256, 23);
            txtNombre.TabIndex = 10;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(74, 196);
            txtPrecio.Margin = new Padding(2, 2, 2, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(121, 23);
            txtPrecio.TabIndex = 11;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(274, 196);
            txtStock.Margin = new Padding(2, 2, 2, 2);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(121, 23);
            txtStock.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 168);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 13;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(274, 168);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 14;
            label5.Text = "Stock";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(74, 253);
            btnSalir.Margin = new Padding(2, 2, 2, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(120, 29);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 311);
            Controls.Add(btnSalir);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tstId);
            Controls.Add(label1);
            Controls.Add(tsbNuevo);
            Controls.Add(tsbGuardar);
            Controls.Add(tsbEliminar);
            Controls.Add(tsbCancelar);
            Controls.Add(tsbBuscar);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmProductos";
            Text = "Form1";
            Load += frmProductos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tsbBuscar;
        private Button tsbCancelar;
        private Button tsbEliminar;
        private Button tsbGuardar;
        private Button tsbNuevo;
        private Label label1;
        private TextBox tstId;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Label label4;
        private Label label5;
        private Button btnSalir;
    }
}