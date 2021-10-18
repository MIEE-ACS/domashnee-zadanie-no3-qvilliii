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

namespace dz3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

            private void Button_Click(object sender, RoutedEventArgs e)
        {
            string TEXT = tb1.Text;
            int LENGHT = TEXT.Length;
            int result = 1;

            for (int i = 0; i < LENGHT-2; i++)
            {
                if ((TEXT[i] == '.' && TEXT[i+1] != '.' && TEXT[i - 1] != '.') || 

                    (TEXT[i] == '?'  && TEXT[i + 1] != '!') || TEXT[i] == ';' || 

                    (TEXT[i] == '.' && TEXT[i-1] == '.' && TEXT[i+1] == '.') ||

                    (TEXT[i] == '?' && TEXT[i + 1] == '!') || 

                    (TEXT[i] == '!' && TEXT[i - 1] != '?'))
                {
                    result++;
                }

            }
            
            tb2.Text = String.Format("{0}", result);
        }
    }
}
