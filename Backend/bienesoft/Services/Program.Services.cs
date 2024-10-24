using bienesoft.Models;
using Bienesoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bienesoft.Models
{
    public class ProgramServices
    {
        private readonly AppDbContext _context;

        public ProgramServices(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ProgramModel> GetPrograms()
        {
            return _context.program.ToList(); // Asegúrate de que 'program' es el DbSet correcto en tu contexto.
        }

        public void AddProgram(ProgramModel program)
        {
            if (program == null)
            {
                throw new ArgumentNullException(nameof(program), "El modelo de Program no puede ser nulo.");
            }

            _context.program.Add(program); // Asegúrate de que 'program' es el DbSet correcto.
            _context.SaveChanges();
        }

        public ProgramModel GetById(int id)
        {
            var program = _context.program.FirstOrDefault(p => p.Program_Id == id);
            if (program == null)
            {
                throw new KeyNotFoundException($"El programa con el ID {id} no se encontró en la base de datos.");
            }
            return program;
        }

        public void Delete(int id)
        {
            var program = _context.program.FirstOrDefault(p => p.Program_Id == id);
            if (program == null)
            {
                throw new KeyNotFoundException($"El programa con el ID {id} no se pudo encontrar.");
            }

            try
            {
                _context.program.Remove(program); // Asegúrate de que 'program' es el DbSet correcto.
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminar el programa: " + ex.Message);
            }
        }

        public void UpdateProgram(ProgramModel program)
        {
            if (program == null)
            {
                throw new ArgumentNullException(nameof(program), "El modelo de Program es nulo.");
            }

            var existingProgram = _context.program.Find(program.Program_Id);
            if (existingProgram == null)
            {
                throw new KeyNotFoundException($"El programa con el ID {program.Program_Id} no se encontró.");
            }

            existingProgram.Program_Name = program.Program_Name;
            existingProgram.File_Id = program.File_Id; // Actualiza otros campos según sea necesario.

            _context.SaveChanges();
        }
    }
}
