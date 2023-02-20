using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EquipmentApplication.Shared
{
    [Keyless]
    [NotMapped]
    public class ResponsePerson
    {
        public int PersonId { get; set; }
        public string Initials { get; set; } = string.Empty;
    }
}
