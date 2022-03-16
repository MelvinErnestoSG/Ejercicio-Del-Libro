using System;
using System.Windows;

namespace Ejercicio_Del_Libro_En_Wpf._03_Capitulos_6_y_7.Capitulos_6.Ejercicio_2
{
    /// <summary>
    /// Interaction logic for Capitulo6_Ejercicio2.xaml
    /// </summary>
    public partial class Capitulo6_Ejercicio2 : Window
    {
        public Capitulo6_Ejercicio2()
        {
            InitializeComponent();
        }

        private float Promedio;
        private int Menor = 2147483647;
        private readonly int[] Numeros = new int[5];

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            int cantidad = Convert.ToInt32(CantidadTextBox.Text);

            for (int n = 1; n < 5; n++)
            {
                Numeros[n] = Convert.ToInt32(CantidadTextBox.Text);
                Promedio += Convert.ToSingle(CantidadTextBox.Text);

                if (Convert.ToInt32(CantidadTextBox.Text) < Menor)
                    Menor = Convert.ToInt32(CantidadTextBox.Text);

            }

            PromedioTextBox.Text = Convert.ToString(Promedio / Convert.ToSingle(CantidadTextBox.Text));
            MenorTextBox.Text = Convert.ToString(Menor);
        }
    }
}
