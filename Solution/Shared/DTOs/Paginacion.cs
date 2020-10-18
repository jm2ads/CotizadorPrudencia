using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Shared.DTOs
{
    public class Paginacion
    {
        public int Pagina { get; set; } = 1;
        public int CantidadRegistros { get; set; } = 10;
    }
}
