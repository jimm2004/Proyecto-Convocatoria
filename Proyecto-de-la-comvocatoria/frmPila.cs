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
    public partial class frmPila : Form
    {
        // Coleccion LIFO (Ultimo en entrar, primero en salir)
        private Stack<(string Nombre, string Tipo, double Precio)> pilaInventario = new Stack<(string, string, double)>();
        // Arreglos de los inventario de las categorias
        string[] productosInternos;
        string[] productosExternos;

        public frmPila()
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

            foreach (var producto in pilaInventario)
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

            // Realizamos un push al stck de productos del inventario
            pilaInventario.Push((productoSeleccionado, tipo, precio));


            // Actualizamos el DataGridView Con los nuevos productos
            ActualizarDataGridView();

            // Mostramos un mensage de la accion completada
            MessageBox.Show("Producto agregado al inventario.");
        }


        // Funcion Pop del inventario
        private void btnPop_Click(object sender, EventArgs e)
        {

            // Verificamos que la pila no este vacia
            if (pilaInventario.Count == 0)
            {
                MessageBox.Show("El inventario está vacío.");
                return;
            }

            // Eliminamos el ultimo producto que entro a la pila
            var productoEliminado = pilaInventario.Pop();

            // actualizamos el dataGridView
            ActualizarDataGridView();

            // Mostramos un mensage de completacion de la tarea
            MessageBox.Show($"Producto eliminado: {productoEliminado.Nombre}");
        }

        // Funcion que muestra el ultimo producto que entro a la pila sin eliminarlo
        private void btnPeek_Click(object sender, EventArgs e)
        {

            // verificamos que la pila no este vacia
            if (pilaInventario.Count == 0)
            {
                MessageBox.Show("El inventario está vacío.");
                return;
            }

            // buscamos en la parte superior de la pila el producto y lo seleccionamos
            var producto = pilaInventario.Peek();


            // mostramos en un mensage el ultimo producto
            MessageBox.Show($"Último producto agregado: {producto.Nombre} - Precio: {producto.Precio}");
        }
    }
}