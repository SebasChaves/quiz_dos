using System;
using System.Collections.Generic;

namespace BackEnd.Models
{
    public partial class EmpleadoModel
    {
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; } = null!;
        public double Salario { get; set; }
    }
}
