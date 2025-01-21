using System.Configuration;

using PCAxis.Sql.DbConfig;

namespace ManualTests
{
    [Ignore]
    [TestClass]
    public class ConfigTest
    {


        public ConfigTest()
        {
        }

        [TestMethod]
        public void TestReadsConfig()
        {
            var k = ConfigurationManager.AppSettings["dbconfigFile"];
            Assert.AreEqual("SqlDb.config", k);
        }

        [TestMethod]
        public void TestGetsDefaultDatabase()
        {
            var dbConf = SqlDbConfigsStatic.DefaultDatabase;
            var langCount = dbConf.GetAllLanguages().Count;
            Assert.IsTrue(langCount > 1);
        }

    }
}
