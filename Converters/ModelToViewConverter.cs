using System;
using System.Globalization;

using IdeaGeneratorPersona.Common;
using IdeaGeneratorPersona.Helpers;
using IdeaGeneratorPersona.ViewModels;

using Microsoft.Maui.Controls;

namespace IdeaGeneratorPersona.Converters;

public class ModelToViewConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        // if (value is ExampleViewModel viewModel)
        // {
        //     return Utils.CreateView(viewModel.Example, false);
        // } 
        // else if (value is Example example)
        // {
        //     return Utils.CreateView(example, true);
        // }
        // else if (value is Control control)
        // {
        //     return Utils.CreateView(control);
        // }
        // else
        // {
            return null;
       // }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
