
namespace practica1_cs
{
    partial class frmCalculadora
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
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cbOpcion = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(256, 101);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(329, 31);
            this.txtNumero1.TabIndex = 0;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(257, 155);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(328, 31);
            this.txtNumero2.TabIndex = 1;
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(256, 281);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(329, 31);
            this.txtResultado.TabIndex = 3;
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(130, 101);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(105, 25);
            this.lblNumero1.TabIndex = 3;
            this.lblNumero1.Text = "Numero 1\r\n";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(130, 158);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(105, 25);
            this.lblNumero2.TabIndex = 4;
            this.lblNumero2.Text = "Numero 2";
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.Location = new System.Drawing.Point(41, 223);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(194, 25);
            this.lblOpcion.TabIndex = 5;
            this.lblOpcion.Text = "Seleccione opcion:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(287, 49);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(198, 25);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Calculadora Basica";
            // 
            // cbOpcion
            // 
            this.cbOpcion.FormattingEnabled = true;
            this.cbOpcion.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion",
            "Division"});
            this.cbOpcion.Location = new System.Drawing.Point(257, 220);
            this.cbOpcion.Name = "cbOpcion";
            this.cbOpcion.Size = new System.Drawing.Size(329, 33);
            this.cbOpcion.TabIndex = 2;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(120, 281);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(115, 25);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Resultado:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(417, 350);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(168, 55);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(717, 48);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(115, 36);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(189, 350);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(165, 55);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 538);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cbOpcion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblOpcion);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNumero1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cbOpcion;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

