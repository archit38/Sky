using Newtonsoft.Json;
using Bill.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Bill.Controllers
{
    public class BillController : ApiController
    {
        public readonly string URL = "http://safe-plains-5453.herokuapp.com/bill.json";

        [HttpGet]
        public IHttpActionResult GetBill()
        {
            using (WebClient client = new WebClient())
            {
                string billJson = client.DownloadString(URL);
                var bill = JsonConvert.DeserializeObject<Bill.Models.Bill>(billJson);
                if (bill == null)
                    return NotFound();
                return Ok(bill);     
            }
        }
    }
}