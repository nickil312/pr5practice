using pr5.pr5DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace pr5
{
    /// <summary>
    /// Логика взаимодействия для RolePage.xaml
    /// </summary>
    public partial class RolePage : Page
    {
        Login_dataTableAdapter login = new Login_dataTableAdapter();
        Role_tableTableAdapter role = new Role_tableTableAdapter();
        public RolePage()
        {
            InitializeComponent();
            RoleGrid.ItemsSource = role.GetData();
            
        }

        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            if (RoleGrid.SelectedItem != null)
            {
                object id = (RoleGrid.SelectedItem as DataRowView).Row[0];
                role.DeleteQuery(Convert.ToInt32(id));
                RoleGrid.ItemsSource = role.GetData();
                //ComboBox.ItemsSource = car.GetData();
               
            }
            else
            {
                MessageBox.Show("Вы не выбрали обьект");
            }

        }

        private void ADDButton_Click(object sender, RoutedEventArgs e)
        {
            if (RoleBox.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                string input = RoleBox.Text;
               
                if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Z]+$"))
                {
                    role.InsertQuery(RoleBox.Text);
                    RoleGrid.ItemsSource = role.GetData();
                    
                }
                else
                {
                    MessageBox.Show("Не допустимо число");
                }
                
            }
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            if (RoleGrid.SelectedItem != null)
            {
                if (RoleBox.Text == "")
                {
                    MessageBox.Show("Не все поля заполнены");
                }
                else
                {
                    string input = RoleBox.Text;
                    if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Z]+$"))
                    {
                        object id = (RoleGrid.SelectedItem as DataRowView).Row[0];
                        role.UpdateQuery(RoleBox.Text, Convert.ToInt32(id));
                        RoleGrid.ItemsSource = role.GetData();
                        

                    }
                    else
                    {
                        MessageBox.Show("Не допустимо число");
                    }
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали обьект");
            }

        }



        private void RoleGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RoleGrid.SelectedItem != null)
            {
                
                object selectedRow = (RoleGrid.SelectedItem as DataRowView).Row[1];
                //object selected = (RoleGrid.SelectedItem as DataRowView).Row[2];
                RoleBox.Text = Convert.ToString(selectedRow);

                //ComboBox.SelectedValue = selected;

               
            }
            

        }

        private void PeoplePage_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as AdminWindow).FirstFrame.Content = new AdminPage1();

        }

        private void LoginPage_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as AdminWindow).FirstFrame.Content = new LoginPage();
        }

        private void RolePagee_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы на этой странице");
        }
    }
}