using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ImageControl.Resources;
using Microsoft.Phone.Tasks;
using System.Windows.Media.Imaging;

namespace ImageControl
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void rdoCamera_Checked(object sender, RoutedEventArgs e)
        {
            CameraCaptureTask cct = new CameraCaptureTask();
            //Launch the Camera
            cct.Show();
            //Add Event   
            cct.Completed += cct_Completed; 
        }

        private void cct_Completed(object sender, PhotoResult e)
        {
           //Code will be executed when an image  
            BitmapImage image=new BitmapImage();
            image.SetSource(e.ChosenPhoto);
            //display on image control
            imgPhoto.Source = image;

        }

        private void rdoBrowse_Checked(object sender, RoutedEventArgs e)
        {
            PhotoChooserTask pct = new PhotoChooserTask();
            //Launch photo chooser
            pct.Show();

            pct.Completed += pct_Completed;
        }

        private void pct_Completed(object sender, PhotoResult e)
        {

            //Code will be executed when an image  
            BitmapImage image = new BitmapImage();
            image.SetSource(e.ChosenPhoto);
            //display on image control
            imgPhoto.Source = image;

        }

        

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}