using System;
using System.Collections;
using System.Windows;

namespace Ejercicio_Del_Libro_En_Wpf._03_Capitulos_6_y_7.Capitulos_7.Ejercicio_1
{
    /// <summary>
    /// Interaction logic for Capitulo7_Ejercicio1.xaml
    /// </summary>
    public partial class Capitulo7_Ejercicio1 : Window
    {
        public Capitulo7_Ejercicio1()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            ArrayList lista = new ArrayList
            {
                "Cantidad de Alumnos son 100",
                "Cantidad de Salones son 10",
                "Promedio de Alumnos son 10",
                "Calificacion de Alumnos Maxima es 90",
                "Calificacion de Alumnos minima es 70",
            };

            foreach (object datos in lista)
            {
                _ = MessageBox.Show("Precione Enter Para Continuar", datos.ToString());
            }
        }
    }
}
