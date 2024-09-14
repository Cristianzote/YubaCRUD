using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using YubaCRUD.Models;

namespace YubaCRUD
{
    public class EstudianteDBContext : DbContext
    {
        //Añadir aqui la connection string de una base de datos sql, puedes añadirla y nombrarla en Employee.Management.Web.Config <connectionStrings>
        public EstudianteDBContext() : base("SomeeSqlDbConnection")
        {
        }
        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}