using HolaMundoCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolaMundoCore.Services
{
    public class PaisRepositorioEnMemoria
    {


        public List<Pais> obtenerTodos()
        {
            List<Pais> pais = new List<Pais>()
            {
                new Pais
                {
                    Id = 1,
                    Nombre= "Venezuela"
                },

                new Pais
                {
                    Id = 2,
                    Nombre= "Colombia"
                },

                new Pais
                {
                    Id = 3,
                    Nombre= "Mexico"
                },
            };


            return pais;
        }
    }
}
