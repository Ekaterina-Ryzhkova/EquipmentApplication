using System.ComponentModel.DataAnnotations;

namespace EquipmentApplication.Model
{
    public class Equipment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string InventoryId { get; set; } = string.Empty;
        [Required]
        [StringLength(150)]
        public string FullName { get; set; } = string.Empty;
        [Required]
        public TypeEquipment TypeEquipment { get; set; }
        [Required]
        public string Model { get; set; } = string.Empty;
        [Required]
        public DateTime? DeliveryDate { get; set; }
        [Required]
        public string StorageLocation { get; set; } = string.Empty;
        [Required]
        public string DestinationLocation { get; set; } = string.Empty;
        [Required]
        public ResponsePerson ResponsePerson { get; set; }
        public string Comment { get; set; } = string.Empty;
    }
}
