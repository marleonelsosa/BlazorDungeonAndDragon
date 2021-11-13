using BlazorDungeonAndDragon.Client.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDungeonAndDragon.Client.Pages
{
    partial class Test: ComponentBase
    {
        private string test = string.Empty;
        private string test2 = string.Empty;
        protected override async Task OnInitializedAsync()
        {
            TestService testService = new TestService();
            test = testService.LlenarTest("Matsi");
            test2 = testService.LlenarTest("Mathi");
            test2 = string.Empty;

            //await Task.WhenAll(LlenarTest(), LlenarTest2());
            //StateHasChanged();
            await Task.Delay(3000);
            test = "Hola Maxiiiiiii";
        }
        //private async Task LlenarTest()
        //{
        //    TestService testService = new TestService();
        //    test = testService.LlenarTest("Matsi");
        //}
        //private async Task LlenarTest2()
        //{
        //    TestService testService = new TestService();
        //    test2 = testService.LlenarTest("Mathi");
        //}
    }
}
