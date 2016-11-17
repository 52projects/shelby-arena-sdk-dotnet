using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shelby.Api;
using Shouldly;

namespace Shelby.Api.Tests.Session {
    [TestClass]
    public class GetSessionTests : BaseTest {
        [TestMethod]
        public void integration_session_get_session() {
            var apiSession = base.GetApiSession();
            apiSession.SessionID.ShouldNotBe(null);
        }
    }
}
