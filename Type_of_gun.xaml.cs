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
using pr5.pr5DataSetTableAdapters;

namespace pr5
{
    /// <summary>
    /// Логика взаимодействия для Type_of_gun.xaml
    /// </summary>
    public partial class Type_of_gun : Page
    {
        Type_of_gun_dataTableAdapter gun = new Type_of_gun_dataTableAdapter();
        public Type_of_gun()
        {
            InitializeComponent();
            Play_areaGrid.ItemsSource = gun.GetData();

        }
        private void Play_areaPagee_Click(object sender, RoutedEventArgs e)
        {

            (Application.Current.MainWindow as GGWindow).SecondFrame.Content = new Play_areaPage();

        }
        private void Play_TimePage_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as GGWindow).SecondFrame.Content = new Play_TimePage();
        }
        private void Count_of_guns_Page_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as GGWindow).SecondFrame.Content = new Count_of_guns_Page();

        }
        private void Play_area_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Play_areaGrid.SelectedItem != null)
            {
                object selectedName = (Play_areaGrid.SelectedItem as DataRowView).Row[1];

                Play_areaBox.Text = Convert.ToString(selectedName);


            }
        }

        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            if (Play_areaGrid.SelectedItem != null)
            {
                object id = (Play_areaGrid.SelectedItem as DataRowView).Row[0];
                gun.DeleteQuery(Convert.ToInt32(id));
                Play_areaGrid.ItemsSource = gun.GetData();
            }

            else
            {
                MessageBox.Show("Вы не выбрали обьект");
            }
        }

        private void ADDButton_Click(object sender, RoutedEventArgs e)
        {
            if (Play_areaBox.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                string input = Play_areaBox.Text;

                if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Z ]+$"))
                {
                    gun.InsertQuery(Play_areaBox.Text);
                    //выводит ошибку при добавлении нового пароля человеку 
                    Play_areaGrid.ItemsSource = gun.GetData();

                }
                else
                {
                    MessageBox.Show("Не допустимо число");
                }
                

            }
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            if (Play_areaGrid.SelectedItem != null)
            {
                if (Play_areaBox.Text == "")
                {
                    MessageBox.Show("Не все поля заполнены");
                }
                else
                {
                    string input = Play_areaBox.Text;

                    if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Z ]+$"))
                    {
                        object id = (Play_areaGrid.SelectedItem as DataRowView).Row[0];
                        gun.UpdateQuery(Play_areaBox.Text, Convert.ToInt32(id));
                        Play_areaGrid.ItemsSource = gun.GetData();

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

        private void Type_of_gun_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы на этой странице");
        }

        private void Weapon_type_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as GGWindow).SecondFrame.Content = new Weapon_type();
        }

        private void Maximum_projectile_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as GGWindow).SecondFrame.Content = new Maximum_projectile();

        }
        private void Import_Click(object sender, RoutedEventArgs e)
        {
            List<Type_of_gunModel> forImport = Derser.DeserializeObject<List<Type_of_gunModel>>();
            foreach (var item in forImport)
            {
                gun.InsertQuery(item.gun);

            }
            Play_areaGrid.ItemsSource = null;
            Play_areaGrid.ItemsSource = gun.GetData();

        }
    }
}
