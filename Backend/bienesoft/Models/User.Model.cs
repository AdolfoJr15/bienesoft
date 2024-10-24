using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace bienesoft.models
{
    public class User
    {
        [Key]
        public int User_Id { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        [EmailAddress(ErrorMessage = "Formato de correo electrónico inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La contraseña es requerida")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Cantidad de Sesiones")]
        [Required(ErrorMessage = "Campo {0} es requerido")]
        [Range(0, int.MaxValue, ErrorMessage = "El campo {0} debe ser un número positivo")]
        public int Session_Count { get; set; }

        [DisplayName("Token")]
        [StringLength(255, ErrorMessage = "El campo {0} tiene un límite de caracteres de {1}")]
        public string Tok_JWT { get; set; }

        [DisplayName("Bloqueo")]
        public bool Blockade { get; set; }

        public string Leap { get; set; }

        [DisplayName("Tipo de Usuario")]
        [Required(ErrorMessage = "Campo {0} es requerido")]
        public string User_Type { get; set; }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Campo {0} es requerido")]
        public string User_Name { get; set; }

        [DisplayName("Apellido")]
        public string User_Surname { get; set; }

        [DisplayName("Número de Teléfono")]
        [Phone(ErrorMessage = "Formato de teléfono inválido")]
        public string Phone_Number { get; set; }

        [DisplayName("Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        public string Date_Birth { get; set; }

        public bool Asset { get; set; }
    }

    public class ResetPassUser
    {
        [Required(ErrorMessage = "El correo es requerido")]
        [EmailAddress(ErrorMessage = "Formato de correo electrónico inválido")]
        public string Email { get; set; }
    }
}

