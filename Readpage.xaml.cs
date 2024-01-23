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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace NTharani
{
    /// <summary>
    /// Interaction logic for Readpage.xaml
    /// </summary>
    public partial class Readpage : Page
    {
        public Readpage()
        {
            InitializeComponent();
        }

        private void Read_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //ComboBoxItem selectedvalue = (ComboBoxItem)cmbdate.SelectedItem;

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            //ComboBoxItem selectedvalue = (ComboBoxItem)cmbmonth.SelectedItem;

        }

        private void ComboBox_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {
           // ComboBoxItem selectedvalue = (ComboBoxItem)cmbyear.SelectedItem;

        }

        private void Read_Click_1(object sender, RoutedEventArgs e)
        {
            string path = $"D:\\Diary\\(Date).txt";
            if (File.Exists(path))
            {
                string content = File.ReadAllText(path);
                string[] value = content.Split("");
                txtname.Text = value[0];
               
            }

        }

        private void cmbmonth_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedvalue = (ComboBoxItem)cmbmonth.SelectedItem;

        }

        private void cmbyear_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedvalue = (ComboBoxItem)cmbyear.SelectedItem;
        }

        private void cmbdate_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedvalue = (ComboBoxItem)cmbdate.SelectedItem;

        }
    }
}
