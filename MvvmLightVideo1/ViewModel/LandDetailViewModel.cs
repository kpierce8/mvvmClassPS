using GalaSoft.MvvmLight;
using MvvmLightVideo1.Model;

namespace MvvmLightVideo1.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class LandDetailViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the LandDetailViewModel class.
        /// </summary>
        public LandDetailViewModel()
        {
        }

        /// <summary>
        /// The <see cref="CurrentLand" /> property's name.
        /// </summary>
        public const string CurrentLandPropertyName = "CurrentLand";

        private ltdilRecord _landRecord;

        /// <summary>
        /// Sets and gets the CurrentLand property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public ltdilRecord CurrentLand
        {
            get
            {
                return _landRecord;
            }

            set
            {
                if (_landRecord == value)
                {
                    return;
                }

                _landRecord = value;
                LandName = value.lineValue;
                LandID = value.landID;
                ParkID = value.parkID;
                RaisePropertyChanged(CurrentLandPropertyName);
            }
        }

        /// <summary>
        /// The <see cref="LandName" /> property's name.
        /// </summary>
        public const string LandNamePropertyName = "LandName";

        private string _landName;

        /// <summary>
        /// Sets and gets the LandName property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string LandName
        {
            get
            {
                return _landName;
            }

            set
            {
                if (_landName == value)
                {
                    return;
                }

                _landName = value;
                RaisePropertyChanged(LandNamePropertyName);
            }
        }

        /// <summary>
        /// The <see cref="LandID" /> property's name.
        /// </summary>
        public const string LandIDPropertyName = "LandID";

        private int _landID = 0;

        /// <summary>
        /// Sets and gets the LandID property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public int LandID
        {
            get
            {
                return _landID;
            }

            set
            {
                if (_landID == value)
                {
                    return;
                }

                _landID = value;
                RaisePropertyChanged(LandIDPropertyName);
            }
        }

        /// <summary>
        /// The <see cref="ParkID" /> property's name.
        /// </summary>
        public const string ParkIDPropertyName = "ParkID";

        private int _parkID = 0;

        /// <summary>
        /// Sets and gets the ParkID property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public int ParkID
        {
            get
            {
                return _parkID;
            }

            set
            {
                if (_parkID == value)
                {
                    return;
                }

                _parkID = value;
                RaisePropertyChanged(ParkIDPropertyName);
            }
        }


    }
}