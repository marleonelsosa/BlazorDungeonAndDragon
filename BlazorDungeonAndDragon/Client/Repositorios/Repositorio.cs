using BlazorDungeonAndDragon.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDungeonAndDragon.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Clase> ObtenerClases()
        {
            {
                return new List<Clase>()
{
            new Clase(){ Nombre = "Guerrero",
                PuntosDeGolpe = 10,
                Imagen = "http://www.clker.com/cliparts/K/f/D/d/k/c/black-sword-and-shield.svg.med.png",
                Descripcion = "Todos los guerreros comparten un dominio magistral de las armas y armaduras, y un exhaustivo conocimiento de las habilidades del combate. Además, están muy relacionados con la muerte, tanto repartiéndola como mirándola fijamente, desafiantes."},

            new Clase(){ Nombre = "Bárbaro",
                PuntosDeGolpe = 12,
                Imagen = "https://us.123rf.com/450wm/martialred/martialred1605/martialred160500095/57038916-battleaxe-or-battle-axe-flat-icon-for-games-and-websites.jpg?ver=6",
                Descripcion = "Para algunos, su rabia brota de la comunión con espíritus de animales salvajes. Otros recurren a su hirviente reserva de ira frente a un mundo lleno de dolor. Para los bárbaros, la furia es un poder que no sólo les proporciona un frenesí ciego en la batalla, sino también extraordinarios reflejos, resistencia y proezas de fuerza."},

            new Clase(){ Nombre = "Mago",
                PuntosDeGolpe = 6,
                Imagen = "https://i.pinimg.com/originals/4d/ac/c1/4dacc171d6eebdda38ebf7320a72f1f1.png",
                Descripcion = "Los magos son los practicantes supremos de la magia, definidos y unidos como una clase por los hechizos que conjuran. A partir de la sutil onda de la magia que impregna el cosmos, los magos lanzan explosivos hechizos de fuego, arcos voltaicos, sutiles engaños y brutales formas de control mental."}
        };
            }
        }
    }
}