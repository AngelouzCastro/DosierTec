
namespace DossierTec
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cargaAcademicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumentaicionesYAvanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectosDeDescargaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tips = new System.Windows.Forms.ToolTip(this.components);
            this.BtnInstrumentacion = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.BtnProyectos = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.PnlPrincipal = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.PnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargaAcademicaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cargaAcademicaToolStripMenuItem
            // 
            this.cargaAcademicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instrumentaicionesYAvanceToolStripMenuItem,
            this.proyectosDeDescargaToolStripMenuItem});
            this.cargaAcademicaToolStripMenuItem.Name = "cargaAcademicaToolStripMenuItem";
            this.cargaAcademicaToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.cargaAcademicaToolStripMenuItem.Text = "Carga Academica";
            // 
            // instrumentaicionesYAvanceToolStripMenuItem
            // 
            this.instrumentaicionesYAvanceToolStripMenuItem.Name = "instrumentaicionesYAvanceToolStripMenuItem";
            this.instrumentaicionesYAvanceToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.instrumentaicionesYAvanceToolStripMenuItem.Text = "Instrumentaciones y avance";
            this.instrumentaicionesYAvanceToolStripMenuItem.Click += new System.EventHandler(this.instrumentaicionesYAvanceToolStripMenuItem_Click);
            // 
            // proyectosDeDescargaToolStripMenuItem
            // 
            this.proyectosDeDescargaToolStripMenuItem.Name = "proyectosDeDescargaToolStripMenuItem";
            this.proyectosDeDescargaToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.proyectosDeDescargaToolStripMenuItem.Text = "Proyectos de descarga";
            this.proyectosDeDescargaToolStripMenuItem.Click += new System.EventHandler(this.proyectosDeDescargaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // BtnInstrumentacion
            // 
            this.BtnInstrumentacion.AnimationHoverSpeed = 0.07F;
            this.BtnInstrumentacion.AnimationSpeed = 0.03F;
            this.BtnInstrumentacion.BackColor = System.Drawing.Color.Transparent;
            this.BtnInstrumentacion.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(93)))), ((int)(((byte)(211)))));
            this.BtnInstrumentacion.BorderColor = System.Drawing.Color.Black;
            this.BtnInstrumentacion.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnInstrumentacion.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnInstrumentacion.CheckedForeColor = System.Drawing.Color.White;
            this.BtnInstrumentacion.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnInstrumentacion.CheckedImage")));
            this.BtnInstrumentacion.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnInstrumentacion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnInstrumentacion.FocusedColor = System.Drawing.Color.Empty;
            this.BtnInstrumentacion.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.BtnInstrumentacion.ForeColor = System.Drawing.Color.White;
            this.BtnInstrumentacion.Image = global::DossierTec.Properties.Resources.carpeta;
            this.BtnInstrumentacion.ImageSize = new System.Drawing.Size(150, 150);
            this.BtnInstrumentacion.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnInstrumentacion.Location = new System.Drawing.Point(53, 92);
            this.BtnInstrumentacion.Name = "BtnInstrumentacion";
            this.BtnInstrumentacion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BtnInstrumentacion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnInstrumentacion.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnInstrumentacion.OnHoverImage = null;
            this.BtnInstrumentacion.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnInstrumentacion.OnPressedColor = System.Drawing.Color.Black;
            this.BtnInstrumentacion.Radius = 15;
            this.BtnInstrumentacion.Size = new System.Drawing.Size(322, 295);
            this.BtnInstrumentacion.TabIndex = 3;
            this.BtnInstrumentacion.Text = "Instrumentaciones y avance";
            this.BtnInstrumentacion.Click += new System.EventHandler(this.BtnInstrumentacion_Click);
            // 
            // BtnProyectos
            // 
            this.BtnProyectos.AnimationHoverSpeed = 0.07F;
            this.BtnProyectos.AnimationSpeed = 0.03F;
            this.BtnProyectos.BackColor = System.Drawing.Color.Transparent;
            this.BtnProyectos.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(93)))), ((int)(((byte)(211)))));
            this.BtnProyectos.BorderColor = System.Drawing.Color.Black;
            this.BtnProyectos.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnProyectos.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnProyectos.CheckedForeColor = System.Drawing.Color.White;
            this.BtnProyectos.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnProyectos.CheckedImage")));
            this.BtnProyectos.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnProyectos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnProyectos.FocusedColor = System.Drawing.Color.Empty;
            this.BtnProyectos.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.BtnProyectos.ForeColor = System.Drawing.Color.White;
            this.BtnProyectos.Image = global::DossierTec.Properties.Resources.archivo;
            this.BtnProyectos.ImageSize = new System.Drawing.Size(150, 150);
            this.BtnProyectos.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnProyectos.Location = new System.Drawing.Point(424, 92);
            this.BtnProyectos.Name = "BtnProyectos";
            this.BtnProyectos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BtnProyectos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnProyectos.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnProyectos.OnHoverImage = null;
            this.BtnProyectos.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnProyectos.OnPressedColor = System.Drawing.Color.Black;
            this.BtnProyectos.Radius = 15;
            this.BtnProyectos.Size = new System.Drawing.Size(322, 295);
            this.BtnProyectos.TabIndex = 4;
            this.BtnProyectos.Text = "Proyectos de descarga";
            this.BtnProyectos.Click += new System.EventHandler(this.BtnProyectos_Click);
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.Controls.Add(this.BtnInstrumentacion);
            this.PnlPrincipal.Controls.Add(this.BtnProyectos);
            this.PnlPrincipal.Location = new System.Drawing.Point(0, 31);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.Size = new System.Drawing.Size(800, 478);
            this.PnlPrincipal.TabIndex = 5;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.PnlPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DossierTec - Generador de estructura de repositorios";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PnlPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cargaAcademicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instrumentaicionesYAvanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyectosDeDescargaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolTip tips;
        private Guna.UI.WinForms.GunaAdvenceTileButton BtnInstrumentacion;
        private Guna.UI.WinForms.GunaAdvenceTileButton BtnProyectos;
        private System.Windows.Forms.Panel PnlPrincipal;
    }
}

