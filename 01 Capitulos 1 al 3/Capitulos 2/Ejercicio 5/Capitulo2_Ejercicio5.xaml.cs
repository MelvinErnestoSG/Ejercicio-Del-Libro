using System;
using System.Windows;

namespace Ejercicio_Del_Libro_En_Wpf._01_Capitulos_1_al_3.Capitulos_2.Ejercicio_5
{
    /// <summary>
    /// Interaction logic for Capitulo2_Ejercicio5.xaml
    /// </summary>
    public partial class Capitulo2_Ejercicio5 : Window
    {
        public Capitulo2_Ejercicio5()
        {
            InitializeComponent();
        }

        private void CalcularBoton_Click(object sender, RoutedEventArgs e)
        {
            double Dolar;
            double Euro;
            double TasaDolar;
            double TasaEuro;
            double ResultadoDolar;
            double ResultadoEuro;

            Dolar = Convert.ToInt32(DolarTextBox.Text);

            TasaDolar = Convert.ToInt32(TasaDolarTextBox.Text);

            Euro = Convert.ToInt32(EuroTextBox.Text);

            TasaEuro = Convert.ToInt32(TasaEuroTextBox.Text);

            ResultadoDolar = Dolar * TasaDolar;
            ResultDolarTextBox.Text = Convert.ToString(ResultadoDolar);

            ResultadoEuro = Euro * TasaEuro;
            ResultEuroTextBox.Text = Convert.ToString(ResultadoEuro);
        }
    }
}
