using BlazorDungeonAndDragon.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDungeonAndDragon.Client.Repositorios
{
    public interface IRepositorio
    {
        List<Clase> ObtenerClases();      
        }
    }

