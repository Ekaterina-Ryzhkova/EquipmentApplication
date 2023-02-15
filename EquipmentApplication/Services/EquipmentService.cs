using EquipmentApplication.Model;

namespace EquipmentApplication.Services
{
    public class EquipmentService : ServiceBase<Equipment>
    {
        public EquipmentService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
