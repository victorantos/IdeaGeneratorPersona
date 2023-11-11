using IdeaGeneratorPersona.Common;
namespace IdeaGeneratorPersona.Services;

 public interface IConfigurationService
    {
        public Configuration Configuration { get; }

        public IEnumerable<Control> GetControlsConfiguration();
    }
