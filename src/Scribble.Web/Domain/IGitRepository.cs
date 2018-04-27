namespace Scribble.Web.Domain
{
    public interface IGitRepository
    {
        string Get(string path);
    }
}