namespace Laboratorio_12
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
            this.buttonCalcular_Click = new System.Windows.Forms.Button();
            this.buttonLimpiar_Click = new System.Windows.Forms.Button();
            this.buttonSalir_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxVelocidad = new System.Windows.Forms.TextBox();
            this.textBoxTiempo = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCalcular_Click
            // 
            this.buttonCalcular_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcular_Click.Location = new System.Drawing.Point(62, 234);
            this.buttonCalcular_Click.Name = "buttonCalcular_Click";
            this.buttonCalcular_Click.Size = new System.Drawing.Size(172, 48);
            this.buttonCalcular_Click.TabIndex = 0;
            this.buttonCalcular_Click.Text = "Calcular";
            this.buttonCalcular_Click.UseVisualStyleBackColor = true;
            this.buttonCalcular_Click.Click += new System.EventHandler(this.buttonCalcular_Click1);
            // 
            // buttonLimpiar_Click
            // 
            this.buttonLimpiar_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar_Click.Location = new System.Drawing.Point(276, 234);
            this.buttonLimpiar_Click.Name = "buttonLimpiar_Click";
            this.buttonLimpiar_Click.Size = new System.Drawing.Size(180, 48);
            this.buttonLimpiar_Click.TabIndex = 1;
            this.buttonLimpiar_Click.Text = "Limpiar";
            this.buttonLimpiar_Click.UseVisualStyleBackColor = true;
            this.buttonLimpiar_Click.Click += new System.EventHandler(this.buttonLimpiar_Click1);
            // 
            // buttonSalir_Click
            // 
            this.buttonSalir_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir_Click.Location = new System.Drawing.Point(502, 234);
            this.buttonSalir_Click.Name = "buttonSalir_Click";
            this.buttonSalir_Click.Size = new System.Drawing.Size(203, 48);
            this.buttonSalir_Click.TabIndex = 2;
            this.buttonSalir_Click.Text = "Salir";
            this.buttonSalir_Click.UseVisualStyleBackColor = true;
            this.buttonSalir_Click.Click += new System.EventHandler(this.buttonSalir_Click1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Velocidad Movil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Resultado";
            // 
            // textBoxVelocidad
            // 
            this.textBoxVelocidad.Location = new System.Drawing.Point(469, 61);
            this.textBoxVelocidad.Name = "textBoxVelocidad";
            this.textBoxVelocidad.Size = new System.Drawing.Size(165, 22);
            this.textBoxVelocidad.TabIndex = 7;
            // 
            // textBoxTiempo
            // 
            this.textBoxTiempo.Location = new System.Drawing.Point(469, 123);
            this.textBoxTiempo.Name = "textBoxTiempo";
            this.textBoxTiempo.Size = new System.Drawing.Size(165, 22);
            this.textBoxTiempo.TabIndex = 8;
            // 
            // labelResultado
            // 
            this.labelResultado.Location = new System.Drawing.Point(306, 331);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(417, 22);
            this.labelResultado.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.textBoxTiempo);
            this.Controls.Add(this.textBoxVelocidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSalir_Click);
            this.Controls.Add(this.buttonLimpiar_Click);
            this.Controls.Add(this.buttonCalcular_Click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalcular_Click;
        private System.Windows.Forms.Button buttonLimpiar_Click;
        private System.Windows.Forms.Button buttonSalir_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxVelocidad;
        private System.Windows.Forms.TextBox textBoxTiempo;
        private System.Windows.Forms.TextBox labelResultado;
    }
}

