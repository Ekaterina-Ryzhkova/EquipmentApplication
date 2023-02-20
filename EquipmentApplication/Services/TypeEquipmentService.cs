using EquipmentApplication.Model;
using EquipmentApplication.Shared;

namespace EquipmentApplication.Services
{
    public class TypeEquipmentService : ServiceBase<TypeEquipment>
    {
        public TypeEquipmentService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
