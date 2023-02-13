using System.ComponentModel.DataAnnotations;

namespace EquipmentApplication.Model
{
    public class ResponsePerson
    {
        [Key]
        [Required]
        public int PersonId { get; set; }
        public string Initials { get; set; } = string.Empty;
    }
}
