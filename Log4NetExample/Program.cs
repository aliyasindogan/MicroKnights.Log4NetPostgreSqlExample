using log4net;
using log4net.Config;
using System.IO;
using System.Linq;
using System.Reflection;
using DataAccess;

namespace Log4NetExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Migration da oluşturuken bu kodu aktifleştiriniz.
            using (PostgreSqlDbContext context = new PostgreSqlDbContext())
            {
                var list = context.log.ToList();
            }
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());

            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
            var logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            logger.Error("Hello World111!");
        }
    }
}