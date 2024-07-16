 
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Layouts;
using Microsoft.Maui.Platform;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace GalleryApp;

public partial class DynamicControls : ContentPage
{
    List<string> list;
    int count;
    Image img;

    public DynamicControls()
	{
		InitializeComponent();
        count = 0;
        list = new List<string>()
            {
                "a1","a2","a3","a4","a5","a6","a7","a8","a9", "a10","a11","a12","a13","a14","a15","a16",
            };
        InitView();
        

    }

    

    private void InitView()
    {
        Button btnUp = new Button()
        {
            Text = "\ue5c7",
            BackgroundColor = Colors.Transparent,
            FontFamily = "Icon",
            FontSize = 40,
            TextColor = Colors.Black,
            HorizontalOptions = LayoutOptions.Center,

        };
        Button btnDown = new Button()
        {
            Text = "\ue5c5",
            BackgroundColor = Colors.Transparent,
            FontFamily = "Icon",
            FontSize = 40,
            TextColor = Colors.Black,
            HorizontalOptions = LayoutOptions.Center,
        };
        Border borderImg = new Border()
        {
            Stroke = new SolidColorBrush(Colors.CornflowerBlue),
            StrokeThickness = 10,
            WidthRequest = 300,
            HeightRequest = 250,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            BackgroundColor = Colors.Transparent,
            
 

        };
        img = new Image()
        {
            Aspect = Aspect.AspectFit,
            HeightRequest = 185,
            HorizontalOptions = LayoutOptions.Center,
            Source = "a1.jpeg",
        };

        borderImg.Content= img; 

        btnUp.Clicked += BtnUp_Clicked;
        btnDown.Clicked += BtnDown_Clicked;

        MainStackLayout.Children.Add(btnUp);
        MainStackLayout.Children.Add(borderImg);
        MainStackLayout.Children.Add(btnDown);

    }
             

    private void BtnDown_Clicked(object? sender, EventArgs e)
    {
        count--;
        if (count < 0)
            count = 15;
        img.Source = list[count];
    }

    private void BtnUp_Clicked(object? sender, EventArgs e)
    {
       
        count++;
        if (count == list.Count)
            count = 0;
        img.Source = list[count];

    }
}