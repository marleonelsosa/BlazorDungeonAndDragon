using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDungeonAndDragon.Client.Services
{
    public class TestService
    {
        public string LlenarTest(string nombre)
        {
            return $"Hola {nombre}";
        }
    }
}
