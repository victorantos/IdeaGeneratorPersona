using Microsoft.Maui;
using ILayout = Microsoft.Maui.ILayout;

namespace IdeaGeneratorPersona.Layouts
{
    public interface IUniformLayout : ILayout
    {
        UniformLayoutMode LayoutMode { get; }
        double Spacing { get; }
    }

}

