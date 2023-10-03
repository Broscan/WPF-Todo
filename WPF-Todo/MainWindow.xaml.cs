using System;
using System.Media;
using System.Windows;

namespace WPF_Todo
{

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


            if (cbPriority != null && txtChore.Text != "")
            {

                string listTodo = $"Chore: {txtChore.Text} Priority: {cbPriority.SelectedItem}";

                lstTodos.Items.Add(listTodo);

                txtChore.Clear();
                cbPriority.SelectedItem = null;


            }
            else
            {
                SoundPlayer soundPlayer = new SoundPlayer();
                soundPlayer.Play();

                MessageBox.Show("Some or many inputs are empty!");
            }

        }
    }
}
