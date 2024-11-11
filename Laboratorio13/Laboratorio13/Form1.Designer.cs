namespace Laboratorio13
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnDesplegar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Conectar y desconectar de SQL Server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(263, 160);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(262, 169);
            this.listBox1.TabIndex = 1;

            // 
            // BtnDesplegar
            // 
            this.BtnDesplegar.Location = new System.Drawing.Point(303, 360);
            this.BtnDesplegar.Name = "BtnDesplegar";
            this.BtnDesplegar.Size = new System.Drawing.Size(178, 50);
            this.BtnDesplegar.TabIndex = 2;
            this.BtnDesplegar.Text = "Desplegar Productos";
            this.BtnDesplegar.UseVisualStyleBackColor = true;
            this.BtnDesplegar.Click += new System.EventHandler(this.BtnDesplegar_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDesplegar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Conexión a SQL Server";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnDesplegar;
        private System.Windows.Forms.ListBox listBox1;
    }
}
