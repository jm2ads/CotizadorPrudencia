using Project.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Shared.DTOs
{
    public class HomePageDTO
    {
        public List<Pelicula> PeliculasEnCartelera { get; set; }
        public List<Pelicula> ProximosEstrenos { get; set; }
    }
}
