namespace ElJuegoDeLaVida
{
    partial class FormMenu
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
            btnJugar = new Button();
            btnCargar = new Button();
            btnComo = new Button();
            btnNocturno = new Button();
            btnSalir = new Button();
            timerMenu = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnJugar
            // 
            btnJugar.FlatStyle = FlatStyle.Flat;
            btnJugar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJugar.Location = new Point(860, 100);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(200, 50);
            btnJugar.TabIndex = 0;
            btnJugar.Text = "JUGAR";
            btnJugar.UseVisualStyleBackColor = true;
            btnJugar.Click += button1_Click;
            // 
            // btnCargar
            // 
            btnCargar.FlatStyle = FlatStyle.Flat;
            btnCargar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargar.Location = new Point(860, 250);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(200, 50);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "CARGAR PARTIDA";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += button2_Click;
            // 
            // btnComo
            // 
            btnComo.FlatStyle = FlatStyle.Flat;
            btnComo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComo.Location = new Point(860, 400);
            btnComo.Name = "btnComo";
            btnComo.Size = new Size(200, 50);
            btnComo.TabIndex = 2;
            btnComo.Text = "COMO JUGAR";
            btnComo.UseVisualStyleBackColor = true;
            btnComo.Click += button3_Click;
            // 
            // btnNocturno
            // 
            btnNocturno.FlatStyle = FlatStyle.Flat;
            btnNocturno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNocturno.Location = new Point(860, 550);
            btnNocturno.Name = "btnNocturno";
            btnNocturno.Size = new Size(200, 50);
            btnNocturno.TabIndex = 3;
            btnNocturno.Text = "MODO NOCTURNO";
            btnNocturno.UseVisualStyleBackColor = true;
            btnNocturno.Click += button4_Click;
            // 
            // btnSalir
            // 
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(860, 700);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(200, 50);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button1_Click_1;
            // 
            // timerMenu
            // 
            timerMenu.Enabled = true;
            timerMenu.Interval = 1000;
            timerMenu.Tick += timerMenu_Tick;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1904, 1041);
            Controls.Add(btnSalir);
            Controls.Add(btnNocturno);
            Controls.Add(btnComo);
            Controls.Add(btnCargar);
            Controls.Add(btnJugar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenu";
            Activated += FormMenu_Activated;
            FormClosing += FormMenu_FormClosing;
            Load += FormMenu_Load;
            Paint += FormMenu_Paint;
            ResumeLayout(false);
        }

        #endregion

        private Button btnJugar;
        private Button btnCargar;
        private Button btnComo;
        private Button btnNocturno;
        private Button btnSalir;
        private System.Windows.Forms.Timer timerMenu;
    }
}