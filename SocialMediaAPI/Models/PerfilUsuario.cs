namespace SocialMediaAPI.Models
{
    public class PerfilUsuario : NovaPublicacao
    {
        public Usuario Usuario { get; set; }

        public int IdFeedPostagem { get; set; }
        public FeedPostagem FeedPostagem { get; set; }

    }
}
