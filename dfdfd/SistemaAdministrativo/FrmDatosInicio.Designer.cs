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
            label1 = new Label();
            pnlDadosAdmi = new Panel();
            gridDatosAd = new DataGridView();
            pnlInicio.SuspendLayout();
            pnlInformacionAd.SuspendLayout();
            pnlDadosAdmi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridDatosAd).BeginInit();
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
            pnlInformacionAd.Controls.Add(label1);
            pnlInformacionAd.Dock = DockStyle.Left;
            pnlInformacionAd.Location = new Point(0, 37);
            pnlInformacionAd.Margin = new Padding(4, 3, 4, 3);
            pnlInformacionAd.Name = "pnlInformacionAd";
            pnlInformacionAd.Size = new Size(233, 556);
            pnlInformacionAd.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 250);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(199, 48);
            label1.TabIndex = 6;
            label1.Text = "    DATOS DEL \r\nADMINISTRADOR  ";
            // 
            // pnlDadosAdmi
            // 
            pnlDadosAdmi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlDadosAdmi.Controls.Add(gridDatosAd);
            pnlDadosAdmi.Location = new Point(233, 175);
            pnlDadosAdmi.Margin = new Padding(4, 3, 4, 3);
            pnlDadosAdmi.Name = "pnlDadosAdmi";
            pnlDadosAdmi.Size = new Size(687, 415);
            pnlDadosAdmi.TabIndex = 4;
            // 
            // gridDatosAd
            // 
            gridDatosAd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridDatosAd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDatosAd.Dock = DockStyle.Fill;
            gridDatosAd.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridDatosAd.Location = new Point(0, 0);
            gridDatosAd.Name = "gridDatosAd";
            gridDatosAd.ReadOnly = true;
            gridDatosAd.RowTemplate.Height = 25;
            gridDatosAd.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            gridDatosAd.Size = new Size(687, 415);
            gridDatosAd.TabIndex = 0;
            gridDatosAd.CellContentClick += gridDatosAd_CellContentClick;
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
            pnlInformacionAd.ResumeLayout(false);
            pnlInformacionAd.PerformLayout();
            pnlDadosAdmi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridDatosAd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlInicio;
        private Label lblInicioFrmInicio;
        private Panel pnlInformacionAd;
        private Label label1;
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
        private DataGridView gridDatosAd;
    }
}