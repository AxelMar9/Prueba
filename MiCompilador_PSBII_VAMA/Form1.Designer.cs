namespace MiCompilador_PSBII_VAMA
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
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lenguajeOriginalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lenguajeTraducidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstLenguajeOriginal = new System.Windows.Forms.ListBox();
            this.lstLenguajeTraducido = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lpLineasTraducidas = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lpLineasNoTraducidas = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCompilar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.serviciosToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1279, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lenguajeOriginalToolStripMenuItem,
            this.lenguajeTraducidoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // lenguajeOriginalToolStripMenuItem
            // 
            this.lenguajeOriginalToolStripMenuItem.Name = "lenguajeOriginalToolStripMenuItem";
            this.lenguajeOriginalToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.lenguajeOriginalToolStripMenuItem.Text = "Lenguaje Original";
            // 
            // lenguajeTraducidoToolStripMenuItem
            // 
            this.lenguajeTraducidoToolStripMenuItem.Name = "lenguajeTraducidoToolStripMenuItem";
            this.lenguajeTraducidoToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.lenguajeTraducidoToolStripMenuItem.Text = "Lenguaje Traducido";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem,
            this.ejemplosToolStripMenuItem});
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.ayudaToolStripMenuItem.Text = "Ayuda ";
            // 
            // ejemplosToolStripMenuItem
            // 
            this.ejemplosToolStripMenuItem.Name = "ejemplosToolStripMenuItem";
            this.ejemplosToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.ejemplosToolStripMenuItem.Text = "Ejemplos";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "Compilador Fase 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lenguaje Original:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(738, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(508, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lenguaje Traducido(VISUAL BASIC)";
            // 
            // lstLenguajeOriginal
            // 
            this.lstLenguajeOriginal.FormattingEnabled = true;
            this.lstLenguajeOriginal.ItemHeight = 16;
            this.lstLenguajeOriginal.Location = new System.Drawing.Point(57, 260);
            this.lstLenguajeOriginal.Name = "lstLenguajeOriginal";
            this.lstLenguajeOriginal.Size = new System.Drawing.Size(512, 308);
            this.lstLenguajeOriginal.TabIndex = 4;
            // 
            // lstLenguajeTraducido
            // 
            this.lstLenguajeTraducido.FormattingEnabled = true;
            this.lstLenguajeTraducido.ItemHeight = 16;
            this.lstLenguajeTraducido.Location = new System.Drawing.Point(744, 260);
            this.lstLenguajeTraducido.Name = "lstLenguajeTraducido";
            this.lstLenguajeTraducido.Size = new System.Drawing.Size(512, 308);
            this.lstLenguajeTraducido.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lpLineasTraducidas,
            this.toolStripStatusLabel2,
            this.lpLineasNoTraducidas});
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1279, 26);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(121, 20);
            this.toolStripStatusLabel1.Text = "LineasTraducidas";
            // 
            // lpLineasTraducidas
            // 
            this.lpLineasTraducidas.Name = "lpLineasTraducidas";
            this.lpLineasTraducidas.Size = new System.Drawing.Size(17, 20);
            this.lpLineasTraducidas.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel2.Text = "Lineas NO Traducidas";
            // 
            // lpLineasNoTraducidas
            // 
            this.lpLineasNoTraducidas.Name = "lpLineasNoTraducidas";
            this.lpLineasNoTraducidas.Size = new System.Drawing.Size(17, 20);
            this.lpLineasNoTraducidas.Text = "0";
            // 
            // btnCompilar
            // 
            this.btnCompilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompilar.Location = new System.Drawing.Point(575, 369);
            this.btnCompilar.Name = "btnCompilar";
            this.btnCompilar.Size = new System.Drawing.Size(163, 81);
            this.btnCompilar.TabIndex = 7;
            this.btnCompilar.Text = "Traducir";
            this.btnCompilar.UseVisualStyleBackColor = true;
            this.btnCompilar.Click += new System.EventHandler(this.btnCompilar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 604);
            this.Controls.Add(this.btnCompilar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lstLenguajeTraducido);
            this.Controls.Add(this.lstLenguajeOriginal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Mi Compilador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lenguajeOriginalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lenguajeTraducidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejemplosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstLenguajeOriginal;
        private System.Windows.Forms.ListBox lstLenguajeTraducido;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lpLineasTraducidas;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lpLineasNoTraducidas;
        private System.Windows.Forms.Button btnCompilar;
    }
}

