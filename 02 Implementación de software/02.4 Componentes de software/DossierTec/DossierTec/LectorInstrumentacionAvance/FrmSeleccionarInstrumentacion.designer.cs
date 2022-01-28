
namespace LectorInstrumentacionAvance
{
    partial class FrmSeleccionarInstrumentacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeleccionarInstrumentacion));
            this.label1 = new System.Windows.Forms.Label();
            this.PbCarga = new System.Windows.Forms.ProgressBar();
            this.lblCargando = new System.Windows.Forms.Label();
            this.lblHojas = new System.Windows.Forms.Label();
            this.DgvLista = new Guna.UI.WinForms.GunaDataGridView();
            this.TxtArchivo = new Guna.UI.WinForms.GunaTextBox();
            this.BtnGenerar = new Guna.UI.WinForms.GunaButton();
            this.BtnCancelar = new Guna.UI.WinForms.GunaButton();
            this.BtnCargar = new Guna.UI.WinForms.GunaButton();
            this.BtnSeleccionar = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Archivo: ";
            // 
            // PbCarga
            // 
            this.PbCarga.Location = new System.Drawing.Point(28, 93);
            this.PbCarga.Name = "PbCarga";
            this.PbCarga.Size = new System.Drawing.Size(577, 25);
            this.PbCarga.Step = 1;
            this.PbCarga.TabIndex = 6;
            // 
            // lblCargando
            // 
            this.lblCargando.AutoSize = true;
            this.lblCargando.Location = new System.Drawing.Point(33, 70);
            this.lblCargando.Name = "lblCargando";
            this.lblCargando.Size = new System.Drawing.Size(46, 17);
            this.lblCargando.TabIndex = 7;
            this.lblCargando.Text = "Carga";
            // 
            // lblHojas
            // 
            this.lblHojas.AutoSize = true;
            this.lblHojas.Location = new System.Drawing.Point(33, 443);
            this.lblHojas.Name = "lblHojas";
            this.lblHojas.Size = new System.Drawing.Size(0, 17);
            this.lblHojas.TabIndex = 8;
            // 
            // DgvLista
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DgvLista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvLista.BackgroundColor = System.Drawing.Color.White;
            this.DgvLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvLista.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvLista.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgvLista.EnableHeadersVisualStyles = false;
            this.DgvLista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvLista.Location = new System.Drawing.Point(28, 169);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowHeadersVisible = false;
            this.DgvLista.RowHeadersWidth = 51;
            this.DgvLista.RowTemplate.Height = 24;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(744, 328);
            this.DgvLista.TabIndex = 13;
            this.DgvLista.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DgvLista.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvLista.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvLista.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvLista.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvLista.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvLista.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvLista.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvLista.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgvLista.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvLista.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DgvLista.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvLista.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvLista.ThemeStyle.HeaderStyle.Height = 25;
            this.DgvLista.ThemeStyle.ReadOnly = true;
            this.DgvLista.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvLista.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvLista.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DgvLista.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvLista.ThemeStyle.RowsStyle.Height = 24;
            this.DgvLista.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvLista.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // TxtArchivo
            // 
            this.TxtArchivo.BackColor = System.Drawing.Color.Transparent;
            this.TxtArchivo.BaseColor = System.Drawing.Color.White;
            this.TxtArchivo.BorderColor = System.Drawing.Color.Silver;
            this.TxtArchivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtArchivo.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtArchivo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtArchivo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtArchivo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtArchivo.Location = new System.Drawing.Point(102, 17);
            this.TxtArchivo.Name = "TxtArchivo";
            this.TxtArchivo.PasswordChar = '\0';
            this.TxtArchivo.Radius = 5;
            this.TxtArchivo.SelectedText = "";
            this.TxtArchivo.Size = new System.Drawing.Size(521, 30);
            this.TxtArchivo.TabIndex = 14;
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.AnimationHoverSpeed = 0.07F;
            this.BtnGenerar.AnimationSpeed = 0.03F;
            this.BtnGenerar.BackColor = System.Drawing.Color.Transparent;
            this.BtnGenerar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BtnGenerar.BorderColor = System.Drawing.Color.Black;
            this.BtnGenerar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnGenerar.FocusedColor = System.Drawing.Color.Empty;
            this.BtnGenerar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnGenerar.ForeColor = System.Drawing.Color.White;
            this.BtnGenerar.Image = global::DossierTec.Properties.Resources.hierarchy;
            this.BtnGenerar.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnGenerar.Location = new System.Drawing.Point(631, 93);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnGenerar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnGenerar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnGenerar.OnHoverImage = null;
            this.BtnGenerar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnGenerar.Radius = 10;
            this.BtnGenerar.Size = new System.Drawing.Size(141, 32);
            this.BtnGenerar.TabIndex = 15;
            this.BtnGenerar.Text = "Generar";
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
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
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnCancelar.Location = new System.Drawing.Point(631, 131);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnCancelar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnCancelar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnCancelar.OnHoverImage = null;
            this.BtnCancelar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnCancelar.Radius = 10;
            this.BtnCancelar.Size = new System.Drawing.Size(141, 32);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click_1);
            // 
            // BtnCargar
            // 
            this.BtnCargar.AnimationHoverSpeed = 0.07F;
            this.BtnCargar.AnimationSpeed = 0.03F;
            this.BtnCargar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCargar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BtnCargar.BorderColor = System.Drawing.Color.Black;
            this.BtnCargar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnCargar.FocusedColor = System.Drawing.Color.Empty;
            this.BtnCargar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCargar.ForeColor = System.Drawing.Color.White;
            this.BtnCargar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCargar.Image")));
            this.BtnCargar.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnCargar.Location = new System.Drawing.Point(631, 55);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnCargar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnCargar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnCargar.OnHoverImage = null;
            this.BtnCargar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnCargar.Radius = 10;
            this.BtnCargar.Size = new System.Drawing.Size(141, 32);
            this.BtnCargar.TabIndex = 11;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.Click += new System.EventHandler(this.BtnAceptar_Click);
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
            this.BtnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("BtnSeleccionar.Image")));
            this.BtnSeleccionar.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnSeleccionar.Location = new System.Drawing.Point(631, 16);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnSeleccionar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnSeleccionar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnSeleccionar.OnHoverImage = null;
            this.BtnSeleccionar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnSeleccionar.Radius = 10;
            this.BtnSeleccionar.Size = new System.Drawing.Size(141, 32);
            this.BtnSeleccionar.TabIndex = 10;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // FrmSeleccionarInstrumentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.BtnGenerar);
            this.Controls.Add(this.TxtArchivo);
            this.Controls.Add(this.DgvLista);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.BtnSeleccionar);
            this.Controls.Add(this.lblHojas);
            this.Controls.Add(this.lblCargando);
            this.Controls.Add(this.PbCarga);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSeleccionarInstrumentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Selecionar Archivo";
            this.Load += new System.EventHandler(this.FrmSeleccionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar PbCarga;
        private System.Windows.Forms.Label lblCargando;
        private System.Windows.Forms.Label lblHojas;
        private Guna.UI.WinForms.GunaButton BtnCancelar;
        private Guna.UI.WinForms.GunaButton BtnCargar;
        private Guna.UI.WinForms.GunaButton BtnSeleccionar;
        private Guna.UI.WinForms.GunaDataGridView DgvLista;
        private Guna.UI.WinForms.GunaTextBox TxtArchivo;
        private Guna.UI.WinForms.GunaButton BtnGenerar;
    }
}

