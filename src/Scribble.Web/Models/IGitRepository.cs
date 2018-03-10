namespace Scribble.Web.Models
{
    public interface IGitRepository
    {
        string Get(string path);
    }
}