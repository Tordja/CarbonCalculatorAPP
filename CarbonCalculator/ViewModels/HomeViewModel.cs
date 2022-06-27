using System.ComponentModel;
using System.Runtime.CompilerServices;
using CarbonCalculator.Models;

namespace CarbonCalculator.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {

        public List<Art> ArtList { get; set; }

        public HomeViewModel()
        {
            InitData();
        }

        private void InitData()
        {
            ArtList = new List<Art>()
            {
                new Art
                {
                    Name = "Noe rare greier",
                    TravelFrom = "Oslo",
                    TravelTo = "Trondheim"
                }, 
                new Art
                {
                    Name = "Noe rare greier",
                    TravelFrom = "Oslo",
                    TravelTo = "Trondheim"
                }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
