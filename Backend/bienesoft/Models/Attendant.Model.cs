using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bienesoft.Models
{
    public class Attendant
    {
        [Key]
        public int Attendant_Id { get; set; }

        [DisplayName("Nombre Acudiente")]
        [Required(ErrorMessage = "Se requiere este campo")]
        [StringLength(50, ErrorMessage = "El campo {0} solo permite {1} caracteres")]
        public string Attendant_Name { get; set; }

        [DisplayName("Apellido Acudiente")]
        [Required(ErrorMessage = "Se requiere este campo")]
        [StringLength(50, ErrorMessage = "El campo {0} solo permite {1} caracteres")]
        public string Attendant_Surname { get; set; }

        [DisplayName("Nombre Acudiente")]
        [Required(ErrorMessage = "Se requiere este campo")]
        [Range(0, 12, ErrorMessage = "El campo {0} solo permite {1} caracteres")]
        public int Attendant_Phone { get; set; }

        [DisplayName("Direccion Acudiente")]
        [Required(ErrorMessage = "Se requiere este campo")]
        [StringLength(50, ErrorMessage = "El campo {0} solo permite {1} caracteres")]
        public string Attendant_Adress { get; set; }

        [DisplayName("Email Acudiente")]
        [Required(ErrorMessage = "Se requiere este campo")]
        [StringLength(50, ErrorMessage = "El campo {0} solo permite {1} caracteres")]
        public string Attendant_Email { get; set; }

        [DisplayName("Edad")]
        [Required(ErrorMessage = "Se requiere este campo")]
        [Range(0, 20, ErrorMessage = "El campo {0} solo permite {1} caracteres")]
        public int Attendant_Age { get; set; }
    }
}




