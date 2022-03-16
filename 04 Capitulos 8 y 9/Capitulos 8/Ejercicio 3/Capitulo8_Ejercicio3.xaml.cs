using System;
using System.Windows;

namespace Ejercicio_Del_Libro_En_Wpf._04_Capitulos_8_y_9.Capitulos_8.Ejercicio_3
{
    /// <summary>
    /// Interaction logic for Capitulo8_Ejercicio3.xaml
    /// </summary>
    public partial class Capitulo8_Ejercicio3 : Window
    {
        public Capitulo8_Ejercicio3()
        {
            InitializeComponent();
        }

        private void PresionarButton_Click(object sender, RoutedEventArgs e)
        {
            DateTime date = DateTime.Today;
            string format = "dddd MMMM yyyy d, hh mm";
            _ = MessageBox.Show("Precione Enter Para Continuar:", date.ToString(format));
        }
    }
}
