using Scribble.Web.Models;

namespace Scribble.Tests.FakesAndSpies
{
    public class FakeMarkdownConverter : IMarkdownConverter
    {
        public string Convert(string input)
        {
            return $"<p>{input}</p>";
        }
    }
}