using System.Collections.Generic;

namespace IdeaGeneratorPersona.Services
{
    public interface ISearchService
    {
        public IEnumerable<SearchResult> Search(string text);
    }
}
