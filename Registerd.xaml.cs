using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace NTharani
{
    /// <summary>
    /// Interaction logic for Registerd.xaml
    /// </summary>
    public partial class Registerd : Window
    {
        public Registerd()
        {
            InitializeComponent();
        }

        private void btnreg_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnreg_Click_1(object sender, RoutedEventArgs e)
        {
            string path = $"D:\\Diary\\{txtuser.Text}.txt";
            string content = $"{txtuser.Text},{txtPassword.Text}";
            if (!File.Exists(path))
            {
                File.WriteAllText(path, content);
                lblerror.Content = "";
                MessageBox.Show("Registration Sucess");
            }
            else
            {
                lblerror.Content = "User name already exists,try with different name";
            }
        }
    }
}
