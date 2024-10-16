using System.ComponentModel.DataAnnotations;

namespace bienesoft.Models
{
    public class FileModel
    {
        [Key]
        public int File_Id { get; set; }

        public int File_Number { get; set; }

        public int Apprentice_count_File { get; set; }

        public DateTime Start_Date { get; set; }

        public DateTime End_Date {  get; set; }
    }
}
