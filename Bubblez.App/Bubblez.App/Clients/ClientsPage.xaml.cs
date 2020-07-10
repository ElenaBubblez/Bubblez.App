using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bubblez.App.Clients
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClientsPage : ContentPage
    {
        public ClientsPage()
        {
            InitializeComponent();
        }

        //this is a buttton in the toolbar that links to the add client page
        public void ToolbarItem_Activated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddClient());

        }

        // when a contact is tapped it opens the contact info page
        private void ContactListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new ContactInfo(ContentProperty));
        }
    }
}