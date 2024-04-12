using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Persistence.Contexts;
using Domain.Entities;

namespace Persistence.Repositories
{
    public class ModelRepository : EfRepositoryBase<Model, BaseDbContext>, IModelRepository
    {
        public ModelRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
