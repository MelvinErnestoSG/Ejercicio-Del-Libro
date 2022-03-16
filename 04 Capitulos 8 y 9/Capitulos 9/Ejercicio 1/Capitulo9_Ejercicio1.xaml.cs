using System;
using System.Windows;
using System.Windows.Controls;

namespace Ejercicio_Del_Libro_En_Wpf._04_Capitulos_8_y_9.Capitulos_9.Ejercicio_1
{
    /// <summary>
    /// Interaction logic for Capitulo9_Ejercicio1.xaml
    /// </summary>
    public partial class Capitulo9_Ejercicio1 : Window
    {
        public Capitulo9_Ejercicio1()
        {
            InitializeComponent();
        }

        public struct Products
        {
            public string name;
            public double price;

            public Products(string Name, double Price)
            {
                name = Name;
                price = Price;
            }
        }

        readonly Products[] products = new Products[10];
        int accumulator;

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            products[accumulator].name = NameTextBox.Text;
            TextBox priceTextBox = PriceTextBox;
            products[accumulator].price = Convert.ToDouble(priceTextBox.Text);
            accumulator++;
        }
    }
}
