namespace YTCFullApplication.Domain
{
    public class Docente : Persona
    {
        public virtual ICollection<Abbinamento> Abbinamenti { get; set; }
    }
}