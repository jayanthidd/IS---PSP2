using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatheWPF
{
    class MathModell : INotifyPropertyChanged
    {
        private int _Number1;

        public int Number1
        {
            get { return _Number1; }
            set { _Number1 = value;
                RaisePropertyChanged("Number1");
            }
        }

        private int _Addition;

        public int Addition
        {
            get { return _Addition; }
            set { 
                _Addition = value;
                RaisePropertyChanged("Addition");
            }
        }

        private int _Subtraction;

        public int Subtraction
        {
            get { return _Subtraction; }
            set { 
                _Subtraction = value;
                RaisePropertyChanged("Subtraction");
            }
        }



        private int _Number2;

        public int Number2
        {
            get { return _Number2; }
            set { _Number2 = value;
                RaisePropertyChanged("Number2");
            }
        }

        private Dictionary<int, string> _Operator;

        public Dictionary<int, string> Operator
        {
            get { return _Operator; }
            set { _Operator = value; }
        }



        private string _Oper;

        public string Oper
        {
            get { return _Oper; }
            set { _Oper = value;
                RaisePropertyChanged("Oper");
            }
        }


        public string RandomOperator
        {
            get {
                Random r = new Random();
                int key = r.Next(0, 2);
                return _Operator[key]; 
            }
        }


        private int _Answer;

        private int _Questions;
        public int Questions { 
            get {
                return _Questions;
            } 
            set
            {
                _Questions = value;
                RaisePropertyChanged("Questions");
            } 
        }

        private int _CorrectAnswers;
        public int CorrectAnswers { 
            get {
                return _CorrectAnswers;
            } 
            set {
                _CorrectAnswers = value;
                RaisePropertyChanged("CorrectAnswers");
            } 
        }

        public int Answer
        {
            get {
                if (Oper == "+")
                    return _Number1 + _Number2;
                else
                    return Number1 - Number2;
            }
            set { _Answer = value; }
        }

        private int _IncorrectAnswers;

        public int IncorrectAnswers
        {
            get { return _IncorrectAnswers; }
            set { _IncorrectAnswers = value;
                RaisePropertyChanged("IncorrectAnswers");
            }
        }

        public void CheckAnswer()
        {
            if (Input == Answer)
                CorrectAnswers++;
            else
                IncorrectAnswers++;
        }

        public void ResetGame()
        {
            Operator = new Dictionary<int, string>();
            Operator.Add(0, "+");
            Operator.Add(1, "-");

            CorrectAnswers = 0;
            IncorrectAnswers = 0;
            Addition = 0;
            Subtraction = 0;
            GenerateNewQuestion();
        }

        public void GenerateNewQuestion()
        {
            Input = 0;
            Random random = new Random();
            Number1 = random.Next(0, 100);
            Number2 = random.Next(0, 100);
            Oper = RandomOperator;
            if (Oper == "+")
                Addition ++;
            else
                Subtraction ++;
            Questions++;
        }


        private int _Input;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Input

        {
            get { return _Input; }
            set { _Input = value;
                RaisePropertyChanged("Input");
                RaisePropertyChanged("Result");
            }
        }

        private string _Result;

        public string Result
        {
            get {
                if (Input == Answer)
                {
                    return $"That is absolutely correct!";
                }
                else
                    return $"Incorrect!";
            }
            set { _Result = value; }
        }

        void RaisePropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }


    }
}
