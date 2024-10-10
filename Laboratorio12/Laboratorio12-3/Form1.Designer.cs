namespace Laboratorio_12_3
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
            this.components = new System.ComponentModel.Container();
            this.buttonCalcularSemiperimetro = new System.Windows.Forms.Button();
            this.buttonArea = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLadoA = new System.Windows.Forms.TextBox();
            this.textBoxLadoB = new System.Windows.Forms.TextBox();
            this.textBoxLadoC = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelSemiperimetro = new System.Windows.Forms.TextBox();
            this.labelArea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCalcularSemiperimetro
            // 
            this.buttonCalcularSemiperimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcularSemiperimetro.Location = new System.Drawing.Point(29, 201);
            this.buttonCalcularSemiperimetro.Name = "buttonCalcularSemiperimetro";
            this.buttonCalcularSemiperimetro.Size = new System.Drawing.Size(188, 51);
            this.buttonCalcularSemiperimetro.TabIndex = 0;
            this.buttonCalcularSemiperimetro.Text = "Serpentimiento";
            this.buttonCalcularSemiperimetro.UseVisualStyleBackColor = true;
            this.buttonCalcularSemiperimetro.Click += new System.EventHandler(this.ButtonCalcularSemiperimetro);
            // 
            // buttonArea
            // 
            this.buttonArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArea.Location = new System.Drawing.Point(225, 201);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.Size = new System.Drawing.Size(137, 51);
            this.buttonArea.TabIndex = 1;
            this.buttonArea.Text = "Area";
            this.buttonArea.UseVisualStyleBackColor = true;
            this.buttonArea.Click += new System.EventHandler(this.ButtonArea_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(379, 201);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(151, 51);
            this.buttonLimpiar.TabIndex = 2;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.ButtonLimpiar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Location = new System.Drawing.Point(551, 201);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(170, 51);
            this.buttonSalir.TabIndex = 3;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.ButtonSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingresa longitud lado A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingresa longitud lado B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingresa longitud lado C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Calcular Serpentimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Area del Triangulo";
            // 
            // textBoxLadoA
            // 
            this.textBoxLadoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLadoA.Location = new System.Drawing.Point(418, 34);
            this.textBoxLadoA.Name = "textBoxLadoA";
            this.textBoxLadoA.Size = new System.Drawing.Size(75, 24);
            this.textBoxLadoA.TabIndex = 9;
            // 
            // textBoxLadoB
            // 
            this.textBoxLadoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLadoB.Location = new System.Drawing.Point(418, 79);
            this.textBoxLadoB.Name = "textBoxLadoB";
            this.textBoxLadoB.Size = new System.Drawing.Size(75, 24);
            this.textBoxLadoB.TabIndex = 10;
            // 
            // textBoxLadoC
            // 
            this.textBoxLadoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLadoC.Location = new System.Drawing.Point(418, 123);
            this.textBoxLadoC.Name = "textBoxLadoC";
            this.textBoxLadoC.Size = new System.Drawing.Size(75, 24);
            this.textBoxLadoC.TabIndex = 11;
            // 
            // labelSemiperimetro
            // 
            this.labelSemiperimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemiperimetro.Location = new System.Drawing.Point(366, 312);
            this.labelSemiperimetro.Name = "labelSemiperimetro";
            this.labelSemiperimetro.Size = new System.Drawing.Size(355, 27);
            this.labelSemiperimetro.TabIndex = 12;
            // 
            // labelArea
            // 
            this.labelArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArea.Location = new System.Drawing.Point(366, 366);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(355, 27);
            this.labelArea.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.labelSemiperimetro);
            this.Controls.Add(this.textBoxLadoC);
            this.Controls.Add(this.textBoxLadoB);
            this.Controls.Add(this.textBoxLadoA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonArea);
            this.Controls.Add(this.buttonCalcularSemiperimetro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalcularSemiperimetro;
        private System.Windows.Forms.Button buttonArea;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLadoA;
        private System.Windows.Forms.TextBox textBoxLadoB;
        private System.Windows.Forms.TextBox textBoxLadoC;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox labelSemiperimetro;
        private System.Windows.Forms.TextBox labelArea;
    }
}
