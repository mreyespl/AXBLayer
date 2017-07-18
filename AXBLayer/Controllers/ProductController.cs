using AXBLayer.AxServiceRef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace AXBLayer.Controllers
{
    public class ProductController : ApiController
    {
        // GET: api/Product
        public IEnumerable<string> Get()
        {

            try
            {
                ItemServiceClient ProductClient = new ItemServiceClient();
                
                CallContext cc = new CallContext(); 
                cc.Language = "es-mx";
                cc.LogonAsUser = "plcorp\\jpeinado";
                cc.Company = "PL";


                QueryCriteria qc = new QueryCriteria(); 
                CriteriaElement[] qe = { new CriteriaElement() }; 
                qe[0].DataSourceName = "InventTable";
                qe[0].FieldName = "ItemID";
                qe[0].Operator = Operator.NotEqual;
                qe[0].Value1 = "";
                qe[0].Value2 = "";
                qc.CriteriaElement = qe;
                 
                ProductClient.ClientCredentials.Windows.ClientCredential.Domain = "plcorp";
                ProductClient.ClientCredentials.Windows.ClientCredential.Password = "Prensa2017";
                ProductClient.ClientCredentials.Windows.ClientCredential.UserName = "jpeinado";

                //AxdEntity_SalesQuotationTable[] table1 = ProductClient.find(cc, qc);
                AxdEntity_InventTable[] table1 = ProductClient.find(cc, qc);
                 
                /***/
                 
            }
            catch (Exception e)
            {

                return new string[] { e.Message};
            }

            return new string[] { "value1", "value2" };
        }

        // GET: api/Product/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Product
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
