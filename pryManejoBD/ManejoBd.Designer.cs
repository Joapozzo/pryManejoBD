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
            this.Verduleros = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbPedidos = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtVer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.mrcConectar.SuspendLayout();
            this.Verduleros.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConectarBase
            // 
            this.btnConectarBase.Location = new System.Drawing.Point(132, 45);
            this.btnConectarBase.Margin = new System.Windows.Forms.Padding(2);
            this.btnConectarBase.Name = "btnConectarBase";
            this.btnConectarBase.Size = new System.Drawing.Size(146, 34);
            this.btnConectarBase.TabIndex = 0;
            this.btnConectarBase.Text = "Conectar";
            this.btnConectarBase.UseVisualStyleBackColor = true;
            this.btnConectarBase.Click += new System.EventHandler(this.btnConectarBase_Click);
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(16, 182);
            this.dgvTabla.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.RowHeadersWidth = 51;
            this.dgvTabla.RowTemplate.Height = 24;
            this.dgvTabla.Size = new System.Drawing.Size(806, 145);
            this.dgvTabla.TabIndex = 3;
            // 
            // cmbTablas
            // 
            this.cmbTablas.FormattingEnabled = true;
            this.cmbTablas.Location = new System.Drawing.Point(130, 103);
            this.cmbTablas.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTablas.Name = "cmbTablas";
            this.cmbTablas.Size = new System.Drawing.Size(150, 21);
            this.cmbTablas.TabIndex = 4;
            this.cmbTablas.SelectedIndexChanged += new System.EventHandler(this.cmbTablas_SelectedIndexChanged);
            // 
            // lblBaseDatos
            // 
            this.lblBaseDatos.AutoSize = true;
            this.lblBaseDatos.Location = new System.Drawing.Point(8, 54);
            this.lblBaseDatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBaseDatos.Name = "lblBaseDatos";
            this.lblBaseDatos.Size = new System.Drawing.Size(117, 13);
            this.lblBaseDatos.TabIndex = 5;
            this.lblBaseDatos.Text = "Elegí tu Base de Datos";
            // 
            // lblSeleccionaTabla
            // 
            this.lblSeleccionaTabla.AutoSize = true;
            this.lblSeleccionaTabla.Location = new System.Drawing.Point(8, 103);
            this.lblSeleccionaTabla.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeleccionaTabla.Name = "lblSeleccionaTabla";
            this.lblSeleccionaTabla.Size = new System.Drawing.Size(90, 13);
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
            this.mrcConectar.Location = new System.Drawing.Point(16, 18);
            this.mrcConectar.Margin = new System.Windows.Forms.Padding(2);
            this.mrcConectar.Name = "mrcConectar";
            this.mrcConectar.Padding = new System.Windows.Forms.Padding(2);
            this.mrcConectar.Size = new System.Drawing.Size(315, 150);
            this.mrcConectar.TabIndex = 7;
            this.mrcConectar.TabStop = false;
            this.mrcConectar.Text = "Conectar Base de Datos";
            // 
            // Verduleros
            // 
            this.Verduleros.Controls.Add(this.tabPage1);
            this.Verduleros.Controls.Add(this.tabPage2);
            this.Verduleros.Controls.Add(this.tabPage3);
            this.Verduleros.Location = new System.Drawing.Point(12, 17);
            this.Verduleros.Name = "Verduleros";
            this.Verduleros.SelectedIndex = 0;
            this.Verduleros.Size = new System.Drawing.Size(846, 365);
            this.Verduleros.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mrcConectar);
            this.tabPage1.Controls.Add(this.dgvTabla);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(838, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manejo BD";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblPedidos);
            this.tabPage2.Controls.Add(this.dgvPedidos);
            this.tabPage2.Controls.Add(this.cmbPedidos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(838, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pedidos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Location = new System.Drawing.Point(23, 31);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(45, 13);
            this.lblPedidos.TabIndex = 2;
            this.lblPedidos.Text = "Pedidos";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3});
            this.dgvPedidos.Location = new System.Drawing.Point(17, 69);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(797, 247);
            this.dgvPedidos.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // cmbPedidos
            // 
            this.cmbPedidos.FormattingEnabled = true;
            this.cmbPedidos.Location = new System.Drawing.Point(74, 28);
            this.cmbPedidos.Name = "cmbPedidos";
            this.cmbPedidos.Size = new System.Drawing.Size(121, 21);
            this.cmbPedidos.TabIndex = 0;
            this.cmbPedidos.SelectedIndexChanged += new System.EventHandler(this.cmbPedidos_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtVer);
            this.tabPage3.Controls.Add(this.btnAgregar);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.txtKg);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.dtpFecha);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.cmbProducto);
            this.tabPage3.Controls.Add(this.cmbVendedor);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(838, 339);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Verduleros";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(19, 37);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(121, 21);
            this.cmbVendedor.TabIndex = 0;
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(170, 37);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbProducto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione producto";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(325, 37);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de venta";
            // 
            // txtKg
            // 
            this.txtKg.Location = new System.Drawing.Point(551, 38);
            this.txtKg.Name = "txtKg";
            this.txtKg.Size = new System.Drawing.Size(100, 20);
            this.txtKg.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kilos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(632, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(668, 91);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtVer
            // 
            this.txtVer.Location = new System.Drawing.Point(668, 129);
            this.txtVer.Name = "txtVer";
            this.txtVer.Size = new System.Drawing.Size(75, 23);
            this.txtVer.TabIndex = 10;
            this.txtVer.Text = "Ver";
            this.txtVer.UseVisualStyleBackColor = true;
            // 
            // frmManejoDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 396);
            this.Controls.Add(this.Verduleros);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmManejoDatos";
            this.Text = "Manejo Base de Datos";
            this.Load += new System.EventHandler(this.frmManejoDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.mrcConectar.ResumeLayout(false);
            this.mrcConectar.PerformLayout();
            this.Verduleros.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TabControl Verduleros;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.ComboBox cmbPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.Button txtVer;
        private System.Windows.Forms.Button btnAgregar;
    }
}

