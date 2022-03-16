using System;
using System.Windows;

namespace Ejercicio_Del_Libro_En_Wpf._04_Capitulos_8_y_9.Capitulos_9.Ejercicio_3
{
    /// <summary>
    /// Interaction logic for Capitulo9_Ejercicio3.xaml
    /// </summary>
    public partial class Capitulo9_Ejercicio3 : Window
    {
        public Capitulo9_Ejercicio3()
        {
            InitializeComponent();
        }

        public struct Veterinaria
        {
            public string nameDueno;
            public double nameMascota;

            public Veterinaria(string NameDueno, double NameMascota)
            {
                nameDueno = NameDueno;
                nameMascota = NameMascota;
            }
        }

        readonly Veterinaria[] veterinarias = new Veterinaria[10];
        int accumulator;

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            veterinarias[accumulator].nameDueno = NameDuenoTextBox.Text;
            veterinarias[accumulator].nameMascota = Convert.ToDouble(NameMascotaTextBox.Text);
            accumulator++;
        }
    }
}
