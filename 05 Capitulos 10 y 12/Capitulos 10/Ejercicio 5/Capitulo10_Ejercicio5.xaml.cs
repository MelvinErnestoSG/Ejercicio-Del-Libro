using System.Text;
using System.Windows;

namespace Ejercicio_Del_Libro_En_Wpf._05_Capitulos_10_y_12.Capitulos_10.Ejercicio_5
{
    /// <summary>
    /// Interaction logic for Capitulo10_Ejercicio5.xaml
    /// </summary>
    public partial class Capitulo10_Ejercicio5 : Window
    {
        public Capitulo10_Ejercicio5()
        {
            InitializeComponent();
        }

        public class PoligonoDos
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

            public PoligonoDos()
            {
                Lados = 0;
                MedidasLados = 0.0f;
            }

            public PoligonoDos(int Lados, float MedidasLados)
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

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"Poligono: \n\tLados del polígono: {Lados}\n\tMedidas de los lados: {MedidasLados}");
                return (sb.ToString());
            }
        }
    }
}
