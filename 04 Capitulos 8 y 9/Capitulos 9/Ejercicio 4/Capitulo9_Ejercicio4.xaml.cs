using System;
using System.Windows;

namespace Ejercicio_Del_Libro_En_Wpf._04_Capitulos_8_y_9.Capitulos_9.Ejercicio_4
{
    /// <summary>
    /// Interaction logic for Capitulo9_Ejercicio4.xaml
    /// </summary>
    public partial class Capitulo9_Ejercicio4 : Window
    {
        public Capitulo9_Ejercicio4()
        {
            InitializeComponent();
        }

        enum tiposNeumaticos { verano, invierno, deportivos, dePista, todoTerreno, antiPincho, todoTiempo, otros }

        public void Types()
        {
            tiposNeumaticos neumaticos = tiposNeumaticos.antiPincho;
            int option = Convert.ToInt32(NumberTextBox.Text);

            switch (option)
            {
                case 1:
                    OptionListBox.Text = Convert.ToString(tiposNeumaticos.verano);
                    break;

                case 2:
                    OptionListBox.Text = Convert.ToString(tiposNeumaticos.invierno);
                    break;

                case 3:
                    OptionListBox.Text = Convert.ToString(tiposNeumaticos.deportivos);
                    break;

                case 4:
                    OptionListBox.Text = Convert.ToString(tiposNeumaticos.dePista);
                    break;

                case 5:
                    OptionListBox.Text = Convert.ToString(tiposNeumaticos.todoTerreno);
                    break;

                case 6:
                    OptionListBox.Text = Convert.ToString(tiposNeumaticos.antiPincho);
                    break;

                case 7:
                    OptionListBox.Text = Convert.ToString(tiposNeumaticos.todoTiempo);
                    break;

                case 8:
                    OptionListBox.Text = Convert.ToString(tiposNeumaticos.otros);
                    break;

                default:
                    MessageBox.Show("Pruebe con un numero entre 1 y 8.");
                    break;
            }
        }

        private void DisplayButton_Click(object sender, RoutedEventArgs e)
        {
            Types();
        }
    }
}
