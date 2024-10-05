using YTCFullApplication.Shared;

namespace YTCFullApplication.Domain
{
    public class Studente : Entity<int>
    {

        public string Nome { get; set; } = string.Empty;
        public string Cognome { get; set; } = string.Empty;
        public DateOnly DataNascita { get; set; }

    }
}
