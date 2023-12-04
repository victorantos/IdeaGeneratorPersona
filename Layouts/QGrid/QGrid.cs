using System;
using Microsoft.Maui.Layouts;

namespace IdeaGeneratorPersona.Layouts
{
    public partial class QGrid : Grid
    {
        protected override ILayoutManager CreateLayoutManager()
        {
            return new QGridLayoutManager(this);
        }
    }
}

