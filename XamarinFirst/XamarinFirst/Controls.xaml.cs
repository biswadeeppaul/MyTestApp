using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFirst
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Controls : ContentPage
	{
		public Controls ()
		{
			InitializeComponent ();
		}


        private void ThePicker_OnSelectedIndexChangeddIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TheDatePicker_OnDateSelectedePickerDateSelected(object sender, DateChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TheStepper_OnValueChangedlueChanged(object sender, ValueChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TheTimePicker_OnPropertyChangedertyChanged(object sender, PropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TheSlider_OnValueChangedrValueChanged(object sender, ValueChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TheSwitch_OnToggledhToggled(object sender, ToggledEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}