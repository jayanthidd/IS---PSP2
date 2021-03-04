using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankKonto
{


    public class KontoEventargs
    {
        public double newAccountBalance { get; set; }
    }
    //Event-provide, Event-publisher
    class BankKonto
    {
        public event Action<object, KontoEventargs> onGreaterthan1000;
        public string accountholder { get; set; }

        private double _Accountbalance;
        public bool _privateorderbusiness { get; set; }

        public double Accountbalance
        {
            get { return _Accountbalance; }
            set { _Accountbalance = value; 
                //null check to ensure a function has been assigned to the address
            if(_Accountbalance >1000 & onGreaterthan1000 != null)
                {
                    //raise an event
                    onGreaterthan1000(this, new KontoEventargs() { newAccountBalance = _Accountbalance });
                }
            }
        }

    }
}
