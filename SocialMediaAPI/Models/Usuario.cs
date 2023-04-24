namespace SocialMediaAPI.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string? Telefone { get; set; }
        public DateTime DataInscricao { get; set; }
        public bool ContaAtiva { get; set;  }
        public DateTime? DataContaInativa { get; set; }

        public int IdPerfilUsuario { get; set; }
        public PerfilUsuario PerfilUsuario { get; set; }
        public List<Repostagem> Repostagens { get; set; } = new List<Repostagem>();
    }
}
