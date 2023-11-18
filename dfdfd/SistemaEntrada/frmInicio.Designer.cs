namespace Login
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            splitContainer1 = new SplitContainer();
            pictCargando = new PictureBox();
            panel2 = new Panel();
            PicMostrar = new PictureBox();
            PicOcultar = new PictureBox();
            labRegistrarme = new Label();
            label1 = new Label();
            txtCarnet = new TextBox();
            label2 = new Label();
            btnIngresar = new Button();
            pictureBox2 = new PictureBox();
            txtPassword = new TextBox();
            label5 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictCargando).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicMostrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicOcultar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4, 3, 4, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.AutoScroll = true;
            splitContainer1.Panel1.BackgroundImage = (Image)resources.GetObject("splitContainer1.Panel1.BackgroundImage");
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel1.Controls.Add(pictCargando);
            splitContainer1.Panel1.Controls.Add(panel2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AutoScroll = true;
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Font = new Font("Yu Gothic UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            splitContainer1.Size = new Size(1283, 715);
            splitContainer1.SplitterDistance = 425;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // pictCargando
            // 
            pictCargando.Anchor = AnchorStyles.None;
            pictCargando.Image = (Image)resources.GetObject("pictCargando.Image");
            pictCargando.Location = new Point(203, 611);
            pictCargando.Name = "pictCargando";
            pictCargando.Size = new Size(57, 40);
            pictCargando.SizeMode = PictureBoxSizeMode.StretchImage;
            pictCargando.TabIndex = 21;
            pictCargando.TabStop = false;
            pictCargando.Visible = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.AutoScroll = true;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(PicMostrar);
            panel2.Controls.Add(PicOcultar);
            panel2.Controls.Add(labRegistrarme);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtCarnet);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnIngresar);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(83, 63);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(324, 542);
            panel2.TabIndex = 13;
            // 
            // PicMostrar
            // 
            PicMostrar.BackColor = Color.FromArgb(247, 233, 233);
            PicMostrar.Image = (Image)resources.GetObject("PicMostrar.Image");
            PicMostrar.Location = new Point(266, 411);
            PicMostrar.Margin = new Padding(4, 3, 4, 3);
            PicMostrar.Name = "PicMostrar";
            PicMostrar.Size = new Size(35, 23);
            PicMostrar.SizeMode = PictureBoxSizeMode.StretchImage;
            PicMostrar.TabIndex = 18;
            PicMostrar.TabStop = false;
            PicMostrar.Click += PicMostrar_Click;
            // 
            // PicOcultar
            // 
            PicOcultar.BackColor = Color.FromArgb(247, 233, 233);
            PicOcultar.Image = (Image)resources.GetObject("PicOcultar.Image");
            PicOcultar.Location = new Point(266, 411);
            PicOcultar.Margin = new Padding(4, 3, 4, 3);
            PicOcultar.Name = "PicOcultar";
            PicOcultar.Size = new Size(35, 23);
            PicOcultar.SizeMode = PictureBoxSizeMode.StretchImage;
            PicOcultar.TabIndex = 17;
            PicOcultar.TabStop = false;
            PicOcultar.Visible = false;
            PicOcultar.Click += PicOcultar_Click;
            // 
            // labRegistrarme
            // 
            labRegistrarme.Anchor = AnchorStyles.None;
            labRegistrarme.AutoSize = true;
            labRegistrarme.BackColor = Color.Transparent;
            labRegistrarme.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Underline, GraphicsUnit.Point);
            labRegistrarme.ForeColor = Color.FromArgb(176, 25, 30);
            labRegistrarme.Location = new Point(120, 77);
            labRegistrarme.Margin = new Padding(4, 0, 4, 0);
            labRegistrarme.Name = "labRegistrarme";
            labRegistrarme.Size = new Size(89, 18);
            labRegistrarme.TabIndex = 13;
            labRegistrarme.Text = "Registrarme";
            labRegistrarme.Click += labRegistrarme_Click;
            labRegistrarme.MouseEnter += labRegistrarme_MouseEnter_1;
            labRegistrarme.MouseLeave += labRegistrarme_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(92, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 24);
            label1.TabIndex = 14;
            label1.Text = "Iniciar Sesión";
            // 
            // txtCarnet
            // 
            txtCarnet.Anchor = AnchorStyles.None;
            txtCarnet.BackColor = Color.FromArgb(247, 233, 233);
            txtCarnet.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCarnet.Location = new Point(23, 324);
            txtCarnet.Margin = new Padding(4, 3, 4, 3);
            txtCarnet.Multiline = true;
            txtCarnet.Name = "txtCarnet";
            txtCarnet.PasswordChar = '*';
            txtCarnet.Size = new Size(280, 40);
            txtCarnet.TabIndex = 1;
            txtCarnet.UseSystemPasswordChar = true;
            txtCarnet.KeyPress += txtCarnet_KeyPress;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(71, 57);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(180, 18);
            label2.TabIndex = 10;
            label2.Text = "¿Aun no estas registrado?";
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.None;
            btnIngresar.BackColor = Color.FromArgb(177, 32, 31);
            btnIngresar.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.ControlLightLight;
            btnIngresar.Location = new Point(23, 462);
            btnIngresar.Margin = new Padding(4, 3, 4, 3);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(281, 52);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            btnIngresar.MouseEnter += btnIngresar_MouseEnter;
            btnIngresar.MouseLeave += btnIngresar_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(83, 120);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(180, 174);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = Color.FromArgb(247, 233, 233);
            txtPassword.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(23, 403);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(280, 40);
            txtPassword.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(20, 381);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(86, 16);
            label5.TabIndex = 6;
            label5.Text = "Contraseña";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(20, 302);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(52, 16);
            label4.TabIndex = 4;
            label4.Text = "Carnet";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.AutoSize = true;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.ImeMode = ImeMode.Disable;
            panel1.Location = new Point(21, 197);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(773, 255);
            panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(743, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(89, 190);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(620, 37);
            label6.TabIndex = 1;
            label6.Text = "Sistema de Gestión y Control de Horas Sociales";
            // 
            // frmInicio
            // 
            AcceptButton = btnIngresar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1283, 715);
            Controls.Add(splitContainer1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictCargando).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicMostrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicOcultar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label6;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtCarnet;
        private Button btnIngresar;
        private PictureBox pictureBox2;
        private TextBox txtPassword;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label labRegistrarme;
        private PictureBox PicOcultar;
        private PictureBox PicMostrar;
        private PictureBox pictureBox1;
        private PictureBox pictCargando;
    }
}

