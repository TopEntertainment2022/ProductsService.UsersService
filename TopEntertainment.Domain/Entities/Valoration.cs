namespace TopEntertainment.Domain.Entities
{
    public class Valoration
    {
        public int ValorationId { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public bool Valoracion { get; set; }
        public virtual User user { get; set; }
    }
}
