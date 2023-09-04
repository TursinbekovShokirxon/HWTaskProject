using System.Threading.Tasks;

namespace Application.Interface
{
    public interface InterfaceForCrudBase<T>
    {
        public void Create();
        public IEnumerable<T> GetAll();
        public void GetById();
        public void Update();
        public void Delete();
    }
}
