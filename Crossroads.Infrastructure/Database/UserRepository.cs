using System.Collections.Generic;
using System.Linq;

namespace Crossroads.Infrastructure.Database
{
    internal class UserRepository : IBaseRepository<UserEntity>
    {
        public List<UserEntity> GetList()
        {
            using (var context = new Context())
            {
                var items = context.User.ToList();
                return items;
            }
        }
        public UserEntity GetById(long id)
        {
            using (var context = new Context())
            {
                var item = context.User.FirstOrDefault(x => x.ID == id);
                return item;
            }
        }

    }
}
