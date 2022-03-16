using System.Windows;

namespace Ejercicio_Del_Libro_En_Wpf._05_Capitulos_10_y_12.Capitulos_10.Ejercicio_3
{
    /// <summary>
    /// Interaction logic for Capitulo10_Ejercicio3.xaml
    /// </summary>
    public partial class Capitulo10_Ejercicio3 : Window
    {
        public Capitulo10_Ejercicio3()
        {
            InitializeComponent();
        }

        public class Poligonos
        {
            public int CantidadLados { get; set; }
            public float MedidaLados { get; set; }

            public Poligonos()
            {
                CantidadLados = 0;
                MedidaLados = 0.0f;
            }

            public Poligonos(int CantidadLados, float MedidaLados)
            {
                this.CantidadLados = CantidadLados;
                this.MedidaLados = MedidaLados;
            }
        }
    }
}
