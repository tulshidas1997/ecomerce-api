using CleanArchitecture.Core.Interfaces.Repositories;
using CleanArchitecture.Repositories.Context;
using Core.Models;

namespace CleanArchitecture.Repositories
{
    public class CowRepository : BaseRepository<Cow>, ICowRepository
    {
        public CowRepository(AppDbContext context) : base(context)
        {

        }
    }
}