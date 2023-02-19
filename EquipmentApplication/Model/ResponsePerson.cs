using System.ComponentModel.DataAnnotations;

namespace EquipmentApplication.Model
{
    public class ResponsePerson
    {
        [Key]
        public int PersonId { get; set; }
        public string Initials { get; set; } = string.Empty;
    }
}
