using System;
using Arcaim.DesignPatterns.Decorator;
using Arcaim.DesignPatterns.Factory;
using Arcaim.DesignPatterns.Observer.DotNet;
using Arcaim.DesignPatterns.Observer.Simple;
using Arcaim.DesignPatterns.Strategy;
using Arcaim.DesignPatterns.NullObject;

namespace Arcaim.DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // StrategyClient.Run();
            // ObserverSimpleClient.Run();
            // ObserverDotNetClient.Run();
            // DecoratorClient.Run();
            // SimpleFactoryClient.Run();
            NullObjectClient.Run();
        }
    }
}
