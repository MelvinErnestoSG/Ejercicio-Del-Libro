using System;
using System.Windows;

namespace Ejercicio_Del_Libro_En_Wpf._03_Capitulos_6_y_7.Capitulos_6.Ejercicio_4
{
    /// <summary>
    /// Interaction logic for Capitulo6_Ejercicio4.xaml
    /// </summary>
    public partial class Capitulo6_Ejercicio4 : Window
    {
        public Capitulo6_Ejercicio4()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {

            int Salones = 0;

            // Creamos el arreglo
            int[][] calif = new int[Salones][];


            int Valor = Convert.ToInt32(CantidadTextBox.Text);

            static void Calcular(int Cantidad, int Salones, int[][] calif)
            {
                for (int n = 0; n < Salones; n++)
                {
                    calif[n] = new int[Cantidad];

                    for (int m = 0; m < calif[n].GetLength(0); m++)
                    {
                        calif[n][m] = calif[n][m];
                    }
                }
            }
            PromedioTextBox.Text = Convert.ToString(Salones + 2 / Convert.ToSingle(CantidadTextBox.Text));
        }
    }
}
