using Microsoft.AspNetCore.Builder;
using WebApp.MultiLayer;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<MultiLayerWebTestModule>();

public partial class Program
{
}
