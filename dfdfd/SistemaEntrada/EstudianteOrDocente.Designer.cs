namespace Login
{
    partial class EstudianteOrDocente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstudianteOrDocente));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelUniversitario = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PanelDocente = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelUniversitario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PanelDocente.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 299);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelUniversitario
            // 
            this.PanelUniversitario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelUniversitario.Controls.Add(this.label1);
            this.PanelUniversitario.Controls.Add(this.pictureBox1);
            this.PanelUniversitario.Location = new System.Drawing.Point(184, 123);
            this.PanelUniversitario.Name = "PanelUniversitario";
            this.PanelUniversitario.Size = new System.Drawing.Size(358, 346);
            this.PanelUniversitario.TabIndex = 2;
            this.PanelUniversitario.Click += new System.EventHandler(this.PanelUniversitario_Click);
            this.PanelUniversitario.MouseEnter += new System.EventHandler(this.PanelUniversitario_MouseEnter);
            this.PanelUniversitario.MouseLeave += new System.EventHandler(this.PanelUniversitario_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Universitario";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(337, 299);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // PanelDocente
            // 
            this.PanelDocente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelDocente.Controls.Add(this.label2);
            this.PanelDocente.Controls.Add(this.pictureBox2);
            this.PanelDocente.Location = new System.Drawing.Point(580, 123);
            this.PanelDocente.Name = "PanelDocente";
            this.PanelDocente.Size = new System.Drawing.Size(358, 346);
            this.PanelDocente.TabIndex = 3;
            this.PanelDocente.Click += new System.EventHandler(this.PanelDocente_Click);
            this.PanelDocente.MouseEnter += new System.EventHandler(this.PanelDocente_MouseEnter);
            this.PanelDocente.MouseLeave += new System.EventHandler(this.PanelDocente_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Encargado/Docente";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(426, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Por favor seleccióne una Opción";
            // 
            // EstudianteOrDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 620);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PanelDocente);
            this.Controls.Add(this.PanelUniversitario);
            this.Name = "EstudianteOrDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstudianteOrDocente";
            this.Load += new System.EventHandler(this.EstudianteOrDocente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelUniversitario.ResumeLayout(false);
            this.PanelUniversitario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PanelDocente.ResumeLayout(false);
            this.PanelDocente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelUniversitario;
        private System.Windows.Forms.Panel PanelDocente;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}