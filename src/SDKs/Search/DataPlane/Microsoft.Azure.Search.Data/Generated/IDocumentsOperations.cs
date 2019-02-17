// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// DocumentsProxyOperations operations.
    /// </summary>
    internal partial interface IDocumentsProxyOperations
    {
        /// <summary>
        /// Queries the number of documents in the Azure Search index.
        /// <see href="https://docs.microsoft.com/rest/api/searchservice/Count-Documents" />
        /// </summary>
        /// <param name='searchRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<long?>> CountWithHttpMessagesAsync(SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken), Newtonsoft.Json.JsonSerializerSettings requestSerializerSettings = null, Newtonsoft.Json.JsonSerializerSettings responseDeserializerSettings = null);
        /// <summary>
        /// Retrieves a document from the Azure Search index.
        /// <see href="https://docs.microsoft.com/rest/api/searchservice/lookup-document" />
        /// </summary>
        /// <param name='key'>
        /// The key of the document to retrieve.
        /// </param>
        /// <param name='selectedFields'>
        /// List of field names to retrieve for the document; Any field not
        /// retrieved will be missing from the returned document.
        /// </param>
        /// <param name='searchRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<T>> GetWithHttpMessagesAsync<T>(string key, IList<string> selectedFields = default(IList<string>), SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken), Newtonsoft.Json.JsonSerializerSettings requestSerializerSettings = null, Newtonsoft.Json.JsonSerializerSettings responseDeserializerSettings = null);
        /// <summary>
        /// Suggests documents in the Azure Search index that match the given
        /// partial query text.
        /// <see href="https://docs.microsoft.com/rest/api/searchservice/suggestions" />
        /// </summary>
        /// <param name='searchText'>
        /// The search text to use to suggest documents. Must be at least 1
        /// character, and no more than 100 characters.
        /// </param>
        /// <param name='suggesterName'>
        /// The name of the suggester as specified in the suggesters collection
        /// that's part of the index definition.
        /// </param>
        /// <param name='suggestParameters'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='searchRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DocumentSuggestResult<T>>> SuggestGetWithHttpMessagesAsync<T>(string searchText, string suggesterName, SuggestParameters suggestParameters = default(SuggestParameters), SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken), Newtonsoft.Json.JsonSerializerSettings requestSerializerSettings = null, Newtonsoft.Json.JsonSerializerSettings responseDeserializerSettings = null);
        /// <summary>
        /// Suggests documents in the Azure Search index that match the given
        /// partial query text.
        /// <see href="https://docs.microsoft.com/rest/api/searchservice/suggestions" />
        /// </summary>
        /// <param name='suggestRequest'>
        /// The Suggest request.
        /// </param>
        /// <param name='searchRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DocumentSuggestResult<T>>> SuggestPostWithHttpMessagesAsync<T>(SuggestRequest suggestRequest, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken), Newtonsoft.Json.JsonSerializerSettings requestSerializerSettings = null, Newtonsoft.Json.JsonSerializerSettings responseDeserializerSettings = null);
        /// <summary>
        /// Autocompletes incomplete query terms based on input text and
        /// matching terms in the Azure Search index.
        /// <see href="https://docs.microsoft.com/rest/api/searchservice/autocomplete" />
        /// </summary>
        /// <param name='searchText'>
        /// The incomplete term which should be auto-completed.
        /// </param>
        /// <param name='suggesterName'>
        /// The name of the suggester as specified in the suggesters collection
        /// that's part of the index definition.
        /// </param>
        /// <param name='searchRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='autocompleteParameters'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AutocompleteResult>> AutocompleteGetWithHttpMessagesAsync(string searchText, string suggesterName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), AutocompleteParameters autocompleteParameters = default(AutocompleteParameters), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken), Newtonsoft.Json.JsonSerializerSettings requestSerializerSettings = null, Newtonsoft.Json.JsonSerializerSettings responseDeserializerSettings = null);
        /// <summary>
        /// Autocompletes incomplete query terms based on input text and
        /// matching terms in the Azure Search index.
        /// <see href="https://docs.microsoft.com/rest/api/searchservice/autocomplete" />
        /// </summary>
        /// <param name='autocompleteRequest'>
        /// The definition of the Autocomplete request.
        /// </param>
        /// <param name='searchRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AutocompleteResult>> AutocompletePostWithHttpMessagesAsync(AutocompleteRequest autocompleteRequest, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken), Newtonsoft.Json.JsonSerializerSettings requestSerializerSettings = null, Newtonsoft.Json.JsonSerializerSettings responseDeserializerSettings = null);
    }
}
