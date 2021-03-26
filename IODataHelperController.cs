using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;

namespace ODataHelper.AspNet.Abstractions
{
    public interface IODataHelperController<TEntity>
        where TEntity : class
    {
        ValueTask<IHttpActionResult> Get(ODataQueryOptions<TEntity> options);
        ValueTask<IHttpActionResult> Get([FromODataUri] object key, ODataQueryOptions<TEntity> options);
        ValueTask<IHttpActionResult> Post([FromBody]TEntity postEntity);
        ValueTask<IHttpActionResult> Delete([FromODataUri] object key);
        ValueTask<IHttpActionResult> Patch([FromODataUri] object key, Delta<TEntity> delta);
        ValueTask<IHttpActionResult> Put([FromODataUri] object key, TEntity putEntity);
    }
}
