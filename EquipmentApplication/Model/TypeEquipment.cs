using System.ComponentModel.DataAnnotations;

namespace EquipmentApplication.Model
{
    public class TypeEquipment
    {
        [Key]
        public int TypeId { get; set; }
        public string TypeName { get; set; } = string.Empty;
    }
}
