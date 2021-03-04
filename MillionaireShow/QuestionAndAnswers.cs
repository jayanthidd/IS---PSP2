using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionaireShow
{
    class QuestionAndAnswers : INotifyPropertyChanged

    {
        public string Question { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string CorrectAnswer { get; set; }
        private string _Result;

        public event PropertyChangedEventHandler PropertyChanged;




        public string Result
        {
            get { return _Result; }
            set { _Result = value; }
        }


    }
}
