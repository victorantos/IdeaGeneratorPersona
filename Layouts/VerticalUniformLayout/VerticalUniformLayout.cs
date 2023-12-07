using Microsoft.Maui.Controls;
using Microsoft.Maui.Layouts;

namespace IdeaGeneratorPersona.Layouts;

public partial class VerticalUniformLayout : Grid
{
    protected override ILayoutManager CreateLayoutManager()
    {
        return new VerticalUniformLayoutManager(this);
    }
}
