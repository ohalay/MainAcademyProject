using BusTicketClient.Tables;
using Refit;
using Shared.MVVM;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using System;

namespace Shared
{
    public class MainViewModel : MvvmViewMode
    {
        private string _resultFrom;
        private string _resultTo;
        private IEnumerable<City> _citiesTo;
        private IEnumerable<City> _citiesFrom;
        private IEnumerable<Journey> _journeys;
        private bool _isVisibleFrom;
        private bool _isVisibleTo;
        private City _selectedItemFrom;
        private City _selectedItemTo;

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            _isVisibleFrom = true;
            _isVisibleTo = true;
        }

        public IEnumerable<Journey> Journeys
        {
            get
            {
                return _journeys;
            }
            set
            {
                _journeys = value;
                
                OnPropertyChanged(nameof(Journeys));
            }
        }

        public IEnumerable<City> CitiesFrom
        {
            get
            {
                return _citiesFrom;
            }
            set
            {
                _citiesFrom = value;
                OnPropertyChanged(nameof(CitiesFrom));
            }
        }

        public IEnumerable<City> CitiesTo
        {
            get
            {
                return _citiesTo;
            }
            set
            {
                _citiesTo = value;
                OnPropertyChanged(nameof(CitiesTo));
            }
        }

        public bool IsVisibleFrom
        {
            get => _isVisibleFrom;
            set
            {
                SetProperty(ref _isVisibleFrom, value);
            }
        }
        public bool IsVisibleTo
        {
            get => _isVisibleTo;
            set
            {
                SetProperty(ref _isVisibleTo, value);
            }
        }

        public City SelectedItemFrom
        {
            get => _selectedItemFrom;
            set
            {
                _selectedItemFrom = value;
                if (_selectedItemFrom != null)
                {
                    IsVisibleFrom = false;
                    ResultFrom = _selectedItemFrom.Name;
                    SearchJourney();
                }
            }
        }

        public City SelectedItemTo
        {
            get => _selectedItemTo;
            set
            {
                _selectedItemTo = value;
                if (_selectedItemTo != null)
                {
                    IsVisibleTo = false;
                    ResultTo = _selectedItemTo.Name;
                    SearchJourney();
                }
            }
        }

        public ICommand SearchCommandFrom
            => new MvvmCommand(param =>
            {
                var client = RestService.For<IClient>(Constant.ServerPath);
                CitiesFrom = client.GetCity(this.ResultFrom).Result;
            });

        public ICommand SearchCommandTo
            => new MvvmCommand(param =>
            {
                var client = RestService.For<IClient>(Constant.ServerPath);
                CitiesTo = client.GetCity(param.ToString()).Result;
            });

        public string ResultFrom
        {
            get => _resultFrom;
            set
            {
                _resultFrom = value;
                OnPropertyChanged();
            }
        }

        public string ResultTo
        {
            get => _resultTo;
            private set
            {
                _resultTo = value;
                OnPropertyChanged();
            }
        }
        public void SearchJourney()
        {
            if (SelectedItemFrom != null && SelectedItemTo != null)
            {
                var client = RestService.For<IClient>(Constant.ServerPath);
                Journeys = client.GetJourney(SelectedItemFrom.ID, SelectedItemTo.ID).Result;
                foreach(var item in Journeys)
                {
                    item.CityNameFrom = _selectedItemFrom.Name;
                    item.CityNameTo = _selectedItemTo.Name;
                }
            }
        }
        
    }
}