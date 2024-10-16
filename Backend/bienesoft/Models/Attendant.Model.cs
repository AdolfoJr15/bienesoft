using System.ComponentModel.DataAnnotations;

namespace Bienesoft.Models
{
    public class Attendant
    {
            [Key]
            public int Attendant_Id { get; set; }
            public string Attendant_Name { get; set; }
            public string Attendant_Surname { get; set; }
            public int Attendant_Phone { get; set; }
            public string Attendant_Address { get; set; }
            public string Attendant_Email { get; set; }
            public int Attendant_Age { get; set; }
    }


}

