using _04_Factory.Exercice;
using Xunit;

namespace _03_Factory
{
    public class Enonce
    {
        [Fact]
        public void _01_Creer_une_classe_XmlLogger_avec_une_methode_Log()
        {
            var xmlLogger = new XmlLogger();

            var log = xmlLogger.Log("mon log");

            Assert.Equal("<log>mon log</log>", log);
        }

        [Fact]
        public void _02_Creer_une_classe_JsonLogger_avec_une_methode_Log()
        {
            var jsonLogger = new JsonLogger();

            var log = jsonLogger.Log("mon log");

            Assert.Equal("{Log:'mon log'}", log);
        }

        [Fact]
        public void _03_Creer_une_interface_ILogger_avec_une_methode_Log_pour_unifier_XmlLogger_et_JsonLogger()
        {
            ILogger xmlLogger = new XmlLogger();

            ILogger jsonLogger = new JsonLogger();

            Assert.Equal("<log>mon log</log>", xmlLogger.Log("mon log"));

            Assert.Equal("{Log:'mon log'}", jsonLogger.Log("mon log"));
        }

        [Fact]
        public void _04_Creer_une_classe_Logger_avec_une_methode_statique_Create()
        {
            ILogger xmlLogger = Logger.Create(LoggerType.Xml);

            Assert.Equal("<log>mon log</log>", xmlLogger.Log("mon log"));

            ILogger jsonLogger = Logger.Create(LoggerType.Json);

            Assert.Equal("{Log:'mon log'}", jsonLogger.Log("mon log"));
        }
    }
}

