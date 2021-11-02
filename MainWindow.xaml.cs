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

namespace Encrypt
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

        private void inputV1TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (outputV1TextBox != null) {
                outputV1TextBox.Text = "";
                foreach (char ch in inputV1TextBox.Text)
                {
                    outputV1TextBox.Text += Convert.ToChar(ch + new Random().Next(1, 4));
                }
            }

            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (outputV1TextBox != null)
            {
                outputV1TextBox.Text = "";
                foreach (char ch in inputV1TextBox.Text)
                {
                    outputV1TextBox.Text += Convert.ToChar(ch + new Random().Next(1, 4));
                }
            }

            if (outputV2TextBox != null)
            {
                outputV2TextBox.Text = "";
            }
            if (keyV2TextBox != null)
            {
                keyV2TextBox.Text = new Random().Next(1000, 9999).ToString();
            }
            foreach (char ch in inputV1TextBox.Text)
            {
                if (outputV2TextBox != null)
                {
                    outputV2TextBox.Text += Convert.ToChar(ch + (Convert.ToInt32(keyV2TextBox.Text) / 100));
                }
            }
        }

        private void inputV2TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (outputV2TextBox != null)
            {
                outputV2TextBox.Text = "";
            }
            if (keyV2TextBox != null)
            {
                keyV2TextBox.Text = new Random().Next(1000, 9999).ToString();
            }
            foreach (char ch in inputV1TextBox.Text)
            {
                if (outputV2TextBox != null)
                {
                    outputV2TextBox.Text += Convert.ToChar(ch + (Convert.ToInt32(keyV2TextBox.Text) / 100));
                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            rez.Text = "";
            if (!key1.Text.Equals(""))
            {
                foreach (char ch in text1.Text)
                {
                    if (text1.Text != null)
                    {
                        try
                        {
                            rez.Text += Convert.ToChar(ch - (Convert.ToInt32(key1.Text) / 100));
                        }
                        catch (Exception)
                        {

                            //throw;
                        }
                    }
                }
            }
        }
    }
}
