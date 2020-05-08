using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculoMetodosNumU4
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        ReglaTrapecio trapecio;
        SimpsonTercio simpsonTercio;
        SimpsonOchoTercios ochoTercios;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Trapecio.IsChecked == true)
                {
                    trapecio = new ReglaTrapecio()
                    {
                        A = double.Parse(a.Text),
                        B = double.Parse(b.Text),
                        N = double.Parse(n.Text),
                        Funcion = Funcion.Text
                    };
                    trapecio.AplicarMetodo();
                    Respuesta.Content = trapecio.Resultado.ToString();
                    //ErrorRelativo.Content = trapecio.ErrorRelativo.ToString();
                }
                else if (SimpsonTresOctavos.IsChecked == true)
                {
                    ochoTercios = new SimpsonOchoTercios()
                    {
                        A = double.Parse(a.Text),
                        B = double.Parse(b.Text),
                        N = double.Parse(n.Text),
                        Funcion = Funcion.Text
                    };
                    ochoTercios.AplicarMetodo();
                    Respuesta.Content = ochoTercios.Resultado.ToString();
                }
                else
                {
                    simpsonTercio = new SimpsonTercio()
                    {
                        A = double.Parse(a.Text),
                        B = double.Parse(b.Text),
                        N = double.Parse(n.Text),
                        Funcion = Funcion.Text
                    };
                    simpsonTercio.AplicarMetodo();
                    Respuesta.Content = simpsonTercio.Resultado.ToString();
                }
            }
            catch (FormatException F)
            {
                MessageBox.Show(F.Message);
            }
            catch(OverflowException Ov)
            {
                MessageBox.Show(Ov.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
