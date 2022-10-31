using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFwithModel.ViewModel
{
    internal class CoffeeMakerViewModel:INotifyPropertyChanged
    {
        IMachine machine;
        public string Name { get { return machine.Name; }
            set {
                OnPropertyChanged();
                this.machine.Name= value; } 
        }
        public int brewer
        {
            get { return machine.brewer; }
            set
            {
                OnPropertyChanged();
                this.machine.brewer = value;
            }
        }
        public int cups
        {
            get { return machine.cups; }
            set
            {
                OnPropertyChanged();
                this.machine.cups = value;
            }
        }

        public CoffeeMakerViewModel(IMachine mach)
        {
            this.machine = mach;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
