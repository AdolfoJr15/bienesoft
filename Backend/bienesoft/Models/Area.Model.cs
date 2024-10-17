using System.ComponentModel.DataAnnotations;

namespace Bienesoft.Models
{
    public class Area
    {
        [Key]
        public int Area_Id { get; set; }
        public string Area_Name { get; set; }

    }
}