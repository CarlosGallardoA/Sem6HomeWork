using Sem6HomeWork.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sem6HomeWork.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsesGrup : ContentPage
    {
        public UsesGrup()
        {
            InitializeComponent();
            this.BindingContext = new UserVm();
        }
    }
}