using Parcial1_V2.Data;

namespace Parcial1_V2.Views;

public partial class PastToursPage : ContentPage
{
	public PastToursPage()
	{
		InitializeComponent();
        PastToursList.ItemsSource = ArtistRepository.GetPastTours();
    }
}