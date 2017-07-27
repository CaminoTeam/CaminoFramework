using Microsoft.Owin.Cors;
using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaminoServer
{
    public class MdCServer
    {
        public static void Init(string url)
        {
            WebApp.Start<MdCServer>(url);
        }

        public void Configuration(IAppBuilder app)
        {

            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR();
        }
    }
}
