using System.IO;
using System.Windows;

namespace NTharani
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnreg_Click(object sender, RoutedEventArgs e)
        {
            Registerd oregisterd = new Registerd();
            oregisterd.Show();
        }


        //    private void btnreg_Click(object sender, RoutedEventArgs e)
        //{
            

        //}

        private void btnlog_Click(object sender, RoutedEventArgs e)
        {
            string path = $"D:\\Diary\\{txtname.Text}.txt";
                if (File.Exists(path))
                {
                    string content = File.ReadAllText(path);
                    string[] values = content.Split(",");
                    if (values.Length > 1)
                    {
                        if (txtpass.Text == values[1])
                        {
                        Diary odiary = new Diary();

                        odiary.txtbname.Text = $"Welcome to {txtname.Text}'s Diary";
                        odiary.Show();
                        
                      



                        }
                        else
                        {
                            MessageBox.Show("Invalid Username And Password");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username And Password");
                }
                //string content = $"{txtname.Text},{pwdpass.Password}";
                //if(!File.Exists(path))
                //{
                //    File.WriteAllText(path, content);
                //    lblerror.Content = "";
                //    MessageBox.Show("sucess");

                //}
                //else
                //{
                //    lblerror.Content = "User Name Already Exists";
                //}


            }

        }
    }
    
            

