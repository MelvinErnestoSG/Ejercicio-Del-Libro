using System;
using System.Windows;

namespace Ejercicio_Del_Libro_En_Wpf._04_Capitulos_8_y_9.Capitulos_8.Ejercicio_5
{
    /// <summary>
    /// Interaction logic for Capitulo8_Ejercicio5.xaml
    /// </summary>
    public partial class Capitulo8_Ejercicio5 : Window
    {
        public Capitulo8_Ejercicio5()
        {
            InitializeComponent();
        }

        private void VerificarButton_Click(object sender, RoutedEventArgs e)
        {

            string StringNumberOne, StringNumberTwo;
            StringNumberOne = StringOneTextBox.Text;
            StringNumberTwo = StringTwoTextBox.Text;

            int compare = String.Compare(StringNumberOne, StringNumberTwo);

            if (compare == 0)
            {
                _ = MessageBox.Show("Las Letras Iguales.", StringNumberOne.ToString());
            }
            else
            {
                _ = MessageBox.Show("Las letras No Son Iguales.", StringNumberTwo.ToString());
            }
        }
    }
}
