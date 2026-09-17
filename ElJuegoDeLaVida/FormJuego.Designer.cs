namespace ElJuegoDeLaVida
{
    partial class FormJuego
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
            components = new System.ComponentModel.Container();
            menuOpciones = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            menuIniciar = new ToolStripMenuItem();
            menuReiniciar = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            menuGuardar = new ToolStripMenuItem();
            menuCargar = new ToolStripMenuItem();
            menuAvanzar = new ToolStripMenuItem();
            menuModoNocturno = new ToolStripMenuItem();
            importarPatronToolStripMenuItem = new ToolStripMenuItem();
            menuAyuda = new ToolStripMenuItem();
            menuComoJugar = new ToolStripMenuItem();
            menuAcercaDe = new ToolStripMenuItem();
            menuSalir = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            menuOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // menuOpciones
            // 
            menuOpciones.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuOpciones.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem, menuAvanzar, menuModoNocturno, importarPatronToolStripMenuItem, menuAyuda, menuSalir });
            menuOpciones.Location = new Point(0, 0);
            menuOpciones.Name = "menuOpciones";
            menuOpciones.Size = new Size(1904, 25);
            menuOpciones.TabIndex = 6;
            menuOpciones.Text = "menuOpciones";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuIniciar, menuReiniciar, toolStripSeparator1, menuGuardar, menuCargar });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(57, 21);
            opcionesToolStripMenuItem.Text = "Juego";
            // 
            // menuIniciar
            // 
            menuIniciar.Name = "menuIniciar";
            menuIniciar.Size = new Size(201, 22);
            menuIniciar.Text = "Iniciar";
            menuIniciar.Click += menuIniciar_Click;
            // 
            // menuReiniciar
            // 
            menuReiniciar.Name = "menuReiniciar";
            menuReiniciar.Size = new Size(201, 22);
            menuReiniciar.Text = "Reiniciar Simulación";
            menuReiniciar.Click += menuReiniciar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(198, 6);
            // 
            // menuGuardar
            // 
            menuGuardar.Name = "menuGuardar";
            menuGuardar.Size = new Size(201, 22);
            menuGuardar.Text = "Guardar";
            menuGuardar.Click += menuGuardar_Click;
            // 
            // menuCargar
            // 
            menuCargar.Name = "menuCargar";
            menuCargar.Size = new Size(201, 22);
            menuCargar.Text = "Cargar";
            menuCargar.Click += menuCargar_Click;
            // 
            // menuAvanzar
            // 
            menuAvanzar.Name = "menuAvanzar";
            menuAvanzar.Size = new Size(141, 21);
            menuAvanzar.Text = "Avanzar generación";
            menuAvanzar.Click += avanzarGeneraciónToolStripMenuItem_Click;
            // 
            // menuModoNocturno
            // 
            menuModoNocturno.Name = "menuModoNocturno";
            menuModoNocturno.Size = new Size(118, 21);
            menuModoNocturno.Text = "Modo Nocturno";
            menuModoNocturno.Click += menuModoNocturno_Click;
            // 
            // importarPatronToolStripMenuItem
            // 
            importarPatronToolStripMenuItem.Name = "importarPatronToolStripMenuItem";
            importarPatronToolStripMenuItem.Size = new Size(119, 21);
            importarPatronToolStripMenuItem.Text = "Importar patron";
            importarPatronToolStripMenuItem.Click += importarPatronToolStripMenuItem_Click;
            // 
            // menuAyuda
            // 
            menuAyuda.DropDownItems.AddRange(new ToolStripItem[] { menuComoJugar, menuAcercaDe });
            menuAyuda.Name = "menuAyuda";
            menuAyuda.Size = new Size(59, 21);
            menuAyuda.Text = "Ayuda";
            // 
            // menuComoJugar
            // 
            menuComoJugar.Name = "menuComoJugar";
            menuComoJugar.Size = new Size(162, 22);
            menuComoJugar.Text = "¿Como Jugar?";
            menuComoJugar.Click += menuComoJugar_Click;
            // 
            // menuAcercaDe
            // 
            menuAcercaDe.Name = "menuAcercaDe";
            menuAcercaDe.Size = new Size(162, 22);
            menuAcercaDe.Text = "Acerca de";
            menuAcercaDe.Click += menuAcercaDe_Click;
            // 
            // menuSalir
            // 
            menuSalir.Name = "menuSalir";
            menuSalir.Size = new Size(47, 21);
            menuSalir.Text = "Salir";
            menuSalir.Click += menuSalir_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FormJuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(menuOpciones);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormJuego";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormJuego";
            FormClosing += FormJuego_FormClosing;
            FormClosed += FormJuego_FormClosed;
            Load += FormJuego_Load;
            Paint += FormJuego_Paint;
            MouseClick += FormJuego_MouseClick;
            menuOpciones.ResumeLayout(false);
            menuOpciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuOpciones;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem menuIniciar;
        private ToolStripMenuItem menuReiniciar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem menuGuardar;
        private ToolStripMenuItem menuCargar;
        private ToolStripMenuItem menuModoNocturno;
        private ToolStripMenuItem menuAyuda;
        private ToolStripMenuItem menuComoJugar;
        private ToolStripMenuItem menuAcercaDe;
        private ToolStripMenuItem menuSalir;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem importarPatronToolStripMenuItem;
        private ToolStripMenuItem menuAvanzar;
    }
}