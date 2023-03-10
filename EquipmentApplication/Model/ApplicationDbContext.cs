using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EquipmentApplication.Model
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<TypeEquipment> TypeEquipment { get; set; }
        public DbSet<ResponsePerson> ResponsePerson { get; set; }
    }
}
