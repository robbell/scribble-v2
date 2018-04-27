namespace Scribble.Web.Domain
{
    public interface IMarkdownConverter
    {
        string Convert(string input);
    }
}