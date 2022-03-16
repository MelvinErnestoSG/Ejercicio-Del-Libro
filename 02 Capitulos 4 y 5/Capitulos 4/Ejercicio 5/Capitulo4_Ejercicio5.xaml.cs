using System;
using System.Windows;

namespace Ejercicio_Del_Libro_En_Wpf._02_Capitulos_4_y_5.Capitulos_4.Ejercicio_5
{
    /// <summary>
    /// Interaction logic for Capitulo4_Ejercicio5.xaml
    /// </summary>
    public partial class Capitulo4_Ejercicio5 : Window
    {
        public Capitulo4_Ejercicio5()
        {
            InitializeComponent();
        }

        float Promedio = 0;
        int Contador = 1;
        int Mayor = -2147483648;
        int Menor = 2147483647;

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            int cantidad = Convert.ToInt32(CantidadTextBox.Text);

            Promedio += Convert.ToSingle(EdadTextBox.Text);

            if (Convert.ToInt32(EdadTextBox.Text) < Menor)
                Menor = Convert.ToInt32(EdadTextBox.Text);

            if (Convert.ToInt32(EdadTextBox.Text) > Mayor)
                Mayor = Convert.ToInt32(EdadTextBox.Text);

            if ((cantidad - Contador) == 0)

                Contador += 1;
            PromedioTextBox.Text = Convert.ToString(Promedio / Convert.ToSingle(CantidadTextBox.Text));
            MayorTextBox.Text = Convert.ToString(Mayor);
            MenorTextBox.Text = Convert.ToString(Menor);
        }
    }
}
