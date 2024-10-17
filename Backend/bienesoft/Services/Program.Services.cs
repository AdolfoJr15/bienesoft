//using bienesoft.Models;

//namespace bienesoft.Services
//{
//    public class ProgramServices
//    {
//        private readonly AppDbContext _context;
//        public ProgramServices(AppDbContext context)
//        {
//            _context = context;
//        }
//        public IEnumerable<Program> GetProgram()
//        {
//            return _context.program.ToList();
//        }
//        public void AddProgram(Program program)
//        {
//            _context.program.Add(program);
//            _context.SaveChanges();
//        }
//    }
//}
