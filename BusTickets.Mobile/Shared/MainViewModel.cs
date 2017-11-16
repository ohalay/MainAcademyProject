using Refit;
using Shared.IClient;
using Shared.MVVM;
using System.Collections.Generic;
using System.Windows.Input;

namespace Shared
{
    public class MainViewModel : MvvmViewMode
    {
        private string _result;
        private IEnumerable<City> _cities;
        private bool _isVisible;
        private City _selectedItem;

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            _isVisible = true;
        }

        public IEnumerable<City> Cities
        {
            get
            {
                return _cities;
            }
            set
            {
                _cities = value;
                OnPropertyChanged(nameof(Cities));
            }
        }

        public bool IsVisible
        {
            get => _isVisible;
            set
            {
                SetProperty(ref _isVisible, value);
            }
        }

        public City SelectedItem
        {
            get => _selectedItem;
            set
            {
                _selectedItem = value;
                if (_selectedItem != null)
                {
                    IsVisible = false;
                    Result = _selectedItem.Name;
                }
            }
        }

        public ICommand SearchCommand
            => new MvvmCommand(param =>
            {
                var client = RestService.For<Shared.IClient.IClient>("http://localhost:55194");
                Cities = client.GetCity(param.ToString()).Result;
            });

        public string Result
        {
            get => _result;
            private set
            {
                _result = value;
                OnPropertyChanged();
            }
        }
    }
}