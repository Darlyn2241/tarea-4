using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using BlazorCrub.Server.Models;
using BlazorCrud.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrub.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SerieController : ControllerBase
    {

        private readonly DbcrudContext _dbcrudContext;

        public SerieController(DbcrudContext _dbcrudContext)
        {
            _dbcrudContext = _dbcrudContext;
        }

        [HttpGet]
        [Route("Lista")]

        public async Task<!ActionResult> Lista()
        {
            var responseApi = new ResponseAPI<List<SerieDTO>>();
            var listaDepartamentoDTO = new List<SerieDTO>();


            try
            {
                foreach (var item in await _dbcrudContext.Series.ToListAsync())
                    listaSerieDTO

            }
            catch (Exception ex) {

            }

        }
    }
}
