namespace ProyectoSocial.Otros
{
    partial class frmModificacionUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificacionUsuario));
            label1 = new Label();
            txtCorreo = new TextBox();
            txtApellidos = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtNombres = new TextBox();
            label3 = new Label();
            txtContraseña = new TextBox();
            btnGuardar = new Button();
            btnRegresar = new Button();
            PicMostrar = new PictureBox();
            PicOcultar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PicMostrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicOcultar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(177, 32, 31);
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(95, 41);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(253, 30);
            label1.TabIndex = 43;
            label1.Text = "Modificación de Usuario";
            // 
            // txtCorreo
            // 
            txtCorreo.Anchor = AnchorStyles.None;
            txtCorreo.Location = new Point(159, 296);
            txtCorreo.Margin = new Padding(4, 3, 4, 3);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(168, 23);
            txtCorreo.TabIndex = 66;
            // 
            // txtApellidos
            // 
            txtApellidos.Anchor = AnchorStyles.None;
            txtApellidos.Location = new Point(159, 240);
            txtApellidos.Margin = new Padding(4, 3, 4, 3);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(168, 23);
            txtApellidos.TabIndex = 65;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(74, 289);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 30);
            label6.TabIndex = 64;
            label6.Text = "Correo";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(42, 233);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(105, 30);
            label5.TabIndex = 63;
            label5.Text = "Apellidos";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(42, 177);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 30);
            label4.TabIndex = 62;
            label4.Text = "Nombres";
            // 
            // txtNombres
            // 
            txtNombres.Anchor = AnchorStyles.None;
            txtNombres.Location = new Point(159, 184);
            txtNombres.Margin = new Padding(4, 3, 4, 3);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(168, 23);
            txtNombres.TabIndex = 61;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(18, 121);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(123, 30);
            label3.TabIndex = 60;
            label3.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Anchor = AnchorStyles.None;
            txtContraseña.Location = new Point(159, 128);
            txtContraseña.Margin = new Padding(4, 3, 4, 3);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(168, 23);
            txtContraseña.TabIndex = 59;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = Color.FromArgb(177, 32, 31);
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(212, 369);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.RightToLeft = RightToLeft.Yes;
            btnGuardar.Size = new Size(115, 36);
            btnGuardar.TabIndex = 68;
            btnGuardar.Text = "Guadar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Anchor = AnchorStyles.None;
            btnRegresar.BackColor = Color.FromArgb(177, 32, 31);
            btnRegresar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegresar.ForeColor = SystemColors.ControlLightLight;
            btnRegresar.Location = new Point(86, 369);
            btnRegresar.Margin = new Padding(4, 3, 4, 3);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(118, 36);
            btnRegresar.TabIndex = 67;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // PicMostrar
            // 
            PicMostrar.Anchor = AnchorStyles.None;
            PicMostrar.BackColor = Color.White;
            PicMostrar.Image = (Image)resources.GetObject("PicMostrar.Image");
            PicMostrar.Location = new Point(335, 128);
            PicMostrar.Margin = new Padding(4, 3, 4, 3);
            PicMostrar.Name = "PicMostrar";
            PicMostrar.Size = new Size(35, 23);
            PicMostrar.SizeMode = PictureBoxSizeMode.StretchImage;
            PicMostrar.TabIndex = 70;
            PicMostrar.TabStop = false;
            PicMostrar.Click += PicMostrar_Click;
            // 
            // PicOcultar
            // 
            PicOcultar.Anchor = AnchorStyles.None;
            PicOcultar.BackColor = Color.White;
            PicOcultar.Image = (Image)resources.GetObject("PicOcultar.Image");
            PicOcultar.Location = new Point(335, 128);
            PicOcultar.Margin = new Padding(4, 3, 4, 3);
            PicOcultar.Name = "PicOcultar";
            PicOcultar.Size = new Size(35, 23);
            PicOcultar.SizeMode = PictureBoxSizeMode.StretchImage;
            PicOcultar.TabIndex = 69;
            PicOcultar.TabStop = false;
            PicOcultar.Visible = false;
            PicOcultar.Click += PicOcultar_Click;
            // 
            // frmModificacionUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(424, 461);
            Controls.Add(PicMostrar);
            Controls.Add(PicOcultar);
            Controls.Add(btnGuardar);
            Controls.Add(btnRegresar);
            Controls.Add(txtCorreo);
            Controls.Add(txtApellidos);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtNombres);
            Controls.Add(label3);
            Controls.Add(txtContraseña);
            Controls.Add(label1);
            Name = "frmModificacionUsuario";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ITCA FEPADE";
            Load += frmModificacionUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)PicMostrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicOcultar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCorreo;
        private TextBox txtApellidos;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtNombres;
        private Label label3;
        private TextBox txtContraseña;
        private Button btnGuardar;
        private Button btnRegresar;
        private PictureBox PicMostrar;
        private PictureBox PicOcultar;
    }
}