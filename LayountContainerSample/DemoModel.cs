using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LayountContainerSample
{
    class DemoModel
    {
        public ListBoxItem chosenColor { get; set; }

        private string _Farbe;

        public string Farbe
        {
            get { if (chosenColor != null)
                    return chosenColor.Content.ToString();
                else return "Red";
            }
            set { _Farbe = value; }
        }

    }
}
