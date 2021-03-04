using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayWpf
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        //Use Entoty Framework Context
        //NugetEntity Framework
        // Database Context
        // Create a VacationContext class and inherit the DbContext class
        // createa DbSet inside

        private VacationAmendedContext vacationContext = new VacationAmendedContext();//To be able to access the databse here

        private string _NoOfVacations;

        public string NoOfVacations
        {
            get { return "Number of Vacations : " + ObservableVacationCollection.Count; }
            set { _NoOfVacations = value; }
        }

        private string _NoOfRelaxingVacations;

        public string NoOfRelaxingVacations
        {
            get { return "Active Vacation : " + ObservableVacationCollection
                    .Where(u=>u.Type=="Action")
                    .Count(); }
            set { _NoOfRelaxingVacations = value; }
        }


        private string _NoOfActiveVacations;

        public string NoOfActiveVacations
        {
            get
            {
                return "Relaxing Vacation : " + ObservableVacationCollection
                  .Where(u => u.Type == "Relax")
                  .Count();
            }
            set { _NoOfActiveVacations = value; }
        }

        internal void DeleteVacation()
        {
            Vacation del = ChosenVacation;
            ObservableVacationCollection.Remove(del);
            vacationContext.Vacations.Remove(del);
            ChosenVacation = ObservableVacationCollection[0];
            vacationContext.SaveChanges();
        }

        public string SearchText { get; set; }

        public ObservableCollection<Vacation> ObservableVacationCollectionFiltered
        {
            get; set;
        }

        private string _FilteredNumber;

        public string FilteredNumber
        {
            get { 
                if (ObservableVacationCollectionFiltered==null)
                    return "FilteredNumber : 0";
                return "FilteredNumber : " + ObservableVacationCollectionFiltered.Count(); 
            }
            set { _FilteredNumber = value; }
        }


        public void Filter()
        {
            ObservableVacationCollectionFiltered = new ObservableCollection<Vacation>(ObservableVacationCollection.Where(v => v.Description.Contains(SearchText)));
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs("ObservableVacationCollectionFiltered"));
                PropertyChanged(this, new PropertyChangedEventArgs("FilteredNumber"));
            }
        }

        private ObservableCollection<string> _VacationTypes;

        public ObservableCollection<string> VacationTypes
        {
            get { return _VacationTypes; }
            set { _VacationTypes = value; }
        }


        public ObservableCollection<Vacation> ObservableVacationCollection { get; set; }

        private Vacation _ChosenVacation;

        public event PropertyChangedEventHandler PropertyChanged;

        public Vacation ChosenVacation

        {
            get { return _ChosenVacation; }
            set { _ChosenVacation = value; 
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("ChosenVacation"));
                }
            }
        }

        public void InitFirstLoad()
        {

            ObservableVacationCollection.Add(new Vacation()
            {
                Id = 1,
                Description = "By the Sea",
                Type = "Relax",
                Photo = "Sea.jpg",
                Rating = 5,
                Vorgemerkt = true  
            });
            vacationContext.Vacations.Add(ObservableVacationCollection[0]);

            ObservableVacationCollection.Add(new Vacation()
            {
                Id = 2,
                Description = "Vacation with Fun",
                Type = "Action",
                Photo = "CostaRica.jpg",
                Rating = 5,
                Vorgemerkt = true
            });
            vacationContext.Vacations.Add(ObservableVacationCollection[1]);

            vacationContext.SaveChanges(); // to save down these data in the database
        }

        void InitLoad()
        {
            var vacationList = vacationContext.Vacations.ToList();
            foreach (Vacation vacation in vacationList) {
                ObservableVacationCollection.Add(vacation);
            }
        }

        public MainWindowViewModel()
        {

            ObservableVacationCollection = new ObservableCollection<Vacation>();
            //InitFirstLoad();//Only for the first time to create the database
            InitLoad();//This will be called after the database has been created so that the list will get filled up
            ChosenVacation = ObservableVacationCollection[1];
            VacationTypes = new ObservableCollection<string>();
            VacationTypes.Add("Action");
            VacationTypes.Add("Relax");

            NewVacation = new Vacation();
        }

        public Vacation NewVacation { get; set; }

        public void AddNewVacation()
        {
            Vacation vac = new Vacation();

            vac.Type = NewVacation.Type;
            vac.Description = NewVacation.Description;
            vac.Photo = NewVacation.Photo;
            vac.Rating = NewVacation.Rating;
            vac.Vorgemerkt = NewVacation.Vorgemerkt;
            var total = ObservableVacationCollection.Max(v => v.Id);

            vac.Id = ++total;

            ObservableVacationCollection.Add(vac);
            vacationContext.Vacations.Add(vac);
            vacationContext.SaveChanges();
            //Also save into a database

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("NoOfVacations"));
                PropertyChanged(this, new PropertyChangedEventArgs("NoOfRelaxingVacations"));
                PropertyChanged(this, new PropertyChangedEventArgs("NoOfActiveVacations"));
            }
        }
    }
}
