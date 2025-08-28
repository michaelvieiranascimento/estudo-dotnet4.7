using Microsoft.EntityFrameworkCore;
using Mvn.Domain.Interfaces.v1;
using Mvn.Infra.SqlServer.Contexts.v1;
using System.Threading;
using System.Threading.Tasks;

namespace Mvn.Infra.SqlServer.Repositories.v1
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;

        public UserRepository(AppDbContext context)
        {
            _dbContext = context;
        }

        public async Task GetUserByLogin(string login, string password, CancellationToken cancellationToken)
        {
            await _dbContext.Users
                .FirstOrDefaultAsync(user => user.Login.Equals(login, System.StringComparison.CurrentCultureIgnoreCase)
                    && user.Password == password, cancellationToken);
        }
    }
}