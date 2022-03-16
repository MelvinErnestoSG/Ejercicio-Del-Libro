using System;
using System.Windows;

namespace Ejercicio_Del_Libro_En_Wpf._02_Capitulos_4_y_5.Capitulos_4.Ejercicio_1
{
    /// <summary>
    /// Interaction logic for Capitulo4_Ejercicio1.xaml
    /// </summary>
    public partial class Capitulo4_Ejercicio1 : Window
    {
        public Capitulo4_Ejercicio1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int valor;
            valor = Convert.ToInt32(valorTextBox.Text);

            Label1.Content = valorTextBox.Text;
            Label2.Content = valorTextBox.Text;
            Label3.Content = valorTextBox.Text;
            Label4.Content = valorTextBox.Text;
            Label5.Content = valorTextBox.Text;
            Label6.Content = valorTextBox.Text;
            Label7.Content = valorTextBox.Text;
            Label8.Content = valorTextBox.Text;
            Label9.Content = valorTextBox.Text;
            Label10.Content = valorTextBox.Text;

            result1.Content = 1 * valor;
            result2.Content = 2 * valor;
            result3.Content = 3 * valor;
            result4.Content = 4 * valor;
            result5.Content = 5 * valor;
            result6.Content = 6 * valor;
            result7.Content = 7 * valor;
            result8.Content = 8 * valor;
            result9.Content = 9 * valor;
            result10.Content = 10 * valor;

        }
    }
}
