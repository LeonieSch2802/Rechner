using MvvmCross.ViewModels;
using Rechner.Core;

namespace WpfApp
{
    public class MainViewModel : MvxViewModel
    {

        Rechenautomat calc = new Rechenautomat();
        public string Title => "Rechenautomat";

        public string Erkl => "Das ist ein Rechenautomat";

        public string Calculation
        {
            get
            {
                return calc.NächsteBerechnung();
            }
        }

    }
}
