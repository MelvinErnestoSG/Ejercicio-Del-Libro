using Ejercicio_Del_Libro_En_Wpf._01_Capitulos_1_al_3.Capitulos_1.Ejercicio_1;
using Ejercicio_Del_Libro_En_Wpf._01_Capitulos_1_al_3.Capitulos_1.Ejercicio_5;

using Ejercicio_Del_Libro_En_Wpf._01_Capitulos_1_al_3.Capitulos_2.Ejercicio_1;
using Ejercicio_Del_Libro_En_Wpf._01_Capitulos_1_al_3.Capitulos_2.Ejercicio_3;
using Ejercicio_Del_Libro_En_Wpf._01_Capitulos_1_al_3.Capitulos_2.Ejercicio_4;
using Ejercicio_Del_Libro_En_Wpf._01_Capitulos_1_al_3.Capitulos_2.Ejercicio_5;

using Ejercicio_Del_Libro_En_Wpf._01_Capitulos_1_al_3.Capitulos_3.Ejercicio_1;
using Ejercicio_Del_Libro_En_Wpf._01_Capitulos_1_al_3.Capitulos_3.Ejercicio_4;

using Ejercicio_Del_Libro_En_Wpf._02_Capitulos_4_y_5.Capitulos_4.Ejercicio_1;
using Ejercicio_Del_Libro_En_Wpf._02_Capitulos_4_y_5.Capitulos_4.Ejercicio_2;
using Ejercicio_Del_Libro_En_Wpf._02_Capitulos_4_y_5.Capitulos_4.Ejercicio_5;

using Ejercicio_Del_Libro_En_Wpf._02_Capitulos_4_y_5.Capitulos_5.Ejercicio_4;
using Ejercicio_Del_Libro_En_Wpf._02_Capitulos_4_y_5.Capitulos_5.Ejercicio_5;

using Ejercicio_Del_Libro_En_Wpf._03_Capitulos_6_y_7.Capitulos_6.Ejercicio_1;
using Ejercicio_Del_Libro_En_Wpf._03_Capitulos_6_y_7.Capitulos_6.Ejercicio_2;
using Ejercicio_Del_Libro_En_Wpf._03_Capitulos_6_y_7.Capitulos_6.Ejercicio_3;
using Ejercicio_Del_Libro_En_Wpf._03_Capitulos_6_y_7.Capitulos_6.Ejercicio_4;
using Ejercicio_Del_Libro_En_Wpf._03_Capitulos_6_y_7.Capitulos_6.Ejercicio_5;

using Ejercicio_Del_Libro_En_Wpf._03_Capitulos_6_y_7.Capitulos_7.Ejercicio_1;
using Ejercicio_Del_Libro_En_Wpf._03_Capitulos_6_y_7.Capitulos_7.Ejercicio_2;
using Ejercicio_Del_Libro_En_Wpf._03_Capitulos_6_y_7.Capitulos_7.Ejercicio_5;

using Ejercicio_Del_Libro_En_Wpf._04_Capitulos_8_y_9.Capitulos_8.Ejercicio_3;
using Ejercicio_Del_Libro_En_Wpf._04_Capitulos_8_y_9.Capitulos_8.Ejercicio_5;
using Ejercicio_Del_Libro_En_Wpf._04_Capitulos_8_y_9.Capitulos_9.Ejercicio_1;
using Ejercicio_Del_Libro_En_Wpf._04_Capitulos_8_y_9.Capitulos_9.Ejercicio_3;
using Ejercicio_Del_Libro_En_Wpf._04_Capitulos_8_y_9.Capitulos_9.Ejercicio_4;

using Ejercicio_Del_Libro_En_Wpf._05_Capitulos_10_y_12.Capitulos_10.Ejercicio_1;
using Ejercicio_Del_Libro_En_Wpf._05_Capitulos_10_y_12.Capitulos_10.Ejercicio_2;
using Ejercicio_Del_Libro_En_Wpf._05_Capitulos_10_y_12.Capitulos_10.Ejercicio_3;
using Ejercicio_Del_Libro_En_Wpf._05_Capitulos_10_y_12.Capitulos_10.Ejercicio_4;
using Ejercicio_Del_Libro_En_Wpf._05_Capitulos_10_y_12.Capitulos_10.Ejercicio_5;

using Ejercicio_Del_Libro_En_Wpf._05_Capitulos_10_y_12.Capitulos_12.Ejercicio_1;
using Ejercicio_Del_Libro_En_Wpf._05_Capitulos_10_y_12.Capitulos_12.Ejercicio_2;
using Ejercicio_Del_Libro_En_Wpf._05_Capitulos_10_y_12.Capitulos_12.Ejercicio_3;
using Ejercicio_Del_Libro_En_Wpf._05_Capitulos_10_y_12.Capitulos_12.Ejercicio_4;
using Ejercicio_Del_Libro_En_Wpf._05_Capitulos_10_y_12.Capitulos_12.Ejercicio_5;

using System.Windows;

namespace Ejercicio_Del_Libro_En_Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /*Botones Para El Capitulo 1*/
        private void Capitulo1_Ejercicio1_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo1_Ejercicio1();
            Ventana.Show();
        }

        private void Capitulo1_Ejercicio5_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo1_Ejercicio5();
            Ventana.Show();
        }

        /*Botones Para El Capitulo 2*/
        private void Capitulo2_Ejercicio1_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo2_Ejercicio1();
            Ventana.Show();
        }

        private void Capitulo2_Ejercicio3_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo2_Ejercicio3();
            Ventana.Show();
        }

        private void Capitulo2_Ejercicio4_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo2_Ejercicio4();
            Ventana.Show();
        }

        private void Capitulo2_Ejercicio5_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo2_Ejercicio5();
            Ventana.Show();
        }

        /*Botones Para El Capitulo 3*/
        private void Capitulo3_Ejercicio1_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo3_Ejercicio1();
            Ventana.Show();
        }

        private void Capitulo3_Ejercicio4_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo3_Ejercicio4();
            Ventana.Show();
        }

        /*Botones Para El Capitulo 4*/
        private void Capitulo4_Ejercicio1_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo4_Ejercicio1();
            Ventana.Show();
        }

        private void Capitulo4_Ejercicio2_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo4_Ejercicio2();
            Ventana.Show();
        }

        private void Capitulo4_Ejercicio5_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo4_Ejercicio5();
            Ventana.Show();
        }

        /*Botones Para El Capitulo 5*/
        private void Capitulo5_Ejercicio4_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo5_Ejercicio4();
            Ventana.Show();
        }

        private void Capitulo5_Ejercicio5_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo5_Ejercicio5();
            Ventana.Show();
        }

        /*Botones Para El Capitulo 6*/
        private void Capitulo6_Ejercicio1_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo6_Ejercicio1();
            Ventana.Show();
        }

        private void Capitulo6_Ejercicio2_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo6_Ejercicio2();
            Ventana.Show();
        }

        private void Capitulo6_Ejercicio3_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo6_Ejercicio3();
            Ventana.Show();
        }

        private void Capitulo6_Ejercicio4_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo6_Ejercicio4();
            Ventana.Show();
        }

        private void Capitulo6_Ejercicio5_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo6_Ejercicio5();
            Ventana.Show();
        }

        /*Botones Para El Capitulo 7*/
        private void Capitulo7_Ejercicio1_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo7_Ejercicio1();
            Ventana.Show();
        }

        private void Capitulo7_Ejercicio2_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo7_Ejercicio2();
            Ventana.Show();
        }

        private void Capitulo7_Ejercicio5_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo7_Ejercicio5();
            Ventana.Show();
        }

        /*Botones Para El Capitulo 8*/
        private void Capitulo8_Ejercicio3_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo8_Ejercicio3();
            Ventana.Show();
        }

        private void Capitulo8_Ejercicio5_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo8_Ejercicio5();
            Ventana.Show();
        }

        /*Botones Para El Capitulo 9*/
        private void Capitulo9_Ejercicio1_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo9_Ejercicio1();
            Ventana.Show();
        }

        private void Capitulo9_Ejercicio3_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo9_Ejercicio3();
            Ventana.Show();
        }

        private void Capitulo9_Ejercicio4_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo9_Ejercicio4();
            Ventana.Show();
        }

        /*Botones Para El Capitulo 10*/
        private void Capitulo10_Ejercicio1_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo10_Ejercicio1();
            Ventana.Show();
        }

        private void Capitulo10_Ejercicio2_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo10_Ejercicio2();
            Ventana.Show();
        }

        private void Capitulo10_Ejercicio3_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo10_Ejercicio3();
            Ventana.Show();
        }

        private void Capitulo10_Ejercicio4_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo10_Ejercicio4();
            Ventana.Show();
        }

        private void Capitulo10_Ejercicio5_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo10_Ejercicio5();
            Ventana.Show();
        }

        /*Botones Para El Capitulo 12*/
        private void Capitulo12_Ejercicio1_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo12_Ejercicio1();
            Ventana.Show();
        }

        private void Capitulo12_Ejercicio2_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo12_Ejercicio2();
            Ventana.Show();
        }

        private void Capitulo12_Ejercicio3_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo12_Ejercicio3();
            Ventana.Show();
        }

        private void Capitulo12_Ejercicio4_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo12_Ejercicio4();
            Ventana.Show();
        }

        private void Capitulo12_Ejercicio5_Click(object sender, RoutedEventArgs e)
        {
            var Ventana = new Capitulo12_Ejercicio5();
            Ventana.Show();
        }
    }
}
