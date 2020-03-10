using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Grading_App.Resources;

namespace Grading_App
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int regno;
            int marks;
            char grade;
            grade=Convert.ToChar("");
            string uname, ucode;
            regno = int.Parse(txtRegNo.Text);
            marks = int.Parse(txtMarks.Text);
            uname = txtUnitName.Text;
            ucode= txtUnitCode.Text;
            if (marks<0||marks>100){
                MessageBox.Show("Invalid Marks");
                    txtMarks.Focus();
                return;
            }
            else
            {
                //grading computation
                if (marks>=70&&marks<=100){
grade='A';
                }
                else if (marks>=60&&marks<=69){
                    grade='B';
                }
                else if (marks>=50 && marks<=59){
                    grade='C';
                }
                else if(marks >=40 && marks<=49){
                    grade='D';
                }
                else if (marks>=0 && marks<=39){
                    grade='F';
                }
            }
            //program output
            MessageBox.Show("Student Grade is:"+grade);
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