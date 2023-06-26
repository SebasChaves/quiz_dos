
using FrontEnd.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace FrontEnd.Helpers
{
    public class EmpleadoHelper
    {
        private ServiceRepository ServiceRepository;


        public EmpleadoHelper()
        {
            ServiceRepository= new ServiceRepository();
        }



        public List<EmpleadoViewModel> GetAll()
        {
            List<EmpleadoViewModel> lista;


            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/Empleado/");
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            lista= JsonConvert.DeserializeObject<List<EmpleadoViewModel>>(content);



            return lista;
        }

        public EmpleadoViewModel Get(int id)
        {
            EmpleadoViewModel factura;


            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/Empleado/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            factura = JsonConvert.DeserializeObject<EmpleadoViewModel>(content);



            return factura;
        }


        public EmpleadoViewModel Create(EmpleadoViewModel factura) {


            EmpleadoViewModel Factura;


            HttpResponseMessage responseMessage = ServiceRepository.PostResponse("api/Empleado/", factura);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Factura = JsonConvert.DeserializeObject<EmpleadoViewModel>(content);



            return Factura;
        }




        public EmpleadoViewModel Edit(EmpleadoViewModel factura)
        {


            EmpleadoViewModel Factura;


            HttpResponseMessage responseMessage = ServiceRepository.PutResponse("api/Empleado/", factura);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Factura = JsonConvert.DeserializeObject<EmpleadoViewModel>(content);



            return Factura;
        }



        public EmpleadoViewModel Delete(int id)
        {


            EmpleadoViewModel Factura;


            HttpResponseMessage responseMessage = ServiceRepository.DeleteResponse("api/Empleado/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Factura = JsonConvert.DeserializeObject<EmpleadoViewModel>(content);



            return Factura;
        }

    } 




    }

