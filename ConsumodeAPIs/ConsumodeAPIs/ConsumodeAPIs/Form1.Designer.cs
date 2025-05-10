namespace ConsumodeAPIs
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            picPokemon = new PictureBox();
            lblNombre = new Label();
            Estd = new Label();
            BuscarGato = new Button();
            button1 = new Button();
            Limpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)picPokemon).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(141, 97);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(114, 27);
            txtBuscar.TabIndex = 0;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Transparent;
            btnBuscar.Location = new Point(306, 94);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(176, 32);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar Pokemon";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // picPokemon
            // 
            picPokemon.BackColor = Color.Transparent;
            picPokemon.Location = new Point(55, 171);
            picPokemon.Margin = new Padding(3, 4, 3, 4);
            picPokemon.Name = "picPokemon";
            picPokemon.Size = new Size(227, 188);
            picPokemon.SizeMode = PictureBoxSizeMode.StretchImage;
            picPokemon.TabIndex = 3;
            picPokemon.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(21, 100);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            lblNombre.Click += lblNombre_Click;
            // 
            // Estd
            // 
            Estd.AutoSize = true;
            Estd.Location = new Point(55, 373);
            Estd.Name = "Estd";
            Estd.Size = new Size(95, 20);
            Estd.TabIndex = 5;
            Estd.Text = "Esstadisticas ";
            Estd.Click += Estd_Click;
            // 
            // BuscarGato
            // 
            BuscarGato.BackColor = Color.Transparent;
            BuscarGato.Location = new Point(306, 133);
            BuscarGato.Name = "BuscarGato";
            BuscarGato.Size = new Size(176, 32);
            BuscarGato.TabIndex = 6;
            BuscarGato.Text = "Buscar gato";
            BuscarGato.UseVisualStyleBackColor = false;
            BuscarGato.Click += BuscarGato_Click;
            // 
            // button1
            // 
            button1.AccessibleName = "GuardarD";
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(306, 171);
            button1.Name = "button1";
            button1.Size = new Size(176, 32);
            button1.TabIndex = 7;
            button1.Text = "Guardar Datos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Limpiar
            // 
            Limpiar.BackColor = Color.Transparent;
            Limpiar.Location = new Point(306, 209);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(71, 31);
            Limpiar.TabIndex = 8;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = false;
            Limpiar.Click += Limpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(672, 600);
            Controls.Add(Limpiar);
            Controls.Add(button1);
            Controls.Add(BuscarGato);
            Controls.Add(Estd);
            Controls.Add(lblNombre);
            Controls.Add(picPokemon);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picPokemon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private Button btnBuscar;
        private PictureBox picPokemon;
        private Label lblNombre;
        private Label Estd;
        private Button BuscarGato;
        private Button button1;
        private Button Limpiar;
    }
}
