using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Configuration;
using System.Data.SqlClient;
using System.IO; 

namespace Agenda.DAL.Test
{
    [TestFixture]
    public class BaseTest
    {
        private string _script;
        private string _con;
        private string _catalogTest;

        public BaseTest()
        {
            _script = @"DBAgendaTest_Create.sql";
            _con = ConfigurationManager.ConnectionStrings["conSetupTest"].ConnectionString;
            _catalogTest = ConfigurationManager.ConnectionStrings["conSetupTest"].ProviderName;
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        { 
            // CreateDBTest();
        }


        [OneTimeTearDown]   
        public void OneTimeTearDown()
        {
            // DeleteDBTest();
        }
    }
}
