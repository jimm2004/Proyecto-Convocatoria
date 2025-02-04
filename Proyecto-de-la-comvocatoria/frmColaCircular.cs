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
    public partial class frmColaCircular : Form
    {
        private (string Nombre, string Tipo, double Precio)[] inventario;
        private int frente = -1, final = -1, capacidad;
        private bool tieneCapacidad = false;
        // Arreglos de los inventario de las categorias
        string[] productosInternos;
        string[] productosExternos;

        public frmColaCircular()
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

        private void ActualizarDataGridView()
        {
            // Limpiar el DataGridView
            dgvInventario.Rows.Clear();

            // Obtener los productos de la cola circular
            var inventario = ObtenerInventario();

            // Agregar cada producto al DataGridView
            foreach (var producto in inventario)
            {
                dgvInventario.Rows.Add(producto.Nombre, producto.Tipo, producto.Precio);
            }
        }

        // Funcion para ver si la cola circular esta vacia
        public bool EstaVacia()
        {
            return frente == -1;
        }

        // Funcion para ver si la cola circular esta llena
        public bool EstaLlena()
        {
            return (final + 1) % capacidad == frente;
        }

        // Agregar a la cola circular ultimo entra
        public void Enqueue(string nombre, string tipo, double precio)
        {
            if (EstaLlena())
            {
                MessageBox.Show("El inventario está lleno.");
                return;
            }

            if (EstaVacia())
            {
                frente = 0;
            }

            final = (final + 1) % capacidad;
            inventario[final] = (nombre, tipo, precio);
        }

        // Eliminar a la cola circular primero sale
        public void Dequeue()
        {
            if (EstaVacia())
            {
                MessageBox.Show("El inventario está vacío.");
                return;
            }

            if (frente == final)
            {
                frente = -1;
                final = -1;
            }
            else
            {
                frente = (frente + 1) % capacidad;
            }
        }

        // Ver el primero en la cola circular
        public (string Nombre, string Tipo, double Precio) Peek()
        {
            if (EstaVacia())
            {
                throw new InvalidOperationException("El inventario está vacío.");
            }

            return inventario[frente];
        }

        // Obtiene los elementos de todo el inventario
        public List<(string Nombre, string Tipo, double Precio)> ObtenerInventario()
        {
            List<(string, string, double)> lista = new List<(string, string, double)>();

            if (EstaVacia())
            {
                return lista;
            }

            int i = frente;
            while (true)
            {
                lista.Add(inventario[i]);
                if (i == final)
                {
                    break;
                }
                i = (i + 1) % capacidad;
            }

            return lista;
        }

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
                inventario = new (string, string, double)[this.capacidad];
                tieneCapacidad = true;
                txtCapacidad.ReadOnly = true;
            }

            // Obtener el tipo de producto seleccionado (Interno/Externo)
            string tipo = rdaInterno.Checked ? "Interno" : "Externo";

            // Obtener el producto seleccionado
            string productoSeleccionado = cmbProductos.SelectedItem.ToString();

            // Agregar a la cola circular
            Enqueue(productoSeleccionado, tipo, precio);

            // Actualizar el DataGridView
            ActualizarDataGridView();

            MessageBox.Show("Producto agregado al inventario.");
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (EstaVacia())
            {
                MessageBox.Show("El inventario está vacío.");
                return;
            }

            // Eliminar el primer producto
            Dequeue();

            // Actualizar el DataGridView
            ActualizarDataGridView();

            MessageBox.Show("Producto eliminado del inventario.");
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (EstaVacia())
            {
                MessageBox.Show("El inventario está vacío.");
                return;
            }

            // Obtener el primer producto
            var producto = Peek();

            MessageBox.Show($"Primer producto agregado: {producto.Nombre} - Precio: {producto.Precio}");
        }
    }
}
