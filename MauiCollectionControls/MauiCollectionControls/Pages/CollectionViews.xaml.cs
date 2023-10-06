using MauiCollectionControls.Models;

namespace MauiCollectionControls.Pages;

public partial class CollectionViews : ContentPage
{
	public CollectionViews()
	{
		InitializeComponent();
		collectionView.ItemsSource=GetCountries();
        //collectionView.ItemsSource=new List<Country>();

    }
    private List<Country> GetCountries()
	{
		return new List<Country>
		{
			new Country{CountryName="United America",ISONumber="ISO-numeric 840",FlagURL="https://flagcdn.com/256x192/ua.png"},
			new Country{CountryName="Bangladesh",ISONumber="ISO-numeric 50",FlagURL="https://flagcdn.com/256x192/bd.png"},
			new Country{CountryName="India",ISONumber="ISO-numeric 1",FlagURL="https://flagcdn.com/256x192/in.png"},
			new Country{CountryName="Pakisthan",ISONumber="ISO-numeric 586,",FlagURL="https://flagcdn.com/256x192/pk.png"},
			new Country{CountryName="Andorra",ISONumber="ISO-numeric 587",FlagURL="https://flagcdn.com/256x192/ad.png"},

        };

    }
}