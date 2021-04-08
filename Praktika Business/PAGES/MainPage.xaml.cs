using Praktika_Business.CONTEXT;
using Praktika_Business.SQL;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Praktika_Business.PAGES
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void butExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DataGridMain.ItemsSource = dbcontext.db.MainTable.ToList();
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {

            MainTable deleterow = (MainTable)DataGridMain.SelectedItem;
            if(MessageBox.Show("Хотите удалить строку?","Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                if(deleterow != null)
                {
                    dbcontext.db.MainTable.Remove(deleterow);
                    dbcontext.db.SaveChanges();
                    Page_Loaded(null, null);
                    MessageBox.Show("Вы удалили строку", "Уведомление");
                }
                else
                {
                    MessageBox.Show("Вы не выбрали строку", "Уведомление");
                }
            }
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPage());
        }

        private void ButtonEdit_Click_1(object sender, RoutedEventArgs e)
        
        
        {
            MainTable editrow = (MainTable)DataGridMain.SelectedItem;
            if(editrow != null)
            {
                NavigationService.Navigate(new EditPage(editrow));
            }

            else
            {
                MessageBox.Show("Вы не выбрали элемент", "Уведомление");
            }
        }

        private void tbsearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataGridMain.ItemsSource = dbcontext.db.MainTable.Where(item => item.Client.FullName.Contains(tbsearch.Text)).ToList();
        }
    }
}





























//{
//    MainTable DeleteRow = (MainTable)DataGridMain.SelectedItem;
//    if (MessageBox.Show("Вы точно хотите удалить выбранную строку?", "Уведомление",  MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
//    {
//        if( DeleteRow != null)
//        {
//            dbcontext.db.MainTable.Remove(DeleteRow);
//            dbcontext.db.SaveChanges();
//            Page_Loaded(sender: null, e: null);
//            MessageBox.Show("Вы удалили строку!", "Оповещание");
//        }
//    }

//            else
//    {
//        MessageBox.Show("Непредвиденная ошибка!", "Оповещание");
//    }

//}