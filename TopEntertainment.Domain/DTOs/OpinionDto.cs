namespace TopEntertainment.Domain.DTOs
{
    public class OpinionDto
    {
        public int OpinionId { get; set; }
        public int JuegoId { get; set; }
        public int UserId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
    }
}
