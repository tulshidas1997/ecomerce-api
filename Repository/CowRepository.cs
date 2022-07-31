using Core.Interfaces.Repositories;
using Core.Models;
using Repositories.Context;

namespace Repositories
{
    public class CowRepository : BaseRepository<Cow>, ICowRepository
    {
        public CowRepository(AppDbContext context) : base(context)
        {

        }
    }
}