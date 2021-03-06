//==============================================================================
//
//  This file was auto-generated by a tool using the PayPal REST API schema.
//  More information: https://developer.paypal.com/docs/api/
//
//==============================================================================
using Newtonsoft.Json;
using PayPal.Util;

namespace PayPal.Api
{
    public class Sale : PayPalResourceObject
    {
        /// <summary>
        /// Identifier of the sale transaction.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string id { get; set; }

        /// <summary>
        /// Identifier to the purchase unit corresponding to this sale transaction.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "purchase_unit_reference_id")]
        public string purchase_unit_reference_id { get; set; }

        /// <summary>
        /// Amount being collected.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public Amount amount { get; set; }

        /// <summary>
        /// specifies payment mode of the transaction
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_mode")]
        public string payment_mode { get; set; }

        /// <summary>
        /// State of the sale transaction.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state")]
        public string state { get; set; }

        /// <summary>
        /// Reason code for the transaction state being Pending or Reversed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reason_code")]
        public string reason_code { get; set; }

        /// <summary>
        /// Protection Eligibility of the Payer 
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "protection_eligibility")]
        public string protection_eligibility { get; set; }

        /// <summary>
        /// Protection Eligibility Type of the Payer 
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "protection_eligibility_type")]
        public string protection_eligibility_type { get; set; }

        /// <summary>
        /// Expected clearing time for eCheck Transactions
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "clearing_time")]
        public string clearing_time { get; set; }

        /// <summary>
        /// ID of the Payment resource that this transaction is based on.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parent_payment")]
        public string parent_payment { get; set; }

        /// <summary>
        /// Time the resource was created in UTC ISO8601 format.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "create_time")]
        public string create_time { get; set; }

        /// <summary>
        /// Time the resource was last updated in UTC ISO8601 format.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "update_time")]
        public string update_time { get; set; }

        /// <summary>
        /// Obtain the Sale transaction resource for the given identifier.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <param name="saleId">Identifier of the Payment Resource to obtain the data for.</param>
        /// <returns>Sale</returns>
        public static Sale Get(APIContext apiContext, string saleId)
        {
            // Validate the arguments to be used in the request
            ArgumentValidator.ValidateAndSetupAPIContext(apiContext);
            ArgumentValidator.Validate(saleId, "saleId");

            // Configure and send the request
            var pattern = "v1/payments/sale/{0}";
            var resourcePath = SDKUtil.FormatURIPath(pattern, new object[] { saleId });
            return PayPalResource.ConfigureAndExecute<Sale>(apiContext, HttpMethod.GET, resourcePath);
        }

        /// <summary>
        /// Creates (and processes) a new Refund Transaction added as a related resource.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <param name="refund">Refund</param>
        /// <returns>Refund</returns>
        public Refund Refund(APIContext apiContext, Refund refund)
        {
            return Sale.Refund(apiContext, this.id, refund);
        }

        /// <summary>
        /// Creates (and processes) a new Refund Transaction added as a related resource.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <param name="saleId">ID of the sale to refund.</param>
        /// <param name="refund">Refund</param>
        /// <returns>Refund</returns>
        public static Refund Refund(APIContext apiContext, string saleId, Refund refund)
        {
            // Validate the arguments to be used in the request
            ArgumentValidator.ValidateAndSetupAPIContext(apiContext);
            ArgumentValidator.Validate(saleId, "saleId");
            ArgumentValidator.Validate(refund, "refund");

            // Configure and send the request
            var pattern = "v1/payments/sale/{0}/refund";
            var resourcePath = SDKUtil.FormatURIPath(pattern, new object[] { saleId });
            return PayPalResource.ConfigureAndExecute<Refund>(apiContext, HttpMethod.POST, resourcePath, refund.ConvertToJson());
        }
    }
}
