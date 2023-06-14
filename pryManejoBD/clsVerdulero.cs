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
    internal class clsVerdulero
    {
        OleDbConnection conectarBasePedidos = new OleDbConnection();
        OleDbCommand comandoBasePedidos = new OleDbCommand();
        OleDbDataReader lectorBasePedidos;

        OleDbConnection conectarBaseProducto = new OleDbConnection();
        OleDbCommand comandoBaseProducto = new OleDbCommand();
        OleDbDataReader lectorBaseProducto;

        OleDbConnection conectarVenta = new OleDbConnection();
        OleDbCommand comandoVenta = new OleDbCommand();
        OleDbDataReader lectorVenta;

        public void conectarVendedores()
        {
            try
            {
                conectarBasePedidos = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source =VERDULEROS.mdb");
                comandoBasePedidos = new OleDbCommand();
                conectarBasePedidos.Open();

                comandoBasePedidos.Connection = conectarBasePedidos;
                comandoBasePedidos.CommandType = CommandType.TableDirect;
                comandoBasePedidos.CommandText = "Vendedores";

                lectorBasePedidos = comandoBasePedidos.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }
        public void conectarProductos()
        {
            try
            {
                conectarBaseProducto = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source =VERDULEROS.mdb");
                comandoBaseProducto = new OleDbCommand();
                conectarBaseProducto.Open();

                comandoBaseProducto.Connection = conectarBasePedidos;
                comandoBaseProducto.CommandType = CommandType.TableDirect;
                comandoBaseProducto.CommandText = "Productos";

                lectorBaseProducto = comandoBaseProducto.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        public void cargarCombo(ComboBox cmbVendedores, ComboBox cmbProducto) 
        {
            conectarVendedores();
            conectarProductos();
            while (lectorBasePedidos.Read())
            {
                cmbVendedores.Items.Add(lectorBasePedidos[1]);
                
            }
            while (lectorBaseProducto.Read())
            {
                cmbProducto.Items.Add(lectorBaseProducto[1]);
            }
        }

        public void añadirVenta() 
        {
            try
            {
                conectarVenta = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source =VERDULEROS.mdb");
                comandoVenta = new OleDbCommand();
                conectarVenta.Open();

                comandoVenta.Connection = conectarVenta;
                comandoVenta.CommandType = System.Data.CommandType.Text;
                comandoVenta.CommandText = "INSERT INTO Ventas (`Cod Vendedor`, `Cod Producto`," + " Fecha, Kilos) VALUES (1,1 '14/06/2023',1)";
                comandoVenta.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
