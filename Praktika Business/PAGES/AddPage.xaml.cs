using Praktika_Business.CONTEXT;
using Praktika_Business.SQL;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Praktika_Business.PAGES
{
    /// <summary>
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        public AddPage()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            Company newcompany = new Company();
            MainTable newmaintable = new MainTable();
            Resources newresources = new Resources();
            Client newclient = new Client();
            Order neworder = new Order();


            newcompany.CompanyName = tbCompanyName.Text;

            newresources.PerformersDepartment = tbPerformersDepartment.Text;
            newresources.PhoneNumberOfPerformers = tbPhoneNumberOfPerformers.Text;
            newresources.HoursToCompleteTheOrder = Convert.ToInt32(tbHoursToCompleteTheOrder.Text);
            newresources.ResponsibleForTheOrder = tbResponsibleForTheOrder.Text;

            newclient.FullName = tbFullName.Text;
            newclient.DeliveryAddress = tbDeliveryAddress.Text;
            newclient.Telephone = tbTelephone.Text;
            newclient.FaxNumber = tbFaxNumber.Text;

            neworder.Cost = Convert.ToInt32(tbCost.Text);
            neworder.Product = tbProduct.Text;
            neworder.Manufacturer = tbManufacturer.Text;
            neworder.SerialNumber = tbSerialNumber.Text;
            neworder.OrderCompletionDate = (tbOrderCompletionDate.SelectedDate);
            neworder.DateOfReceiptOfTheOrder = (tbDateOfReceiptOfTheOrder.SelectedDate);


            newmaintable.IDClient = newclient.ID;
            newmaintable.IDOrder = neworder.ID;
            newmaintable.IDResources = newresources.ID;
            newclient.IDСompany = newcompany.ID;



            dbcontext.db.MainTable.Add(newmaintable);
            dbcontext.db.Company.Add(newcompany);
            dbcontext.db.Resources.Add(newresources);
            dbcontext.db.Client.Add(newclient);
            dbcontext.db.Order.Add(neworder);

            dbcontext.db.SaveChanges();

            MessageBox.Show("Вы добавили данные", "Уведомление");


        }

        private void deletebutton_Click(object sender, RoutedEventArgs e)
        {
            tbCompanyName.Text = null;

            tbPerformersDepartment.Text = null;
            tbPhoneNumberOfPerformers.Text = null;
            tbHoursToCompleteTheOrder.Text = null;
            tbFaxNumber.Text = null;

            tbResponsibleForTheOrder.Text = null;
            tbDeliveryAddress.Text = null;
            tbTelephone.Text = null;
            tbTelephone.Text = null;

            tbCost.Text = null;
            tbProduct.Text = null;
            tbOrderCompletionDate.Text = null;
            tbDateOfReceiptOfTheOrder.Text = null;
            tbManufacturer.Text = null;
            tbSerialNumber.Text = null;

        }
    }
}
