namespace RFIDWeb.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Photo { get; set; } // chemin image
        public string Description { get; set; }
        public string Audio { get; set; } // chemin audio
    }
}
