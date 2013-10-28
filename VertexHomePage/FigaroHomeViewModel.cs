using System.Collections.ObjectModel;
using System.ComponentModel;
using VertexHomePage.Annotations;

namespace VertexHomePage
{
    public class FigaroHomeViewModel : INotifyPropertyChanged
	{
        private ObservableCollection<NavigableItem> _favourites = new ObservableCollection<NavigableItem>(); 
	    public ObservableCollection<NavigableItem> Favourites {
	        get
	        {
	            return _favourites;
	        }
	        set
	        {
	            if (_favourites != value)
	            {
	                _favourites = value;
                    OnPropertyChanged("Favourites");
	            }
	        }
	    }

        private ObservableCollection<NavigableItem> _selectedPrograms = new ObservableCollection<NavigableItem>();
        public ObservableCollection<NavigableItem> SelectedPrograms
        {
            get
            {
                return _selectedPrograms;
            }
            set
            {
                if (_selectedPrograms != value)
                {
                    _selectedPrograms = value;
                    OnPropertyChanged("SelectedPrograms");
                }
            }
        }
        
	    public event PropertyChangedEventHandler PropertyChanged;

	    [NotifyPropertyChangedInvocator]
	    protected virtual void OnPropertyChanged(string propertyName)
	    {
	        PropertyChangedEventHandler handler = PropertyChanged;
	        if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
	    }
	}
}