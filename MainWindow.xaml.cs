using _2307ca2.Model;
using System.Windows;
using System.Windows.Controls;

namespace _2307ca2
{
    public partial class MainWindow : Window
    {
        public List<User> users { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            users = new List<User>()
            {
                new User("name 1", "email", "pass"),
                new User("name 2", "email", "pass"),
                new User("name 3", "email", "pass"),
            };
            
            ComboBoxUserName.ItemsSource = ConverUserToName(users);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button bt = sender as Button;
            bt.Content = "OK";
            bt.FontSize = 40;

            tBlock.Text = tBox.Text;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox ch = sender as CheckBox;

            if (ch.IsChecked == true)
            {
                StackPanelInpyt.Visibility = Visibility.Visible;
            }
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox ch = sender as CheckBox;

            if (ch.IsChecked == false)
            {
                StackPanelInpyt.Visibility = Visibility.Collapsed;
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            
            if(rb.IsChecked == true)
            {
                if(rb.Content.ToString() == "выбор 1")
                {
                    MessageBox.Show("верное решение " + rb.Content.ToString());
                }
                else
                {
                    MessageBox.Show("не верное решение " + rb.Content.ToString());
                }
            }
        }

        private void ListBoxUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox list = sender as ListBox;

            //MessageBox.Show(list.SelectedItem.ToString());
        }

        private void Add_user(object sender, RoutedEventArgs e)
        {
            users.Add(new User("new user", "new email", "new pass"));
            ListBoxUser.Items.Refresh();
        }

        private void selected_user_name(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = sender as ComboBox;

            //MessageBox.Show(box.SelectedItem.ToString());
        }
        public List<string> ConverUserToName(List<User> user)
        {
            List<string> result = new List<string>();

            foreach (var item in user)
            {
                result.Add(item.Name);
            }
            return result;
        }

        private void MenuItem_edit(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Настройки");
        }
    }
}