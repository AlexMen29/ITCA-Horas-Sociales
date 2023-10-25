namespace SistemaAdministrativo
{
    partial class FrmSisAd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSisAd));
            PanelOpciones = new Panel();
            pictureBox1 = new PictureBox();
            btnHojaSocial = new Button();
            btnEnviarMensaje = new Button();
            btnEliModi = new Button();
            btnDetalles = new Button();
            btnInicio = new Button();
            btnCerrarSesion = new Button();
            PanelMenu = new Panel();
            btnPerfil = new Button();
            btnNotificacion = new Button();
            pnlLogo = new Panel();
            LabNombre = new Label();
            label1 = new Label();
            pnlContenedor = new Panel();
            PanelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            SuspendLayout();
            // 
            // PanelOpciones
            // 
            PanelOpciones.BackColor = Color.FromArgb(206, 144, 17);
            PanelOpciones.BackgroundImage = (Image)resources.GetObject("PanelOpciones.BackgroundImage");
            PanelOpciones.BackgroundImageLayout = ImageLayout.Stretch;
            PanelOpciones.Controls.Add(pictureBox1);
            PanelOpciones.Controls.Add(btnHojaSocial);
            PanelOpciones.Controls.Add(btnEnviarMensaje);
            PanelOpciones.Controls.Add(btnEliModi);
            PanelOpciones.Controls.Add(btnDetalles);
            PanelOpciones.Controls.Add(btnInicio);
            PanelOpciones.Controls.Add(btnCerrarSesion);
            PanelOpciones.Dock = DockStyle.Left;
            PanelOpciones.Location = new Point(0, 0);
            PanelOpciones.Margin = new Padding(4, 3, 4, 3);
            PanelOpciones.Name = "PanelOpciones";
            PanelOpciones.Size = new Size(271, 562);
            PanelOpciones.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(82, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // btnHojaSocial
            // 
            btnHojaSocial.Anchor = AnchorStyles.None;
            btnHojaSocial.BackColor = Color.FromArgb(176, 25, 29);
            btnHojaSocial.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHojaSocial.ForeColor = SystemColors.ControlLightLight;
            btnHojaSocial.Image = (Image)resources.GetObject("btnHojaSocial.Image");
            btnHojaSocial.ImageAlign = ContentAlignment.MiddleLeft;
            btnHojaSocial.Location = new Point(0, 378);
            btnHojaSocial.Margin = new Padding(4, 3, 4, 3);
            btnHojaSocial.Name = "btnHojaSocial";
            btnHojaSocial.Size = new Size(271, 55);
            btnHojaSocial.TabIndex = 13;
            btnHojaSocial.Text = "   Hoja de Hora Social";
            btnHojaSocial.UseVisualStyleBackColor = false;
            btnHojaSocial.Click += btnHojaSocial_Click;
            // 
            // btnEnviarMensaje
            // 
            btnEnviarMensaje.Anchor = AnchorStyles.None;
            btnEnviarMensaje.BackColor = Color.FromArgb(176, 25, 29);
            btnEnviarMensaje.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnviarMensaje.ForeColor = SystemColors.ControlLightLight;
            btnEnviarMensaje.Image = (Image)resources.GetObject("btnEnviarMensaje.Image");
            btnEnviarMensaje.ImageAlign = ContentAlignment.MiddleLeft;
            btnEnviarMensaje.Location = new Point(0, 323);
            btnEnviarMensaje.Margin = new Padding(4, 3, 4, 3);
            btnEnviarMensaje.Name = "btnEnviarMensaje";
            btnEnviarMensaje.Size = new Size(271, 55);
            btnEnviarMensaje.TabIndex = 12;
            btnEnviarMensaje.Text = "Enviar mensaje";
            btnEnviarMensaje.UseVisualStyleBackColor = false;
            // 
            // btnEliModi
            // 
            btnEliModi.Anchor = AnchorStyles.None;
            btnEliModi.BackColor = Color.FromArgb(176, 25, 29);
            btnEliModi.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliModi.ForeColor = SystemColors.ControlLightLight;
            btnEliModi.Image = (Image)resources.GetObject("btnEliModi.Image");
            btnEliModi.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliModi.Location = new Point(0, 268);
            btnEliModi.Margin = new Padding(4, 3, 4, 3);
            btnEliModi.Name = "btnEliModi";
            btnEliModi.Size = new Size(271, 55);
            btnEliModi.TabIndex = 10;
            btnEliModi.Text = "Eliminar/Modificar";
            btnEliModi.UseVisualStyleBackColor = false;
            btnEliModi.Click += button3_Click;
            // 
            // btnDetalles
            // 
            btnDetalles.Anchor = AnchorStyles.None;
            btnDetalles.BackColor = Color.FromArgb(176, 25, 29);
            btnDetalles.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDetalles.ForeColor = SystemColors.ControlLightLight;
            btnDetalles.Image = (Image)resources.GetObject("btnDetalles.Image");
            btnDetalles.ImageAlign = ContentAlignment.MiddleLeft;
            btnDetalles.Location = new Point(0, 212);
            btnDetalles.Margin = new Padding(4, 3, 4, 3);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(271, 55);
            btnDetalles.TabIndex = 9;
            btnDetalles.Text = "Detalles ";
            btnDetalles.UseVisualStyleBackColor = false;
            btnDetalles.Click += btnDetalles_Click;
            // 
            // btnInicio
            // 
            btnInicio.Anchor = AnchorStyles.None;
            btnInicio.BackColor = Color.FromArgb(176, 25, 29);
            btnInicio.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInicio.ForeColor = SystemColors.ButtonHighlight;
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(0, 151);
            btnInicio.Margin = new Padding(4, 3, 4, 3);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(271, 55);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(176, 25, 29);
            btnCerrarSesion.Dock = DockStyle.Bottom;
            btnCerrarSesion.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrarSesion.ForeColor = SystemColors.ControlLightLight;
            btnCerrarSesion.Image = (Image)resources.GetObject("btnCerrarSesion.Image");
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(0, 508);
            btnCerrarSesion.Margin = new Padding(4, 3, 4, 3);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(271, 54);
            btnCerrarSesion.TabIndex = 8;
            btnCerrarSesion.Tag = "Cerrar Sesión";
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // PanelMenu
            // 
            PanelMenu.Controls.Add(btnPerfil);
            PanelMenu.Controls.Add(btnNotificacion);
            PanelMenu.Controls.Add(pnlLogo);
            PanelMenu.Dock = DockStyle.Top;
            PanelMenu.Location = new Point(271, 0);
            PanelMenu.Margin = new Padding(4, 3, 4, 3);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(767, 46);
            PanelMenu.TabIndex = 3;
            // 
            // btnPerfil
            // 
            btnPerfil.Anchor = AnchorStyles.Right;
            btnPerfil.FlatStyle = FlatStyle.Flat;
            btnPerfil.Image = (Image)resources.GetObject("btnPerfil.Image");
            btnPerfil.Location = new Point(681, 0);
            btnPerfil.Margin = new Padding(4, 3, 4, 3);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(84, 46);
            btnPerfil.TabIndex = 4;
            btnPerfil.UseVisualStyleBackColor = true;
            // 
            // btnNotificacion
            // 
            btnNotificacion.Anchor = AnchorStyles.Right;
            btnNotificacion.FlatStyle = FlatStyle.Flat;
            btnNotificacion.Image = (Image)resources.GetObject("btnNotificacion.Image");
            btnNotificacion.Location = new Point(597, 0);
            btnNotificacion.Margin = new Padding(4, 3, 4, 3);
            btnNotificacion.Name = "btnNotificacion";
            btnNotificacion.Size = new Size(88, 46);
            btnNotificacion.TabIndex = 3;
            btnNotificacion.UseVisualStyleBackColor = true;
            btnNotificacion.MouseEnter += btnNotificacion_MouseEnter;
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(LabNombre);
            pnlLogo.Controls.Add(label1);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Margin = new Padding(4, 3, 4, 3);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(767, 46);
            pnlLogo.TabIndex = 2;
            // 
            // LabNombre
            // 
            LabNombre.AutoSize = true;
            LabNombre.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabNombre.ForeColor = SystemColors.ControlDarkDark;
            LabNombre.Location = new Point(135, 9);
            LabNombre.Margin = new Padding(4, 0, 4, 0);
            LabNombre.Name = "LabNombre";
            LabNombre.Size = new Size(14, 19);
            LabNombre.TabIndex = 1;
            LabNombre.Text = " ";
            LabNombre.Click += LabNombre_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 19);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido/a: ";
            // 
            // pnlContenedor
            // 
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(271, 46);
            pnlContenedor.Margin = new Padding(4, 3, 4, 3);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(767, 516);
            pnlContenedor.TabIndex = 4;
            pnlContenedor.Paint += pnlContenedor_Paint;
            // 
            // FrmSisAd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 562);
            Controls.Add(pnlContenedor);
            Controls.Add(PanelMenu);
            Controls.Add(PanelOpciones);
            Location = new Point(224, 40);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmSisAd";
            ShowIcon = false;
            Text = "Horas Sociales ITCA FEPADE Santa Tecla";
            WindowState = FormWindowState.Maximized;
            Load += FrmSisAd_Load;
            PanelOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelMenu.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelOpciones;
        private Button btnCerrarSesion;
        private Panel PanelMenu;
        private Button btnPerfil;
        private Button btnNotificacion;
        private Panel pnlLogo;
        private Panel pnlContenedor;
        private Button btnInicio;
        private Button btnHojaSocial;
        private Button btnEnviarMensaje;
        private Button btnEliModi;
        private Button btnDetalles;
        private Label label1;
        private PictureBox pictureBox1;
        private Label LabNombre;
    }
}

