﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bienesoft.models
{
        [Table("user", Schema = "bienesoft")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("User_Id")]
        public int User_Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(100, ErrorMessage = "El campo {0} tiene un límite de caracteres de {1}")]
        [EmailAddress(ErrorMessage = "El campo {0} no es una dirección de correo electrónico válida")]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(255, ErrorMessage = "El campo {0} tiene un límite de caracteres de {1}")]
        [DisplayName("Hashed Password")]
        public string HashedPassword { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(255, ErrorMessage = "El campo {0} tiene un límite de caracteres de {1}")]
        [DisplayName("Salt")]
        public string Salt { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(0, int.MaxValue, ErrorMessage = "El campo {0} debe ser un valor positivo")]
        [DefaultValue(0)]
        [DisplayName("Session Count")]
        public int SessionCount { get; set; }

        [StringLength(255, ErrorMessage = "El campo {0} tiene un límite de caracteres de {1}")]
        [DisplayName("Token JWT")]
        public string TokJwt { get; set; }

        [DefaultValue(false)]
        [DisplayName("Blocked")]
        public bool Blockade { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50, ErrorMessage = "El campo {0} tiene un límite de caracteres de {1}")]
        [DisplayName("User Type")]
        public string UserType { get; set; }

        [DefaultValue(true)]
        [DisplayName("Active")]
        public bool Asset { get; set; }
    }

    public class ResetPassUser
    {
        [Required(ErrorMessage = "El correo es requerido")]
        [EmailAddress(ErrorMessage = "Formato de correo electrónico inválido")]
        public string Email { get; set; }
    }

    public class LoginUser
    {
        public string Email { get; set; }
        public string HashedPassword { get; set; }
    }
}
