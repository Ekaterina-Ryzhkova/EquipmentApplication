using System.ComponentModel.DataAnnotations;

namespace EquipmentApplication.Model
{
    public class Equipment
    {
        public int Id { get; set; }
        public string InventoryId { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public TypeEquipment TypeEquipment { get; set; }
        public int TypeId { get; set; }
        public string Model { get; set; } = string.Empty;
        public DateTime? DeliveryDate { get; set; }
        public string StorageLocation { get; set; } = string.Empty;
        public string DestinationLocation { get; set; } = string.Empty;
        public ResponsePerson ResponsePerson { get; set; }
        public int PersonId { get; set; }
        public string Comment { get; set; } = string.Empty;
    }
}
