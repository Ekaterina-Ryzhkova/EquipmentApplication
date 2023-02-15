using EquipmentApplication.Model;

namespace EquipmentApplication.Services
{
    public class TypeEquipmentService : ServiceBase<TypeEquipment>
    {
        public TypeEquipmentService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
