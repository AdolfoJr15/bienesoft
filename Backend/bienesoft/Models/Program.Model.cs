<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;

namespace Bienesoft.Models
{
    public class Program
    {
        public int Program_Id { get; set; }
        public string Program_Name  { get; set; }
        public int File_Id { get; set; }

=======
﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Bienesoft.Models
{
    public class ProgramModel
    {
        [Key]public int Program_Id { get; set; }
        public string Name_Program { get; set; }
        public int Id_File { get; set; }
>>>>>>> 64461c392736522cbfe87334807d176ce0a35131
    }
}
