using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Reflection;
using Android.Content.Res;

namespace ContactManager
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        List<Contact> contacts; 
        public MainPage()
        {
            InitializeComponent();
            GetXML();
        }

        private void GetXML()
        {
            AssetManager assets = Android.App.Application.Context.Assets;
            var fileName = assets.Open("Contacts.xml");
            var writeableFile = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Contacts.xml");

            if (!File.Exists(writeableFile))
            {
                var fileStream = File.OpenWrite(writeableFile);
                fileName.CopyTo(fileStream);
                fileStream.Dispose();
            }
            using (var reader = new StreamReader(writeableFile))
            {
                
                var serializer = new XmlSerializer(typeof(List<Contact>), new XmlRootAttribute("ContactList"));
                contacts = (List<Contact>)serializer.Deserialize(reader);
            }
            pckPreview.ItemsSource = contacts;
        }

        private void pckPreview_selected(object sender, EventArgs e)
        {
            try
            {
                entFirstName.Text = contacts[pckPreview.SelectedIndex].FirstName;
                entLastName.Text = contacts[pckPreview.SelectedIndex].LastName;
                entMobile.Text = contacts[pckPreview.SelectedIndex].Mobile;
                entEmail.Text = contacts[pckPreview.SelectedIndex].Email;
            }
            catch (Exception ex)
            {
                //Do nothing
            }
        }

        private void btnUpdate_Clicked(object sender, EventArgs e)
        {
            contacts[pckPreview.SelectedIndex].FirstName = entFirstName.Text;
            contacts[pckPreview.SelectedIndex].LastName = entLastName.Text;
            contacts[pckPreview.SelectedIndex].Mobile = entMobile.Text;
            contacts[pckPreview.SelectedIndex].Email = entEmail.Text;

            var writeableFile = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Contacts.xml");

            if (!File.Exists(writeableFile))
            {
                AssetManager assets = Android.App.Application.Context.Assets;
                var fileName = assets.Open("Contacts.xml");
                var fileStream = File.OpenWrite(writeableFile);
                fileName.CopyTo(fileStream);
                fileStream.Dispose();
            }
            using (StreamWriter writer = new StreamWriter(writeableFile))
            {
                var serializer = new XmlSerializer(typeof(List<Contact>), new XmlRootAttribute("ContactList"));
                serializer.Serialize(writer, contacts);
            }
        }

        private void btnDelete_Clicked(object sender, EventArgs e)
        {
            contacts.RemoveAt(pckPreview.SelectedIndex);
            pckPreview.ItemsSource = null;
            pckPreview.ItemsSource = contacts;

            entFirstName.Text = "";
            entLastName.Text = "";
            entMobile.Text = "";
            entEmail.Text = "";

            var writeableFile = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Contacts.xml");

            if (!File.Exists(writeableFile))
            {
                AssetManager assets = Android.App.Application.Context.Assets;
                var fileName = assets.Open("Contacts.xml");
                var fileStream = File.OpenWrite(writeableFile);
                fileName.CopyTo(fileStream);
                fileStream.Dispose();
            }
            using (StreamWriter writer = new StreamWriter(writeableFile))
            {
                var serializer = new XmlSerializer(typeof(List<Contact>), new XmlRootAttribute("ContactList"));
                serializer.Serialize(writer, contacts);
            }

        }
    }
}
