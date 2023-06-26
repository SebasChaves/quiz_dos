using System;
using System.Collections.Generic;

namespace FrontEnd.Models
{
    public partial class EmpleadoViewModel
    {
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; } = null!;
        public double Salario { get; set; }
    }
}
