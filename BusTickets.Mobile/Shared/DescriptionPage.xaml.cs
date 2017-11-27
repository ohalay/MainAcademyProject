using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shared
{

	public partial class DescriptionPage : ContentPage
	{
		public DescriptionPage ()
		{
			InitializeComponent ();
            BindingContext = new DescriptionViewModel();
		}
	}
}