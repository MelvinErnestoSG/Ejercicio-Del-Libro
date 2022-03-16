using System;
using System.Windows;

namespace Ejercicio_Del_Libro_En_Wpf._02_Capitulos_4_y_5.Capitulos_4.Ejercicio_2
{
    /// <summary>
    /// Interaction logic for Capitulo4_Ejercicio2.xaml
    /// </summary>
    public partial class Capitulo4_Ejercicio2 : Window
    {
        public Capitulo4_Ejercicio2()
        {
            InitializeComponent();
        }

        private void CalcularBoton_Click(object sender, RoutedEventArgs e)
        {
            double valor1;
            double valor2;
            double valor3;

            valor1 = Convert.ToInt32(CoeficienteTextBox.Text);
            valor2 = Convert.ToInt32(ExponenteTextBox.Text);

            valor3 = Math.Pow(valor1, valor2);
            ResultTextBox.Text = Convert.ToString(valor3);
        }
    }
}
