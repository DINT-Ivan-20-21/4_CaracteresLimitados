using System.Windows;
using System.Windows.Controls;

namespace _4_CaracteresLimitados
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

        private void entradaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            contadorTextBlock.Text = $"{entradaTextBox.Text.Length}/{entradaTextBox.MaxLength}";
            entradaTextBox.IsReadOnly = entradaTextBox.Text.Length == entradaTextBox.MaxLength;
        }
    }
}
