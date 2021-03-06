using Bunq.Sdk.Context;
using Bunq.Sdk.Http;
using Bunq.Sdk.Json;
using Bunq.Sdk.Model.Core;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;

namespace Bunq.Sdk.Model.Generated.Endpoint
{
    /// <summary>
    /// Used to get a Device or a listing of Devices. Creating a DeviceServer should happen via /device-server
    /// </summary>
    public class Device : BunqModel
    {
        /// <summary>
        /// Endpoint constants.
        /// </summary>
        private const string ENDPOINT_URL_READ = "device/{0}";
        private const string ENDPOINT_URL_LISTING = "device";
    
        /// <summary>
        /// Object type.
        /// </summary>
        private const string OBJECT_TYPE = "Device";
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DevicePhone")]
        public DevicePhone DevicePhone { get; private set; }
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DeviceServer")]
        public DeviceServer DeviceServer { get; private set; }
    
        /// <summary>
        /// Get a single Device. A Device is either a DevicePhone or a DeviceServer.
        /// </summary>
        public static BunqResponse<Device> Get(ApiContext apiContext, int deviceId, IDictionary<string, string> customHeaders = null)
        {
            if (customHeaders == null) customHeaders = new Dictionary<string, string>();
    
            var apiClient = new ApiClient(apiContext);
            var responseRaw = apiClient.Get(string.Format(ENDPOINT_URL_READ, deviceId), new Dictionary<string, string>(), customHeaders);
    
            return FromJson<Device>(responseRaw);
        }
    
        /// <summary>
        /// Get a collection of Devices. A Device is either a DevicePhone or a DeviceServer.
        /// </summary>
        public static BunqResponse<List<Device>> List(ApiContext apiContext, IDictionary<string, string> urlParams = null, IDictionary<string, string> customHeaders = null)
        {
            if (urlParams == null) urlParams = new Dictionary<string, string>();
            if (customHeaders == null) customHeaders = new Dictionary<string, string>();
    
            var apiClient = new ApiClient(apiContext);
            var responseRaw = apiClient.Get(ENDPOINT_URL_LISTING, urlParams, customHeaders);
    
            return FromJsonList<Device>(responseRaw);
        }
    }
}
