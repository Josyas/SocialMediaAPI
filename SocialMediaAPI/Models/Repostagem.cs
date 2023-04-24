namespace SocialMediaAPI.Models
{
    public class Repostagem
    {
        public int Id { get; set; }
        public string Republicar { get; set; }
        public DateTime DataRepublicar { get; set; }

        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
    }
}
