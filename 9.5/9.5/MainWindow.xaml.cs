using System;
using System.Linq;
using System.Windows;

namespace _9._5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void OnSplitButtonClicked(object sender, EventArgs e)
        {
            var text = inputTextBox.Text;
            if (!string.IsNullOrEmpty(text))
            {
                var words = text.Split(' ');
                foreach (var word in words)
                    outputListBox.Items.Add(word);
            }
            else
            {
                MessageBox.Show("Textbox is empty");
            }
        }

        private void ReverseButtonOnClicked(Object sender, EventArgs e) 
        {
            var text = textBox.Text;

            if (!string.IsNullOrEmpty(text))
            {
                var words = text.Split(' ');
                Array.Reverse(words);

                outputLabel.Content = string.Join(" ", words);
            }
            else
            {
                MessageBox.Show("TextBox is empty");
            }
        }
    }
}
