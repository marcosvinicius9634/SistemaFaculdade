using SistemaNassau.Data.Context;
using SistemaNassau.Domain.Entities;
using SistemaNassau.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNassau.Infra.Repositores
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(BancoDbContext context): base(context){}

        public IEnumerable<User> GetAll()
        {
            return Query(x => !x.IsDeleted == false);
        }
    }

}
