using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.ViewModel
{
   public class MainViewModel : ViewModelBase
    {  
    public
    const string ClickCountPropertyName = "ClickCount";
        private int clickCount;
        /// <summary>  
        /// Initializes a new instance of the MainViewModel class.  
        /// </summary>  
        public MainViewModel()
        { }
        public int ClickCount
        {
            get
            {
                return clickCount;
            }
            set
            {
                if (Set(() => ClickCount, ref clickCount, value))
                {
                    RaisePropertyChanged(() => ClickCountFormatted);
                }
            }
        }
        public string ClickCountFormatted
        {
            get
            {
                return string.Format("The button was clicked {0} time(s)", ClickCount);
            }
        }
        private RelayCommand incrementCommand;
        /// <summary>  
        /// Gets the IncrementCommand.  
        /// </summary>  
        public RelayCommand IncrementCommand
        {
            get
            {
                return incrementCommand ?? 
                    (incrementCommand = new RelayCommand(() =>
                    {
                       ClickCount++;
                    }
                    )
                    );
            }
        }
    }
}

