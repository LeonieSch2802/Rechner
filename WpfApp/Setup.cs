using MvvmCross.Platforms.Wpf.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp
{
    public class Setup : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<MainViewModel>();
        }
    }
}
