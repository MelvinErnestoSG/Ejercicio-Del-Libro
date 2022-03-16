using System;
using System.Windows;

namespace Ejercicio_Del_Libro_En_Wpf._01_Capitulos_1_al_3.Capitulos_2.Ejercicio_3
{
    /// <summary>
    /// Interaction logic for Capitulo2_Ejercicio3.xaml
    /// </summary>
    public partial class Capitulo2_Ejercicio3 : Window
    {
        public Capitulo2_Ejercicio3()
        {
            InitializeComponent();
        }

        private void CalcularBoton_Click(object sender, RoutedEventArgs e)
        {
            float Grados;
            double Radianes;

            Grados = Convert.ToInt32(GradosTextBox.Text);
            
            Radianes = (Grados * (System.Math.PI / 180));

            ResultGradosTextBox.Text = Convert.ToString(Grados);

            ResultRadianesTextBox.Text = Convert.ToString(Radianes);
        }
    }
}
