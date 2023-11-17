namespace HorasSociales2
{
    partial class FrmDatosGenerales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatosGenerales));
            pnlTop = new Panel();
            picLogo = new PictureBox();
            pnlTitle = new Panel();
            lblTitle = new Label();
            picLine = new PictureBox();
            pnlLeft = new Panel();
            pnlContent = new Panel();
            txtSSE = new TextBox();
            txtEGPhone = new TextBox();
            txtEmergency = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            lblName = new Label();
            txtCareer = new TextBox();
            txtSchool = new TextBox();
            lblSSE = new Label();
            lblEGPhone = new Label();
            lblEmergency = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblCareer = new Label();
            lblSchool = new Label();
            txtYear = new TextBox();
            lblYear = new Label();
            txtCarnet = new TextBox();
            lblCarnet = new Label();
            txtName = new TextBox();
            pnlRight = new Panel();
            panel1 = new Panel();
            pnlBottom = new Panel();
            pictureBox1 = new PictureBox();
            btnNext = new Button();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLine).BeginInit();
            pnlContent.SuspendLayout();
            panel1.SuspendLayout();
            pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.Transparent;
            pnlTop.Controls.Add(picLogo);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(232, 0);
            pnlTop.Margin = new Padding(4, 3, 4, 3);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(947, 104);
            pnlTop.TabIndex = 2;
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(12, 12);
            picLogo.Margin = new Padding(4, 3, 4, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(385, 81);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // pnlTitle
            // 
            pnlTitle.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(232, 104);
            pnlTitle.Margin = new Padding(4, 3, 4, 3);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(947, 58);
            pnlTitle.TabIndex = 4;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(338, 9);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.RightToLeft = RightToLeft.No;
            lblTitle.Size = new Size(298, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Tag = "1. Datos Generales";
            lblTitle.Text = "1. Datos Generales";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picLine
            // 
            picLine.Anchor = AnchorStyles.Top;
            picLine.Image = (Image)resources.GetObject("picLine.Image");
            picLine.Location = new Point(299, 9);
            picLine.Margin = new Padding(4, 3, 4, 3);
            picLine.Name = "picLine";
            picLine.Size = new Size(383, 9);
            picLine.TabIndex = 5;
            picLine.TabStop = false;
            // 
            // pnlLeft
            // 
            pnlLeft.BackgroundImage = (Image)resources.GetObject("pnlLeft.BackgroundImage");
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Margin = new Padding(4, 3, 4, 3);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(232, 722);
            pnlLeft.TabIndex = 0;
            // 
            // pnlContent
            // 
            pnlContent.AutoScroll = true;
            pnlContent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlContent.BackColor = Color.Transparent;
            pnlContent.Controls.Add(txtSSE);
            pnlContent.Controls.Add(txtEGPhone);
            pnlContent.Controls.Add(txtEmergency);
            pnlContent.Controls.Add(txtPhone);
            pnlContent.Controls.Add(txtEmail);
            pnlContent.Controls.Add(lblName);
            pnlContent.Controls.Add(txtCareer);
            pnlContent.Controls.Add(txtSchool);
            pnlContent.Controls.Add(lblSSE);
            pnlContent.Controls.Add(lblEGPhone);
            pnlContent.Controls.Add(lblEmergency);
            pnlContent.Controls.Add(lblPhone);
            pnlContent.Controls.Add(lblEmail);
            pnlContent.Controls.Add(lblCareer);
            pnlContent.Controls.Add(lblSchool);
            pnlContent.Controls.Add(txtYear);
            pnlContent.Controls.Add(lblYear);
            pnlContent.Controls.Add(txtCarnet);
            pnlContent.Controls.Add(lblCarnet);
            pnlContent.Controls.Add(txtName);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(232, 194);
            pnlContent.Margin = new Padding(4, 3, 4, 3);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(947, 396);
            pnlContent.TabIndex = 6;
            // 
            // txtSSE
            // 
            txtSSE.Anchor = AnchorStyles.Top;
            txtSSE.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSSE.Location = new Point(299, 563);
            txtSSE.Margin = new Padding(4, 3, 4, 3);
            txtSSE.Name = "txtSSE";
            txtSSE.Size = new Size(475, 29);
            txtSSE.TabIndex = 20;
            // 
            // txtEGPhone
            // 
            txtEGPhone.Anchor = AnchorStyles.Top;
            txtEGPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEGPhone.Location = new Point(299, 489);
            txtEGPhone.Margin = new Padding(4, 3, 4, 3);
            txtEGPhone.Name = "txtEGPhone";
            txtEGPhone.Size = new Size(187, 29);
            txtEGPhone.TabIndex = 19;
            // 
            // txtEmergency
            // 
            txtEmergency.Anchor = AnchorStyles.Top;
            txtEmergency.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmergency.Location = new Point(299, 415);
            txtEmergency.Margin = new Padding(4, 3, 4, 3);
            txtEmergency.Name = "txtEmergency";
            txtEmergency.Size = new Size(494, 29);
            txtEmergency.TabIndex = 18;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top;
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(299, 342);
            txtPhone.Margin = new Padding(4, 3, 4, 3);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(186, 29);
            txtPhone.TabIndex = 17;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(299, 277);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(494, 29);
            txtEmail.TabIndex = 16;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(55, 18);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.RightToLeft = RightToLeft.No;
            lblName.Size = new Size(232, 37);
            lblName.TabIndex = 1;
            lblName.Tag = "Nombre del Estudiante : ";
            lblName.Text = "Nombre del Estudiante :";
            lblName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCareer
            // 
            txtCareer.Anchor = AnchorStyles.Top;
            txtCareer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCareer.Location = new Point(299, 212);
            txtCareer.Margin = new Padding(4, 3, 4, 3);
            txtCareer.Name = "txtCareer";
            txtCareer.Size = new Size(494, 29);
            txtCareer.TabIndex = 15;
            // 
            // txtSchool
            // 
            txtSchool.Anchor = AnchorStyles.Top;
            txtSchool.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSchool.Location = new Point(299, 148);
            txtSchool.Margin = new Padding(4, 3, 4, 3);
            txtSchool.Name = "txtSchool";
            txtSchool.Size = new Size(494, 29);
            txtSchool.TabIndex = 14;
            // 
            // lblSSE
            // 
            lblSSE.Anchor = AnchorStyles.Top;
            lblSSE.BackColor = Color.Transparent;
            lblSSE.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSSE.Location = new Point(56, 554);
            lblSSE.Margin = new Padding(4, 0, 4, 0);
            lblSSE.Name = "lblSSE";
            lblSSE.RightToLeft = RightToLeft.No;
            lblSSE.Size = new Size(227, 65);
            lblSSE.TabIndex = 13;
            lblSSE.Tag = "Coordinador de Servicio Social Estudiantil :";
            lblSSE.Text = "Coordinador de Servicio Social Estudiantil :";
            lblSSE.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEGPhone
            // 
            lblEGPhone.Anchor = AnchorStyles.Top;
            lblEGPhone.BackColor = Color.Transparent;
            lblEGPhone.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEGPhone.Location = new Point(104, 485);
            lblEGPhone.Margin = new Padding(4, 0, 4, 0);
            lblEGPhone.Name = "lblEGPhone";
            lblEGPhone.RightToLeft = RightToLeft.No;
            lblEGPhone.Size = new Size(184, 37);
            lblEGPhone.TabIndex = 12;
            lblEGPhone.Tag = "Teléfono emergencia :";
            lblEGPhone.Text = "Teléfono emergencia :";
            lblEGPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEmergency
            // 
            lblEmergency.Anchor = AnchorStyles.Top;
            lblEmergency.BackColor = Color.Transparent;
            lblEmergency.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmergency.Location = new Point(56, 406);
            lblEmergency.Margin = new Padding(4, 0, 4, 0);
            lblEmergency.Name = "lblEmergency";
            lblEmergency.RightToLeft = RightToLeft.No;
            lblEmergency.Size = new Size(225, 55);
            lblEmergency.TabIndex = 11;
            lblEmergency.Tag = "En caso de emergencia contactar a :";
            lblEmergency.Text = "En caso de emergencia contactar a :";
            lblEmergency.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.Top;
            lblPhone.BackColor = Color.Transparent;
            lblPhone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhone.Location = new Point(177, 342);
            lblPhone.Margin = new Padding(4, 0, 4, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.RightToLeft = RightToLeft.No;
            lblPhone.Size = new Size(111, 37);
            lblPhone.TabIndex = 10;
            lblPhone.Tag = "Teléfono :";
            lblPhone.Text = "Teléfono :";
            lblPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(96, 277);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.RightToLeft = RightToLeft.No;
            lblEmail.Size = new Size(192, 35);
            lblEmail.TabIndex = 9;
            lblEmail.Tag = "Correo Electrónico :";
            lblEmail.Text = "Correo Electrónico :";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCareer
            // 
            lblCareer.Anchor = AnchorStyles.Top;
            lblCareer.BackColor = Color.Transparent;
            lblCareer.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCareer.Location = new Point(186, 212);
            lblCareer.Margin = new Padding(4, 0, 4, 0);
            lblCareer.Name = "lblCareer";
            lblCareer.RightToLeft = RightToLeft.No;
            lblCareer.Size = new Size(103, 37);
            lblCareer.TabIndex = 8;
            lblCareer.Tag = "Carrera :";
            lblCareer.Text = "Carrera :";
            lblCareer.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSchool
            // 
            lblSchool.Anchor = AnchorStyles.Top;
            lblSchool.BackColor = Color.Transparent;
            lblSchool.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSchool.Location = new Point(186, 148);
            lblSchool.Margin = new Padding(4, 0, 4, 0);
            lblSchool.Name = "lblSchool";
            lblSchool.RightToLeft = RightToLeft.No;
            lblSchool.Size = new Size(103, 37);
            lblSchool.TabIndex = 7;
            lblSchool.Tag = "Escuela :";
            lblSchool.Text = "Escuela :";
            lblSchool.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtYear
            // 
            txtYear.Anchor = AnchorStyles.Top;
            txtYear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtYear.Location = new Point(682, 83);
            txtYear.Margin = new Padding(4, 3, 4, 3);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(111, 29);
            txtYear.TabIndex = 6;
            txtYear.KeyPress += txtYear_KeyPress;
            // 
            // lblYear
            // 
            lblYear.Anchor = AnchorStyles.Top;
            lblYear.BackColor = Color.Transparent;
            lblYear.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblYear.Location = new Point(494, 83);
            lblYear.Margin = new Padding(4, 0, 4, 0);
            lblYear.Name = "lblYear";
            lblYear.RightToLeft = RightToLeft.No;
            lblYear.Size = new Size(177, 37);
            lblYear.TabIndex = 5;
            lblYear.Tag = "Año académico:";
            lblYear.Text = "Año académico:";
            lblYear.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCarnet
            // 
            txtCarnet.Anchor = AnchorStyles.Top;
            txtCarnet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCarnet.Location = new Point(299, 83);
            txtCarnet.Margin = new Padding(4, 3, 4, 3);
            txtCarnet.Name = "txtCarnet";
            txtCarnet.Size = new Size(177, 29);
            txtCarnet.TabIndex = 4;
            txtCarnet.KeyPress += txtCarnet_KeyPress;
            // 
            // lblCarnet
            // 
            lblCarnet.Anchor = AnchorStyles.Top;
            lblCarnet.BackColor = Color.Transparent;
            lblCarnet.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCarnet.Location = new Point(139, 83);
            lblCarnet.Margin = new Padding(4, 0, 4, 0);
            lblCarnet.Name = "lblCarnet";
            lblCarnet.RightToLeft = RightToLeft.No;
            lblCarnet.Size = new Size(149, 37);
            lblCarnet.TabIndex = 3;
            lblCarnet.Tag = "N° de carnet :";
            lblCarnet.Text = "N° de carnet :";
            lblCarnet.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(299, 18);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(494, 29);
            txtName.TabIndex = 2;
            // 
            // pnlRight
            // 
            pnlRight.Dock = DockStyle.Right;
            pnlRight.Location = new Point(1179, 0);
            pnlRight.Margin = new Padding(4, 3, 4, 3);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(62, 722);
            pnlRight.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(picLine);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(232, 162);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(947, 32);
            panel1.TabIndex = 8;
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(pictureBox1);
            pnlBottom.Controls.Add(btnNext);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(232, 590);
            pnlBottom.Margin = new Padding(4, 3, 4, 3);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(947, 132);
            pnlBottom.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(289, 9);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 9);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.Location = new Point(745, 37);
            btnNext.Margin = new Padding(4, 3, 4, 3);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(177, 65);
            btnNext.TabIndex = 0;
            btnNext.Tag = "Siguiente";
            btnNext.Text = "Siguiente";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // FrmDatosGenerales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1241, 722);
            Controls.Add(pnlContent);
            Controls.Add(pnlBottom);
            Controls.Add(panel1);
            Controls.Add(pnlTitle);
            Controls.Add(pnlTop);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmDatosGenerales";
            Text = "Horas Sociales";
            pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLine).EndInit();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            panel1.ResumeLayout(false);
            pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLeft;
        private Panel pnlTop;
        private PictureBox picLogo;
        private Panel pnlTitle;
        private Label lblTitle;
        private PictureBox picLine;
        private Panel pnlContent;
        private Label lblName;
        private TextBox txtName;
        private Label lblCarnet;
        private TextBox txtYear;
        private Label lblYear;
        private TextBox txtCarnet;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblCareer;
        private Label lblSchool;
        private Label lblSSE;
        private Label lblEGPhone;
        private Label lblEmergency;
        private TextBox txtSchool;
        private TextBox txtSSE;
        private TextBox txtEGPhone;
        private TextBox txtEmergency;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtCareer;
        private Panel pnlRight;
        private Panel panel1;
        private Panel pnlBottom;
        private Button btnNext;
        private PictureBox pictureBox1;
    }
}

