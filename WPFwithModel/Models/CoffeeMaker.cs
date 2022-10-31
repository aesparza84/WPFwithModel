using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFwithModel.Models
{
    public class CoffeeMaker : IMachine
    {
        public string Name { get; set; }
        public int brewer { get; set; }        

        public int cups { get; set; }
       

        // public int CupCount;


        public event PropertyChangedEventHandler? PropertyChanged;

        //private void RaisePorpertyChanged(string property)
        //{
        //    if (PropertyChanged != null)
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(property));
        //    }
        //}

        protected void OnPropertyChanged([CallerMemberName]string propertyName = null)
        { 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public event EventHandler OnBeansAdd;
        public event EventHandler OnCupBrewed;
        public CoffeeMaker(string name)
        {
            brewer = 0;
            cups = 0;
            //CupCount = Cups.Count;
            this.OnBeansAdd += CoffeeMaker_OnBeansAdd;
            this.OnCupBrewed += CoffeeMaker_OnCupBrewed;
            Name = name;
        }

        private void CoffeeMaker_OnCupBrewed(object? sender, EventArgs e)
        {
            if (brewer > 0)
            {
                cups++;
                brewer--;
            }
        }

        private void CoffeeMaker_OnBeansAdd(object? sender, EventArgs e)
        {
            brewer += 2;
        }

        public void addBeans()
        {
            this.OnBeansAdd.Invoke(this, EventArgs.Empty);
        }

        public void brewCup()
        {
            this.OnCupBrewed.Invoke(this, EventArgs.Empty);
        }

        public void Task()
        {
            brewCup();
        }

        public void TaskTwo()
        {
            addBeans();
        }
    }
}
