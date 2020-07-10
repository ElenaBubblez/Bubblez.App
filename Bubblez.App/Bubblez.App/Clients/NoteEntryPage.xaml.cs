using System;
using Bubblez.App.Classes;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bubblez.App.Clients
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoteEntryPage : ContentPage
    {
        public NoteEntryPage()
        {
            InitializeComponent();
        }

        public void SaveNoteButton_Clicked(object sender, EventArgs e)
        {
            //this sets the entry values to the properties when the save button is clicked
            Notes note = new Notes()
            {

                ClientNote = noteEntry.Text,
                Date = DateTime.Now

            };

        }

    }

}