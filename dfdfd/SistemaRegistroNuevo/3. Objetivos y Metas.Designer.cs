namespace HorasSociales2
{
    partial class FrmObjetivosMetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmObjetivosMetas));
            pnlTop = new Panel();
            picLogo = new PictureBox();
            pnlTitle = new Panel();
            lblTitle = new Label();
            picLine = new PictureBox();
            pnlLeft = new Panel();
            pnlContent = new Panel();
            tblytMain = new TableLayoutPanel();
            lblDuracion = new Label();
            lblGoals = new Label();
            lblObjetivos = new Label();
            txtDuracion1 = new TextBox();
            lblAct = new Label();
            txtGoals1 = new TextBox();
            txtObjetivos1 = new TextBox();
            txtGoals2 = new TextBox();
            txtObjetivos2 = new TextBox();
            txtAct1 = new TextBox();
            txtAct2 = new TextBox();
            txtDuracion2 = new TextBox();
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
            tblytMain.SuspendLayout();
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
            lblTitle.Tag = "3. Objetivos Generales y Metas Concretas de la Actividad";
            lblTitle.Text = "3. Objetivos Generales y Metas Concretas de la Actividad";
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
            pnlContent.Controls.Add(tblytMain);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(232, 194);
            pnlContent.Margin = new Padding(4, 3, 4, 3);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(947, 396);
            pnlContent.TabIndex = 6;
            // 
            // tblytMain
            // 
            tblytMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tblytMain.BackColor = Color.White;
            tblytMain.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tblytMain.ColumnCount = 4;
            tblytMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblytMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblytMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblytMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblytMain.Controls.Add(lblDuracion, 3, 0);
            tblytMain.Controls.Add(lblGoals, 2, 0);
            tblytMain.Controls.Add(lblObjetivos, 1, 0);
            tblytMain.Controls.Add(txtDuracion1, 3, 1);
            tblytMain.Controls.Add(lblAct, 0, 0);
            tblytMain.Controls.Add(txtGoals1, 2, 1);
            tblytMain.Controls.Add(txtObjetivos1, 1, 1);
            tblytMain.Controls.Add(txtGoals2, 0, 2);
            tblytMain.Controls.Add(txtObjetivos2, 0, 2);
            tblytMain.Controls.Add(txtAct1, 0, 1);
            tblytMain.Controls.Add(txtAct2, 0, 2);
            tblytMain.Controls.Add(txtDuracion2, 3, 2);
            tblytMain.Location = new Point(48, 18);
            tblytMain.Margin = new Padding(4, 3, 4, 3);
            tblytMain.Name = "tblytMain";
            tblytMain.RowCount = 3;
            tblytMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblytMain.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tblytMain.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tblytMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tblytMain.Size = new Size(849, 359);
            tblytMain.TabIndex = 22;
            // 
            // lblDuracion
            // 
            lblDuracion.Anchor = AnchorStyles.Top;
            lblDuracion.BackColor = Color.Transparent;
            lblDuracion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDuracion.Location = new Point(656, 1);
            lblDuracion.Margin = new Padding(4, 0, 4, 0);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.RightToLeft = RightToLeft.No;
            lblDuracion.Size = new Size(173, 35);
            lblDuracion.TabIndex = 25;
            lblDuracion.Tag = "Duración";
            lblDuracion.Text = "Duración";
            lblDuracion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGoals
            // 
            lblGoals.Anchor = AnchorStyles.Top;
            lblGoals.BackColor = Color.Transparent;
            lblGoals.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGoals.Location = new Point(444, 1);
            lblGoals.Margin = new Padding(4, 0, 4, 0);
            lblGoals.Name = "lblGoals";
            lblGoals.RightToLeft = RightToLeft.No;
            lblGoals.Size = new Size(173, 35);
            lblGoals.TabIndex = 24;
            lblGoals.Tag = "Metas";
            lblGoals.Text = "Metas";
            lblGoals.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblObjetivos
            // 
            lblObjetivos.Anchor = AnchorStyles.Top;
            lblObjetivos.BackColor = Color.Transparent;
            lblObjetivos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblObjetivos.Location = new Point(232, 1);
            lblObjetivos.Margin = new Padding(4, 0, 4, 0);
            lblObjetivos.Name = "lblObjetivos";
            lblObjetivos.RightToLeft = RightToLeft.No;
            lblObjetivos.Size = new Size(173, 35);
            lblObjetivos.TabIndex = 23;
            lblObjetivos.Tag = "Objetivos";
            lblObjetivos.Text = "Objetivos";
            lblObjetivos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDuracion1
            // 
            txtDuracion1.Anchor = AnchorStyles.Top;
            txtDuracion1.BorderStyle = BorderStyle.None;
            txtDuracion1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDuracion1.HideSelection = false;
            txtDuracion1.Location = new Point(641, 40);
            txtDuracion1.Margin = new Padding(4, 3, 4, 3);
            txtDuracion1.Multiline = true;
            txtDuracion1.Name = "txtDuracion1";
            txtDuracion1.Size = new Size(203, 152);
            txtDuracion1.TabIndex = 8;
            txtDuracion1.TextAlign = HorizontalAlignment.Center;
            // 
            // lblAct
            // 
            lblAct.Anchor = AnchorStyles.Top;
            lblAct.BackColor = Color.Transparent;
            lblAct.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAct.Location = new Point(20, 1);
            lblAct.Margin = new Padding(4, 0, 4, 0);
            lblAct.Name = "lblAct";
            lblAct.RightToLeft = RightToLeft.No;
            lblAct.Size = new Size(173, 35);
            lblAct.TabIndex = 10;
            lblAct.Tag = "Actividad a realizar";
            lblAct.Text = "Actividad a realizar";
            lblAct.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtGoals1
            // 
            txtGoals1.Anchor = AnchorStyles.Top;
            txtGoals1.BorderStyle = BorderStyle.None;
            txtGoals1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGoals1.HideSelection = false;
            txtGoals1.Location = new Point(429, 40);
            txtGoals1.Margin = new Padding(4, 3, 4, 3);
            txtGoals1.Multiline = true;
            txtGoals1.Name = "txtGoals1";
            txtGoals1.Size = new Size(203, 152);
            txtGoals1.TabIndex = 6;
            txtGoals1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtObjetivos1
            // 
            txtObjetivos1.Anchor = AnchorStyles.Top;
            txtObjetivos1.BorderStyle = BorderStyle.None;
            txtObjetivos1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtObjetivos1.HideSelection = false;
            txtObjetivos1.Location = new Point(217, 40);
            txtObjetivos1.Margin = new Padding(4, 3, 4, 3);
            txtObjetivos1.Multiline = true;
            txtObjetivos1.Name = "txtObjetivos1";
            txtObjetivos1.Size = new Size(203, 152);
            txtObjetivos1.TabIndex = 4;
            txtObjetivos1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtGoals2
            // 
            txtGoals2.Anchor = AnchorStyles.Top;
            txtGoals2.BorderStyle = BorderStyle.None;
            txtGoals2.Enabled = false;
            txtGoals2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGoals2.HideSelection = false;
            txtGoals2.Location = new Point(217, 200);
            txtGoals2.Margin = new Padding(4, 3, 4, 3);
            txtGoals2.Multiline = true;
            txtGoals2.Name = "txtGoals2";
            txtGoals2.Size = new Size(203, 152);
            txtGoals2.TabIndex = 7;
            txtGoals2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtObjetivos2
            // 
            txtObjetivos2.BorderStyle = BorderStyle.None;
            txtObjetivos2.Enabled = false;
            txtObjetivos2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtObjetivos2.HideSelection = false;
            txtObjetivos2.Location = new Point(429, 200);
            txtObjetivos2.Margin = new Padding(4, 3, 4, 3);
            txtObjetivos2.Multiline = true;
            txtObjetivos2.Name = "txtObjetivos2";
            txtObjetivos2.Size = new Size(203, 152);
            txtObjetivos2.TabIndex = 5;
            txtObjetivos2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAct1
            // 
            txtAct1.Anchor = AnchorStyles.Top;
            txtAct1.BorderStyle = BorderStyle.None;
            txtAct1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAct1.HideSelection = false;
            txtAct1.Location = new Point(5, 40);
            txtAct1.Margin = new Padding(4, 3, 4, 3);
            txtAct1.Multiline = true;
            txtAct1.Name = "txtAct1";
            txtAct1.Size = new Size(203, 152);
            txtAct1.TabIndex = 2;
            txtAct1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAct2
            // 
            txtAct2.Anchor = AnchorStyles.Top;
            txtAct2.BorderStyle = BorderStyle.None;
            txtAct2.Enabled = false;
            txtAct2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAct2.HideSelection = false;
            txtAct2.Location = new Point(5, 200);
            txtAct2.Margin = new Padding(4, 3, 4, 3);
            txtAct2.Multiline = true;
            txtAct2.Name = "txtAct2";
            txtAct2.Size = new Size(203, 152);
            txtAct2.TabIndex = 3;
            txtAct2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDuracion2
            // 
            txtDuracion2.Anchor = AnchorStyles.Top;
            txtDuracion2.BorderStyle = BorderStyle.None;
            txtDuracion2.Enabled = false;
            txtDuracion2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDuracion2.HideSelection = false;
            txtDuracion2.Location = new Point(641, 200);
            txtDuracion2.Margin = new Padding(4, 3, 4, 3);
            txtDuracion2.Multiline = true;
            txtDuracion2.Name = "txtDuracion2";
            txtDuracion2.Size = new Size(203, 152);
            txtDuracion2.TabIndex = 26;
            txtDuracion2.TextAlign = HorizontalAlignment.Center;
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
            btnNext.TabIndex = 10;
            btnNext.Tag = "Siguiente";
            btnNext.Text = "Siguiente";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // FrmObjetivosMetas
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
            Name = "FrmObjetivosMetas";
            Text = "Horas Sociales";
            Load += FrmObjetivosMetas_Load;
            pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLine).EndInit();
            pnlContent.ResumeLayout(false);
            tblytMain.ResumeLayout(false);
            tblytMain.PerformLayout();
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
        private TableLayoutPanel tblytMain;
        private Label lblDuracion;
        private Label lblGoals;
        private Label lblObjetivos;
        private TextBox txtDuracion1;
        private Label lblAct;
        private TextBox txtGoals1;
        private TextBox txtObjetivos1;
        private TextBox txtGoals2;
        private TextBox txtObjetivos2;
        private TextBox txtAct1;
        private TextBox txtAct2;
        private TextBox txtDuracion2;
    }
}

