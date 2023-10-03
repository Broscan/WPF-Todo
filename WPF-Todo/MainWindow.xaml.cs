using System;
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

                Todo newTodo = new(txtChore.Text);
                Priority _priority = new(cbPriority.SelectedItem);

                lstTodos.Items.Add(newTodo.GetChores());

                txtChore.Clear();


            }

        }
    }
}
