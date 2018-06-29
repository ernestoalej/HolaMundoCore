using HolaMundoCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolaMundoCore.Services
{
    public interface IRepositorioPais
    {
        List<Pais> ObtenerTodos();
    }
}
