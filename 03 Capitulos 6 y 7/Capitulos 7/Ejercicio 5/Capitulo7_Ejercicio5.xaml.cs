using System.Collections;
using System.Windows;

namespace Ejercicio_Del_Libro_En_Wpf._03_Capitulos_6_y_7.Capitulos_7.Ejercicio_5
{
    /// <summary>
    /// Interaction logic for Capitulo7_Ejercicio5.xaml
    /// </summary>
    public partial class Capitulo7_Ejercicio5 : Window
    {

        public Capitulo7_Ejercicio5()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            Hashtable definition = new Hashtable
            {
                { "Nombre es Julian ", "Su Telefono 809-456-8903" },
                { "Nombre es Ana ", "Su Telefono Tel 829-331-2415" },
                { "Nombre es Pedro ", "Su Telefono 849-501-5691" },
                { "Nombre es Juan ", "Su Telefono 809-881-2244" }
            };

            foreach (DictionaryEntry elemento in definition)
            {
                _ = MessageBox.Show("Precione Enter Para Continuar", elemento.Key + elemento.Value.ToString());
            }
        }
    }
}
