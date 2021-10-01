using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CuadrosDeTexto2._8
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NombreTextBox.Tag = InformacionNombreDelClienteTextBlock;
            ApellidoTextBox.Tag = InformacionApellidoTextBlock;
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox mensaje = (TextBox)sender;
            TextBlock informacion = (TextBlock)mensaje.Tag;

            if (e.Key == Key.F1)
            {
                informacion.Visibility = Visibility.Visible;
            }
            else
            {
                informacion.Visibility = Visibility.Hidden;
            }
        }

        private void EdadTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            bool esDigito = EdadTextBox.Text.All(char.IsDigit); //Para saber si es digito//

            if (e.Key == Key.F2 && !esDigito) 
            {
                ErrorEdadTextBlock.Visibility = Visibility.Visible;
            }
            else
            {
                ErrorEdadTextBlock.Visibility = Visibility.Hidden;
            }
        }
    }
}
