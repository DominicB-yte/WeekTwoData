using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeekTwoData
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            label1.BindingContext = slider1;
            label1.SetBinding(Label.RotationProperty, "Value");
        }
    }
}
