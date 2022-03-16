using System;
using System.Windows;

namespace Ejercicio_Del_Libro_En_Wpf._02_Capitulos_4_y_5.Capitulos_5.Ejercicio_4
{
    /// <summary>
    /// Interaction logic for Capitulo5_Ejercicio4.xaml
    /// </summary>
    public partial class Capitulo5_Ejercicio4 : Window
    {
        public Capitulo5_Ejercicio4()
        {
            InitializeComponent();
        }

        static long Factorial(long Valor)
        {
            if (Valor < 0)
                Valor *= -1;

            else if (Valor == 0)
                return 1;

            long i = Valor - 1;

            do
            {
                Valor *= i;
                i--;
            } while (i != 0);

            return Valor;
        }

        private void CalcularBoton_Click(object sender, RoutedEventArgs e)
        {
            long Numero, Resultado;

            Numero = Convert.ToInt64(numTextBox.Text);
            Resultado = Factorial(Numero);

            FactorialLabel.Content = Resultado;
        }
    }
}
