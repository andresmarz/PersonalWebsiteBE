namespace PersonalWebsiteBE.Models
{
    public class Message
    {
        public int Id { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string Email { get; set; }

        public string Telefono { get; set; }

        public string Mensaje { get; set; }

        public DateTime Fecha { get; set; }
    }
}