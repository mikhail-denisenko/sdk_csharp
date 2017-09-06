using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bunq.Sdk.Model.Generated.Object
{
    /// <summary>
    /// </summary>
    public class DraftPaymentEntry : BunqModel
    {
        /// <summary>
        /// The amount of the payment.
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public Amount Amount { get; set; }

        /// <summary>
        /// The LabelMonetaryAccount containing the public information of the other (counterparty) side of the
        /// DraftPayment.
        /// </summary>
        [JsonProperty(PropertyName = "counterparty_alias")]
        public MonetaryAccountReference CounterpartyAlias { get; set; }

        /// <summary>
        /// The description for the DraftPayment. Maximum 140 characters for DraftPayments to external IBANs, 9000
        /// characters for DraftPayments to only other bunq MonetaryAccounts.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Optional data to be included with the Payment specific to the merchant.
        /// </summary>
        [JsonProperty(PropertyName = "merchant_reference")]
        public string MerchantReference { get; set; }

        /// <summary>
        /// The Attachments attached to the DraftPayment.
        /// </summary>
        [JsonProperty(PropertyName = "attachment")]
        public List<AttachmentMonetaryAccountPayment> Attachment { get; set; }

        /// <summary>
        /// Whether or not sending a bunq.to payment is allowed.
        /// </summary>
        [JsonProperty(PropertyName = "allow_bunqto")]
        public bool? AllowBunqto { get; set; }

        /// <summary>
        /// The id of the draft payment entry.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// The LabelMonetaryAccount containing the public information of 'this' (party) side of the DraftPayment.
        /// </summary>
        [JsonProperty(PropertyName = "alias")]
        public MonetaryAccountReference Alias { get; set; }

        /// <summary>
        /// The type of the draft payment entry.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        public DraftPaymentEntry(Amount amount, MonetaryAccountReference counterpartyAlias, string description)
        {
            Amount = amount;
            CounterpartyAlias = counterpartyAlias;
            Description = description;
        }
    }
}