using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bienesoft.Models
{
    public class Permission
    {
        [Key]
        public int Permission_Id { get; set; }

        [DisplayName("Id del Aprendiz")]
        [Required(ErrorMessage = "Se requiere este campo")]
        [Range(0, 20, ErrorMessage = "El campo {0} solo permite {1} caracteres")]
        public int Apprentice_Id { get; set; }

        [DisplayName("Fecha de Salida")]
        [Required(ErrorMessage = "Se requiere este campo")]
        [Range(0, 20, ErrorMessage = "El campo {0} solo permite {1} caracteres")]
        public DateTime Departure_Date { get; set; }

        [DisplayName("Fecha de Entrada")]
        [Required(ErrorMessage = "Se requiere este campo")]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Entry_Date { get; set; }

        [DisplayName("Fecha")]
        [Required(ErrorMessage = "Se requiere este campo")]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Application_Date { get; set; }
    }
}
