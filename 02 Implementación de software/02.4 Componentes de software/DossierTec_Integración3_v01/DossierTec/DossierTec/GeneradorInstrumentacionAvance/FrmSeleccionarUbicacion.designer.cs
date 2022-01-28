
namespace GeneradorInstrumentacionAvance
{
    partial class FrmSeleccionarUbicacion
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
            this.BtCancelar = new Guna.UI.WinForms.GunaButton();
            this.BtnAceptar = new Guna.UI.WinForms.GunaButton();
            this.BtnSeleccionar = new Guna.UI.WinForms.GunaButton();
            this.TxtDireccion = new Guna.UI.WinForms.GunaTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ubicación: ";
            // 
            // BtCancelar
            // 
            this.BtCancelar.AnimationHoverSpeed = 0.07F;
            this.BtCancelar.AnimationSpeed = 0.03F;
            this.BtCancelar.BackColor = System.Drawing.Color.Transparent;
            this.BtCancelar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BtCancelar.BorderColor = System.Drawing.Color.Black;
            this.BtCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtCancelar.FocusedColor = System.Drawing.Color.Empty;
            this.BtCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtCancelar.ForeColor = System.Drawing.Color.White;
            this.BtCancelar.Image = global::DossierTec.Properties.Resources.boton_x;
            this.BtCancelar.ImageSize = new System.Drawing.Size(20, 20);
            this.BtCancelar.Location = new System.Drawing.Point(253, 113);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtCancelar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtCancelar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtCancelar.OnHoverImage = null;
            this.BtCancelar.OnPressedColor = System.Drawing.Color.Black;
            this.BtCancelar.Radius = 10;
            this.BtCancelar.Size = new System.Drawing.Size(141, 32);
            this.BtCancelar.TabIndex = 14;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
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
            this.BtnAceptar.Location = new System.Drawing.Point(78, 113);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnAceptar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnAceptar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnAceptar.OnHoverImage = null;
            this.BtnAceptar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnAceptar.Radius = 10;
            this.BtnAceptar.Size = new System.Drawing.Size(141, 32);
            this.BtnAceptar.TabIndex = 13;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.AnimationHoverSpeed = 0.07F;
            this.BtnSeleccionar.AnimationSpeed = 0.03F;
            this.BtnSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.BtnSeleccionar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BtnSeleccionar.BorderColor = System.Drawing.Color.Black;
            this.BtnSeleccionar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnSeleccionar.FocusedColor = System.Drawing.Color.Empty;
            this.BtnSeleccionar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.BtnSeleccionar.Image = global::DossierTec.Properties.Resources.folder_checked;
            this.BtnSeleccionar.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnSeleccionar.Location = new System.Drawing.Point(389, 47);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnSeleccionar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnSeleccionar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnSeleccionar.OnHoverImage = null;
            this.BtnSeleccionar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnSeleccionar.Radius = 10;
            this.BtnSeleccionar.Size = new System.Drawing.Size(141, 32);
            this.BtnSeleccionar.TabIndex = 15;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.BackColor = System.Drawing.Color.Transparent;
            this.TxtDireccion.BaseColor = System.Drawing.Color.White;
            this.TxtDireccion.BorderColor = System.Drawing.Color.Silver;
            this.TxtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDireccion.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtDireccion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtDireccion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtDireccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtDireccion.Location = new System.Drawing.Point(111, 47);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.PasswordChar = '\0';
            this.TxtDireccion.Radius = 5;
            this.TxtDireccion.ReadOnly = true;
            this.TxtDireccion.SelectedText = "";
            this.TxtDireccion.Size = new System.Drawing.Size(255, 30);
            this.TxtDireccion.TabIndex = 16;
            // 
            // FrmSeleccionarUbicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 170);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.BtnSeleccionar);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.label1);
            this.Name = "FrmSeleccionarUbicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selección de Ubicación del Directorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton BtCancelar;
        private Guna.UI.WinForms.GunaButton BtnAceptar;
        private Guna.UI.WinForms.GunaButton BtnSeleccionar;
        private Guna.UI.WinForms.GunaTextBox TxtDireccion;
    }
}

