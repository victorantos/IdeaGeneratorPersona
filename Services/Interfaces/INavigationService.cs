namespace IdeaGeneratorPersona.Services;

public interface INavigationService
{
    public Task NavigateToAsync<TViewModel>(params object[] arguments);

    // public Task NavigateToExampleAsync(Example example);

    // public Task NavigateToConfigurationPageAsync(ExampleViewModel viewmodel);

    // public Task NavigateToDescriptionPageAsync(DescriptionViewModel viewmodel);

    public Task NavigateToRootAsync();

    public Task NavigateBackAsync();
}