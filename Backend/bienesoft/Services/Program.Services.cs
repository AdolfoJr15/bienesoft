<<<<<<< HEAD
﻿//using bienesoft.Models;

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
=======
﻿using bienesoft.Models;
using Bienesoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bienesoft.Services
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
            return _context.program.ToList(); // Asegúrate de que tu DbSet se llame "Programs"
        }

        public void AddProgram(ProgramModel program)
        {
            _context.program.Add(program);
            _context.SaveChanges();
        }

        public ProgramModel GetById(int id)
        {
            return _context.program.FirstOrDefault(p => p.Program_Id == id);
        }

        public void Delete(int id)
        {
            var program = _context.program.FirstOrDefault(p => p.Program_Id == id);
            if (program != null)
            {
                try
                {
                    _context.program.Remove(program);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("No se pudo eliminar el programa: " + ex.Message);
                }
            }
            else
            {
                throw new KeyNotFoundException("El programa con el ID " + id + " no se pudo encontrar.");
            }
        }

        public void UpdateProgram(ProgramModel program)
        {
            if (program == null)
            {
                throw new ArgumentNullException(nameof(program), "El modelo de programa es nulo.");
            }

            var existingProgram = _context.program.Find(program.Program_Id);
            if (existingProgram == null)
            {
                throw new ArgumentException("Programa no encontrado.");
            }

            existingProgram.Name_Program = program.Name_Program;
            existingProgram.Id_File = program.Id_File; // Actualiza otros campos si es necesario

            _context.SaveChanges();
        }
    }
}
>>>>>>> 64461c392736522cbfe87334807d176ce0a35131
