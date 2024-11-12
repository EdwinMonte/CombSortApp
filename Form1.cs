namespace CombSortApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            // Limpia el DataGridView para el nuevo conjunto de datos
            dataGridViewSteps.Rows.Clear();
            dataGridViewSteps.Columns.Clear();

            // Genera un arreglo de 6 números aleatorios
            int[] numbers = GenerateRandomArray(6);

            // Crea las columnas en el DataGridView
            for (int i = 0; i < numbers.Length; i++)
            {
                dataGridViewSteps.Columns.Add("Column" + i, "Elemento " + i);
            }

            // Muestra el arreglo inicial en el DataGridView
            AddArrayToDataGridView(numbers, "Array inicial");

            // Llama al método de Comb Sort y muestra el proceso en DataGridView
            CombSort(numbers);

            // Muestra el resultado final en el DataGridView
            AddArrayToDataGridView(numbers, "Array ordenado");
        }

        private int[] GenerateRandomArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 101); // Números aleatorios entre 1 y 100
            }
            return array;
        }

        private void CombSort(int[] array)
        {
            int gap = array.Length;
            bool swapped = true;
            double shrinkFactor = 1.3;

            // Comienza el proceso de ordenamiento
            while (gap > 1 || swapped)
            {
                // Actualiza el valor de gap
                gap = (int)(gap / shrinkFactor);
                if (gap < 1)
                    gap = 1;

                swapped = false;

                // Recorre el arreglo y compara elementos a la distancia actual
                for (int i = 0; i + gap < array.Length; i++)
                {
                    if (array[i] > array[i + gap])
                    {
                        // Intercambia los elementos
                        int temp = array[i];
                        array[i] = array[i + gap];
                        array[i + gap] = temp;
                        swapped = true;

                        // Muestra el estado actual del arreglo en el DataGridView
                        AddArrayToDataGridView(array, "Paso intermedio");
                    }
                }
            }
        }
        private void AddArrayToDataGridView(int[] array, string label)
        {
            // Crea una fila nueva en el DataGridView
            int rowIndex = dataGridViewSteps.Rows.Add();
            for (int i = 0; i < array.Length; i++)
            {
                dataGridViewSteps.Rows[rowIndex].Cells[i].Value = array[i];
            }
        }
    }
}
