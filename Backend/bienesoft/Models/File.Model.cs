using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace bienesoft.Models
{
    public class FileModel
    {
        [Key]
        public int File_Id { get; set; }

        [DisplayName("Numero de Ficha")]
        [Required(ErrorMessage = "Se requiere este campo")]
        [Range(0, 20, ErrorMessage = "El campo {0} solo permite {1} caracteres")]
        public int File_Number { get; set; }

        [DisplayName("Cantidad de aprendices")]
        [Required(ErrorMessage = "Se requiere este campo")]
        [Range(0, 20, ErrorMessage = "El campo {0} solo permite {1} caracteres")]
        public int Apprentice_count { get; set; }

        [DisplayName("Fecha de Inicio")]
        [Required(ErrorMessage = "Se requiere este campo")]
        [Range(0, 20, ErrorMessage = "El campo {0} solo permite {1} caracteres")]
        public DateTime Start_Date { get; set; }

        [DisplayName("Fecha de Fin")]
        [Required(ErrorMessage = "Se requiere este campo")]
        [Range(0, 20, ErrorMessage = "El campo {0} solo permite {1} caracteres")]
        public DateTime End_Date { get; set; }
    }
}
