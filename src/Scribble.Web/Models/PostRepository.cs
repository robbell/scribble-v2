namespace Scribble.Web.Models
{
    public class PostRepository
    {
        private readonly IGitRepository gitRepository;
        private readonly IMarkdownConverter converter;

        public PostRepository(IGitRepository gitRepository, IMarkdownConverter converter)
        {
            this.gitRepository = gitRepository;
            this.converter = converter;
        }

        public Post Get(string path)
        {
            var markdownBody = gitRepository.Get(path);

            var htmlBody = converter.Convert(markdownBody);

            return new Post { Body = htmlBody };
        }
    }
}