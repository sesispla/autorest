// This is my custom license header. I am a nice person so please don't steal
// my code.
//
// Cheers.

namespace AwesomeNamespace
{
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// The Storage Management Client.
    /// </summary>
    public partial interface IStorageManagementClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// Client Api Version.
        /// </summary>
        string ApiVersion { get; set; }


        /// <summary>
        /// Gets the IStorageAccounts.
        /// </summary>
        IStorageAccounts StorageAccounts { get; }

        /// <summary>
        /// Gets the IUsageOperations.
        /// </summary>
        IUsageOperations Usage { get; }

    }
}
