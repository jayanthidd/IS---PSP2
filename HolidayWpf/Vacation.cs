using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayWpf
{
    class Vacation :INotifyPropertyChanged
    {
        public int Id { get; set; }

        public string Type { get; set; }
        public string Photo { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private string _Description;

        public string Description
        {
            get { return _Description; }
            set {
                _Description = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Description"));
                }
            }
        }
        //Rating between 0 and 10 with a slider in the GUI
        public int Rating { get; set; }
        // with a control box
        public bool Vorgemerkt { get; set; }

    }
}
