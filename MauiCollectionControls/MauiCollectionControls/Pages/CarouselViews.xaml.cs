using MauiCollectionControls.Models;

namespace MauiCollectionControls.Pages;

public partial class CarouselViews : ContentPage
{
	public CarouselViews()
	{
		InitializeComponent();
		var items = new List<CollectionItem> {

		new CollectionItem{ Title="Title Demo 1", Description="This is title demo 1"},
        new CollectionItem{ Title="Title Demo 2", Description="This is title demo 2"},
        new CollectionItem{ Title="Title Demo 3", Description="This is title demo 3"},
        new CollectionItem{ Title="Title Demo 4", Description="This is title demo 4"},
        new CollectionItem{ Title="Title Demo 5", Description="This is title demo 5"}
        };
        carouselView.ItemsSource = items;

    }
}