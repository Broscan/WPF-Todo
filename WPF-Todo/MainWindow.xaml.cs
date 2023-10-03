using System;
using System.Windows;

namespace WPF_Todo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach (Priority _priority in Enum.GetValues(typeof(Priority)))
            {
                cbPriority.Items.Add(_priority);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
