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
    public partial class frmCola : Form
    {
        // Colleccion FIFO (Primero en entrar, primero en salir)
        private Queue<(string Nombre, string Tipo, double Precio)> colaInventario = new Queue<(string, string, double)>();
        // Arreglos de los inventario de las categorias
        string[] productosInternos;
        string[] productosExternos;

        public frmCola()
        {
            InitializeComponent();
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

        // Actualizacion del DataGridView cuando hacemos Push, Pop y Peek
        private void ActualizarDataGridView()
        {
            dgvInventario.Rows.Clear();

            foreach (var producto in colaInventario)
            {
                dgvInventario.Rows.Add(producto.Nombre, producto.Tipo, producto.Precio);
            }
        }

        // Funcion Push al inventario
        private void btnPush_Click(object sender, EventArgs e)
        {

            // Validamos que el valor del precio sea valido y no entre vacio
            if (string.IsNullOrEmpty(txtPrecio.Text) || !double.TryParse(txtPrecio.Text, out double precio))
            {
                MessageBox.Show("Ingrese un precio válido.");
                return;
            }

            // Verificamos la categoria del producto
            string tipo = rdaInterno.Checked ? "Interno" : "Externo";

            // Seleccionamos el producto del comboBox
            string productoSeleccionado = cmbProductos.SelectedItem.ToString();

            // Realizamos un push al final de la cola 
            colaInventario.Enqueue((productoSeleccionado, tipo, precio));

            // Actualizamos el DataGridView Con los nuevos productos
            ActualizarDataGridView();

            // Mostramos un mensage de la accion completada
            MessageBox.Show("Producto agregado al inventario.");
        }


        private void btnPop_Click(object sender, EventArgs e)
        {
            // Verificamos que la cola no este vacia
            if (colaInventario.Count == 0)
            {
                MessageBox.Show("El inventario está vacío.");
                return;
            }

            // Eliminar el primer producto agregado
            var productoEliminado = colaInventario.Dequeue();

            // Actualizamos el DataGridView Con los nuevos productos
            ActualizarDataGridView();

            // Mostramos un mensage de la accion completada
            MessageBox.Show($"Producto eliminado: {productoEliminado.Nombre}");
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            // Verificamos que la cola no este vacia
            if (colaInventario.Count == 0)
            {
                MessageBox.Show("El inventario está vacío.");
                return;
            }

            // Obtener el primer producto sin eliminar
            var producto = colaInventario.Peek();

            // Mostramos en un mensage el ultimo producto
            MessageBox.Show($"Primer producto agregado: {producto.Nombre} - Precio: {producto.Precio}");
        }
    }
}
