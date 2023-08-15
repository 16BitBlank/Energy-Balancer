﻿using System.Data;
using CommunityToolkit.WinUI.UI;
using EnergyPerformance.Models;
using EnergyPerformance.Services;
using EnergyPerformance.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Media;
using Windows.Media.AppRecording;

namespace EnergyPerformance.Views;

public sealed partial class PersonaListPage : Page
{
    public PersonaViewModel ViewModel
    {
        get;
    }
    
    public PersonaListPage()
    {
        ViewModel = App.GetService<PersonaViewModel>();
        InitializeComponent();
    }

    // Function that is called when item in list view is selected
    // Navigates to the Customise Persona Page and passes the selected index as a parameter
    private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Frame.Navigate(typeof(CustomisePersonaPage), PersonaList.SelectedIndex);    
    }

    // Function that is called when the Edit Persona button is clicked
    // Navigates to the Customise Persona Page
    // Note - No parameter is passed, as we want to add a new persona
    private void NavigateToEditPage (object sender, RoutedEventArgs e)
    {
        Frame.Navigate(typeof(CustomisePersonaPage));
    }

    private void NavigateToAddPage(object sender, RoutedEventArgs e)
    {
        Frame.Navigate(typeof(AddPersonaPage));
    }
}