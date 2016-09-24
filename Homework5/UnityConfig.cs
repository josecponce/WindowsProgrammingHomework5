using Homework5.Entities;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Homework5 {
    public static class UnityConfig {
        public static IUnityContainer RegisterComponents() {
            IUnityContainer container = new UnityContainer();

            container.RegisterType<ITextFileRepository, TextFileRepository>()
                .RegisterInstance(typeof(IFormatter), new BinaryFormatter());
        
            return container;
        }
    }
}
