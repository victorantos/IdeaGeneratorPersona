using Microsoft.Maui.Controls;
using System.Windows.Input;
using Telerik.Maui.Controls;
using IdeaGeneratorPersona.Services;

namespace IdeaGeneratorPersona;

public class ViewModelBase : NotifyPropertyChangedBase
{
    public INavigationService NavigationService => DependencyService.Get<INavigationService>();
}

