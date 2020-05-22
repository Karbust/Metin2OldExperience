using BaseLib;
using LegacyMetin2.Server.Auth;
using LegacyMetin2.Server.Game;
using System;

namespace LegacyMetin2
{
    class Program : BaseProgram
    {
        protected override void OnInit()
        {
            Console.Title = "Metin2 2005 Master Emulator";

            Console.WriteLine("########################################################");
            Console.WriteLine("##  Chinese CBT Server emulator for Metin2            ##");
            Console.WriteLine("##  https://github.com/arves100/Metin2OldExperience   ##");
            Console.WriteLine("##  Author: Arves100                                  ##");
            Console.WriteLine("########################################################");
        }

        protected override void OnStart()
        {
            Console.WriteLine("Type 'help' for a list of commands");
        }

        protected override void Register(ServerManager manager)
        {
            manager.Add(new ServerInfo
            {
                Ip = "127.0.0.1",
                Port = 55551,
                Type = typeof(AuthServer),
                MaxConnections = 100,
            });

            manager.Add(new ServerInfo
            {
                Ip = "127.0.0.1",
                Port = 50000,
                Type = typeof(GameServer),
                MaxConnections = 100,
            });
        }

        static void Main(string[] args) => new Program().Start(args);
    }
}
