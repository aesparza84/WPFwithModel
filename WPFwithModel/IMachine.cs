using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFwithModel
{
    internal interface IMachine
    {
        string Name { get; set; }
        int brewer { get; set; }
        int cups { get; set; }

        void Task();
        void TaskTwo();
    }
}
