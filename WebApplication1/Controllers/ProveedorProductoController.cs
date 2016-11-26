using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class ProveedorProductoController : ApiController
    {

        private NorthwindEntities db = new NorthwindEntities();

        [HttpGet]
        public IEnumerable<Proveedor_Producto_Result> Get(int Id)
        {

            return db.Proveedor_Producto(Id).AsEnumerable();

            
        }
    }
}
