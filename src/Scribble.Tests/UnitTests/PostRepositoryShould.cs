using FluentAssertions;
using Scribble.Tests.FakesAndSpies;
using Scribble.Web.Models;
using Xunit;

namespace Scribble.Tests.UnitTests
{
    public class PostRepositoryShould
    {
        [Fact]
        public void RetrievePostFromGitHub()
        {
            var expectedPost = new Post { Body = "<p>My post body</p>" };

            var fakeGitRepository = new FakeGitRepository();
            var fakeMarkdownConverter = new FakeMarkdownConverter();
            var postRepository = new PostRepository(fakeGitRepository, fakeMarkdownConverter);

            var result = postRepository.Get("some-path");

            result.Should().BeEquivalentTo(expectedPost);
        }
    }
}
