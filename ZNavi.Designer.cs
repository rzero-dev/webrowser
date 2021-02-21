
namespace ZNavi
{
    partial class ZNavi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZNavi));
            this.pbxRecargar = new System.Windows.Forms.PictureBox();
            this.nav = new System.Windows.Forms.WebBrowser();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnAdelante = new System.Windows.Forms.Button();
            this.pbxDetener = new System.Windows.Forms.PictureBox();
            this.pbxIr = new System.Windows.Forms.PictureBox();
            this.tbxUrl = new System.Windows.Forms.TextBox();
            this.pbxUrl = new System.Windows.Forms.PictureBox();
            this.pbxInicio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRecargar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetener)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxRecargar
            // 
            this.pbxRecargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxRecargar.Image = ((System.Drawing.Image)(resources.GetObject("pbxRecargar.Image")));
            this.pbxRecargar.Location = new System.Drawing.Point(74, 10);
            this.pbxRecargar.Name = "pbxRecargar";
            this.pbxRecargar.Size = new System.Drawing.Size(25, 23);
            this.pbxRecargar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRecargar.TabIndex = 0;
            this.pbxRecargar.TabStop = false;
            this.pbxRecargar.Click += new System.EventHandler(this.pbxRecargar_Click);
            // 
            // nav
            // 
            this.nav.Location = new System.Drawing.Point(12, 42);
            this.nav.MinimumSize = new System.Drawing.Size(20, 20);
            this.nav.Name = "nav";
            this.nav.Size = new System.Drawing.Size(865, 462);
            this.nav.TabIndex = 1;
            this.nav.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.nav_DocumentCompleted);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 10);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(25, 23);
            this.btnAtras.TabIndex = 2;
            this.btnAtras.Text = "<";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnAdelante
            // 
            this.btnAdelante.Location = new System.Drawing.Point(43, 10);
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Size = new System.Drawing.Size(25, 23);
            this.btnAdelante.TabIndex = 3;
            this.btnAdelante.Text = ">";
            this.btnAdelante.UseVisualStyleBackColor = true;
            this.btnAdelante.Click += new System.EventHandler(this.btnAdelante_Click);
            // 
            // pbxDetener
            // 
            this.pbxDetener.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxDetener.Image = ((System.Drawing.Image)(resources.GetObject("pbxDetener.Image")));
            this.pbxDetener.Location = new System.Drawing.Point(105, 10);
            this.pbxDetener.Name = "pbxDetener";
            this.pbxDetener.Size = new System.Drawing.Size(25, 23);
            this.pbxDetener.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDetener.TabIndex = 4;
            this.pbxDetener.TabStop = false;
            this.pbxDetener.Click += new System.EventHandler(this.pbxDetener_Click);
            // 
            // pbxIr
            // 
            this.pbxIr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxIr.Image = ((System.Drawing.Image)(resources.GetObject("pbxIr.Image")));
            this.pbxIr.Location = new System.Drawing.Point(817, 10);
            this.pbxIr.Name = "pbxIr";
            this.pbxIr.Size = new System.Drawing.Size(25, 23);
            this.pbxIr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxIr.TabIndex = 5;
            this.pbxIr.TabStop = false;
            this.pbxIr.Click += new System.EventHandler(this.pbxIr_Click);
            // 
            // tbxUrl
            // 
            this.tbxUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUrl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxUrl.Location = new System.Drawing.Point(176, 16);
            this.tbxUrl.Name = "tbxUrl";
            this.tbxUrl.Size = new System.Drawing.Size(626, 13);
            this.tbxUrl.TabIndex = 6;
            this.tbxUrl.Enter += new System.EventHandler(this.tbxUrl_Enter);
            this.tbxUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxUrl_KeyDown);
            this.tbxUrl.Leave += new System.EventHandler(this.tbxUrl_Leave);
            // 
            // pbxUrl
            // 
            this.pbxUrl.Image = ((System.Drawing.Image)(resources.GetObject("pbxUrl.Image")));
            this.pbxUrl.Location = new System.Drawing.Point(167, 10);
            this.pbxUrl.Name = "pbxUrl";
            this.pbxUrl.Size = new System.Drawing.Size(644, 26);
            this.pbxUrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUrl.TabIndex = 7;
            this.pbxUrl.TabStop = false;
            // 
            // pbxInicio
            // 
            this.pbxInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxInicio.Image = ((System.Drawing.Image)(resources.GetObject("pbxInicio.Image")));
            this.pbxInicio.Location = new System.Drawing.Point(136, 10);
            this.pbxInicio.Name = "pbxInicio";
            this.pbxInicio.Size = new System.Drawing.Size(25, 23);
            this.pbxInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxInicio.TabIndex = 8;
            this.pbxInicio.TabStop = false;
            this.pbxInicio.Click += new System.EventHandler(this.pbxInicio_Click);
            // 
            // ZNavi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(889, 516);
            this.Controls.Add(this.pbxInicio);
            this.Controls.Add(this.pbxIr);
            this.Controls.Add(this.pbxDetener);
            this.Controls.Add(this.btnAdelante);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.nav);
            this.Controls.Add(this.pbxRecargar);
            this.Controls.Add(this.tbxUrl);
            this.Controls.Add(this.pbxUrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZNavi";
            this.Text = "ZNavi";
            this.Load += new System.EventHandler(this.ZNavi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxRecargar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetener)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxRecargar;
        private System.Windows.Forms.WebBrowser nav;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAdelante;
        private System.Windows.Forms.PictureBox pbxDetener;
        private System.Windows.Forms.PictureBox pbxIr;
        private System.Windows.Forms.TextBox tbxUrl;
        private System.Windows.Forms.PictureBox pbxUrl;
        private System.Windows.Forms.PictureBox pbxInicio;
    }
}

