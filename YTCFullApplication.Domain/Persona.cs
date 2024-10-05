using YTCFullApplication.Shared;

namespace YTCFullApplication.Domain
{
    public abstract class Persona : ArchiveableEntity<Guid>
    {
        public string Nome { get; set; } = string.Empty;
        public string Cognome { get; set; } = string.Empty;
        public string CognomeNome { get; set; } = string.Empty;
        public string CodiceFiscale { get; set; } = string.Empty;
        public DateOnly DataNascita { get; set; }
    }
}
