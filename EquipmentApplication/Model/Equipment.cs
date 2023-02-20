using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentApplication.Model
{
    public class Equipment
    {
        public int Id { get; set; }
        public string InventoryId { get; set; }
        public string FullName { get; set; }
        public string Model { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string StorageLocation { get; set; }
        public string DestinationLocation { get; set; }
        public string Comment { get; set; }
        public int TypeId { get; set; }
        [ForeignKey("TypeId")]
        public TypeEquipment TypeEquipment { get; set; }
        public int PersonId { get; set; }
        [ForeignKey("PersonId")]
        public ResponsePerson ResponsePerson { get; set; }
    }
}
