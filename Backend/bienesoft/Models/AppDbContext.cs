﻿using bienesoft.models;
using Bienesoft.Models;
using Microsoft.EntityFrameworkCore;

namespace bienesoft.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        //Agrega tus DbSet para las entidades
        public DbSet<Apprentice> apprentice { get; set; }
        public DbSet<FileModel> file { get; set; }
        public DbSet<Area> area { get; set; }
        public DbSet<Permission> permission { get; set; }
        public DbSet<Attendant> attendant { get; set; }
        public DbSet<ProgramModel> program { get; set; }
        public DbSet<User> user { get; set; }
        public DbSet<Department>department { get; set; }
        public DbSet<Locality> locality { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Database=Bienesoft;User=root;Password=argeol1234;Port=3306",
                    new MySqlServerVersion(new Version(8,0,23)));
            }

        }
    }


}
