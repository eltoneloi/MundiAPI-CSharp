/*
 * MundiAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MundiAPI.PCL;
using MundiAPI.PCL.Utilities;
using MundiAPI.PCL.Http.Request;
using MundiAPI.PCL.Http.Response;
using MundiAPI.PCL.Http.Client;

namespace MundiAPI.PCL.Controllers
{
    public partial interface ICustomersController
    {
        /// <summary>
        /// Creates a access token for a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="request">Required parameter: Request for creating a access token</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetAccessTokenResponse response from the API call</return>
        Models.GetAccessTokenResponse CreateAccessToken(string customerId, Models.CreateAccessTokenRequest request, string idempotencyKey = null);

        /// <summary>
        /// Creates a access token for a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="request">Required parameter: Request for creating a access token</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetAccessTokenResponse response from the API call</return>
        Task<Models.GetAccessTokenResponse> CreateAccessTokenAsync(string customerId, Models.CreateAccessTokenRequest request, string idempotencyKey = null);

        /// <summary>
        /// Updates a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="request">Required parameter: Request for updating a customer</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetCustomerResponse response from the API call</return>
        Models.GetCustomerResponse UpdateCustomer(string customerId, Models.UpdateCustomerRequest request, string idempotencyKey = null);

        /// <summary>
        /// Updates a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="request">Required parameter: Request for updating a customer</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetCustomerResponse response from the API call</return>
        Task<Models.GetCustomerResponse> UpdateCustomerAsync(string customerId, Models.UpdateCustomerRequest request, string idempotencyKey = null);

        /// <summary>
        /// Delete a Customer's access tokens
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <return>Returns the Models.ListAccessTokensResponse response from the API call</return>
        Models.ListAccessTokensResponse DeleteAccessTokens(string customerId);

        /// <summary>
        /// Delete a Customer's access tokens
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <return>Returns the Models.ListAccessTokensResponse response from the API call</return>
        Task<Models.ListAccessTokensResponse> DeleteAccessTokensAsync(string customerId);

        /// <summary>
        /// Get a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <return>Returns the Models.GetCustomerResponse response from the API call</return>
        Models.GetCustomerResponse GetCustomer(string customerId);

        /// <summary>
        /// Get a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <return>Returns the Models.GetCustomerResponse response from the API call</return>
        Task<Models.GetCustomerResponse> GetCustomerAsync(string customerId);

        /// <summary>
        /// Gets all adressess from a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <return>Returns the Models.ListAddressesResponse response from the API call</return>
        Models.ListAddressesResponse GetAddresses(string customerId, int? page = null, int? size = null);

        /// <summary>
        /// Gets all adressess from a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <return>Returns the Models.ListAddressesResponse response from the API call</return>
        Task<Models.ListAddressesResponse> GetAddressesAsync(string customerId, int? page = null, int? size = null);

        /// <summary>
        /// Get a Customer's access token
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="tokenId">Required parameter: Token Id</param>
        /// <return>Returns the Models.GetAccessTokenResponse response from the API call</return>
        Models.GetAccessTokenResponse GetAccessToken(string customerId, string tokenId);

        /// <summary>
        /// Get a Customer's access token
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="tokenId">Required parameter: Token Id</param>
        /// <return>Returns the Models.GetAccessTokenResponse response from the API call</return>
        Task<Models.GetAccessTokenResponse> GetAccessTokenAsync(string customerId, string tokenId);

        /// <summary>
        /// Get a customer's address
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="addressId">Required parameter: Address Id</param>
        /// <return>Returns the Models.GetAddressResponse response from the API call</return>
        Models.GetAddressResponse GetAddress(string customerId, string addressId);

        /// <summary>
        /// Get a customer's address
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="addressId">Required parameter: Address Id</param>
        /// <return>Returns the Models.GetAddressResponse response from the API call</return>
        Task<Models.GetAddressResponse> GetAddressAsync(string customerId, string addressId);

        /// <summary>
        /// Creates a new card for a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="request">Required parameter: Request for creating a card</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetCardResponse response from the API call</return>
        Models.GetCardResponse CreateCard(string customerId, Models.CreateCardRequest request, string idempotencyKey = null);

        /// <summary>
        /// Creates a new card for a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="request">Required parameter: Request for creating a card</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetCardResponse response from the API call</return>
        Task<Models.GetCardResponse> CreateCardAsync(string customerId, Models.CreateCardRequest request, string idempotencyKey = null);

        /// <summary>
        /// Renew a card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="cardId">Required parameter: Card Id</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetCardResponse response from the API call</return>
        Models.GetCardResponse RenewCard(string customerId, string cardId, string idempotencyKey = null);

        /// <summary>
        /// Renew a card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="cardId">Required parameter: Card Id</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetCardResponse response from the API call</return>
        Task<Models.GetCardResponse> RenewCardAsync(string customerId, string cardId, string idempotencyKey = null);

        /// <summary>
        /// Creates a new customer
        /// </summary>
        /// <param name="request">Required parameter: Request for creating a customer</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetCustomerResponse response from the API call</return>
        Models.GetCustomerResponse CreateCustomer(Models.CreateCustomerRequest request, string idempotencyKey = null);

        /// <summary>
        /// Creates a new customer
        /// </summary>
        /// <param name="request">Required parameter: Request for creating a customer</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetCustomerResponse response from the API call</return>
        Task<Models.GetCustomerResponse> CreateCustomerAsync(Models.CreateCustomerRequest request, string idempotencyKey = null);

        /// <summary>
        /// Updates an address
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="addressId">Required parameter: Address Id</param>
        /// <param name="request">Required parameter: Request for updating an address</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetAddressResponse response from the API call</return>
        Models.GetAddressResponse UpdateAddress(
                string customerId,
                string addressId,
                Models.UpdateAddressRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// Updates an address
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="addressId">Required parameter: Address Id</param>
        /// <param name="request">Required parameter: Request for updating an address</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetAddressResponse response from the API call</return>
        Task<Models.GetAddressResponse> UpdateAddressAsync(
                string customerId,
                string addressId,
                Models.UpdateAddressRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// Get all access tokens from a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <return>Returns the Models.ListAccessTokensResponse response from the API call</return>
        Models.ListAccessTokensResponse GetAccessTokens(string customerId, int? page = null, int? size = null);

        /// <summary>
        /// Get all access tokens from a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <return>Returns the Models.ListAccessTokensResponse response from the API call</return>
        Task<Models.ListAccessTokensResponse> GetAccessTokensAsync(string customerId, int? page = null, int? size = null);

        /// <summary>
        /// Updates the metadata a customer
        /// </summary>
        /// <param name="customerId">Required parameter: The customer id</param>
        /// <param name="request">Required parameter: Request for updating the customer metadata</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetCustomerResponse response from the API call</return>
        Models.GetCustomerResponse UpdateCustomerMetadata(string customerId, Models.UpdateMetadataRequest request, string idempotencyKey = null);

        /// <summary>
        /// Updates the metadata a customer
        /// </summary>
        /// <param name="customerId">Required parameter: The customer id</param>
        /// <param name="request">Required parameter: Request for updating the customer metadata</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetCustomerResponse response from the API call</return>
        Task<Models.GetCustomerResponse> UpdateCustomerMetadataAsync(string customerId, Models.UpdateMetadataRequest request, string idempotencyKey = null);

        /// <summary>
        /// Delete a Customer's address
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="addressId">Required parameter: Address Id</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetAddressResponse response from the API call</return>
        Models.GetAddressResponse DeleteAddress(string customerId, string addressId, string idempotencyKey = null);

        /// <summary>
        /// Delete a Customer's address
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="addressId">Required parameter: Address Id</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetAddressResponse response from the API call</return>
        Task<Models.GetAddressResponse> DeleteAddressAsync(string customerId, string addressId, string idempotencyKey = null);

        /// <summary>
        /// Updates a card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="cardId">Required parameter: Card id</param>
        /// <param name="request">Required parameter: Request for updating a card</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetCardResponse response from the API call</return>
        Models.GetCardResponse UpdateCard(
                string customerId,
                string cardId,
                Models.UpdateCardRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// Updates a card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="cardId">Required parameter: Card id</param>
        /// <param name="request">Required parameter: Request for updating a card</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetCardResponse response from the API call</return>
        Task<Models.GetCardResponse> UpdateCardAsync(
                string customerId,
                string cardId,
                Models.UpdateCardRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// Get all cards from a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <return>Returns the Models.ListCardsResponse response from the API call</return>
        Models.ListCardsResponse GetCards(string customerId, int? page = null, int? size = null);

        /// <summary>
        /// Get all cards from a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <return>Returns the Models.ListCardsResponse response from the API call</return>
        Task<Models.ListCardsResponse> GetCardsAsync(string customerId, int? page = null, int? size = null);

        /// <summary>
        /// Delete a customer's card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="cardId">Required parameter: Card Id</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetCardResponse response from the API call</return>
        Models.GetCardResponse DeleteCard(string customerId, string cardId, string idempotencyKey = null);

        /// <summary>
        /// Delete a customer's card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="cardId">Required parameter: Card Id</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetCardResponse response from the API call</return>
        Task<Models.GetCardResponse> DeleteCardAsync(string customerId, string cardId, string idempotencyKey = null);

        /// <summary>
        /// Get all Customers
        /// </summary>
        /// <param name="name">Optional parameter: Name of the Customer</param>
        /// <param name="document">Optional parameter: Document of the Customer</param>
        /// <param name="page">Optional parameter: Current page the the search</param>
        /// <param name="size">Optional parameter: Quantity pages of the search</param>
        /// <param name="email">Optional parameter: Customer's email</param>
        /// <param name="code">Optional parameter: Customer's code</param>
        /// <return>Returns the Models.ListCustomersResponse response from the API call</return>
        Models.ListCustomersResponse GetCustomers(
                string name = null,
                string document = null,
                int? page = 1,
                int? size = 10,
                string email = null,
                string code = null);

        /// <summary>
        /// Get all Customers
        /// </summary>
        /// <param name="name">Optional parameter: Name of the Customer</param>
        /// <param name="document">Optional parameter: Document of the Customer</param>
        /// <param name="page">Optional parameter: Current page the the search</param>
        /// <param name="size">Optional parameter: Quantity pages of the search</param>
        /// <param name="email">Optional parameter: Customer's email</param>
        /// <param name="code">Optional parameter: Customer's code</param>
        /// <return>Returns the Models.ListCustomersResponse response from the API call</return>
        Task<Models.ListCustomersResponse> GetCustomersAsync(
                string name = null,
                string document = null,
                int? page = 1,
                int? size = 10,
                string email = null,
                string code = null);

        /// <summary>
        /// Delete a customer's access token
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="tokenId">Required parameter: Token Id</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetAccessTokenResponse response from the API call</return>
        Models.GetAccessTokenResponse DeleteAccessToken(string customerId, string tokenId, string idempotencyKey = null);

        /// <summary>
        /// Delete a customer's access token
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="tokenId">Required parameter: Token Id</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetAccessTokenResponse response from the API call</return>
        Task<Models.GetAccessTokenResponse> DeleteAccessTokenAsync(string customerId, string tokenId, string idempotencyKey = null);

        /// <summary>
        /// Creates a new address for a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="request">Required parameter: Request for creating an address</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetAddressResponse response from the API call</return>
        Models.GetAddressResponse CreateAddress(string customerId, Models.CreateAddressRequest request, string idempotencyKey = null);

        /// <summary>
        /// Creates a new address for a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="request">Required parameter: Request for creating an address</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetAddressResponse response from the API call</return>
        Task<Models.GetAddressResponse> CreateAddressAsync(string customerId, Models.CreateAddressRequest request, string idempotencyKey = null);

        /// <summary>
        /// Get a customer's card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="cardId">Required parameter: Card id</param>
        /// <return>Returns the Models.GetCardResponse response from the API call</return>
        Models.GetCardResponse GetCard(string customerId, string cardId);

        /// <summary>
        /// Get a customer's card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="cardId">Required parameter: Card id</param>
        /// <return>Returns the Models.GetCardResponse response from the API call</return>
        Task<Models.GetCardResponse> GetCardAsync(string customerId, string cardId);

    }
} 