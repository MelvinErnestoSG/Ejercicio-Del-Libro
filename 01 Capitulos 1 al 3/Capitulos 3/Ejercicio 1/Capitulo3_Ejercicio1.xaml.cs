using System;
using System.Windows;

namespace Ejercicio_Del_Libro_En_Wpf._01_Capitulos_1_al_3.Capitulos_3.Ejercicio_1
{
    /// <summary>
    /// Interaction logic for Capitulo3_Ejercicio1.xaml
    /// </summary>
    public partial class Capitulo3_Ejercicio1 : Window
    {
        public Capitulo3_Ejercicio1()
        {
            InitializeComponent();
        }

        private void CalcularBoton_Click(object sender, RoutedEventArgs e)
        {
            int Numero;

            Numero = Convert.ToInt32(NumeroTextBox.Text);

            if (Numero % 2 == 0)
                _ = MessageBox.Show("El Numero es Par.");
            else
                _ = MessageBox.Show("El Numero es ImPar.");
        }
    }
}
