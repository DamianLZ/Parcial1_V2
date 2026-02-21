using Parcial1_V2.Data;

namespace Parcial1_V2.Views;

public partial class DiscografiaPage : ContentPage
{
	public DiscografiaPage()
	{
		InitializeComponent();
        AlbumsList.ItemsSource = ArtistRepository.GetAlbums();
    }
}