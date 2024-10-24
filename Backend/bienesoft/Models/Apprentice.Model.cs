using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace bienesoft.Models
{
    public class Responsible
    {
        [Key]
        public int Apprentice_Id { get; set; }

        [DisplayName("Nombre del Aprendiz")]
        [Required(ErrorMessage = "Campo {0} es requerido")]
        [StringLength(100,ErrorMessage ="El campo {0} tiene un limite de caracteres de {1}")]
        public string Apprentice_Name { get; set; }

        [DisplayName("Numero de Telefono")]
        [Required(ErrorMessage ="Campo {0} es requerido")]
        [StringLength(100, ErrorMessage = "El campo {0} tiene un limite de caracteres de {1}")]
        public string Apprentice_Phone { get; set; }

        [DisplayName("Tipo de Aprendiz")]
        [Required(ErrorMessage = "Campo {0} es requerido")]
        [StringLength(100, ErrorMessage = "El campo {0} tiene un limite de caracteres de {1}")]

        public string Apprentice_Type { get; set; }

 
    }
}
