using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DesignatedDriver
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            picker.ItemsSource = new List<string>() { "Male", "Female" };
            ToolbarItems.Add(new ToolbarItem("Info", "", () =>
            {
                Navigation.PushAsync(new InfoPage());
            }));
        }
        
        private void calculateResult(object sender, EventArgs e)
        {

            try
            {
                int intWeight = int.Parse(weight.Text);
                int intHours = int.Parse(hours.Text);
                bool male = picker.SelectedItem.ToString() == "Male";
                double result;

                if (male)
                {
                    result = ((0.5 + (0.15 * (intHours - 1))) * (intWeight * 0.7)) / 12;
                }
                else
                {
                    result = ((0.5 + (0.15 * (intHours - 1))) * (intWeight * 0.6)) / 12;
                }

                DisplayAlert((int)result + " Drinks Allowed!", "Remember to not drink alcohol atleast 1 hour before driving to sober up!", "Noice!");
            }
            catch
            {
                DisplayAlert("Error!", "Missing or incorrect inputs", "Okay");
            }
        }
        
    }
}
