using System;
using Bubblez.App.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bubblez.App.Clients
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddClient : ContentPage
    {
        public AddClient()
        {
            InitializeComponent();
        }

        public void SaveClientInfo_Clicked(object sender, System.EventArgs e)
        {

            //this sets the entry values to the properties when the save button is clicked
            Contact contact = new Contact()
            {

                Name = nameEntry.Text,
                LastName = lastNameEntry.Text,
                Birthday = birthdayEntry.Date.ToString(),
                Email = emailEntry.Text,
                PhoneNumber = phoneNumberEntry.Text,
                Address = addressEntry.Text,

            };

        }
    }
}