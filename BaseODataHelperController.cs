using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;

namespace ODataHelper.AspNet.Abstractions
{
    public abstract class BaseODataHelperController<TEntity> : ODataController, IODataHelperController<TEntity>
        where TEntity : class
    {
        public abstract ValueTask<IHttpActionResult> Get(ODataQueryOptions<TEntity> options);
        public abstract ValueTask<IHttpActionResult> Get([FromODataUri] object key, ODataQueryOptions<TEntity> options);
        public abstract ValueTask<IHttpActionResult> Post([FromBody] TEntity postEntity);
        public abstract ValueTask<IHttpActionResult> Delete([FromODataUri] object key);
        [AcceptVerbs("PATCH", "MERGE")]
        public abstract ValueTask<IHttpActionResult> Patch([FromODataUri] object key, Delta<TEntity> delta);
        public abstract ValueTask<IHttpActionResult> Put([FromODataUri] object key, TEntity putEntity);
    }
}
