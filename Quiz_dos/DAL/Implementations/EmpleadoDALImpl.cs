using DAL.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class EmpleadoDALImpl : IEmpleadoDAL
    {
        QuizContext context;


        public EmpleadoDALImpl()
        {
            context = new QuizContext();

        }

        public EmpleadoDALImpl(QuizContext _Context)
        {
            context = _Context;

        }


        public bool Add(Empleado entity)
        {
            try
            {
                using (UnidadDeTrabajo<Empleado> unidad = new UnidadDeTrabajo<Empleado>(context))
                {
                    unidad.genericDAL.Add(entity);
                    unidad.Complete();
                }


                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void AddRange(IEnumerable<Empleado> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Empleado> Find(Expression<Func<Empleado, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Empleado Get(int id)
        {
            Empleado empleado;
            using (UnidadDeTrabajo<Empleado> unidad = new UnidadDeTrabajo<Empleado>(context))
            {

                empleado = unidad.genericDAL.Get(id);
            }
            return empleado;
        }

        public IEnumerable<Empleado> GetAll()
        {
            try
            {
                IEnumerable<Empleado> empleados;
                using (UnidadDeTrabajo<Empleado> unidad = new UnidadDeTrabajo<Empleado>(context))
                {
                    empleados = unidad.genericDAL.GetAll();
                }
                return empleados;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Remove(Empleado entity)
        {
            try
            {
                using (UnidadDeTrabajo<Empleado> unidad = new UnidadDeTrabajo<Empleado>(context))
                {
                    unidad.genericDAL.Remove(entity);
                    unidad.Complete();
                }


                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void RemoveRange(IEnumerable<Empleado> entities)
        {
            throw new NotImplementedException();
        }

        public Empleado SingleOrDefault(Expression<Func<Empleado, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(Empleado entity)
        {
            try
            {
                using (UnidadDeTrabajo<Empleado> unidad = new UnidadDeTrabajo<Empleado>(context))
                {
                    unidad.genericDAL.Update(entity);
                    unidad.Complete();
                }


                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
