using FluentAssertions;
using Scribble.Web.Domain;
using Xunit;

namespace Scribble.Tests.ContractTests
{
    public class MarkdownConverterShould
    {
        [Fact, Trait("Category", "Integration")]
        public void ConvertMarkdownToHtml()
        {
            var markdownConverter = new MarkdownConverter();

            var result = markdownConverter.Convert("# Test");

            result.Should().Be("<h1>Test</h1>\r\n");
        }
    }
}