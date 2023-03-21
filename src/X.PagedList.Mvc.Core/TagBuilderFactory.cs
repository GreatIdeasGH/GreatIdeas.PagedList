using GreatIdeas.PagedList.Mvc.Core.Common;

namespace GreatIdeas.PagedList.Mvc.Core;

internal sealed class TagBuilderFactory : ITagBuilderFactory
{
    public ITagBuilder Create(string tagName)
    {
        return new TagBuilder(tagName);
    }
}