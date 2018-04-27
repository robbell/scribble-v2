namespace Scribble.Web.Domain
{
    public class MarkdownConverter : IMarkdownConverter
    {
        public string Convert(string input)
        {
            return CommonMark.CommonMarkConverter.Convert(input);
        }
    }
}