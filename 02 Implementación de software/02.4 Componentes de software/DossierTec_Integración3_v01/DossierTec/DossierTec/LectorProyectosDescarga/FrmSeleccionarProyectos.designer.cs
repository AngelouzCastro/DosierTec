
namespace LectorProyectosDescarga
{
    partial class FrmSeleccionarProyectos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeleccionarProyectos));
            this.LblArchivo = new System.Windows.Forms.Label();
            this.DtgLista = new Guna.UI.WinForms.GunaDataGridView();
            this.TxtArchivo = new Guna.UI.WinForms.GunaTextBox();
            this.lblCargando = new System.Windows.Forms.Label();
            this.PbCarga = new System.Windows.Forms.ProgressBar();
            this.BtnGuardarCSV = new Guna.UI.WinForms.GunaButton();
            this.BtnGenerar = new Guna.UI.WinForms.GunaButton();
            this.BtnCancelar = new Guna.UI.WinForms.GunaButton();
            this.BtnCargar = new Guna.UI.WinForms.GunaButton();
            this.BtnSeleccionar = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.DtgLista)).BeginInit();
            this.SuspendLayout();
            // 
            // LblArchivo
            // 
            this.LblArchivo.AutoSize = true;
            this.LblArchivo.Location = new System.Drawing.Point(33, 23);
            this.LblArchivo.Name = "LblArchivo";
            this.LblArchivo.Size = new System.Drawing.Size(55, 17);
            this.LblArchivo.TabIndex = 1;
            this.LblArchivo.Text = "Archivo";
            // 
            // DtgLista
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DtgLista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DtgLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgLista.BackgroundColor = System.Drawing.Color.White;
            this.DtgLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtgLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtgLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DtgLista.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgLista.DefaultCellStyle = dataGridViewCellStyle6;
            this.DtgLista.EnableHeadersVisualStyles = false;
            this.DtgLista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DtgLista.Location = new System.Drawing.Point(28, 229);
            this.DtgLista.Name = "DtgLista";
            this.DtgLista.ReadOnly = true;
            this.DtgLista.RowHeadersVisible = false;
            this.DtgLista.RowHeadersWidth = 51;
            this.DtgLista.RowTemplate.Height = 24;
            this.DtgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgLista.Size = new System.Drawing.Size(744, 221);
            this.DtgLista.TabIndex = 10;
            this.DtgLista.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DtgLista.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DtgLista.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DtgLista.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DtgLista.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DtgLista.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DtgLista.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DtgLista.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DtgLista.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DtgLista.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtgLista.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DtgLista.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DtgLista.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DtgLista.ThemeStyle.HeaderStyle.Height = 25;
            this.DtgLista.ThemeStyle.ReadOnly = true;
            this.DtgLista.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DtgLista.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtgLista.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DtgLista.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DtgLista.ThemeStyle.RowsStyle.Height = 24;
            this.DtgLista.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DtgLista.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.TxtArchivo.TabIndex = 15;
            // 
            // lblCargando
            // 
            this.lblCargando.AutoSize = true;
            this.lblCargando.Location = new System.Drawing.Point(41, 60);
            this.lblCargando.Name = "lblCargando";
            this.lblCargando.Size = new System.Drawing.Size(46, 17);
            this.lblCargando.TabIndex = 18;
            this.lblCargando.Text = "Carga";
            // 
            // PbCarga
            // 
            this.PbCarga.Location = new System.Drawing.Point(36, 83);
            this.PbCarga.Name = "PbCarga";
            this.PbCarga.Size = new System.Drawing.Size(577, 25);
            this.PbCarga.Step = 1;
            this.PbCarga.TabIndex = 17;
            // 
            // BtnGuardarCSV
            // 
            this.BtnGuardarCSV.AnimationHoverSpeed = 0.07F;
            this.BtnGuardarCSV.AnimationSpeed = 0.03F;
            this.BtnGuardarCSV.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarCSV.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BtnGuardarCSV.BorderColor = System.Drawing.Color.Black;
            this.BtnGuardarCSV.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnGuardarCSV.FocusedColor = System.Drawing.Color.Empty;
            this.BtnGuardarCSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnGuardarCSV.ForeColor = System.Drawing.Color.White;
            this.BtnGuardarCSV.Image = global::DossierTec.Properties.Resources.csv;
            this.BtnGuardarCSV.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnGuardarCSV.Location = new System.Drawing.Point(631, 136);
            this.BtnGuardarCSV.Name = "BtnGuardarCSV";
            this.BtnGuardarCSV.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnGuardarCSV.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnGuardarCSV.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnGuardarCSV.OnHoverImage = null;
            this.BtnGuardarCSV.OnPressedColor = System.Drawing.Color.Black;
            this.BtnGuardarCSV.Radius = 10;
            this.BtnGuardarCSV.Size = new System.Drawing.Size(141, 32);
            this.BtnGuardarCSV.TabIndex = 19;
            this.BtnGuardarCSV.Text = "Guardar";
            this.BtnGuardarCSV.Click += new System.EventHandler(this.BtnGuardarCSV_Click);
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
            this.BtnGenerar.TabIndex = 16;
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
            this.BtnCancelar.Location = new System.Drawing.Point(631, 174);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnCancelar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnCancelar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnCancelar.OnHoverImage = null;
            this.BtnCancelar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnCancelar.Radius = 10;
            this.BtnCancelar.Size = new System.Drawing.Size(141, 32);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
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
            this.BtnCargar.TabIndex = 8;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
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
            this.BtnSeleccionar.TabIndex = 7;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // FrmSeleccionarProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.BtnGuardarCSV);
            this.Controls.Add(this.lblCargando);
            this.Controls.Add(this.PbCarga);
            this.Controls.Add(this.BtnGenerar);
            this.Controls.Add(this.TxtArchivo);
            this.Controls.Add(this.DtgLista);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.BtnSeleccionar);
            this.Controls.Add(this.LblArchivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSeleccionarProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyectos De Descarga";
            ((System.ComponentModel.ISupportInitialize)(this.DtgLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblArchivo;
        private Guna.UI.WinForms.GunaButton BtnSeleccionar;
        private Guna.UI.WinForms.GunaButton BtnCargar;
        private Guna.UI.WinForms.GunaButton BtnCancelar;
        private Guna.UI.WinForms.GunaDataGridView DtgLista;
        private Guna.UI.WinForms.GunaTextBox TxtArchivo;
        private Guna.UI.WinForms.GunaButton BtnGenerar;
        private System.Windows.Forms.Label lblCargando;
        private System.Windows.Forms.ProgressBar PbCarga;
        private Guna.UI.WinForms.GunaButton BtnGuardarCSV;
    }
}

