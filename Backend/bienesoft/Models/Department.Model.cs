using System.ComponentModel.DataAnnotations;

namespace Bienesoft.Models
{
    public class Department
    {
        [Key]public int Department_Id { get; set; }
        public string DepartmentName { get; set; }

    }
}

