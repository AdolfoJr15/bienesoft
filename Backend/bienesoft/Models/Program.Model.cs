using System.ComponentModel.DataAnnotations;

namespace Bienesoft.Models
{
    public class ProgramModel
    {
        [Key]public int Program_Id { get; set; }
        public string Program_Name  { get; set; }
        public int File_Id { get; set; }

    }
}
