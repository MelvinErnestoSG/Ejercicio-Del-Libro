using System;
using System.Windows;

namespace Ejercicio_Del_Libro_En_Wpf._01_Capitulos_1_al_3.Capitulos_3.Ejercicio_4
{
    /// <summary>
    /// Interaction logic for Capitulo3_Ejercicio4.xaml
    /// </summary>
    public partial class Capitulo3_Ejercicio4 : Window
    {
        public Capitulo3_Ejercicio4()
        {
            InitializeComponent();
        }

        private void MostrarBoton_Click(object sender, RoutedEventArgs e)
        {
            int Numero;

            Numero = Convert.ToInt32(NumeroTextBox.Text);

            if (Numero == 1)
                _ = MessageBox.Show("Domingo.");

            if (Numero == 2)
                _ = MessageBox.Show("Lunes");

            if (Numero == 3)
                _ = MessageBox.Show("Martes.");

            if (Numero == 4)
                _ = MessageBox.Show("Miercoles");

            if (Numero == 5)
                _ = MessageBox.Show("Jueves.");

            if (Numero == 6)
                _ = MessageBox.Show("Viernes");

            if (Numero == 7)
                _ = MessageBox.Show("Sabado.");

        }
    }
}
