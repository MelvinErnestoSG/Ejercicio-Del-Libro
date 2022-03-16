using System;
using System.Windows;

namespace Ejercicio_Del_Libro_En_Wpf._01_Capitulos_1_al_3.Capitulos_2.Ejercicio_1
{
    /// <summary>
    /// Interaction logic for Capitulo2_Ejercicio1.xaml
    /// </summary>
    public partial class Capitulo2_Ejercicio1 : Window
    {
        public Capitulo2_Ejercicio1()
        {
            InitializeComponent();
        }

        private void CalcularBoton_Click(object sender, RoutedEventArgs e)
        {
            int Lado1;
            int Lado2;
            int Lado3;
            int Tamanio;
            int Perimetro;

            Lado1 = Convert.ToInt32(Lado1TextBox.Text);
            Lado2 = Convert.ToInt32(Lado2TextBox.Text);
            Lado3 = Convert.ToInt32(Lado3TextBox.Text);

            Tamanio = Convert.ToInt32(TamanioTextBox.Text);

            Perimetro = Tamanio * (Lado1 + Lado2 + Lado3);

            ResultTextBox.Text = Convert.ToString(Perimetro);
        }
    }
}
