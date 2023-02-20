using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EquipmentApplication.Shared
{
    [Keyless]
    [NotMapped]
    public class TypeEquipment
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; } = string.Empty;
    }
}
