using AngleSharp.Html.Dom;

namespace Parser.Common
{
    interface IParser<T> where T : class
    {
        T Parse(IHtmlDocument document);
    }
}
