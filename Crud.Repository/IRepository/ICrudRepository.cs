using Crud.Repository.DataModels;

namespace Crud.Repository.IRepository
{
    public interface ICrudRepository
    {
        int AddEmployeeDetails(Employee employee);
    }
}
