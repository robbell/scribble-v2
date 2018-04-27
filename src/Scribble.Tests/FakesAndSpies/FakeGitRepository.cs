using Scribble.Web.Domain;

namespace Scribble.Tests.FakesAndSpies
{
    public class FakeGitRepository : IGitRepository
    {
        public string Get(string path)
        {
            return "My post body";
        }
    }
}