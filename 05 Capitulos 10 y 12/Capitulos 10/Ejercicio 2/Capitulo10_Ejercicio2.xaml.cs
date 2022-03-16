using System.Windows;

namespace Ejercicio_Del_Libro_En_Wpf._05_Capitulos_10_y_12.Capitulos_10.Ejercicio_2
{
    /// <summary>
    /// Interaction logic for Capitulo10_Ejercicio2.xaml
    /// </summary>
    public partial class Capitulo10_Ejercicio2 : Window
    {
        public Capitulo10_Ejercicio2()
        {
            InitializeComponent();
        }

        public class Estudiantes
        {
            public int Codigo { get; set; }
            public string NombreCompleto { get; set; }
            public int Edad { get; set; }
            public string Direccion { get; set; }
            public string Curso { get; set; }
            public string Telefono { get; set; }


            public Estudiantes()
            {
                Codigo = 0;
                NombreCompleto = "";
                Edad = 0;
                Direccion = "";
                Curso = "";
                Telefono = "";
            }

            public Estudiantes(int Codigo, string NombreCompleto, int Edad, string Curso, string Direccion, string Telefono)
            {
                this.Codigo = Codigo;
                this.NombreCompleto = NombreCompleto;
                this.Edad = Edad;
                this.Direccion = Direccion;
                this.Curso = Curso;
                this.Telefono = Telefono;
            }
        }

    }
}
