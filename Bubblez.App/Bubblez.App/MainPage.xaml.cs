using Bubblez.App.Appointments;
using Bubblez.App.Calendar;
using Bubblez.App.Clients;
using Bubblez.App.Inventory;
using Bubblez.App.Profits;
using Bubblez.App.ShoppingList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Bubblez.App
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void ClientsPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ClientsPage());
        }

        public void AppointmentPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AppointmentsPage());
        }

        public void CalendarPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CalendarPage());
        }

        public void ShoppingPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ShoppingListPage());
        }

        public void InventoryPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InventoryPage());
        }

        private void PandEpage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProfitsPage());
        }
    }
}
