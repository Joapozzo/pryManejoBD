using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;

namespace pryManejoBD
{
    internal class ClsPedidos
    {
        OleDbConnection conectarBasePedidos = new OleDbConnection();
        OleDbCommand comandoBasePedidos = new OleDbCommand();
        OleDbDataReader lectorBasePedidos;
        public void conectarPedidos()
        {
            try
            {
                conectarBasePedidos = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NEPTUNO.accdb");
                comandoBasePedidos = new OleDbCommand();
                conectarBasePedidos.Open();

                comandoBasePedidos.Connection = conectarBasePedidos;
                comandoBasePedidos.CommandType = CommandType.TableDirect; 
                comandoBasePedidos.CommandText = "Pedidos";

                lectorBasePedidos = comandoBasePedidos.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        public void cargarCombo(ComboBox cmbIdPedidos)
        {
            conectarPedidos();
            while (lectorBasePedidos.Read())
            {
                cmbIdPedidos.Items.Add(lectorBasePedidos[0]);
            }
        }

        public void cargarGrilla(ComboBox comboBoxPedidos, DataGridView grillaPedidos)
        {
            conectarBasePedidos = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NEPTUNO.accdb");
            comandoBasePedidos = new OleDbCommand();
            conectarBasePedidos.Open();

            comandoBasePedidos.Connection = conectarBasePedidos;
            comandoBasePedidos.CommandType = CommandType.TableDirect;
            comandoBasePedidos.CommandText = "Detalles de pedidos";
            lectorBasePedidos = comandoBasePedidos.ExecuteReader();

            grillaPedidos.Rows.Clear();
            while (lectorBasePedidos.Read())
            {
                if (comboBoxPedidos.Text == lectorBasePedidos[0].ToString())
                {
                    grillaPedidos.Rows.Add(lectorBasePedidos[0],lectorBasePedidos[1], lectorBasePedidos[2], lectorBasePedidos[3]);
                }
            }
        }
    }
}
