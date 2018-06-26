// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zapappi.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SMSResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the SMSResponseModel class.
        /// </summary>
        public SMSResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SMSResponseModel class.
        /// </summary>
        /// <param name="status">Possible values include: 'Queued', 'Sent',
        /// 'Delivered', 'Failed', 'SentToNetwork', 'NetworkAccepted'</param>
        public SMSResponseModel(string messageId = default(string), string status = default(string))
        {
            MessageId = messageId;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MessageId")]
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Queued', 'Sent',
        /// 'Delivered', 'Failed', 'SentToNetwork', 'NetworkAccepted'
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public string Status { get; set; }

    }
}