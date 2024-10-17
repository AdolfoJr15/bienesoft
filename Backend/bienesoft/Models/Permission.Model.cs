using System.ComponentModel.DataAnnotations;

namespace Bienesoft.Models
{
    public class Permission
    {
        [Key]
        public int Permission_Id { get; set; }
        public int Apprentice_Id { get; set; }
        public int Signature_Id { get; set; }
        public DateTime Departure_Date { get; set; }
        public DateTime Entry_Date { get; set; }
        public DateTime Application_Date { get; set; }
    }
}
