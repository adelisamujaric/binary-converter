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

namespace binaryConvert
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int i;
            if(!int.TryParse(textBox2.Text ,out i))
            {
                MessageBox.Show("TextBox does not contain an integer");
                return;
            }
            if (i < 0)
            {
                MessageBox.Show("enter positive number or zero");
                return;
            }
            int reminder = 0;
            StringBuilder binary = new StringBuilder();

            do
            {
                  reminder = i % 2;
                  i /= 2;
                             binary.Insert(0, reminder);
            }
            while (i > 0);
            
            label1.Content = binary.ToString();
           
        }
    }
}
