namespace ElJuegoDeLaVida
{
    partial class ImportarPatron
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
            listPatrones = new ListBox();
            lblNombre = new Label();
            lblInformacion = new Label();
            button1 = new Button();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // listPatrones
            // 
            listPatrones.FormattingEnabled = true;
            listPatrones.Location = new Point(12, 42);
            listPatrones.Name = "listPatrones";
            listPatrones.Size = new Size(328, 394);
            listPatrones.TabIndex = 0;
            listPatrones.SelectedIndexChanged += listPatrones_SelectedIndexChanged;
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(380, 10);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(400, 40);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblInformacion
            // 
            lblInformacion.Location = new Point(380, 60);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(400, 40);
            lblInformacion.TabIndex = 2;
            lblInformacion.Text = "Información";
            // 
            // button1
            // 
            button1.Location = new Point(540, 385);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Importar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(149, 10);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 4;
            label3.Text = "Patrones";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(390, 420);
            label1.Name = "label1";
            label1.Size = new Size(360, 17);
            label1.TabIndex = 6;
            label1.Text = "Importar este patrón borrará el dibujo actual del tablero.";
            // 
            // ImportarPatron
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(lblInformacion);
            Controls.Add(lblNombre);
            Controls.Add(listPatrones);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ImportarPatron";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Importar Patron";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listPatrones;
        private Label lblNombre;
        private Label lblInformacion;
        private Button button1;
        private Label label3;
        private Label label1;
    }
}