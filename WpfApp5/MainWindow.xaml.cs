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

namespace WpfApp5
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

        string s;
        int i;
        bool i2 = false;
        bool i8 = false;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             s = (string)((Button)e.OriginalSource).Content;
            textBox1.Text += s;

           
            if (s == "Сбросить")
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (i2 == true)
            {
                i = Convert.ToInt32(textBox1.Text);
                textBox2.Text = Convert.ToString(i, 2);
            }
            if (i8 == true)
            {

                i = Convert.ToInt32(textBox2.Text);
                textBox2.Text = Convert.ToString(i, 8);
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {
            i8 = true;
            i2 = true;
        }

            private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
           
            i2 = true;
            i8 = false;
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
