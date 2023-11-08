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
            txtSunPM = new TextBox();
            txtSatPM = new TextBox();
            txtFriPM = new TextBox();
            txtThuPM = new TextBox();
            txtWedPM = new TextBox();
            txtTuePM = new TextBox();
            txtMonPM = new TextBox();
            txtSunAM = new TextBox();
            txtSatAM = new TextBox();
            txtFriAM = new TextBox();
            txtThuAM = new TextBox();
            txtWedAM = new TextBox();
            txtTueAM = new TextBox();
            txtMonAM = new TextBox();
            lblPM = new Label();
            lblDay3 = new Label();
            lblDay2 = new Label();
            lblDay1 = new Label();
            lblHour = new Label();
            lblDay4 = new Label();
            lblDay5 = new Label();
            lblDay6 = new Label();
            lblDay7 = new Label();
            lblAM = new Label();
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
            tableLayoutPanel1.Controls.Add(txtSunPM, 7, 2);
            tableLayoutPanel1.Controls.Add(txtSatPM, 6, 2);
            tableLayoutPanel1.Controls.Add(txtFriPM, 5, 2);
            tableLayoutPanel1.Controls.Add(txtThuPM, 4, 2);
            tableLayoutPanel1.Controls.Add(txtWedPM, 3, 2);
            tableLayoutPanel1.Controls.Add(txtTuePM, 2, 2);
            tableLayoutPanel1.Controls.Add(txtMonPM, 1, 2);
            tableLayoutPanel1.Controls.Add(txtSunAM, 7, 1);
            tableLayoutPanel1.Controls.Add(txtSatAM, 6, 1);
            tableLayoutPanel1.Controls.Add(txtFriAM, 5, 1);
            tableLayoutPanel1.Controls.Add(txtThuAM, 4, 1);
            tableLayoutPanel1.Controls.Add(txtWedAM, 3, 1);
            tableLayoutPanel1.Controls.Add(txtTueAM, 2, 1);
            tableLayoutPanel1.Controls.Add(txtMonAM, 1, 1);
            tableLayoutPanel1.Controls.Add(lblPM, 0, 2);
            tableLayoutPanel1.Controls.Add(lblDay3, 3, 0);
            tableLayoutPanel1.Controls.Add(lblDay2, 2, 0);
            tableLayoutPanel1.Controls.Add(lblDay1, 1, 0);
            tableLayoutPanel1.Controls.Add(lblHour, 0, 0);
            tableLayoutPanel1.Controls.Add(lblDay4, 4, 0);
            tableLayoutPanel1.Controls.Add(lblDay5, 5, 0);
            tableLayoutPanel1.Controls.Add(lblDay6, 6, 0);
            tableLayoutPanel1.Controls.Add(lblDay7, 7, 0);
            tableLayoutPanel1.Controls.Add(lblAM, 0, 1);
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
            // txtSunPM
            // 
            txtSunPM.Anchor = AnchorStyles.Top;
            txtSunPM.BorderStyle = BorderStyle.None;
            txtSunPM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSunPM.HideSelection = false;
            txtSunPM.Location = new Point(747, 200);
            txtSunPM.Margin = new Padding(4, 3, 4, 3);
            txtSunPM.Multiline = true;
            txtSunPM.Name = "txtSunPM";
            txtSunPM.Size = new Size(97, 152);
            txtSunPM.TabIndex = 16;
            txtSunPM.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSatPM
            // 
            txtSatPM.Anchor = AnchorStyles.Top;
            txtSatPM.BorderStyle = BorderStyle.None;
            txtSatPM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSatPM.HideSelection = false;
            txtSatPM.Location = new Point(641, 200);
            txtSatPM.Margin = new Padding(4, 3, 4, 3);
            txtSatPM.Multiline = true;
            txtSatPM.Name = "txtSatPM";
            txtSatPM.Size = new Size(97, 152);
            txtSatPM.TabIndex = 14;
            txtSatPM.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFriPM
            // 
            txtFriPM.Anchor = AnchorStyles.Top;
            txtFriPM.BorderStyle = BorderStyle.None;
            txtFriPM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFriPM.HideSelection = false;
            txtFriPM.Location = new Point(535, 200);
            txtFriPM.Margin = new Padding(4, 3, 4, 3);
            txtFriPM.Multiline = true;
            txtFriPM.Name = "txtFriPM";
            txtFriPM.Size = new Size(97, 152);
            txtFriPM.TabIndex = 12;
            txtFriPM.TextAlign = HorizontalAlignment.Center;
            // 
            // txtThuPM
            // 
            txtThuPM.Anchor = AnchorStyles.Top;
            txtThuPM.BorderStyle = BorderStyle.None;
            txtThuPM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtThuPM.HideSelection = false;
            txtThuPM.Location = new Point(429, 200);
            txtThuPM.Margin = new Padding(4, 3, 4, 3);
            txtThuPM.Multiline = true;
            txtThuPM.Name = "txtThuPM";
            txtThuPM.Size = new Size(97, 152);
            txtThuPM.TabIndex = 10;
            txtThuPM.TextAlign = HorizontalAlignment.Center;
            // 
            // txtWedPM
            // 
            txtWedPM.Anchor = AnchorStyles.Top;
            txtWedPM.BorderStyle = BorderStyle.None;
            txtWedPM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtWedPM.HideSelection = false;
            txtWedPM.Location = new Point(323, 200);
            txtWedPM.Margin = new Padding(4, 3, 4, 3);
            txtWedPM.Multiline = true;
            txtWedPM.Name = "txtWedPM";
            txtWedPM.Size = new Size(97, 152);
            txtWedPM.TabIndex = 8;
            txtWedPM.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTuePM
            // 
            txtTuePM.Anchor = AnchorStyles.Top;
            txtTuePM.BorderStyle = BorderStyle.None;
            txtTuePM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTuePM.HideSelection = false;
            txtTuePM.Location = new Point(217, 200);
            txtTuePM.Margin = new Padding(4, 3, 4, 3);
            txtTuePM.Multiline = true;
            txtTuePM.Name = "txtTuePM";
            txtTuePM.Size = new Size(97, 152);
            txtTuePM.TabIndex = 6;
            txtTuePM.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMonPM
            // 
            txtMonPM.Anchor = AnchorStyles.Top;
            txtMonPM.BorderStyle = BorderStyle.None;
            txtMonPM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMonPM.HideSelection = false;
            txtMonPM.Location = new Point(111, 200);
            txtMonPM.Margin = new Padding(4, 3, 4, 3);
            txtMonPM.Multiline = true;
            txtMonPM.Name = "txtMonPM";
            txtMonPM.Size = new Size(97, 152);
            txtMonPM.TabIndex = 4;
            txtMonPM.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSunAM
            // 
            txtSunAM.Anchor = AnchorStyles.Top;
            txtSunAM.BorderStyle = BorderStyle.None;
            txtSunAM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSunAM.HideSelection = false;
            txtSunAM.Location = new Point(747, 40);
            txtSunAM.Margin = new Padding(4, 3, 4, 3);
            txtSunAM.Multiline = true;
            txtSunAM.Name = "txtSunAM";
            txtSunAM.Size = new Size(97, 152);
            txtSunAM.TabIndex = 15;
            txtSunAM.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSatAM
            // 
            txtSatAM.Anchor = AnchorStyles.Top;
            txtSatAM.BorderStyle = BorderStyle.None;
            txtSatAM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSatAM.HideSelection = false;
            txtSatAM.Location = new Point(641, 40);
            txtSatAM.Margin = new Padding(4, 3, 4, 3);
            txtSatAM.Multiline = true;
            txtSatAM.Name = "txtSatAM";
            txtSatAM.Size = new Size(97, 152);
            txtSatAM.TabIndex = 13;
            txtSatAM.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFriAM
            // 
            txtFriAM.Anchor = AnchorStyles.Top;
            txtFriAM.BorderStyle = BorderStyle.None;
            txtFriAM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFriAM.HideSelection = false;
            txtFriAM.Location = new Point(535, 40);
            txtFriAM.Margin = new Padding(4, 3, 4, 3);
            txtFriAM.Multiline = true;
            txtFriAM.Name = "txtFriAM";
            txtFriAM.Size = new Size(97, 152);
            txtFriAM.TabIndex = 11;
            txtFriAM.TextAlign = HorizontalAlignment.Center;
            // 
            // txtThuAM
            // 
            txtThuAM.Anchor = AnchorStyles.Top;
            txtThuAM.BorderStyle = BorderStyle.None;
            txtThuAM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtThuAM.HideSelection = false;
            txtThuAM.Location = new Point(429, 40);
            txtThuAM.Margin = new Padding(4, 3, 4, 3);
            txtThuAM.Multiline = true;
            txtThuAM.Name = "txtThuAM";
            txtThuAM.Size = new Size(97, 152);
            txtThuAM.TabIndex = 9;
            txtThuAM.TextAlign = HorizontalAlignment.Center;
            // 
            // txtWedAM
            // 
            txtWedAM.Anchor = AnchorStyles.Top;
            txtWedAM.BorderStyle = BorderStyle.None;
            txtWedAM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtWedAM.HideSelection = false;
            txtWedAM.Location = new Point(323, 40);
            txtWedAM.Margin = new Padding(4, 3, 4, 3);
            txtWedAM.Multiline = true;
            txtWedAM.Name = "txtWedAM";
            txtWedAM.Size = new Size(97, 152);
            txtWedAM.TabIndex = 7;
            txtWedAM.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTueAM
            // 
            txtTueAM.Anchor = AnchorStyles.Top;
            txtTueAM.BorderStyle = BorderStyle.None;
            txtTueAM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTueAM.HideSelection = false;
            txtTueAM.Location = new Point(217, 40);
            txtTueAM.Margin = new Padding(4, 3, 4, 3);
            txtTueAM.Multiline = true;
            txtTueAM.Name = "txtTueAM";
            txtTueAM.Size = new Size(97, 152);
            txtTueAM.TabIndex = 5;
            txtTueAM.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMonAM
            // 
            txtMonAM.Anchor = AnchorStyles.Top;
            txtMonAM.BorderStyle = BorderStyle.None;
            txtMonAM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMonAM.HideSelection = false;
            txtMonAM.Location = new Point(111, 40);
            txtMonAM.Margin = new Padding(4, 3, 4, 3);
            txtMonAM.Multiline = true;
            txtMonAM.Name = "txtMonAM";
            txtMonAM.Size = new Size(97, 152);
            txtMonAM.TabIndex = 3;
            txtMonAM.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPM
            // 
            lblPM.Anchor = AnchorStyles.None;
            lblPM.BackColor = Color.Transparent;
            lblPM.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPM.Location = new Point(5, 260);
            lblPM.Margin = new Padding(4, 0, 4, 0);
            lblPM.Name = "lblPM";
            lblPM.RightToLeft = RightToLeft.No;
            lblPM.Size = new Size(97, 35);
            lblPM.TabIndex = 32;
            lblPM.Tag = "PM";
            lblPM.Text = "PM";
            lblPM.TextAlign = ContentAlignment.MiddleCenter;
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
            // lblAM
            // 
            lblAM.Anchor = AnchorStyles.None;
            lblAM.BackColor = Color.Transparent;
            lblAM.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAM.Location = new Point(5, 99);
            lblAM.Margin = new Padding(4, 0, 4, 0);
            lblAM.Name = "lblAM";
            lblAM.RightToLeft = RightToLeft.No;
            lblAM.Size = new Size(97, 35);
            lblAM.TabIndex = 31;
            lblAM.Tag = "AM";
            lblAM.Text = "AM";
            lblAM.TextAlign = ContentAlignment.MiddleCenter;
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
            btnNext.Text = "Siguiente";
            btnNext.UseVisualStyleBackColor = true;
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
            pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLine).EndInit();
            pnlContent.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private TextBox txtSunPM;
        private TextBox txtSatPM;
        private TextBox txtFriPM;
        private TextBox txtThuPM;
        private TextBox txtWedPM;
        private TextBox txtTuePM;
        private TextBox txtMonPM;
        private TextBox txtSunAM;
        private TextBox txtSatAM;
        private TextBox txtFriAM;
        private TextBox txtThuAM;
        private TextBox txtWedAM;
        private TextBox txtTueAM;
        private TextBox txtMonAM;
        private Label lblPM;
        private Label lblDay3;
        private Label lblDay2;
        private Label lblDay1;
        private Label lblHour;
        private Label lblDay4;
        private Label lblDay5;
        private Label lblDay6;
        private Label lblDay7;
        private Label lblAM;
    }
}

