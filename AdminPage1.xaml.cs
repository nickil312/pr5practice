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
    /// Логика взаимодействия для AdminPage1.xaml
    /// </summary>
    public partial class AdminPage1 : Page
    {
        Emloyees_dataTableAdapter employees = new Emloyees_dataTableAdapter();
        Login_dataTableAdapter login = new Login_dataTableAdapter();
        public AdminPage1()
        {
            InitializeComponent();
            PersonGrid.ItemsSource = employees.GetData();
            ComboBox.ItemsSource = login.GetData();
            ComboBox.DisplayMemberPath = "Login_person";
            ComboBox.SelectedValuePath = "Login_data_id";
        }

        private void RoleGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PersonGrid.SelectedItem != null)
            {
                object selectedName = (PersonGrid.SelectedItem as DataRowView).Row[1];
                object selectedSurname = (PersonGrid.SelectedItem as DataRowView).Row[2];
                object selectedPatronymic = (PersonGrid.SelectedItem as DataRowView).Row[3];
                object selectedLoginID = (PersonGrid.SelectedItem as DataRowView).Row[4];
                NameBox.Text = Convert.ToString(selectedName);
                SurnameBox.Text = Convert.ToString(selectedSurname);
                PatronymicBox.Text = Convert.ToString(selectedPatronymic);
                ComboBox.SelectedValue = Convert.ToInt32(selectedLoginID);
            }
            


        }


        private void RolePage_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as AdminWindow).FirstFrame.Content = new RolePage();
        }
        private void LoginPage_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as AdminWindow).FirstFrame.Content = new LoginPage();
        }

        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            if (PersonGrid.SelectedItem != null)
            {
                object id = (PersonGrid.SelectedItem as DataRowView).Row[0];
                employees.DeleteQuery(Convert.ToInt32(id));
                PersonGrid.ItemsSource = employees.GetData();
                ComboBox.ItemsSource = login.GetData();
            }
            else
            {
                MessageBox.Show("Вы не выбрали обьект");
            }

        }

        private void ADDButton_Click(object sender, RoutedEventArgs e)
        {
            if (NameBox.Text == "" || SurnameBox.Text == "" || PatronymicBox.Text == "" || ComboBox.SelectedValue == null)
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                string input = NameBox.Text;
                string input2 = SurnameBox.Text;
                string input3 = PatronymicBox.Text;
                if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Z ]+$")&&
                    System.Text.RegularExpressions.Regex.IsMatch(input2, "^[a-zA-Z ]+$")&&
                    System.Text.RegularExpressions.Regex.IsMatch(input3, "^[a-zA-Z ]+$"))
                {
                    employees.InsertQuery(NameBox.Text, SurnameBox.Text, PatronymicBox.Text, Convert.ToInt32(ComboBox.SelectedValue));
                    PersonGrid.ItemsSource = employees.GetData();
                    ComboBox.ItemsSource = login.GetData();
                }
                else
                    {
                    MessageBox.Show("Не допустимо число");
                }
            }
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            if (PersonGrid.SelectedItem != null)
            {
                if (NameBox.Text == "" || SurnameBox.Text == "" || PatronymicBox.Text == "" || ComboBox.SelectedValue == null)
                {
                    MessageBox.Show("Не все поля заполнены");
                }
                else
                {
                    string input = NameBox.Text;
                    string input2 = SurnameBox.Text;
                    string input3 = PatronymicBox.Text;
                    if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Z ]+$") &&
                        System.Text.RegularExpressions.Regex.IsMatch(input2, "^[a-zA-Z ]+$") &&
                        System.Text.RegularExpressions.Regex.IsMatch(input3, "^[a-zA-Z ]+$"))
                    {
                        object id = (PersonGrid.SelectedItem as DataRowView).Row[0];
                        employees.UpdateQuery(NameBox.Text, SurnameBox.Text, PatronymicBox.Text, Convert.ToInt32(ComboBox.SelectedValue), Convert.ToInt32(id));
                        PersonGrid.ItemsSource = employees.GetData();
                        ComboBox.ItemsSource = login.GetData();
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

        private void PeoplePage_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы на этой странице");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object selected = (ComboBox.SelectedItem as DataRowView).Row[1];
        }
    }
}
