using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_la_comvocatoria
{
    public partial class frmListaSimple : Form
    {
        private List<(string Nombre, string Tipo, double Precio)> listaInventario;
        // Arreglos de los inventario de las categorias
        string[] productosInternos;
        string[] productosExternos;

        public frmListaSimple()
        {
            InitializeComponent();

            listaInventario = new List<(string Nombre, string Tipo, double Precio)>();

            // Inicializacion de los productos segun su categoria
            productosInternos = new string[] { "Arbol de levas", "Cadena de Caja", "Caja de Cambios", "Carburador", "Pistones" };
            productosExternos = new string[] { "Tanque de Combustible", "Cadena", "Tapones", "Tornillos", "Manubrios", "Manecillas" };

            // Cargar productos de la categoria Internos
            foreach (string str in productosInternos)
            {
                cmbProductos.Items.Add(str);
            }

            // Selecionar el primer producto de la categoria
            if (cmbProductos.Items.Count > 0)
            {
                cmbProductos.SelectedIndex = 0;
            }
        }

        // Funcion que corre cuando cambiamos al radio button Interno y selecciona sus productos correspondientes
        private void rdaInterno_CheckedChanged(object sender, EventArgs e)
        {
            cmbProductos.Items.Clear();

            foreach (string str in productosInternos)
            {
                cmbProductos.Items.Add(str);
            }
        }

        // Funcion que corre cuando cambiamos al radio button Externo y selecciona sus productos correspondientes
        private void rdaExterno_CheckedChanged(object sender, EventArgs e)
        {
            cmbProductos.Items.Clear();

            foreach (string str in productosExternos)
            {
                cmbProductos.Items.Add(str);
            }
        }

        // Actualizamkos el dataGridView
        private void ActualizarDataGridView()
        {
            dgvInventario.Rows.Clear();

            foreach (var producto in listaInventario)
            {
                dgvInventario.Rows.Add(producto.Nombre, producto.Tipo, producto.Precio);
            }
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrecio.Text) || !double.TryParse(txtPrecio.Text, out double precio))
            {
                MessageBox.Show("Ingrese un precio válido.");
                return;
            }

            //Obtenemos el radioButton seleccionado
            string tipo = rdaInterno.Checked ? "Interno" : "Externo";

            // Obtenemos el producto seleccionado
            string productoSeleccionado = cmbProductos.SelectedItem.ToString();

            // Agregar a la lista
            listaInventario.Add((productoSeleccionado, tipo, precio));

            // Actualizamos el dataGridView
            ActualizarDataGridView();

            MessageBox.Show("Producto agregado al inventario.");
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (listaInventario.Count == 0)
            {
                MessageBox.Show("El inventario está vacío.");
                return;
            }

            // Removemos el prirmer producto
            listaInventario.RemoveAt(0);

            // Actualizamos el dataGridView
            ActualizarDataGridView();

            MessageBox.Show("Producto eliminado del inventario.");
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (listaInventario.Count == 0)
            {
                MessageBox.Show("El inventario está vacío.");
                return;
            }

            // Obtenemos el primer producto
            var producto = listaInventario[0];

            MessageBox.Show($"Primer producto agregado: {producto.Nombre} - Precio: {producto.Precio}");
        }
    }
}
