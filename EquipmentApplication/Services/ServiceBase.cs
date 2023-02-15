using EquipmentApplication.Interfaces;
using EquipmentApplication.Model;

namespace EquipmentApplication.Services
{
    public class ServiceBase<T> : ICrud<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public ServiceBase(ApplicationDbContext context)
        {
            _context = context;
        }

        protected IQueryable<T> Entities { get => _context.Set<T>(); }

        public bool Add(T entity)
        {
            try
            {
                _context.Set<T>().Add(entity);

                return _context.SaveChanges() != 0;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                _context.Set<T>().Remove(entity);

                return _context.SaveChanges() != 0;
            }
            catch
            {
                return false;
            }
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id) => _context.Set<T>().Find(id);

        public bool Update(T entity)
        {
            try
            {
                _context.Set<T>().Update(entity);

                return _context.SaveChanges() != 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
