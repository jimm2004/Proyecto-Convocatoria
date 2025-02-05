using System;
using System.Collections;
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
    public partial class frmAlgoritmos : Form
    {
        private List<Producto> productos = new List<Producto>();

        public frmAlgoritmos()
        {
            InitializeComponent();
            AgregarProductos();
        }

        private void AgregarProductos()
        {
            Producto[] listaProductos = {
                new Producto("Tapones", "Externos", 10.00, 200),
                new Producto("Anillos de pistón", "Internos", 50.00, 100),
                new Producto("Biela", "Internos", 200.00, 20),
                new Producto("Guardafangos", "Externos", 90.00, 35),
                new Producto("Tornillos", "Externos", 5.00, 500),
                new Producto("Cigueñal", "Internos", 450.00, 10),
                new Producto("Parabrisas", "Externos", 250.00, 10),
                new Producto("Caja de Cambios", "Internos", 300.00, 15),
                new Producto("Pistones", "Internos", 90.25, 50),
                new Producto("Espejos laterales", "Externos", 45.00, 40),
                new Producto("Arbol de levas", "Internos", 150.75, 25),
                new Producto("Faros delanteros", "Externos", 120.00, 25),
                new Producto("Tanque de Combustible", "Externos", 180.00, 20),
                new Producto("Cadena de Caja", "Internos", 80.50, 40),
                new Producto("Junta de culata", "Internos", 25.00, 80),
                new Producto("Carburador", "Internos", 120.00, 30),
                new Producto("Válvulas", "Internos", 75.00, 60),
                new Producto("Cadena", "Externos", 60.00, 50),
                new Producto("Manubrios", "Externos", 70.00, 30),
                new Producto("Manecillas", "Externos", 15.00, 100),
                new Producto("Filtro de aire", "Internos", 35.00, 75),
                new Producto("Radiador", "Internos", 280.00, 15),
                new Producto("Bobina de encendido", "Internos", 110.00, 25),
                new Producto("Bomba de aceite", "Internos", 95.00, 35),
                new Producto("Rodamientos", "Internos", 30.00, 150),
                new Producto("Discos de freno", "Externos", 85.00, 40),
                new Producto("Pastillas de freno", "Externos", 55.00, 60),
                new Producto("Eje trasero", "Internos", 220.00, 20),
                new Producto("Embrague", "Internos", 175.00, 25),
                new Producto("Alternador", "Internos", 320.00, 15),
                new Producto("Bomba de gasolina", "Internos", 145.00, 30),
                new Producto("Correa de distribución", "Internos", 65.00, 45),
                new Producto("Sensor de oxígeno", "Internos", 135.00, 20),
                new Producto("Tapa de válvulas", "Internos", 40.00, 60),
                new Producto("Compresor de aire acondicionado", "Internos", 400.00, 10),
                new Producto("Motor de arranque", "Internos", 275.00, 12),
                new Producto("Bujías", "Internos", 20.00, 100),
                new Producto("Llanta delantera", "Externos", 150.00, 25),
                new Producto("Llanta trasera", "Externos", 175.00, 20),
                new Producto("Guardabarros", "Externos", 90.00, 30),
                new Producto("Asiento de motocicleta", "Externos", 125.00, 15),
                new Producto("Puños de manillar", "Externos", 25.00, 80),
                new Producto("Caballete central", "Externos", 55.00, 50),
                new Producto("Soporte de matrícula", "Externos", 35.00, 70),
                new Producto("Intermitentes LED", "Externos", 50.00, 60),
                new Producto("Amortiguadores", "Internos", 200.00, 20),
                new Producto("Faro trasero", "Externos", 95.00, 30),
                new Producto("Escape deportivo", "Externos", 175.00, 15),
                new Producto("Protector de cadena", "Externos", 40.00, 50)
            };


            foreach (var item in listaProductos)
            {
                productos.Add(item);            
            }

            ActualizarListBox();
        }

        private void ActualizarListBox()
        {
            listaDelinventario.Items.Clear();
            foreach (var producto in productos)
            {
                listaDelinventario.Items.Add(producto.ToString());
            }
        }

        #region BubleSort
        private void btnbubleSort_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < productos.Count - 1; i++)
            {
                for (int j = 0; j < productos.Count - i - 1; j++)
                {
                    if (string.Compare(productos[j].Nombre, productos[j + 1].Nombre) > 0)
                    {
                        var temp = productos[j];
                        productos[j] = productos[j + 1];
                        productos[j + 1] = temp;
                    }
                }
            }
            ActualizarListBox();
        }
        #endregion

        #region QuickSort
        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            QuickSort(productos, 0, productos.Count - 1);
            ActualizarListBox();
        }

        private void QuickSort(List<Producto> lista, int inicio, int fin)
        {
            if (inicio < fin)
            {
                int pivote = Particion(lista, inicio, fin);
                QuickSort(lista, inicio, pivote - 1);
                QuickSort(lista, pivote + 1, fin);
            }
        }

        private int Particion(List<Producto> lista, int inicio, int fin)
        {
            Producto pivote = lista[fin];
            int i = inicio - 1;

            for (int j = inicio; j < fin; j++)
            {
                if (lista[j].Nombre.CompareTo(pivote.Nombre) <= 0)
                {
                    i++;
                    var temp = lista[i];
                    lista[i] = lista[j];
                    lista[j] = temp;
                }
            }

            var temp2 = lista[i + 1];
            lista[i + 1] = lista[fin];
            lista[fin] = temp2;

            return i + 1;
        }
        #endregion

        #region HeapSort
        private void btnHeapSort_Click(object sender, EventArgs e)
        {
            HeapSort(productos);
            ActualizarListBox();
        }

        private void HeapSort(List<Producto> lista)
        {
            int n = lista.Count;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(lista, n, i);
            }

            for (int i = n - 1; i > 0; i--)
            {
                var temp = lista[0];
                lista[0] = lista[i];
                lista[i] = temp;

                Heapify(lista, i, 0);
            }
        }

        private void Heapify(List<Producto> lista, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && lista[left].Nombre.CompareTo(lista[largest].Nombre) > 0) 
            {
                largest = left;
            }

            if (right < n && lista[right].Nombre.CompareTo(lista[largest].Nombre) > 0)
            {
                largest = right;
            }

            if (largest != i)
            {
                var temp = lista[i];
                lista[i] = lista[largest];
                lista[largest] = temp;

                Heapify(lista, n, largest);
            }
        }

        #endregion

        #region ShellSort
        private void btnShellSort_Click(object sender, EventArgs e)
        {
            ShellSort(productos);
            ActualizarListBox();
        }

        private void ShellSort(List<Producto> lista)
        {
            int n = lista.Count;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    Producto temp = lista[i];
                    int j;
                    for (j = i; j >= gap && lista[j - gap].Nombre.CompareTo(temp.Nombre) > 0; j -= gap)
                    {
                        lista[j] = lista[j - gap];
                    }
                    lista[j] = temp;
                }
            }
        }

        #endregion

        #region ShackerSort
        private void btnShackerSort_Click(object sender, EventArgs e)
        {
            ShakerSort(productos);
            ActualizarListBox();
        }

        private void ShakerSort(List<Producto> lista)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < lista.Count - 1; i++)
                {
                    if (lista[i].Nombre.CompareTo(lista[i + 1].Nombre) > 0)
                    {
                        var temp = lista[i];
                        lista[i] = lista[i + 1];
                        lista[i + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped) break;

                swapped = false;
                for (int i = lista.Count - 2; i >= 0; i--)
                {
                    if (lista[i].Nombre.CompareTo(lista[i + 1].Nombre) > 0)
                    {
                        var temp = lista[i];
                        lista[i] = lista[i + 1];
                        lista[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }
        #endregion

        #region SelectioSort
        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            SelectionSort(productos);
            ActualizarListBox();
        }

        private void SelectionSort(List<Producto> lista)
        {
            for (int i = 0; i < lista.Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (lista[j].Nombre.CompareTo(lista[minIndex].Nombre) < 0)
                    {
                        minIndex = j;
                    }
                }
                var temp = lista[i];
                lista[i] = lista[minIndex];
                lista[minIndex] = temp;
            }
        }

        #endregion

        private void btnDesordenar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            productos = productos.OrderBy(x => rnd.Next()).ToList();
            ActualizarListBox();
        }
    }

    public class Producto
    {
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }

        public Producto(string nombre, string categoria, double precio, int cantidad)
        {
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
            Cantidad = cantidad;
        }

        public override string ToString()
        {
            return $"{Nombre} - {Categoria} - ${Precio:F2} - {Cantidad} unidades";
        }
    }
}
