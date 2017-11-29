using BusTicketClient.Tables;
using Refit;
using Shared.MVVM;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    class DescriptionViewModel : MvvmViewMode
    {
        public DescriptionViewModel(Journey journey)
        {
            this._selectedJourney = journey;
            FindBus();
            FindTicket();
        }

        private Bus _selectedBus;
        private int _selectedTicket;
        private Journey _selectedJourney;


        public bool IsFreeTicket
        {
            get
            {
                if (TicketNumber == 0)
                    return false;
                else
                    return true;
            }
        }
        public Xamarin.Forms.Color ButtonColor
        {
            get
            {
                if (TicketNumber == 0)
                    return Xamarin.Forms.Color.Gray;
                else
                    return Xamarin.Forms.Color.Green;
            }
        }

        public string FromCity { get => _selectedJourney.CityNameFrom; }

        public string ToCity { get => _selectedJourney.CityNameTo; }

        public float Distance { get => _selectedJourney.Distance; }

        public int BusNumber { get => _selectedBus.BusNumber; }

        public int TicketNumber { get => _selectedTicket; }

        public void FindBus()
        {
            var client = RestService.For<IClient>(Constant.ServerPath);
            _selectedBus = client.GetBus(_selectedJourney.BusID).Result;
        }
        public void FindTicket()
        {
            var client = RestService.For<IClient>(Constant.ServerPath);
            _selectedTicket = client.GetAvailableTicketNumber(_selectedJourney.ID).Result;
        }
    }
}
