using bienesoft.models;
using bienesoft.Models;
using Bienesoft.Models;
using Microsoft.EntityFrameworkCore;

namespace bienesoft.Services
{
    public class UserServices
    {
        private readonly AppDbContext _context;
        public UserServices(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> UserExistsByEmail(string email)
        {
            return await _context.user.AnyAsync(u => u.Email == email);
        }
        public IEnumerable<User> AllUser()
        {
            return _context.user.ToList();
        }
        public void AddUser(User user)
        {
            _context.user.Add(user);
            _context.SaveChanges();
        }
        public User GetById(int id)
        {
            return _context.user.FirstOrDefault(p => p.User_Id == id);
        }
        public void Delete(int id)
        {
            var user = _context.user.FirstOrDefault(p => p.User_Id == id);
            if (user != null)
            {
                try
                {
                    _context.user.Remove(user);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("No Se Pudo Eliminar El User" + ex.Message);
                }
            }
            else
            {
                throw new KeyNotFoundException("El User Con El Id" + id + "No Se Pudo Encontrar");
            }
        }
        public void UpdateUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(User), "El modelo de User es nulo");
            }

            var existingUser = _context.user.Find(user.User_Id);
            if (existingUser == null)
            {
                throw new ArgumentException("User no encontrado");
            }

            existingUser.User_Name = user.User_Name;
            // Actualiza otros campos según sea necesario

            _context.SaveChanges();
        }
        public IEnumerable<User> GetAttendantsByCriteria(string criteria)
        {
            return _context.user
                .Where(a => a.User_Name.Contains(criteria)) // Puedes modificar esta línea según el criterio
                .ToList();
        }

    }

}

