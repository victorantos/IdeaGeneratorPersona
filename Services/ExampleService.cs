using System;
using IdeaGeneratorPersona.Common;
using Microsoft.Maui.Controls;

namespace IdeaGeneratorPersona.Services
{
    /// <summary>
    /// The ExampleService is responsible for managing the examples section in the app.
    /// </summary>
    public class ExampleService : IExampleService
    {
        private const string NameFormat = "IdeaGeneratorPersona.Examples.{0}Control.{1}Example.{2}";

        public object CreateExample(Example example)
        {
            var controlName = example.ControlName;
            var name = string.Format(NameFormat, controlName, example.Name, example.Page);
            var type = Type.GetType(name);
            View view = (View)Activator.CreateInstance(type);

            return view;
        }
    }
}
