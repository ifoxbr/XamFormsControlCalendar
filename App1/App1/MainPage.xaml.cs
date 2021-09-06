using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            //this.BindingContext = new MainViewModel();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            List<DateTime> DD = new List<DateTime>();
            DD = XALENDAR.SelectedDates.ToList();
            int count = DD.Count;

            foreach(var item in DD)
            {

            }
        }
    }
}
