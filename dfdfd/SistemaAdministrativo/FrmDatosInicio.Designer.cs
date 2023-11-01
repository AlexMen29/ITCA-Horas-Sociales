namespace SistemaAdministrativo
{
    partial class FrmDatosInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatosInicio));
            pnlInicio = new Panel();
            lblInicioFrmInicio = new Label();
            pnlInformacionAd = new Panel();
            pnlDadosAdmi = new Panel();
            boxHoras = new ComboBox();
            label4 = new Label();
            txtActividad = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            pnlInicio.SuspendLayout();
            pnlDadosAdmi.SuspendLayout();
            SuspendLayout();
            // 
            // pnlInicio
            // 
            pnlInicio.Controls.Add(lblInicioFrmInicio);
            pnlInicio.Dock = DockStyle.Top;
            pnlInicio.Location = new Point(0, 0);
            pnlInicio.Margin = new Padding(4, 3, 4, 3);
            pnlInicio.Name = "pnlInicio";
            pnlInicio.Size = new Size(919, 37);
            pnlInicio.TabIndex = 2;
            // 
            // lblInicioFrmInicio
            // 
            lblInicioFrmInicio.AutoSize = true;
            lblInicioFrmInicio.Dock = DockStyle.Top;
            lblInicioFrmInicio.FlatStyle = FlatStyle.Flat;
            lblInicioFrmInicio.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblInicioFrmInicio.Location = new Point(0, 0);
            lblInicioFrmInicio.Margin = new Padding(4, 0, 4, 0);
            lblInicioFrmInicio.Name = "lblInicioFrmInicio";
            lblInicioFrmInicio.Size = new Size(109, 32);
            lblInicioFrmInicio.TabIndex = 0;
            lblInicioFrmInicio.Text = "INICIO";
            // 
            // pnlInformacionAd
            // 
            pnlInformacionAd.AutoScroll = true;
            pnlInformacionAd.BackgroundImage = (Image)resources.GetObject("pnlInformacionAd.BackgroundImage");
            pnlInformacionAd.Dock = DockStyle.Left;
            pnlInformacionAd.Location = new Point(0, 37);
            pnlInformacionAd.Margin = new Padding(4, 3, 4, 3);
            pnlInformacionAd.Name = "pnlInformacionAd";
            pnlInformacionAd.Size = new Size(233, 556);
            pnlInformacionAd.TabIndex = 3;
            // 
            // pnlDadosAdmi
            // 
            pnlDadosAdmi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlDadosAdmi.Controls.Add(boxHoras);
            pnlDadosAdmi.Controls.Add(label4);
            pnlDadosAdmi.Controls.Add(txtActividad);
            pnlDadosAdmi.Controls.Add(label3);
            pnlDadosAdmi.Controls.Add(dateTimePicker1);
            pnlDadosAdmi.Controls.Add(label2);
            pnlDadosAdmi.Controls.Add(label1);
            pnlDadosAdmi.Location = new Point(233, 175);
            pnlDadosAdmi.Margin = new Padding(4, 3, 4, 3);
            pnlDadosAdmi.Name = "pnlDadosAdmi";
            pnlDadosAdmi.Size = new Size(687, 415);
            pnlDadosAdmi.TabIndex = 4;
            // 
            // boxHoras
            // 
            boxHoras.Anchor = AnchorStyles.None;
            boxHoras.FormattingEnabled = true;
            boxHoras.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            boxHoras.Location = new Point(296, 336);
            boxHoras.Name = "boxHoras";
            boxHoras.Size = new Size(81, 23);
            boxHoras.TabIndex = 19;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(219, 300);
            label4.Name = "label4";
            label4.Size = new Size(262, 19);
            label4.TabIndex = 18;
            label4.Text = "Ingrese el numero de horas realizadas";
            // 
            // txtActividad
            // 
            txtActividad.Anchor = AnchorStyles.None;
            txtActividad.Location = new Point(211, 244);
            txtActividad.Name = "txtActividad";
            txtActividad.Size = new Size(280, 23);
            txtActividad.TabIndex = 17;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(243, 212);
            label3.Name = "label3";
            label3.Size = new Size(210, 19);
            label3.TabIndex = 16;
            label3.Text = "Ingresar la actividad realizada";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(235, 140);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(216, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(203, 108);
            label2.Name = "label2";
            label2.Size = new Size(286, 19);
            label2.TabIndex = 14;
            label2.Text = "Ingresar la fecha de la actividad realizada";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(195, 60);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(289, 30);
            label1.TabIndex = 13;
            label1.Text = "Registrar Horas Sociales";
            // 
            // FrmDatosInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(919, 593);
            Controls.Add(pnlDadosAdmi);
            Controls.Add(pnlInformacionAd);
            Controls.Add(pnlInicio);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmDatosInicio";
            Text = "FrmDatosInicio";
            pnlInicio.ResumeLayout(false);
            pnlInicio.PerformLayout();
            pnlDadosAdmi.ResumeLayout(false);
            pnlDadosAdmi.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlInicio;
        private Label lblInicioFrmInicio;
        private Panel pnlInformacionAd;
        private Label lblTelefonoAd;
        private Label lblDepartamentoAd;
        private Label lblCorreoAd;
        private Label lblCarnetAd;
        private Label lblApellidoAd;
        private Label lblNombreAd;
        private Panel pnlDadosAdmi;
        private TextBox txtsShowNum;
        private TextBox txtShowDepart;
        private TextBox txtShowGmail;
        private TextBox txtShowCarnet;
        private TextBox txtShowLastName;
        private TextBox txtShowName;
        private ComboBox boxHoras;
        private Label label4;
        private TextBox txtActividad;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
    }
}