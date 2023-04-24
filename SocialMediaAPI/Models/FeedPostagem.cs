namespace SocialMediaAPI.Models
{
    public class FeedPostagem : NovaPublicacao
    {
        public PerfilUsuario PerfilUsuario { get; set; }
        
        public int IdPaginaInicial { get; set; }
        public PaginaInicial PaginaInicial { get; set; }
    }
}
