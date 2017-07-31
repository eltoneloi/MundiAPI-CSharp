/*
 * MundiAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
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
        /// Gets all adressess from a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <return>Returns the Models.ListAddressesResponse response from the API call</return>
        Models.ListAddressesResponse GetAddresses(string customerId);

        /// <summary>
        /// Gets all adressess from a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <return>Returns the Models.ListAddressesResponse response from the API call</return>
        Task<Models.ListAddressesResponse> GetAddressesAsync(string customerId);

        /// <summary>
        /// Get all cards from a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <return>Returns the Models.ListCardsResponse response from the API call</return>
        Models.ListCardsResponse GetCards(string customerId);

        /// <summary>
        /// Get all cards from a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <return>Returns the Models.ListCardsResponse response from the API call</return>
        Task<Models.ListCardsResponse> GetCardsAsync(string customerId);

        /// <summary>
        /// Get all Customers
        /// </summary>
        /// <return>Returns the Models.ListCustomersResponse response from the API call</return>
        Models.ListCustomersResponse GetCustomers();

        /// <summary>
        /// Get all Customers
        /// </summary>
        /// <return>Returns the Models.ListCustomersResponse response from the API call</return>
        Task<Models.ListCustomersResponse> GetCustomersAsync();

        /// <summary>
        /// Creates a new customer
        /// </summary>
        /// <param name="request">Required parameter: Request for creating a customer</param>
        /// <return>Returns the Models.GetCustomerResponse response from the API call</return>
        Models.GetCustomerResponse CreateCustomer(Models.CreateCustomerRequest request);

        /// <summary>
        /// Creates a new customer
        /// </summary>
        /// <param name="request">Required parameter: Request for creating a customer</param>
        /// <return>Returns the Models.GetCustomerResponse response from the API call</return>
        Task<Models.GetCustomerResponse> CreateCustomerAsync(Models.CreateCustomerRequest request);

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
        /// Updates an address
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="addressId">Required parameter: Address Id</param>
        /// <param name="request">Required parameter: Request for updating an address</param>
        /// <return>Returns the Models.GetAddressResponse response from the API call</return>
        Models.GetAddressResponse UpdateAddress(string customerId, string addressId, Models.UpdateAddressRequest request);

        /// <summary>
        /// Updates an address
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="addressId">Required parameter: Address Id</param>
        /// <param name="request">Required parameter: Request for updating an address</param>
        /// <return>Returns the Models.GetAddressResponse response from the API call</return>
        Task<Models.GetAddressResponse> UpdateAddressAsync(string customerId, string addressId, Models.UpdateAddressRequest request);

        /// <summary>
        /// Updates a card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="cardId">Required parameter: Card id</param>
        /// <param name="request">Required parameter: Request for updating a card</param>
        /// <return>Returns the Models.GetCardResponse response from the API call</return>
        Models.GetCardResponse UpdateCard(string customerId, string cardId, Models.UpdateCardRequest request);

        /// <summary>
        /// Updates a card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="cardId">Required parameter: Card id</param>
        /// <param name="request">Required parameter: Request for updating a card</param>
        /// <return>Returns the Models.GetCardResponse response from the API call</return>
        Task<Models.GetCardResponse> UpdateCardAsync(string customerId, string cardId, Models.UpdateCardRequest request);

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
        /// Delete a Customer's address
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="addressId">Required parameter: Address Id</param>
        /// <return>Returns the Models.GetAddressResponse response from the API call</return>
        Models.GetAddressResponse DeleteAddress(string customerId, string addressId);

        /// <summary>
        /// Delete a Customer's address
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="addressId">Required parameter: Address Id</param>
        /// <return>Returns the Models.GetAddressResponse response from the API call</return>
        Task<Models.GetAddressResponse> DeleteAddressAsync(string customerId, string addressId);

        /// <summary>
        /// Delete a customer's card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="cardId">Required parameter: Card Id</param>
        /// <return>Returns the Models.GetCardResponse response from the API call</return>
        Models.GetCardResponse DeleteCard(string customerId, string cardId);

        /// <summary>
        /// Delete a customer's card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="cardId">Required parameter: Card Id</param>
        /// <return>Returns the Models.GetCardResponse response from the API call</return>
        Task<Models.GetCardResponse> DeleteCardAsync(string customerId, string cardId);

        /// <summary>
        /// Creates a new address for a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="request">Required parameter: Request for creating an address</param>
        /// <return>Returns the Models.GetAddressResponse response from the API call</return>
        Models.GetAddressResponse CreateAddress(string customerId, Models.CreateAddressRequest request);

        /// <summary>
        /// Creates a new address for a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="request">Required parameter: Request for creating an address</param>
        /// <return>Returns the Models.GetAddressResponse response from the API call</return>
        Task<Models.GetAddressResponse> CreateAddressAsync(string customerId, Models.CreateAddressRequest request);

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

        /// <summary>
        /// Creates a new card for a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="request">Required parameter: Request for creating a card</param>
        /// <return>Returns the Models.GetCardResponse response from the API call</return>
        Models.GetCardResponse CreateCard(string customerId, Models.CreateCardRequest request);

        /// <summary>
        /// Creates a new card for a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="request">Required parameter: Request for creating a card</param>
        /// <return>Returns the Models.GetCardResponse response from the API call</return>
        Task<Models.GetCardResponse> CreateCardAsync(string customerId, Models.CreateCardRequest request);

        /// <summary>
        /// Updates a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="request">Required parameter: Request for updating a customer</param>
        /// <return>Returns the Models.GetCustomerResponse response from the API call</return>
        Models.GetCustomerResponse UpdateCustomer(string customerId, Models.UpdateCustomerRequest request);

        /// <summary>
        /// Updates a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="request">Required parameter: Request for updating a customer</param>
        /// <return>Returns the Models.GetCustomerResponse response from the API call</return>
        Task<Models.GetCustomerResponse> UpdateCustomerAsync(string customerId, Models.UpdateCustomerRequest request);

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
        /// Get all access tokens from a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <return>Returns the Models.ListAccessTokensResponse response from the API call</return>
        Models.ListAccessTokensResponse GetAccessTokens(string customerId);

        /// <summary>
        /// Get all access tokens from a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <return>Returns the Models.ListAccessTokensResponse response from the API call</return>
        Task<Models.ListAccessTokensResponse> GetAccessTokensAsync(string customerId);

        /// <summary>
        /// Delete a customer's access token
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="tokenId">Required parameter: Token Id</param>
        /// <return>Returns the Models.GetAccessTokenResponse response from the API call</return>
        Models.GetAccessTokenResponse DeleteAccessToken(string customerId, string tokenId);

        /// <summary>
        /// Delete a customer's access token
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="tokenId">Required parameter: Token Id</param>
        /// <return>Returns the Models.GetAccessTokenResponse response from the API call</return>
        Task<Models.GetAccessTokenResponse> DeleteAccessTokenAsync(string customerId, string tokenId);

        /// <summary>
        /// Creates a access token for a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="request">Required parameter: Request for creating a access token</param>
        /// <return>Returns the Models.GetAccessTokenResponse response from the API call</return>
        Models.GetAccessTokenResponse CreateAccessToken(string customerId, Models.CreateAccessTokenRequest request);

        /// <summary>
        /// Creates a access token for a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="request">Required parameter: Request for creating a access token</param>
        /// <return>Returns the Models.GetAccessTokenResponse response from the API call</return>
        Task<Models.GetAccessTokenResponse> CreateAccessTokenAsync(string customerId, Models.CreateAccessTokenRequest request);

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

    }
} 