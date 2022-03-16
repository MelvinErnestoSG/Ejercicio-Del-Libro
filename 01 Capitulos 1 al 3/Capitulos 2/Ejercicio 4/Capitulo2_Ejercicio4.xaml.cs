using System;
using System.Windows;

namespace Ejercicio_Del_Libro_En_Wpf._01_Capitulos_1_al_3.Capitulos_2.Ejercicio_4
{
    /// <summary>
    /// Interaction logic for Capitulo2_Ejercicio4.xaml
    /// </summary>
    public partial class Capitulo2_Ejercicio4 : Window
    {
        public Capitulo2_Ejercicio4()
        {
            InitializeComponent();
        }

        private void CalcularBoton_Click(object sender, RoutedEventArgs e)
        {
            float Centigrados;
            float Fahrenheit;

            Centigrados = Convert.ToInt32(CentigradosTextBox.Text);

            Fahrenheit = ((Centigrados * 9) / 5 + 32);

            ResultCentigradosTextBox.Text = Convert.ToString(Centigrados);

            ResultFahrenheitTextBox.Text = Convert.ToString(Fahrenheit);
        }
    }
}
