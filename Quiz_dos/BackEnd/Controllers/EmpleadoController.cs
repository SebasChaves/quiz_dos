using DAL.Implementations;
using DAL.Interfaces;
using BackEnd.Models;
using Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly ILogger<EmpleadoController> logger;
        private IEmpleadoDAL facturaDAL;
        public EmpleadoController(ILogger<EmpleadoController> logger)
        {
            facturaDAL = new EmpleadoDALImpl(new Entities.QuizContext());
            this.logger = logger;
        }


 
        private EmpleadoModel Convertir(Empleado entity)
        {
            return new EmpleadoModel
            {
                EmpleadoId = entity.EmpleadoId,
                Nombre = entity.Nombre,
                Salario = entity.Salario
            };
        }


        private Empleado Convertir(EmpleadoModel entity)
        {
            return new Empleado
            {
                EmpleadoId = entity.EmpleadoId,
                Nombre = entity.Nombre,
                Salario = entity.Salario
            };
        }

        // GET: api/<EmpleadoController>
        [HttpGet]
        public JsonResult Get()
        {
            try
            {
                IEnumerable<Empleado> facturas = facturaDAL.GetAll();

                List<EmpleadoModel> lista = new List<EmpleadoModel>();

                foreach (var factura in facturas)
                {
                    lista.Add(Convertir(factura)

                        );
                }
                return new JsonResult(lista);
            }
            catch (Exception e)
            {
                return new JsonResult(null);
            }


        }

        // GET api/<EmpleadoController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Empleado factura = facturaDAL.Get(id);
            return new JsonResult(factura);
        }

        // POST api/<EmpleadoController>
        [HttpPost]
        public JsonResult Post([FromBody] EmpleadoModel value)
        {
            Empleado entity = Convertir(value);
            facturaDAL.Add(entity);
            return new JsonResult(Convertir(entity));
        }

        // PUT api/<EmpleadoController>/5
        [HttpPut]
        public JsonResult Put([FromBody] EmpleadoModel value)
        {

            facturaDAL.Update(Convertir(value));
            return new JsonResult(Convertir(value));
        }

        // DELETE api/<EmpleadoController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Empleado factura = new Empleado{ EmpleadoId= id };
            facturaDAL.Remove(factura);

            return new JsonResult(Convertir(factura));
        }
    }
}