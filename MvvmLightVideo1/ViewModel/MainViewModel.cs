using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MvvmLightVideo1.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;

namespace MvvmLightVideo1.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;

        /// <summary>
        /// The <see cref="WelcomeTitle" /> property's name.
        /// </summary>
        public const string WelcomeTitlePropertyName = "WelcomeTitle";

        private string _welcomeTitle = string.Empty;

        /// <summary>
        /// Gets the WelcomeTitle property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string WelcomeTitle
        {
            get
            {
                return _welcomeTitle;
            }
            set
            {
                Set(ref _welcomeTitle, value);
            }
        }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IDataService dataService)
        {
            _dataService = dataService;
            _dataService.GetData(
                (item, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }

                    WelcomeTitle = item.Title;
                });
        }


        private RelayCommand _myCommand;

        /// <summary>
        /// Gets the MyCommand.
        /// </summary>
        public RelayCommand MyCommand
        {
            get
            {
                return _myCommand
                    ?? (_myCommand = new RelayCommand(
                    () =>
                    {
                        MessageBox.Show("Relay works");
                    }));
            }
        }


        private RelayCommand _showDetail;

        /// <summary>
        /// Gets the ShowDetail.
        /// </summary>
        public RelayCommand ShowDetail
        {
            get
            {
                return _showDetail
                    ?? (_showDetail = new RelayCommand(
                    () =>
                    {
                        LandDetailView ldView = new LandDetailView();
                        LandDetailViewModel ldViewModel = (LandDetailViewModel)ldView.DataContext;
                        ldViewModel.CurrentLand = CurrentLand;
                        ldView.Show(); 

                    }));
            }
        }

        private const string FileBase = "C:\\Users\\Ken\\Dropbox\\json\\theLandsExperiment.json";


        public ObservableCollection<ltdilRecord> Refresh()
        {
            using (StreamReader r = new StreamReader(FileBase))
            {
                string json = r.ReadToEnd();
                var lands = JsonConvert.DeserializeObject<ListOfLands>(json);
                var ocLands = new ObservableCollection<ltdilRecord>(lands.Lands);
                return ocLands;
            }

        }


        private ObservableCollection<ltdilRecord> _theLands;
        public ObservableCollection<ltdilRecord> TheLands
        {
            get { return _theLands; }
            set
            {
                _theLands = value;
                RaisePropertyChanged("TheLands");
            }
        }


        private ltdilRecord _currentLand;
        public ltdilRecord CurrentLand
        {
            get { return _currentLand; }
            set { _currentLand = value;
            RaisePropertyChanged("ltdilRecord");
            }
        }

        private RelayCommand _getLands;

        /// <summary>
        /// Gets the MyCommand.
        /// </summary>
        public RelayCommand GetLands
        {
            get
            {
                return _getLands
                    ?? (_getLands = new RelayCommand(
                    () =>
                    {
                        TheLands = Refresh();
                        RaisePropertyChanged("TheLands");
                    }));
            }
        }

        private RelayCommand _getSelected;

        /// <summary>
        /// Gets the MyCommand.
        /// </summary>
        public RelayCommand GetSelected
        {
            get
            {
                return _getSelected
                    ?? (_getSelected = new RelayCommand(
                    () =>
                    {
                        MessageBox.Show("the current selected land is " + CurrentLand.lineValue + "\nand the current LandID is " + CurrentLand.landID);
                    }));
            }
        }

        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}