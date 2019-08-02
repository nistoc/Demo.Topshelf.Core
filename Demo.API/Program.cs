using Demo.API.Services;
using System;
using Topshelf;
using Topshelf.Autofac;

namespace Demo.API
{
    class Program
    {
        static void Main(string[] args)
        {


            HostFactory.Run(x =>
                {
                    x.UseAutofacContainer(CoontainerHolder.Container);

                    x.Service<ServiceManager>(s =>
                    {

                    });
                });
        }
    }
}
