using YTCFullApplication.Shared;

namespace YTCFullApplication.Domain
{
    public class Materia : Entity<Guid>
    {
        public string Nome { get; set; }
        public virtual ICollection<Abbinamento>? Abbinamenti { get; set; }
    }
}
