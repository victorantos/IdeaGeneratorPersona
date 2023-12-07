using IdeaGeneratorPersona.Common;
using System.Collections.Generic;

namespace IdeaGeneratorPersona.Services
{
    public interface IControlsService
    {
        public IEnumerable<Control> GetAllControls();

        public Control GetControlByName(string controlName);

        public Example GetControlExample(string controlName, string exampleName);
    }
}
