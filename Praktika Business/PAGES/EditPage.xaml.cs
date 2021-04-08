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
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {

        private MainTable editmain;
        public EditPage()

        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        public EditPage(MainTable editmain)
        {
            InitializeComponent();

            this.editmain = editmain;

            tbCompanyName.Text = editmain.Client.Company.CompanyName;

            tbPerformersDepartment.Text = editmain.Resources.PerformersDepartment;
            tbPhoneNumberOfPerformers.Text = editmain.Resources.PhoneNumberOfPerformers;
            tbHoursToCompleteTheOrder.Text =  Convert.ToString(editmain.Resources.HoursToCompleteTheOrder);
            tbResponsibleForTheOrder.Text = editmain.Resources.ResponsibleForTheOrder;

            tbFullName.Text = editmain.Client.FullName;
            tbDeliveryAddress.Text = editmain.Client.DeliveryAddress;
            tbTelephone.Text = editmain.Client.Telephone;
            tbFaxNumber.Text = editmain.Client.FaxNumber;

            tbCost.Text = Convert.ToString(editmain.Order.Cost);
            tbProduct.Text = (editmain.Order.Product);
            tbManufacturer.Text = (editmain.Order.Manufacturer);
            tbSerialNumber.Text = (editmain.Order.SerialNumber);
            tbOrderCompletionDate.SelectedDate = editmain.Order.OrderCompletionDate;
            tbDateOfReceiptOfTheOrder.SelectedDate = editmain.Order.DateOfReceiptOfTheOrder;
        }

        private void editbutton_Click(object sender, RoutedEventArgs e)
        {
            MainTable Save = dbcontext.db.MainTable.FirstOrDefault(item => item.ID == editmain.ID);

            Save.Client.Company.CompanyName = tbCompanyName.Text;

            Save.Resources.PerformersDepartment = tbPerformersDepartment.Text;
            Save.Resources.PhoneNumberOfPerformers = tbPhoneNumberOfPerformers.Text;
            Save.Resources.HoursToCompleteTheOrder = Convert.ToInt32(tbHoursToCompleteTheOrder.Text);
            Save.Resources.ResponsibleForTheOrder = tbResponsibleForTheOrder.Text;

            Save.Client.FullName = tbFullName.Text;
            Save.Client.DeliveryAddress = tbDeliveryAddress.Text;
            Save.Client.Telephone = tbTelephone.Text;
            Save.Client.FaxNumber = tbFaxNumber.Text;


            Save.Order.Cost = Convert.ToInt32(tbCost.Text);
            Save.Order.Product = tbProduct.Text;
            Save.Order.Manufacturer = tbManufacturer.Text;
            Save.Order.SerialNumber = tbSerialNumber.Text;
            Save.Order.OrderCompletionDate =  Convert.ToDateTime(tbOrderCompletionDate.Text);
            Save.Order.DateOfReceiptOfTheOrder = Convert.ToDateTime(tbDateOfReceiptOfTheOrder.Text);



            dbcontext.db.SaveChanges();

            MessageBox.Show("Данные отредактированы", "Уведомление");

            NavigationService.Navigate(new MainPage());








        }
    }
}
