using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BTTH1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WelcomScreen : ContentPage
	{
		public WelcomScreen ()
		{
			InitializeComponent ();
		}

        private void sayHello(object sender, EventArgs e)
        {
            string name = txtName.Text;
            DisplayAlert("Chào", "Chào bạn: " + name, "Thoát");
        }
	}
}