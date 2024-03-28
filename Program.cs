using System;
using System.ComponentModel;
using System.Threading.Tasks;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!!");

app.Run();

partial class Program{

    static async void Main(string[] args){
        await avoidMethods.RunTaskAsync();
        await avoidMethods.ConfigureAwaitExampleAsync();
        avoidMethods.GetResult();

    }

}


