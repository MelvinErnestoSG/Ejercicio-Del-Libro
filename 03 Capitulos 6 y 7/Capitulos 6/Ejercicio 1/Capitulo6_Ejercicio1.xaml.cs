using System;
using System.Windows;

namespace Ejercicio_Del_Libro_En_Wpf._03_Capitulos_6_y_7.Capitulos_6.Ejercicio_1
{
    /// <summary>
    /// Interaction logic for Capitulo6_Ejercicio1.xaml
    /// </summary>
    public partial class Capitulo6_Ejercicio1 : Window
    {
        public Capitulo6_Ejercicio1()
        {
            InitializeComponent();
        }

        private float Promedio;

        private readonly int[] Numeros = new int[10];

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            int Cantidad = Convert.ToInt32(CantidadTextBox.Text);

            for (int n = 1; n < 10; n++)
            {
                Numeros[n] = Convert.ToInt32(CantidadTextBox.Text);
                Promedio += Convert.ToSingle(NumeroTextBox.Text);
            }

            PromedioTextBox.Text = Convert.ToString(Promedio / Convert.ToSingle(CantidadTextBox.Text));
        }
    }
}
