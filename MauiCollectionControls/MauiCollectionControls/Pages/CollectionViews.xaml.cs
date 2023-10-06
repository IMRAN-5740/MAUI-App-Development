using MauiCollectionControls.Models;

namespace MauiCollectionControls.Pages;

public partial class CollectionViews : ContentPage
{
	public CollectionViews()
	{
		InitializeComponent();
		collectionView.ItemsSource=GetCountries();
		
	}
	private List<Country> GetCountries()
	{
		return new List<Country>
		{
			new Country{CountryName="Bangladesh",ISONumber="1234 BD",FlagURL="Demo Url"},
			new Country{CountryName="Bangladesh",ISONumber="1234 BD",FlagURL="Demo Url"},
			new Country{CountryName="Bangladesh",ISONumber="1234 BD",FlagURL="Demo Url"},
			new Country{CountryName="Bangladesh",ISONumber="1234 BD",FlagURL="Demo Url"},
			new Country{CountryName="Bangladesh",ISONumber="1234 BD",FlagURL="Demo Url"},
			new Country{CountryName="Bangladesh",ISONumber="1234 BD",FlagURL="Demo Url"},

		};

    }
}