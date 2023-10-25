namespace SistemaAdministrativo
{
    partial class ImpresionDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImpresionDatos));
            this.pnlImprimir = new System.Windows.Forms.Panel();
            this.pnlHojaAImprimir = new System.Windows.Forms.FlowLayoutPanel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlImprimir.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlImprimir
            // 
            this.pnlImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlImprimir.BackgroundImage")));
            this.pnlImprimir.Controls.Add(this.label1);
            this.pnlImprimir.Controls.Add(this.btnImprimir);
            this.pnlImprimir.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlImprimir.Location = new System.Drawing.Point(502, 0);
            this.pnlImprimir.Name = "pnlImprimir";
            this.pnlImprimir.Size = new System.Drawing.Size(352, 567);
            this.pnlImprimir.TabIndex = 0;
            // 
            // pnlHojaAImprimir
            // 
            this.pnlHojaAImprimir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHojaAImprimir.Location = new System.Drawing.Point(0, 0);
            this.pnlHojaAImprimir.Name = "pnlHojaAImprimir";
            this.pnlHojaAImprimir.Size = new System.Drawing.Size(502, 567);
            this.pnlHojaAImprimir.TabIndex = 1;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(86, 353);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(191, 75);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "        Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido a la última acción como Administrador. \r\nAquí encontrará la forma de i" +
    "mprimir la boleta\r\nde Hora Social de cada estudiante. ";
            // 
            // ImpresionDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 567);
            this.Controls.Add(this.pnlHojaAImprimir);
            this.Controls.Add(this.pnlImprimir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImpresionDatos";
            this.Text = "Impresion de Datos";
            this.pnlImprimir.ResumeLayout(false);
            this.pnlImprimir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlImprimir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.FlowLayoutPanel pnlHojaAImprimir;
        private System.Windows.Forms.Label label1;
    }
}