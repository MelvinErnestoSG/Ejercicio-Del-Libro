using System.Windows;

namespace Ejercicio_Del_Libro_En_Wpf._05_Capitulos_10_y_12.Capitulos_10.Ejercicio_4
{
    /// <summary>
    /// Interaction logic for Capitulo10_Ejercicio4.xaml
    /// </summary>
    public partial class Capitulo10_Ejercicio4 : Window
    {
        public Capitulo10_Ejercicio4()
        {
            InitializeComponent();
        }

        public class Poligono
        {
            public float Lados
            {
                get
                {
                    return Lados;
                }
                set
                {
                    if (value <= 0)
                    {
                        Lados = 3;
                    }
                    else
                    {
                        Lados = value;
                    }
                }
            }
            public float MedidasLados
            {
                get
                {
                    return MedidasLados;
                }
                set
                {
                    if (value <= 0)
                    {
                        MedidasLados = 3;
                    }
                    else
                    {
                        MedidasLados = value;
                    }
                }
            }
            public Poligono()
            {
                Lados = 0;
                MedidasLados = 0.0f;
            }

            public Poligono(int Lados, float MedidasLados)
            {
                if (Lados <= 2)
                {
                    this.Lados = Lados;
                }

                if (MedidasLados <= 0)
                {
                    this.MedidasLados = MedidasLados;
                }
            }
        }
    }
}
