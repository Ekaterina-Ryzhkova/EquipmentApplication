using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentApplication.Model
{
    public class ResponsePerson
    {
        public int Id { get; set; }
        public string? Position { get; set; } 
        public string? FullName { get; set; }

        public List<Equipment> Equipments { get; set; } = new();
    }
}
