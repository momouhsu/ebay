using eBay.Service.Call;
using eBay.Service.Core.Sdk;
using eBay.Service.Core.Soap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace ebay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ApiContext apiContext = GetApiContext();
        }


        ApiContext apiContext = null;


        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+ Welcome to eBay SDK for .Net Sample +");
            Console.WriteLine("+ - HelloWorld                        +");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");

            //[Step 1] Initialize eBay ApiContext object
 


            //[Step 2] Create Call object and execute the Call
            GeteBayOfficialTimeCall apiCall = new GeteBayOfficialTimeCall(apiContext);
            Console.WriteLine("Begin to call eBay API, please wait ...");
            DateTime officialTime = apiCall.GeteBayOfficialTime();
            this.textBox1.Text = officialTime.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetOrdersCall apiCall = new GetOrdersCall(apiContext);
            Console.WriteLine("Begin to call eBay API, please wait ...");
            TimeFilter fltr = new TimeFilter();
            fltr.TimeFrom = DateTime.Now.AddDays(-7);
            fltr.TimeTo = DateTime.Now.AddDays(-2);
            OrderTypeCollection list = apiCall.GetOrders(fltr, TradingRoleCodeType.Seller, OrderStatusCodeType.All);


        }

        private void button3_Click(object sender, EventArgs e)
        {

            GetUserCall apiCall = new GetUserCall(apiContext);
            apiCall.DetailLevelList.Add(DetailLevelCodeType.ReturnAll);
            apiCall.Execute();

            Console.WriteLine("UserID: " + apiCall.User.UserID.ToString());
            Console.WriteLine("EIAS Token is: " + apiCall.User.EIASToken.ToString());
            Console.WriteLine();
        }

        /// <summary>
        /// Populate eBay SDK ApiContext object with data from application configuration file
        /// </summary>
        /// <returns>ApiContext</returns>
        ApiContext GetApiContext()
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
                //set eBay Site target to US
                apiContext.Site = SiteCodeType.US;

                return apiContext;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           

        }
    }
}
