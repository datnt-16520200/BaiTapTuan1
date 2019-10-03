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
	public partial class TotalsScreen : ContentPage
	{
		public TotalsScreen ()
		{
			InitializeComponent ();
		}

        private void calculateTotal(object sender, EventArgs e)
        {
            string str_numA = txtNumberA.Text;
            string str_numB = txtNumberB.Text;

            if (str_numA==null || str_numB==null)
            {
                DisplayAlert("Lỗi", "Bạn chưa điền đủ số", "Thoát");
            }
            else
            {
                double numA = double.Parse(str_numA);
                double numB = double.Parse(str_numB);
                txtTotal.Text = (numA + numB) + "";
            }
        }

        private async void backToMainPage(object sender, EventArgs e)
        {
            await this.Navigation.PopAsync();
        }

    }
}