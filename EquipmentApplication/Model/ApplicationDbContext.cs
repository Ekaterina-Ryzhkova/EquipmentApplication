using EquipmentApplication.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EquipmentApplication.Model
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Equipment> Equipment { get; set; } = null!;
        public DbSet<TypeEquipment> TypeEquipment { get; set; } = null!;
        public DbSet<ResponsePerson> ResponsePerson { get; set; } = null!;
    }
}
