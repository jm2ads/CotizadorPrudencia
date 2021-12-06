﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Shared.Models
{
    public partial class Partner
    {

        public int Id { get; set; }
        public int IdPadre { get; set; }
        public string Type { get; set; }



        public string Url { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Dni { get; set; }

        public string Matricula { get; set; }

        public string Mail { get; set; }

        public string Celular1 { get; set; }
        public string Celular2 { get; set; }

        public string Domicilio { get; set; }

        public string Localidad { get; set; }

        public int ComisionPrima { get; set; }
        public string Logo { get; set; }

        public bool BotonDeseoDarDatos { get; set; }

        public bool Acarreo { get; set; }

        public int GncMonto { get; set; }

        public int Ajuste { get; set; }

        public int DescuentoRecarga { get; set; }

        public string Whatsapp { get; set; }
    }
}
