using System.Windows;

namespace _9._5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonOnClicked(object sender, RoutedEventArgs e) 
        {
            var text = textBox.Text;
            if (!string.IsNullOrEmpty(text))
            {
                var words = text.Split(' ');

                foreach (var word in words)
                    listBox.Items.Add(word);
            }
            else
            {
                MessageBox.Show("text is empty");
            }
        }
    }
}
