using TaxiManager9000.DataAccess;
using TaxiManager9000.DataAccess.Interfaces;
using TaxiManager9000.Domain.Models;
using TaxiManager9000.Services.Interfaces;

namespace TaxiManager9000.Services.Services
{
    public class UserService : ServiceBase<User>, IUserService
    {
        //private IGenericDb<User> _db;

        //public UserService()
        //{
        //    _db = new GenericDb<User>();
        //}
        

    }
}
