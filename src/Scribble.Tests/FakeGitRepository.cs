using Scribble.Web;
using Scribble.Web.Models;

namespace Scribble.Tests
{
    public class FakeGitRepository : IGitRepository
    {
        public string Get(string path)
        {
            return "My post body";
        }
    }
}