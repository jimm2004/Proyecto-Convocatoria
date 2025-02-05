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
    public partial class frmListaDoble : Form
    {
        private Nodo cabeza = null;
        private Nodo cola = null;
        private int contador = 0, capacidad;
        private bool tieneCapacidad = false;
        // Arreglos de los inventario de las categorias
        string[] productosInternos;
        string[] productosExternos;

        public frmListaDoble()
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

        // Agregamos al final
        public void AgregarAlFinal(string nombre, string tipo, double precio)
        {
            if (contador >= capacidad)
            {
                // Eliminamos el primer elemento (FIFO) si la lista está llena
                EliminarAlInicio();
            }

            Nodo nuevoNodo = new Nodo(nombre, tipo, precio);

            if (cabeza == null)
            {
                cabeza = cola = nuevoNodo;
            }
            else
            {
                nuevoNodo.Anterior = cola;
                cola.Siguiente = nuevoNodo;
                cola = nuevoNodo;
            }

            contador++;
        }

        // Eliminamos al inicio
        public void EliminarAlInicio()
        {
            if (cabeza == null) return;

            if (cabeza == cola)
            {
                cabeza = cola = null;
            }
            else
            {
                cabeza = cabeza.Siguiente;
                cabeza.Anterior = null;
            }

            contador--;
        }

        // Obtenemos el nodo cabeza
        public Nodo ObtenerPrimero()
        {
            return cabeza;
        }

        // Obtenemos el inventario completo
        public List<(string, string, double)> ObtenerInventario()
        {
            List<(string, string, double)> inventario = new List<(string, string, double)>();
            Nodo actual = cabeza;

            while (actual != null)
            {
                inventario.Add((actual.Nombre, actual.Tipo, actual.Precio));
                actual = actual.Siguiente;
            }

            return inventario;
        }

        // Verificamos si la lista doble esta llena
        public bool EstaLLena()
        {
            return contador >= capacidad;
        }

        // Actualizamos el inventario
        private void ActualizarDataGridView()
        {
            dgvInventario.Rows.Clear();
            var inventario = ObtenerInventario();

            foreach (var producto in inventario)
            {
                dgvInventario.Rows.Add(producto.Item1, producto.Item2, producto.Item3);
            }
        }

        // Agregamos al final de la lista doble
        private void btnPush_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrecio.Text) || !double.TryParse(txtPrecio.Text, out double precio))
            {
                MessageBox.Show("Ingrese un precio válido.");
                return;
            }

            if (string.IsNullOrEmpty(txtCapacidad.Text) || !int.TryParse(txtCapacidad.Text, out int capacidad))
            {
                MessageBox.Show("Ingrese una capacidad válida.");
                return;
            }

            if (capacidad <= 0)
            {
                MessageBox.Show("Ingrese una capacidad mayor a cero.");
                return;
            }

            if (!tieneCapacidad)
            {
                this.capacidad = capacidad;
                tieneCapacidad = true;
                txtCapacidad.ReadOnly = true;
            }

            string tipo = rdaInterno.Checked ? "Interno" : "Externo";
            string producto = cmbProductos.SelectedItem.ToString();

            // Agregamos al final de la lista doble
            AgregarAlFinal(producto, tipo, precio);

            ActualizarDataGridView();

            if (EstaLLena())
            {
                MessageBox.Show("El inventario está lleno. Se eliminó el producto más antiguo.");
            }
            else
            {
                MessageBox.Show("Producto agregado al inventario.");
            }
        }

        // Eliminamos el producto mas antiguo
        private void btnPop_Click(object sender, EventArgs e)
        {
            if (ObtenerPrimero() == null)
            {
                MessageBox.Show("El inventario está vacío.");
                return;
            }

            // Eliminar el primer elemento
            EliminarAlInicio();

            ActualizarDataGridView();
            MessageBox.Show("Producto eliminado del inventario.");
        }

        // Obtenemos el producto mas antiguo
        private void btnPeek_Click(object sender, EventArgs e)
        {
            Nodo primerProducto = ObtenerPrimero();

            if (primerProducto == null)
            {
                MessageBox.Show("El inventario está vacío.");
                return;
            }

            MessageBox.Show($"Primer producto: {primerProducto.Nombre} - Precio: {primerProducto.Precio}");
        }
    }

    public class Nodo
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public double Precio { get; set; }
        public Nodo Anterior { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(string nombre, string tipo, double precio)
        {
            Nombre = nombre;
            Tipo = tipo;
            Precio = precio;
            Anterior = null;
            Siguiente = null;
        }
    }
}
