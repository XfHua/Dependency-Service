using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App384
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodMenu : ContentPage
    {
        public FoodMenu()
        {
            InitializeComponent();
        }

        public void Food_CameraEntry(object sender, EventArgs e)
        {
            Xamarin.Forms.DependencyService.Register<ITextRecognition>();
            DependencyService.Get<ITextRecognition>().LaunchActivityInAndroid();

        }
    }
    public interface ITextRecognition
    {
        void LaunchActivityInAndroid();
    }
}