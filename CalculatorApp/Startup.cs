using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CalculatorApp.Startup))]
namespace CalculatorApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
