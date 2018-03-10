using Scribble.Web;
using Scribble.Web.Models;

namespace Scribble.Tests
{
    public class FakeMarkdownConverter : IMarkdownConverter
    {
        public string Convert(string input)
        {
            return $"<p>{input}</p>";
        }
    }
}