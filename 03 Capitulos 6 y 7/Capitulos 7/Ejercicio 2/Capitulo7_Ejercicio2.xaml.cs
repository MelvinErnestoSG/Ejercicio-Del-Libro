using System.Collections;
using System.Windows;

namespace Ejercicio_Del_Libro_En_Wpf._03_Capitulos_6_y_7.Capitulos_7.Ejercicio_2
{
    /// <summary>
    /// Interaction logic for Capitulo7_Ejercicio2.xaml
    /// </summary>
    public partial class Capitulo7_Ejercicio2 : Window
    {
        public Capitulo7_Ejercicio2()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            Hashtable definition = new Hashtable
            {
                { "Libro ", "es algo manuscritas o impresas, para leer." },
                { "Lapiz ", "es un instrumento de escritura o de dibujo." },
                { "Lapicero ", "es un instrumento de escritura o de dibujo." },
                { "Borra ", "cuya finalidad es eliminar trazos generalmente de lápiz." },
                { "Silla ", "es algo hecho de madera o pastico, para sentarse." },
                { "Cuaderno ", "es un instrumento de escritura o de dibujo." },
                { "Lapto ", "es un aparato que se utiliza para multiples tareas." },
                { "Mochila ", "cuya finalidad es cargar utiles escolares." },
                { "Calculadora ", "es un aparato que se usa para sumar, restar, dividir, multiplicar." },
                { "Regla ", "es un objecto que se utiliza para graficar lineas rectas." }
            };

            foreach (DictionaryEntry elemento in definition)
            {
                _ = MessageBox.Show("Precione Enter Para Continuar", elemento.Key + elemento.Value.ToString());
                //DatosLabel1.Content = elemento.Key + elemento.Value.ToString();
                //DatosLabel2.Content = elemento.Key + elemento.Value.ToString();
                //DatosLabel3.Content = elemento.Key + elemento.Value.ToString();
                //DatosLabel4.Content = elemento.Key + elemento.Value.ToString();
                //DatosLabel5.Content = elemento.Key + elemento.Value.ToString();
                //DatosLabel6.Content = elemento.Key + elemento.Value.ToString();
                //DatosLabel7.Content = elemento.Key + elemento.Value.ToString();
                //DatosLabel8.Content = elemento.Key + elemento.Value.ToString();
                //DatosLabel9.Content = elemento.Key + elemento.Value.ToString();
                //DatosLabel10.Content = elemento.Key + elemento.Value.ToString();
            }
        }
    }
}
