function pruebaPuntoNetStatic() {
    DotNet.invokeMethodAsync("BlazorDungeonAndDragon.Client", "ObtenerCurrentCount")
        .then(resultado => {
            console.log("conteo desde js " + resultado);
        });
}

function pruebaPuntoNETInstancia(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}