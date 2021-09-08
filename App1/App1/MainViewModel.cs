using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using System.Linq;
using System.Threading.Tasks;
using XamForms.Controls;

namespace App1
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ICommand LerCommand { get; set; }

        public CultureInfo Culture => new CultureInfo("ptr-Br");

        public MainViewModel()
        {
            DatasSelecionadas = new ObservableCollection<DateTime>();
            Attendances = new ObservableCollection<SpecialDate>();

            LerCommand = new Command(() => ExecuteLerCommand());
        }

        public DateTime? _dtChosen;
        public DateTime? DateChosen
        {
            get { return _dtChosen; }
            set
            {
                _dtChosen = value;
                NotifyPropertyChanged(nameof(DateChosen));
            }
        }
        public DateTime? _seldDate;
        public DateTime? SelectedDate
        {
            get { return _seldDate; }
            set
            {
                _seldDate = value;
                NotifyPropertyChanged(nameof(SelectedDate));
            }
        }
        public void ExecuteLerCommand()
        {
            int count = DatasSelecionadas.Count();
        }

        private ObservableCollection<SpecialDate> _atdc;
        public ObservableCollection<SpecialDate> Attendances
        {
            get { return _atdc; }
            set
            {
                _atdc = value;
                NotifyPropertyChanged(nameof(Attendances));
            }
        }

        private ObservableCollection<DateTime> _dtselec;
        public ObservableCollection<DateTime> DatasSelecionadas
        {
            get { return _dtselec; }
            set
            {
                _dtselec = value;
                NotifyPropertyChanged(nameof(DatasSelecionadas));
            }
        }

        public string _min = DateTime.Now.ToString("yyyy-MM-dd");
        public string DataInicialMinima
        {
            get { return _min; }
            set
            {
                _min = value;
                NotifyPropertyChanged(nameof(DataInicialMinima));
            }
        }

        //private DateTime? _date;
        //public DateTime? Date
        //{
        //    get
        //    {
        //        return _date;
        //    }
        //    set
        //    {
        //        _date = value;
        //        System.Diagnostics.Debug.WriteLine(_date.ToString());
        //        NotifyPropertyChanged(nameof(Date));
        //    }
        //}

        //public ICommand DateChosen
        //{
        //    get
        //    {
        //        return new Command((obj) => 
        //        {
        //            //System.Diagnostics.Debug.WriteLine(obj as DateTime?);
        //        });
        //    }
        //}

        //private ObservableCollection<XamForms.Controls.SpecialDate> attendances;
        //public ObservableCollection<XamForms.Controls.SpecialDate> Attendances
        //{
        //    get { return attendances; }
        //    set { attendances = value; NotifyPropertyChanged(nameof(Attendances)); }
        //}

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
