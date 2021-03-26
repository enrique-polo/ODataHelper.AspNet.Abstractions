using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;

namespace ODataHelper.AspNet.Abstractions
{
    public abstract class BaseODataHelperRepositoryAdapter<TEntity> : IODataHelperRepositoryAdapter<TEntity>
        where TEntity : class
    {
        public abstract IQueryable<TEntity> AsQueryable();
        public abstract ValueTask<IQueryable> GetAsync(ODataQueryOptions<TEntity> options,
            ODataQuerySettings querySettings, AllowedQueryOptions ignoreQueryOptions);
        public abstract ValueTask<TEntity> GetAsync(object key, ODataQueryOptions<TEntity> options, ODataQuerySettings querySettings, AllowedQueryOptions ignoreQueryOptions);
        public abstract ValueTask<TEntity> InsertAsync(TEntity entity);
        public abstract ValueTask<TEntity> PatchAsync(TEntity entity, Delta<TEntity> delta);
        public abstract ValueTask<TEntity> PutAsync(TEntity entity);
        public abstract ValueTask<int> RemoveAsync(TEntity entity);
        public abstract ValueTask<int> PersistChangesAsync();
    }
}
