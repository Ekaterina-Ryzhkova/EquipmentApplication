using EquipmentApplication.Model;

namespace EquipmentApplication.Services
{
    public class ResponsePersonService : ServiceBase<ResponsePerson>
    {
        public ResponsePersonService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
