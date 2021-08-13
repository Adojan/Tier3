using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TierThree.Model;
using TierThree.Networking;
using TierThree.Repository;

namespace TierThree
{
    public class Program
    {
        public async Task Main(string[] args)
        {
            SocketServer socketServer = new SocketServer();
            socketServer.StartServer();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}