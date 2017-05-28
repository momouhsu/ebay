using eBay.Service.Core.Sdk;
using eBay.Service.Core.Soap;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ebay
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }



        static ApiContext apiContext = null;

        public static ApiContext GetApiContext()
        {
            //apiContext is a singleton,
            //to avoid duplicate configuration reading
            if (apiContext != null)
            {
                return apiContext;
            }
            else
            {
                apiContext = new ApiContext();

                //set Api Server Url
                apiContext.SoapApiServerUrl =
                    ConfigurationManager.AppSettings["Environment.ApiServerUrl"];
                //set Api Token to access eBay Api Server
                ApiCredential apiCredential = new ApiCredential();
                apiCredential.eBayToken =
                    ConfigurationManager.AppSettings["UserAccount.ApiToken"];
                apiContext.ApiCredential = apiCredential;
                apiContext.ApiCredential.ApiAccount.Application =
                    ConfigurationManager.AppSettings["Application"];
                apiContext.ApiCredential.ApiAccount.Certificate =
                    ConfigurationManager.AppSettings["Certificate"];
                apiContext.ApiCredential.ApiAccount.Developer =
                    ConfigurationManager.AppSettings["Developer"];
                //set eBay Site target to US
                apiContext.Site = SiteCodeType.US;

                return apiContext;
            }
        }


    }
}
