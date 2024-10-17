using System.ComponentModel.DataAnnotations;

namespace bienesoft.Models
{
    public class Apprentice
    {
        [Key]
        public int Apprentice_Id { get; set; }

        public string Apprentice_Name { get; set; }

        public string Apprentice_Phone { get; set; }

        public string Apprentice_Type { get; set; }

        public int Session_Count { get; set; }

        public int Tok_JWT { get; set; }
    }
}
