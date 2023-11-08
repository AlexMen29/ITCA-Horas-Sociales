namespace HorasSociales2
{
    partial class FrmDatosInstitucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatosInstitucion));
            pnlTop = new Panel();
            picLogo = new PictureBox();
            pnlTitle = new Panel();
            lblTitle = new Label();
            picLine = new PictureBox();
            pnlLeft = new Panel();
            pnlContent = new Panel();
            dateDate = new DateTimePicker();
            txtEGPhone = new TextBox();
            txtResponsable = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            lblName = new Label();
            txtSchool = new TextBox();
            lblTime = new Label();
            lblEGPhone = new Label();
            lblResponsable = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblSchool = new Label();
            lblDate = new Label();
            txtTime = new TextBox();
            txtName = new TextBox();
            pnlRight = new Panel();
            panel1 = new Panel();
            pnlBottom = new Panel();
            btnBack = new Button();
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
            lblTitle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(93, 9);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.RightToLeft = RightToLeft.No;
            lblTitle.Size = new Size(812, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Tag = "2. Datos Generales de la Institución en la que realizara su servicio social";
            lblTitle.Text = "2. Datos Generales de la Institución en la que realizara su servicio social";
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
            pnlContent.Controls.Add(dateDate);
            pnlContent.Controls.Add(txtEGPhone);
            pnlContent.Controls.Add(txtResponsable);
            pnlContent.Controls.Add(txtPhone);
            pnlContent.Controls.Add(txtEmail);
            pnlContent.Controls.Add(lblName);
            pnlContent.Controls.Add(txtSchool);
            pnlContent.Controls.Add(lblTime);
            pnlContent.Controls.Add(lblEGPhone);
            pnlContent.Controls.Add(lblResponsable);
            pnlContent.Controls.Add(lblPhone);
            pnlContent.Controls.Add(lblEmail);
            pnlContent.Controls.Add(lblSchool);
            pnlContent.Controls.Add(lblDate);
            pnlContent.Controls.Add(txtTime);
            pnlContent.Controls.Add(txtName);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(232, 194);
            pnlContent.Margin = new Padding(4, 3, 4, 3);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(947, 396);
            pnlContent.TabIndex = 6;
            // 
            // dateDate
            // 
            dateDate.Anchor = AnchorStyles.Top;
            dateDate.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateDate.Format = DateTimePickerFormat.Short;
            dateDate.Location = new Point(681, 563);
            dateDate.Margin = new Padding(4, 3, 4, 3);
            dateDate.MinDate = new DateTime(2000, 12, 31, 0, 0, 0, 0);
            dateDate.Name = "dateDate";
            dateDate.Size = new Size(139, 30);
            dateDate.TabIndex = 9;
            dateDate.Tag = "dateDate";
            dateDate.Value = new DateTime(2023, 10, 10, 22, 24, 9, 0);
            // 
            // txtEGPhone
            // 
            txtEGPhone.Anchor = AnchorStyles.Top;
            txtEGPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEGPhone.Location = new Point(270, 468);
            txtEGPhone.Margin = new Padding(4, 3, 4, 3);
            txtEGPhone.Name = "txtEGPhone";
            txtEGPhone.Size = new Size(187, 29);
            txtEGPhone.TabIndex = 7;
            // 
            // txtResponsable
            // 
            txtResponsable.Anchor = AnchorStyles.Top;
            txtResponsable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtResponsable.Location = new Point(270, 309);
            txtResponsable.Margin = new Padding(4, 3, 4, 3);
            txtResponsable.Name = "txtResponsable";
            txtResponsable.Size = new Size(503, 29);
            txtResponsable.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top;
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(270, 102);
            txtPhone.Margin = new Padding(4, 3, 4, 3);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(186, 29);
            txtPhone.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(270, 388);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(503, 29);
            txtEmail.TabIndex = 6;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(111, 18);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.RightToLeft = RightToLeft.No;
            lblName.Size = new Size(140, 55);
            lblName.TabIndex = 1;
            lblName.Tag = "Nombre de la Institución :";
            lblName.Text = "Nombre de la Institución :";
            lblName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSchool
            // 
            txtSchool.Anchor = AnchorStyles.Top;
            txtSchool.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSchool.Location = new Point(270, 166);
            txtSchool.Margin = new Padding(4, 3, 4, 3);
            txtSchool.Multiline = true;
            txtSchool.Name = "txtSchool";
            txtSchool.Size = new Size(503, 103);
            txtSchool.TabIndex = 4;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Top;
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.Location = new Point(46, 545);
            lblTime.Margin = new Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.RightToLeft = RightToLeft.No;
            lblTime.Size = new Size(202, 92);
            lblTime.TabIndex = 13;
            lblTime.Tag = "Coordinador de Servicio Social Estudiantil :";
            lblTime.Text = "Tiempo estimado en el que se desarrollará el proyecto :";
            lblTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEGPhone
            // 
            lblEGPhone.Anchor = AnchorStyles.Top;
            lblEGPhone.BackColor = Color.Transparent;
            lblEGPhone.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEGPhone.Location = new Point(114, 459);
            lblEGPhone.Margin = new Padding(4, 0, 4, 0);
            lblEGPhone.Name = "lblEGPhone";
            lblEGPhone.RightToLeft = RightToLeft.No;
            lblEGPhone.Size = new Size(134, 55);
            lblEGPhone.TabIndex = 12;
            lblEGPhone.Tag = "Teléfono del Responsable :";
            lblEGPhone.Text = "Teléfono del Responsable :";
            lblEGPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblResponsable
            // 
            lblResponsable.Anchor = AnchorStyles.Top;
            lblResponsable.BackColor = Color.Transparent;
            lblResponsable.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblResponsable.Location = new Point(46, 295);
            lblResponsable.Margin = new Padding(4, 0, 4, 0);
            lblResponsable.Name = "lblResponsable";
            lblResponsable.RightToLeft = RightToLeft.No;
            lblResponsable.Size = new Size(200, 55);
            lblResponsable.TabIndex = 11;
            lblResponsable.Tag = "Persona responsable de supervición :";
            lblResponsable.Text = "Persona responsable de supervición :";
            lblResponsable.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.Top;
            lblPhone.BackColor = Color.Transparent;
            lblPhone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhone.Location = new Point(139, 102);
            lblPhone.Margin = new Padding(4, 0, 4, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.RightToLeft = RightToLeft.No;
            lblPhone.Size = new Size(110, 37);
            lblPhone.TabIndex = 10;
            lblPhone.Tag = "Teléfono :";
            lblPhone.Text = "Teléfono :";
            lblPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(65, 378);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.RightToLeft = RightToLeft.No;
            lblEmail.Size = new Size(180, 53);
            lblEmail.TabIndex = 9;
            lblEmail.Tag = "Correo Electrónico de Responsable :";
            lblEmail.Text = "Correo Electrónico de Responsable :";
            lblEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSchool
            // 
            lblSchool.Anchor = AnchorStyles.Top;
            lblSchool.BackColor = Color.Transparent;
            lblSchool.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSchool.Location = new Point(130, 175);
            lblSchool.Margin = new Padding(4, 0, 4, 0);
            lblSchool.Name = "lblSchool";
            lblSchool.RightToLeft = RightToLeft.No;
            lblSchool.Size = new Size(121, 92);
            lblSchool.TabIndex = 7;
            lblSchool.Tag = "Escuela :";
            lblSchool.Text = "Principales actividades a realizar :";
            lblSchool.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(485, 554);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.RightToLeft = RightToLeft.No;
            lblDate.Size = new Size(177, 65);
            lblDate.TabIndex = 5;
            lblDate.Tag = "Fecha de Inicio del Servicio Social :";
            lblDate.Text = "Fecha de Inicio del Servicio Social :";
            lblDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTime
            // 
            txtTime.Anchor = AnchorStyles.Top;
            txtTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTime.Location = new Point(270, 572);
            txtTime.Margin = new Padding(4, 3, 4, 3);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(186, 29);
            txtTime.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(270, 28);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(503, 29);
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
            pnlBottom.Controls.Add(btnBack);
            pnlBottom.Controls.Add(pictureBox1);
            pnlBottom.Controls.Add(btnNext);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(232, 590);
            pnlBottom.Margin = new Padding(4, 3, 4, 3);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(947, 132);
            pnlBottom.TabIndex = 9;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(37, 37);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(177, 65);
            btnBack.TabIndex = 10;
            btnBack.Tag = "Atrás";
            btnBack.Text = "Atrás";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
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
            btnNext.TabIndex = 11;
            btnNext.Tag = "Siguiente";
            btnNext.Text = "Siguiente";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // FrmDatosInstitucion
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
            Name = "FrmDatosInstitucion";
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
        private Label lblDate;
        private TextBox txtTime;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblSchool;
        private Label lblTime;
        private Label lblEGPhone;
        private Label lblResponsable;
        private TextBox txtSchool;
        private TextBox txtEGPhone;
        private TextBox txtResponsable;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Panel pnlRight;
        private Panel panel1;
        private Panel pnlBottom;
        private Button btnNext;
        private PictureBox pictureBox1;
        private Button btnBack;
        private DateTimePicker dateDate;
    }
}

