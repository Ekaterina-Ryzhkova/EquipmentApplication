using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EquipmentApplication.Model
{
    public class TypeEquipment
    {
        public int Id { get; set; }
        public string? TypeName { get; set; }

        public List<Equipment> Equipments { get; set; } = new();
    }
}
