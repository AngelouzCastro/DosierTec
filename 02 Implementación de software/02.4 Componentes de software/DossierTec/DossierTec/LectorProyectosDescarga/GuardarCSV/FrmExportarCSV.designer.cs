
namespace GuardarCSV
{
    partial class FrmGenerarArchivoCsv
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancelar = new Guna.UI.WinForms.GunaButton();
            this.BtnAceptar = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exportar proyectos de descarga a CSV?";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.AnimationHoverSpeed = 0.07F;
            this.BtnCancelar.AnimationSpeed = 0.03F;
            this.BtnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BtnCancelar.BorderColor = System.Drawing.Color.Black;
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnCancelar.FocusedColor = System.Drawing.Color.Empty;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Image = global::DossierTec.Properties.Resources.boton_x;
            this.BtnCancelar.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnCancelar.Location = new System.Drawing.Point(194, 72);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnCancelar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnCancelar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnCancelar.OnHoverImage = null;
            this.BtnCancelar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnCancelar.Radius = 10;
            this.BtnCancelar.Size = new System.Drawing.Size(141, 32);
            this.BtnCancelar.TabIndex = 20;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.AnimationHoverSpeed = 0.07F;
            this.BtnAceptar.AnimationSpeed = 0.03F;
            this.BtnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.BtnAceptar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BtnAceptar.BorderColor = System.Drawing.Color.Black;
            this.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnAceptar.FocusedColor = System.Drawing.Color.Empty;
            this.BtnAceptar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAceptar.ForeColor = System.Drawing.Color.White;
            this.BtnAceptar.Image = global::DossierTec.Properties.Resources._checked;
            this.BtnAceptar.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnAceptar.Location = new System.Drawing.Point(17, 72);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnAceptar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnAceptar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnAceptar.OnHoverImage = null;
            this.BtnAceptar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnAceptar.Radius = 10;
            this.BtnAceptar.Size = new System.Drawing.Size(141, 32);
            this.BtnAceptar.TabIndex = 19;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // FrmGenerarArchivoCsv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(385, 128);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.label1);
            this.Name = "FrmGenerarArchivoCsv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportar CSV";
            this.Load += new System.EventHandler(this.FrmGenerarArchivoCsv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton BtnCancelar;
        private Guna.UI.WinForms.GunaButton BtnAceptar;
    }
}

