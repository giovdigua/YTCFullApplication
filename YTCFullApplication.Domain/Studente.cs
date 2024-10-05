namespace YTCFullApplication.Domain
{
    public class Studente : Persona
    {
        public virtual ICollection<Frequenza>? Frequenze { get; set; }
    }
}
