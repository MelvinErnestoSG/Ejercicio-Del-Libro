using System;
using System.Windows;

namespace Ejercicio_Del_Libro_En_Wpf._03_Capitulos_6_y_7.Capitulos_6.Ejercicio_5
{
    /// <summary>
    /// Interaction logic for Capitulo6_Ejercicio5.xaml
    /// </summary>
    public partial class Capitulo6_Ejercicio5 : Window
    {
        public Capitulo6_Ejercicio5()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {

            int[] Numeros = new int[10];

            for (int n = 0; n < 1; n++)
            {
                Numeros[n] = Convert.ToInt32(CantidadTextBox.Text);
            }

            void Imprime(int[] Arreglo)
            {
                for (int n = 0; n < 1; n++)
                {
                    PromedioTextBox.Text = Numeros[n].ToString();
                }
            }
            Imprime(Numeros);
        }
    }
}
