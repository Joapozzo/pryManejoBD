using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryManejoBD
{
    public partial class frmManejoDatos : Form
    {
        public string stringConn;
        public frmManejoDatos()
        {
            InitializeComponent();
        }

        private void frmManejoDatos_Load(object sender, EventArgs e)
        {
            cmbTablas.BackColor = Color.DarkGray;
            ClsPedidos objPedidos = new ClsPedidos();
            objPedidos.conectarPedidos();
            objPedidos.cargarCombo(cmbPedidos);
        }

        private void btnConectarBase_Click(object sender, EventArgs e)
        {
            ClsManejoBd objConnBase = new ClsManejoBd();
            stringConn = objConnBase.conectarBase(btnConectarBase, openFileDialog, cmbTablas);
        }

        private void cmbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsManejoBd objConnBase = new ClsManejoBd();
            objConnBase.cargarGrilla(cmbTablas, dgvTabla, stringConn);
        }

        private void cmbPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsPedidos objPedidos = new ClsPedidos();
            objPedidos.conectarPedidos();
            objPedidos.cargarGrilla(cmbPedidos, dgvPedidos);
        }
    }


}
