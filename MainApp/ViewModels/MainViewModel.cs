using System.ComponentModel;

namespace MainApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private int _pages;
        public int Pages
        {
            get
            {
                return _pages;
            }
            set
            {
                _pages = value;
                OnPropertyChanged(nameof(Pages));
            }
        }

        private int _currentPage;
		public int CurrentPage
		{
			get
			{
				return _currentPage;
			}
			set
			{
				_currentPage = value;
				OnPropertyChanged(nameof(CurrentPage));
            }
		}

        private int _pages1;
        public int Pages1
        {
            get
            {
                return _pages1;
            }
            set
            {
                _pages1 = value;
                OnPropertyChanged(nameof(Pages1));
            }
        }

        private int _currentPage1;
        public int CurrentPage1
        {
            get
            {
                return _currentPage1;
            }
            set
            {
                _currentPage1 = value;
                OnPropertyChanged(nameof(CurrentPage1));
            }
        }

        public MainViewModel()
        {
            Pages = 5;
            CurrentPage = 1;

            Pages1 = 25;
            CurrentPage1 = 1;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
