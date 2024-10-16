//using bienesoft.Models;
//using Bienesoft.Models;

//namespace bienesoft.Services
//{
//    public class DepartmentServices
//    {
//        private readonly AppDbContext _context;
//        public DepartmentServices(AppDbContext context)
//        {
//            _context = context;
//        }
//        public IEnumerable<Department> AllApprentice()
//        {
//            return _context.department.ToList();
//        }
//        public void AddDepartment(Department department)
//        {
//            _context.department.Add(department);
//            _context.SaveChanges();
//        }
//        public Department GetById(int id)
//        {
//            return _context.department.FirstOrDefault(p => p.Department_Id == id);
//        }
//        public void Delete(int id)
//        {
//            var department = _context.apprentice.FirstOrDefault(p => p.Apprentice_Id == id);
//            if (department != null)
//            {
//                try
//                {
//                    _context.department.Remove(department);
//                    _context.SaveChanges();
//                }
//                catch (Exception ex)
//                {
//                    throw new Exception("No Se Pudo Eliminar El Department" + ex.Message);
//                }
//            }
//            else
//            {
//                throw new KeyNotFoundException("El Department Con El Id" + id + "No Se Pudo Encontrar");
//            }
//        }
//        public void UpdateDepartment(Department department)
//        {
//            if (department == null)
//            {
//                throw new ArgumentNullException(nameof(Department), "El modelo de Department es nulo");
//            }

//            var existingDepartment = _context.department.Find(department.Department_Id);
//            if (existingDepartment == null)
//            {
//                throw new ArgumentException("Department no encontrado");
//            }

//            existingDepartment.DepartmentName = department.DepartmentName;
//            // Actualiza otros campos según sea necesario

//            _context.SaveChanges();
//        }
//    }
//}
