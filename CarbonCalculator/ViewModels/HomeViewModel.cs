using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CarbonCalculator.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace CarbonCalculator.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {

        public HomeViewModel()
        {
            InitData();
            TotalArtCO2Emission = getTotalArtEmissions();
            TotalTravelCO2Emission = 2000;
            TotalExhibitionCO2Emission = 5000;
        }

        [ObservableProperty]
        public ObservableCollection<Art> artCollection;

        [ObservableProperty]
        public double totalArtCO2Emission;

        [ObservableProperty]
        public double totalTravelCO2Emission;

        [ObservableProperty]
        public double totalExhibitionCO2Emission;

        private double getTotalArtEmissions()
        {
            double total = 0;

            foreach (Art art in ArtCollection) {
                total += art.CO2Emmision;
            }

            return total;
        }

        private void InitData()
        {
            ArtCollection = new ObservableCollection<Art>()
            {
                new Art
                {
                    Name = "Noe rare greier",
                    TravelFrom = "Oslo",
                    TravelTo = "Trondheim",
                    CO2Emmision=500
                    
                }, 
                new Art
                {
                    Name = "Noe andre greier",
                    TravelFrom = "Beirut",
                    TravelTo = "Trondheim",
                    CO2Emmision=20000
                }
            };
        }
    }
}
