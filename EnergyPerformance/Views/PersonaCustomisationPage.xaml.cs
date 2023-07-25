﻿using EnergyPerformance.Models;
using EnergyPerformance.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Media;

namespace EnergyPerformance.Views;

public sealed partial class PersonaCustomisationPage : Page
{
    public PersonaCustomisationViewModel ViewModel
    {
        get;
    }
    
    public PersonaCustomisationPage()
    {
        ViewModel = App.GetService<PersonaCustomisationViewModel>();
        InitializeComponent();
        //PersonaSlider.LayoutUpdated += PersonaSlider_LayoutUpdated;
    }

    private void ShowPopup(object sender, RoutedEventArgs e)
    {
        if (!PersonaPopup.IsOpen) { PersonaPopup.IsOpen = true; }
    }

    private void HidePopup(object sender, RoutedEventArgs e)
    {
        if (PersonaPopup.IsOpen) { PersonaPopup.IsOpen = false; }
    }

        //private void PersonaSlider_LayoutUpdated(object? sender, object e)
        //{
        //    if (VisualTreeHelper.GetOpenPopupsForXamlRoot(PersonaSlider.XamlRoot).LastOrDefault() is Popup popup)
        //    {
        //        popup.Visibility = Microsoft.UI.Xaml.Visibility.Collapsed;
        //    }
        //}
}