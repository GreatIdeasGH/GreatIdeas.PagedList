namespace GreatIdeas.PagedList.Mvc.Core.Common;

public interface ITagBuilderFactory
{
    ITagBuilder Create(string tagName);
}