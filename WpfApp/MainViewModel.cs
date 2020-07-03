using MvvmCross.Commands;
using MvvmCross.ViewModels;
using Rechner.Core;

namespace WpfApp
{
    public class MainViewModel : MvxViewModel
    {

        Rechenautomat calc = new Rechenautomat();

        public MainViewModel()
        {
            this.CheckCommand = new MvxCommand(Check, CanCheck);
        }

        public string Title => "Rechenautomat";

        public string Erkl => "Das ist ein Rechenautomat";

        public string Calculation
        {
            get
            {
                return calc.NächsteBerechnung();
            }
        }

        private string _userInput;

        public string UserInput
        {
            get { return _userInput; }
            set { _userInput = value;
                RaisePropertyChanged(() => UserInput);
                this.CheckCommand.RaiseCanExecuteChanged();
            }
        }

        private int _falsch = 0;

        public string Falsch
        {
            get
            {
                return Convert.ToString(this._falsch);
            }
        }

        private int _richtig = 0;
        public string Richtig
        {
            get
            {
                return Convert.ToString(this._richtig);
            }
        }

        /**
         * commands
         */

        #region Commands
        public MvxCommand CheckCommand { get; set; }
        public void Check()
        {
            var zahl = Convert.ToInt32(this.UserInput);

            var erg = this.calc.Prüfe(zahl);

            RaisePropertyChanged(() => Calculation);

            if(erg)
            {
                //richtig
                this._richtig++;
                RaisePropertyChanged(() => Richtig);
            }
            else
            {
                //falsch
                this._falsch++;
                RaisePropertyChanged(() => Falsch);
            }
        }

        public bool CanCheck()
        {
            return this.UserInput.Trim().Length != 0;
        }
        #endregion

    }
}
