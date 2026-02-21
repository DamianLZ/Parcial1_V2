using Parcial1_V2.Data;

namespace Parcial1_V2.Views;

public partial class UpcomingToursPage : ContentPage
{
	public UpcomingToursPage()
	{
		InitializeComponent();
        UpcomingList.ItemsSource = ArtistRepository.GetUpcomingTours();
    }
}
