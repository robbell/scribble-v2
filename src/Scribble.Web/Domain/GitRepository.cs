using System.Linq;
using Octokit;

namespace Scribble.Web.Domain
{
    public class GitRepository : IGitRepository
    {
        private readonly GitHubClient client;

        public GitRepository(GitHubClient client)
        {
            this.client = client;
        }

        public string Get(string path)
        {
            var result = client.Repository.Content.GetAllContents("robbell", "scribble-v2", path).Result
                .FirstOrDefault();

            return result?.Content;
        }
    }
}