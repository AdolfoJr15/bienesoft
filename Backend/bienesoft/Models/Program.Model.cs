using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Bienesoft.Models
{
    public class ProgramModel
    {
        [Key]public int Program_Id { get; set; }
        public string Name_Program { get; set; }
        public int Id_File { get; set; }
    }
}
