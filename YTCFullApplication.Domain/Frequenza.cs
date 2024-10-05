using YTCFullApplication.Shared;

namespace YTCFullApplication.Domain
{
    public class Frequenza :Entity<Guid>
    {
        public Guid Syudente_Id { get; set; }
        public virtual Studente? Studente { get; set; }

        public Guid Classe_Id { get; set; }
        public virtual Classe? Classe { get; set; }

        public int AnnoScolastico { get; set; }

        public int Esito { get; set; }
    }
}
