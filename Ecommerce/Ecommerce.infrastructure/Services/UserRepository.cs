using Ecommerce.application.Repository;
using Ecommerce.infrastructure.Presistance;
using ECOMMERCE.DOMAIN;


namespace Ecommerce.infrastructure.Services
{
    public class UserRepository : Repository<User>, IuserRepository
    {
        public UserRepository(DBContextApplication context) : base(context)
        {
        }

    }
}
