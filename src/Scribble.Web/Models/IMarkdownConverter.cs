namespace Scribble.Web.Models
{
    public interface IMarkdownConverter
    {
        string Convert(string input);
    }
}