using Microsoft.Maui.Controls;
using IdeaGeneratorPersona.ViewModels;
using System;

namespace IdeaGeneratorPersona.Pages;

public partial class DescriptionPage : ContentPage
{
    public DescriptionPage()
    {
        InitializeComponent();
    }

    private async void Back_Clicked(object sender, EventArgs e)
    {
        DescriptionViewModel vm = (DescriptionViewModel)this.BindingContext;
        await vm.NavigationService.NavigateBackAsync();
    }
}
