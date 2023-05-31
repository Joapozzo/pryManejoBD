namespace pryManejoBD
{
    partial class frmManejoDatos
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
            this.btnConectarBase = new System.Windows.Forms.Button();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.cmbTablas = new System.Windows.Forms.ComboBox();
            this.lblBaseDatos = new System.Windows.Forms.Label();
            this.lblSeleccionaTabla = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mrcConectar = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.mrcConectar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConectarBase
            // 
            this.btnConectarBase.Location = new System.Drawing.Point(176, 55);
            this.btnConectarBase.Name = "btnConectarBase";
            this.btnConectarBase.Size = new System.Drawing.Size(195, 42);
            this.btnConectarBase.TabIndex = 0;
            this.btnConectarBase.Text = "Conectar";
            this.btnConectarBase.UseVisualStyleBackColor = true;
            this.btnConectarBase.Click += new System.EventHandler(this.btnConectarBase_Click);
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(462, 21);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.RowHeadersWidth = 51;
            this.dgvTabla.RowTemplate.Height = 24;
            this.dgvTabla.Size = new System.Drawing.Size(816, 294);
            this.dgvTabla.TabIndex = 3;
            // 
            // cmbTablas
            // 
            this.cmbTablas.FormattingEnabled = true;
            this.cmbTablas.Location = new System.Drawing.Point(173, 127);
            this.cmbTablas.Name = "cmbTablas";
            this.cmbTablas.Size = new System.Drawing.Size(198, 24);
            this.cmbTablas.TabIndex = 4;
            this.cmbTablas.SelectedIndexChanged += new System.EventHandler(this.cmbTablas_SelectedIndexChanged);
            // 
            // lblBaseDatos
            // 
            this.lblBaseDatos.AutoSize = true;
            this.lblBaseDatos.Location = new System.Drawing.Point(10, 66);
            this.lblBaseDatos.Name = "lblBaseDatos";
            this.lblBaseDatos.Size = new System.Drawing.Size(144, 16);
            this.lblBaseDatos.TabIndex = 5;
            this.lblBaseDatos.Text = "Elegí tu Base de Datos";
            // 
            // lblSeleccionaTabla
            // 
            this.lblSeleccionaTabla.AutoSize = true;
            this.lblSeleccionaTabla.Location = new System.Drawing.Point(10, 127);
            this.lblSeleccionaTabla.Name = "lblSeleccionaTabla";
            this.lblSeleccionaTabla.Size = new System.Drawing.Size(114, 16);
            this.lblSeleccionaTabla.TabIndex = 6;
            this.lblSeleccionaTabla.Text = "Selecciona Tabla";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Extension accdb (*.accdb)| *.accdb |Extension mdb (*.mdb) | *.mdb";
            // 
            // mrcConectar
            // 
            this.mrcConectar.Controls.Add(this.btnConectarBase);
            this.mrcConectar.Controls.Add(this.lblSeleccionaTabla);
            this.mrcConectar.Controls.Add(this.cmbTablas);
            this.mrcConectar.Controls.Add(this.lblBaseDatos);
            this.mrcConectar.Location = new System.Drawing.Point(12, 12);
            this.mrcConectar.Name = "mrcConectar";
            this.mrcConectar.Size = new System.Drawing.Size(420, 185);
            this.mrcConectar.TabIndex = 7;
            this.mrcConectar.TabStop = false;
            this.mrcConectar.Text = "Conectar Base de Datos";
            // 
            // frmManejoDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 339);
            this.Controls.Add(this.mrcConectar);
            this.Controls.Add(this.dgvTabla);
            this.Name = "frmManejoDatos";
            this.Text = "Manejo Base de Datos";
            this.Load += new System.EventHandler(this.frmManejoDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.mrcConectar.ResumeLayout(false);
            this.mrcConectar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConectarBase;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.ComboBox cmbTablas;
        private System.Windows.Forms.Label lblBaseDatos;
        private System.Windows.Forms.Label lblSeleccionaTabla;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox mrcConectar;
    }
}

