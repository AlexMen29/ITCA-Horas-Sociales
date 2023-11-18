namespace HorasSociales2
{
    partial class FrmHorarioPeriodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHorarioPeriodo));
            pnlTop = new Panel();
            picLogo = new PictureBox();
            pnlTitle = new Panel();
            lblTitle = new Label();
            picLine = new PictureBox();
            pnlLeft = new Panel();
            pnlContent = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            cmbUntilSUN = new ComboBox();
            cmbUntilSAT = new ComboBox();
            cmbUntilFRI = new ComboBox();
            cmbUntilTHU = new ComboBox();
            cmbUntilWED = new ComboBox();
            cmbUntilTUE = new ComboBox();
            cmbSinceSUN = new ComboBox();
            cmbSinceSAT = new ComboBox();
            cmbSinceFRI = new ComboBox();
            cmbSinceTHU = new ComboBox();
            cmbSinceWED = new ComboBox();
            cmbSinceTUE = new ComboBox();
            lblUntil = new Label();
            lblDay3 = new Label();
            lblDay2 = new Label();
            lblDay1 = new Label();
            lblHour = new Label();
            lblDay4 = new Label();
            lblDay5 = new Label();
            lblDay6 = new Label();
            lblDay7 = new Label();
            lblSince = new Label();
            cmbUntilMON = new ComboBox();
            cmbSinceMON = new ComboBox();
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
            tableLayoutPanel1.SuspendLayout();
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
            lblTitle.Tag = "4. Horario y Periodo en el que se realizara el Servicio Social";
            lblTitle.Text = "4. Horario y Periodo en el que se realizara el Servicio Social";
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
            pnlContent.Controls.Add(tableLayoutPanel1);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(232, 194);
            pnlContent.Margin = new Padding(4, 3, 4, 3);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(947, 396);
            pnlContent.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Controls.Add(cmbUntilSUN, 7, 2);
            tableLayoutPanel1.Controls.Add(cmbUntilSAT, 6, 2);
            tableLayoutPanel1.Controls.Add(cmbUntilFRI, 5, 2);
            tableLayoutPanel1.Controls.Add(cmbUntilTHU, 4, 2);
            tableLayoutPanel1.Controls.Add(cmbUntilWED, 3, 2);
            tableLayoutPanel1.Controls.Add(cmbUntilTUE, 2, 2);
            tableLayoutPanel1.Controls.Add(cmbSinceSUN, 7, 1);
            tableLayoutPanel1.Controls.Add(cmbSinceSAT, 6, 1);
            tableLayoutPanel1.Controls.Add(cmbSinceFRI, 5, 1);
            tableLayoutPanel1.Controls.Add(cmbSinceTHU, 4, 1);
            tableLayoutPanel1.Controls.Add(cmbSinceWED, 3, 1);
            tableLayoutPanel1.Controls.Add(cmbSinceTUE, 2, 1);
            tableLayoutPanel1.Controls.Add(lblUntil, 0, 2);
            tableLayoutPanel1.Controls.Add(lblDay3, 3, 0);
            tableLayoutPanel1.Controls.Add(lblDay2, 2, 0);
            tableLayoutPanel1.Controls.Add(lblDay1, 1, 0);
            tableLayoutPanel1.Controls.Add(lblHour, 0, 0);
            tableLayoutPanel1.Controls.Add(lblDay4, 4, 0);
            tableLayoutPanel1.Controls.Add(lblDay5, 5, 0);
            tableLayoutPanel1.Controls.Add(lblDay6, 6, 0);
            tableLayoutPanel1.Controls.Add(lblDay7, 7, 0);
            tableLayoutPanel1.Controls.Add(lblSince, 0, 1);
            tableLayoutPanel1.Controls.Add(cmbUntilMON, 1, 2);
            tableLayoutPanel1.Controls.Add(cmbSinceMON, 1, 1);
            tableLayoutPanel1.Location = new Point(55, 18);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.Size = new Size(849, 359);
            tableLayoutPanel1.TabIndex = 22;
            // 
            // cmbUntilSUN
            // 
            cmbUntilSUN.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUntilSUN.Enabled = false;
            cmbUntilSUN.FormattingEnabled = true;
            cmbUntilSUN.Items.AddRange(new object[] { "8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM", "7:00 PM" });
            cmbUntilSUN.Location = new Point(746, 200);
            cmbUntilSUN.Name = "cmbUntilSUN";
            cmbUntilSUN.Size = new Size(99, 23);
            cmbUntilSUN.TabIndex = 46;
            // 
            // cmbUntilSAT
            // 
            cmbUntilSAT.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUntilSAT.Enabled = false;
            cmbUntilSAT.FormattingEnabled = true;
            cmbUntilSAT.Items.AddRange(new object[] { "8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM", "7:00 PM" });
            cmbUntilSAT.Location = new Point(640, 200);
            cmbUntilSAT.Name = "cmbUntilSAT";
            cmbUntilSAT.Size = new Size(99, 23);
            cmbUntilSAT.TabIndex = 45;
            // 
            // cmbUntilFRI
            // 
            cmbUntilFRI.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUntilFRI.Enabled = false;
            cmbUntilFRI.FormattingEnabled = true;
            cmbUntilFRI.Items.AddRange(new object[] { "8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM", "7:00 PM" });
            cmbUntilFRI.Location = new Point(534, 200);
            cmbUntilFRI.Name = "cmbUntilFRI";
            cmbUntilFRI.Size = new Size(99, 23);
            cmbUntilFRI.TabIndex = 44;
            // 
            // cmbUntilTHU
            // 
            cmbUntilTHU.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUntilTHU.Enabled = false;
            cmbUntilTHU.FormattingEnabled = true;
            cmbUntilTHU.Items.AddRange(new object[] { "8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM", "7:00 PM" });
            cmbUntilTHU.Location = new Point(428, 200);
            cmbUntilTHU.Name = "cmbUntilTHU";
            cmbUntilTHU.Size = new Size(99, 23);
            cmbUntilTHU.TabIndex = 43;
            // 
            // cmbUntilWED
            // 
            cmbUntilWED.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUntilWED.Enabled = false;
            cmbUntilWED.FormattingEnabled = true;
            cmbUntilWED.Items.AddRange(new object[] { "8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM", "7:00 PM" });
            cmbUntilWED.Location = new Point(322, 200);
            cmbUntilWED.Name = "cmbUntilWED";
            cmbUntilWED.Size = new Size(99, 23);
            cmbUntilWED.TabIndex = 42;
            // 
            // cmbUntilTUE
            // 
            cmbUntilTUE.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUntilTUE.Enabled = false;
            cmbUntilTUE.FormattingEnabled = true;
            cmbUntilTUE.Items.AddRange(new object[] { "8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM", "7:00 PM" });
            cmbUntilTUE.Location = new Point(216, 200);
            cmbUntilTUE.Name = "cmbUntilTUE";
            cmbUntilTUE.Size = new Size(99, 23);
            cmbUntilTUE.TabIndex = 41;
            // 
            // cmbSinceSUN
            // 
            cmbSinceSUN.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSinceSUN.FormattingEnabled = true;
            cmbSinceSUN.Items.AddRange(new object[] { "", "7:00 AM", "8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM" });
            cmbSinceSUN.Location = new Point(746, 40);
            cmbSinceSUN.Name = "cmbSinceSUN";
            cmbSinceSUN.Size = new Size(99, 23);
            cmbSinceSUN.TabIndex = 40;
            // 
            // cmbSinceSAT
            // 
            cmbSinceSAT.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSinceSAT.FormattingEnabled = true;
            cmbSinceSAT.Items.AddRange(new object[] { "", "7:00 AM", "8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM" });
            cmbSinceSAT.Location = new Point(640, 40);
            cmbSinceSAT.Name = "cmbSinceSAT";
            cmbSinceSAT.Size = new Size(99, 23);
            cmbSinceSAT.TabIndex = 39;
            // 
            // cmbSinceFRI
            // 
            cmbSinceFRI.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSinceFRI.FormattingEnabled = true;
            cmbSinceFRI.Items.AddRange(new object[] { "", "7:00 AM", "8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM" });
            cmbSinceFRI.Location = new Point(534, 40);
            cmbSinceFRI.Name = "cmbSinceFRI";
            cmbSinceFRI.Size = new Size(99, 23);
            cmbSinceFRI.TabIndex = 38;
            // 
            // cmbSinceTHU
            // 
            cmbSinceTHU.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSinceTHU.FormattingEnabled = true;
            cmbSinceTHU.Items.AddRange(new object[] { "", "7:00 AM", "8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM" });
            cmbSinceTHU.Location = new Point(428, 40);
            cmbSinceTHU.Name = "cmbSinceTHU";
            cmbSinceTHU.Size = new Size(99, 23);
            cmbSinceTHU.TabIndex = 37;
            // 
            // cmbSinceWED
            // 
            cmbSinceWED.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSinceWED.FormattingEnabled = true;
            cmbSinceWED.Items.AddRange(new object[] { "", "7:00 AM", "8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM" });
            cmbSinceWED.Location = new Point(322, 40);
            cmbSinceWED.Name = "cmbSinceWED";
            cmbSinceWED.Size = new Size(99, 23);
            cmbSinceWED.TabIndex = 36;
            // 
            // cmbSinceTUE
            // 
            cmbSinceTUE.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSinceTUE.FormattingEnabled = true;
            cmbSinceTUE.Items.AddRange(new object[] { "", "7:00 AM", "8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM" });
            cmbSinceTUE.Location = new Point(216, 40);
            cmbSinceTUE.Name = "cmbSinceTUE";
            cmbSinceTUE.Size = new Size(99, 23);
            cmbSinceTUE.TabIndex = 35;
            // 
            // lblUntil
            // 
            lblUntil.Anchor = AnchorStyles.None;
            lblUntil.BackColor = Color.Transparent;
            lblUntil.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUntil.Location = new Point(5, 260);
            lblUntil.Margin = new Padding(4, 0, 4, 0);
            lblUntil.Name = "lblUntil";
            lblUntil.RightToLeft = RightToLeft.No;
            lblUntil.Size = new Size(97, 35);
            lblUntil.TabIndex = 32;
            lblUntil.Tag = "PM";
            lblUntil.Text = "Hasta";
            lblUntil.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDay3
            // 
            lblDay3.Anchor = AnchorStyles.Top;
            lblDay3.BackColor = Color.Transparent;
            lblDay3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDay3.Location = new Point(323, 1);
            lblDay3.Margin = new Padding(4, 0, 4, 0);
            lblDay3.Name = "lblDay3";
            lblDay3.RightToLeft = RightToLeft.No;
            lblDay3.Size = new Size(97, 35);
            lblDay3.TabIndex = 25;
            lblDay3.Tag = "Miércoles";
            lblDay3.Text = "Miércoles";
            lblDay3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDay2
            // 
            lblDay2.Anchor = AnchorStyles.Top;
            lblDay2.BackColor = Color.Transparent;
            lblDay2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDay2.Location = new Point(217, 1);
            lblDay2.Margin = new Padding(4, 0, 4, 0);
            lblDay2.Name = "lblDay2";
            lblDay2.RightToLeft = RightToLeft.No;
            lblDay2.Size = new Size(97, 35);
            lblDay2.TabIndex = 24;
            lblDay2.Tag = "Martes";
            lblDay2.Text = "Martes";
            lblDay2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDay1
            // 
            lblDay1.Anchor = AnchorStyles.Top;
            lblDay1.BackColor = Color.Transparent;
            lblDay1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDay1.Location = new Point(111, 1);
            lblDay1.Margin = new Padding(4, 0, 4, 0);
            lblDay1.Name = "lblDay1";
            lblDay1.RightToLeft = RightToLeft.No;
            lblDay1.Size = new Size(97, 35);
            lblDay1.TabIndex = 23;
            lblDay1.Tag = "Lunes";
            lblDay1.Text = "Lunes";
            lblDay1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHour
            // 
            lblHour.Anchor = AnchorStyles.Top;
            lblHour.BackColor = Color.Transparent;
            lblHour.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHour.Location = new Point(5, 1);
            lblHour.Margin = new Padding(4, 0, 4, 0);
            lblHour.Name = "lblHour";
            lblHour.RightToLeft = RightToLeft.No;
            lblHour.Size = new Size(97, 35);
            lblHour.TabIndex = 26;
            lblHour.Tag = "Hora / Día";
            lblHour.Text = "Hora / Día";
            lblHour.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDay4
            // 
            lblDay4.Anchor = AnchorStyles.Top;
            lblDay4.BackColor = Color.Transparent;
            lblDay4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDay4.Location = new Point(429, 1);
            lblDay4.Margin = new Padding(4, 0, 4, 0);
            lblDay4.Name = "lblDay4";
            lblDay4.RightToLeft = RightToLeft.No;
            lblDay4.Size = new Size(97, 35);
            lblDay4.TabIndex = 29;
            lblDay4.Tag = "Jueves";
            lblDay4.Text = "Jueves";
            lblDay4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDay5
            // 
            lblDay5.Anchor = AnchorStyles.Top;
            lblDay5.BackColor = Color.Transparent;
            lblDay5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDay5.Location = new Point(535, 1);
            lblDay5.Margin = new Padding(4, 0, 4, 0);
            lblDay5.Name = "lblDay5";
            lblDay5.RightToLeft = RightToLeft.No;
            lblDay5.Size = new Size(97, 35);
            lblDay5.TabIndex = 28;
            lblDay5.Tag = "Viernes";
            lblDay5.Text = "Viernes";
            lblDay5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDay6
            // 
            lblDay6.Anchor = AnchorStyles.Top;
            lblDay6.BackColor = Color.Transparent;
            lblDay6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDay6.Location = new Point(641, 1);
            lblDay6.Margin = new Padding(4, 0, 4, 0);
            lblDay6.Name = "lblDay6";
            lblDay6.RightToLeft = RightToLeft.No;
            lblDay6.Size = new Size(97, 35);
            lblDay6.TabIndex = 27;
            lblDay6.Tag = "Sábado";
            lblDay6.Text = "Sábado";
            lblDay6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDay7
            // 
            lblDay7.Anchor = AnchorStyles.Top;
            lblDay7.BackColor = Color.Transparent;
            lblDay7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDay7.Location = new Point(747, 1);
            lblDay7.Margin = new Padding(4, 0, 4, 0);
            lblDay7.Name = "lblDay7";
            lblDay7.RightToLeft = RightToLeft.No;
            lblDay7.Size = new Size(97, 35);
            lblDay7.TabIndex = 30;
            lblDay7.Tag = "Domingo";
            lblDay7.Text = "Domingo";
            lblDay7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSince
            // 
            lblSince.Anchor = AnchorStyles.None;
            lblSince.BackColor = Color.Transparent;
            lblSince.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSince.Location = new Point(5, 99);
            lblSince.Margin = new Padding(4, 0, 4, 0);
            lblSince.Name = "lblSince";
            lblSince.RightToLeft = RightToLeft.No;
            lblSince.Size = new Size(97, 35);
            lblSince.TabIndex = 31;
            lblSince.Tag = "AM";
            lblSince.Text = "Desde";
            lblSince.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbUntilMON
            // 
            cmbUntilMON.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUntilMON.Enabled = false;
            cmbUntilMON.FormattingEnabled = true;
            cmbUntilMON.Items.AddRange(new object[] { "8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM", "7:00 PM" });
            cmbUntilMON.Location = new Point(110, 200);
            cmbUntilMON.Name = "cmbUntilMON";
            cmbUntilMON.Size = new Size(99, 23);
            cmbUntilMON.TabIndex = 34;
            // 
            // cmbSinceMON
            // 
            cmbSinceMON.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSinceMON.FormattingEnabled = true;
            cmbSinceMON.Items.AddRange(new object[] { "", "7:00 AM", "8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM" });
            cmbSinceMON.Location = new Point(110, 40);
            cmbSinceMON.Name = "cmbSinceMON";
            cmbSinceMON.Size = new Size(99, 23);
            cmbSinceMON.TabIndex = 33;
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
            btnBack.TabIndex = 7;
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
            btnNext.TabIndex = 17;
            btnNext.Tag = "Siguiente";
            btnNext.Text = "Terminar";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // FrmHorarioPeriodo
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
            Name = "FrmHorarioPeriodo";
            Text = "Horas Sociales";
            Load += FrmHorarioPeriodo_Load;
            pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLine).EndInit();
            pnlContent.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
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
        private Panel pnlRight;
        private Panel panel1;
        private Panel pnlBottom;
        private Button btnNext;
        private PictureBox pictureBox1;
        private Button btnBack;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblUntil;
        private Label lblDay3;
        private Label lblDay2;
        private Label lblDay1;
        private Label lblHour;
        private Label lblDay4;
        private Label lblDay5;
        private Label lblDay6;
        private Label lblDay7;
        private Label lblSince;
        private ComboBox cmbSinceSUN;
        private ComboBox cmbSinceSAT;
        private ComboBox cmbSinceFRI;
        private ComboBox cmbSinceTHU;
        private ComboBox cmbSinceWED;
        private ComboBox cmbSinceTUE;
        private ComboBox cmbSinceMON;
        private ComboBox cmbUntilMON;
        private ComboBox cmbUntilSUN;
        private ComboBox cmbUntilSAT;
        private ComboBox cmbUntilFRI;
        private ComboBox cmbUntilTHU;
        private ComboBox cmbUntilWED;
        private ComboBox cmbUntilTUE;
    }
}

