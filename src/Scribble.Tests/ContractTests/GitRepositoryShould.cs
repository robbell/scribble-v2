using FluentAssertions;
using Octokit;
using Xunit;

namespace Scribble.Tests.ContractTests
{
    public class GitRepositoryShould
    {
        [Fact, Trait("Category", "Integration")]
        public void GetRawMarkdownFromGitHub()
        {
            var client = new GitHubClient(new ProductHeaderValue("my-cool-app"))
            {
                Credentials = new Credentials("[Removed]", "[Removed]")
            };

            var repository = new GitRepository(client);

            var result = repository.Get("src/Scribble.Tests/TestFiles/sample.md");

            result.Should().Be("# Test\n");
        }
    }
}

