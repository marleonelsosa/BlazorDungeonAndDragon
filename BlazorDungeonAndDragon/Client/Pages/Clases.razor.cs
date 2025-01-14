﻿using BlazorDungeonAndDragon.Client.Repositorios;
using BlazorDungeonAndDragon.Client.Shared;
using BlazorDungeonAndDragon.Shared.Entidades;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDungeonAndDragon.Client.Pages
{
    public partial class Clases
    {
        [Inject] IRepositorio Repositorio { get; set; }
        private List<Clase> clases;
        private Mensaje mensaje;
        Clase claseParaAgregar;

        protected override void OnInitialized()
        {
            clases = Repositorio.ObtenerClases();
        }

        void AgregarClase()
        {
            //clases.Add(new Clase() { Nombre = "Clérigo", PuntosDeGolpe = 8, Descripcion = "Los clérigos son intermediarios entre el mundo mortal y los distantes planos divinos. Tan diferentes entre ellos como los dioses a los que sirven, los clérigos se esfuerzan por personificar las obras de sus deidades. No son sacerdotes ordinarios, un clérigo se encuentra imbuido de magia divina." });
            claseParaAgregar = Repositorio.AgregarClase();
            if (!clases.Contains(claseParaAgregar))
            {
                clases.Add(claseParaAgregar);
            }
            else
            {
                claseParaAgregar = null;
                mensaje.Mostrar();
            }          
        }
    }
}
