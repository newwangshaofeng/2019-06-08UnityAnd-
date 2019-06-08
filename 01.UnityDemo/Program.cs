using System;
using System.Configuration;
using Linglan.IBll;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;


namespace _01.UnityDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var container = ContainerConfigurationFromFile("unity.config");

            var classInfo = container.Resolve<IClass>("ConfigClass");
            classInfo.ShowInfo();


            Console.ReadKey();
        }


        private static IUnityContainer ContainerConfigurationFromFile(string configFile)
        {
            //应用程序配置映射
            var fileMap = new ExeConfigurationFileMap {ExeConfigFilename = configFile};

            //从Config文件读取配置
            var configuration =
                ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            var unitySection = (UnityConfigurationSection) configuration.GetSection("unity");
            var container = new UnityContainer().LoadConfiguration(unitySection);

            return container;
        }
    }
}