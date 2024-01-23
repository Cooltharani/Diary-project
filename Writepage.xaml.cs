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
    /// Interaction logic for Writepage.xaml
    /// </summary>
    public partial class Writepage : Page
    {
        public Writepage()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btndai_Click(object sender, RoutedEventArgs e)
        {


        }

        private void btnwrite_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnRead_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnsave_Click_1(object sender, RoutedEventArgs e)
        {
            if(cmbdate.SelectedItem.ToString() !="Date" && cmbmonth.SelectedItem.ToString() !="Month" && cmbyear.SelectedItem.ToString() !="Year")
            {
                string date = cmbdate.SelectedItem.ToString() + cmbmonth.SelectedItem.ToString() + cmbyear.SelectedItem.ToString();
                string path = $"D:\\Diary\\(Date).txt";
                string content = txttext.Text;
                File.WriteAllText(path, content);
                MessageBox.Show("Data Saved Successfully");
            }
            else
            {
                MessageBox.Show("Please Select Date");
            }

        }

        private void cmbdate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedvalue = (ComboBoxItem)cmbdate.SelectedItem;

        }

        private void cmbmonth_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedvalue = (ComboBoxItem)cmbmonth.SelectedItem;

        }

        private void cmbyear_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                

        }

        private void cmbyear_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedvalue = (ComboBoxItem)cmbyear.SelectedItem;

        }
    }
}
