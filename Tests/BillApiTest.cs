using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bill.Controllers;
using System.Web.Http.Results;

namespace Tests
{
    [TestClass]
    public class BillApiTest
    {
        [TestMethod]
        public void TestAPICall()
        {
            BillController billApi = new BillController();
            var response = billApi.GetBill() as OkNegotiatedContentResult<Bill.Models.Bill>;
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Content.CallCharges.Calls.Count > 0);
            Assert.IsTrue(response.Content.Total > 0);
            Assert.IsNotNull(response.Content.SkyStore);
            Assert.IsNotNull(response.Content.CallCharges);
        }
    }
}
