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
    public partial interface IOrdersController
    {
        /// <summary>
        /// Gets an order
        /// </summary>
        /// <param name="orderId">Required parameter: Order id</param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        Models.GetOrderResponse GetOrder(string orderId);

        /// <summary>
        /// Gets an order
        /// </summary>
        /// <param name="orderId">Required parameter: Order id</param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        Task<Models.GetOrderResponse> GetOrderAsync(string orderId);

        /// <summary>
        /// Gets all orders
        /// </summary>
        /// <return>Returns the Models.ListOrderResponse response from the API call</return>
        Models.ListOrderResponse GetOrders();

        /// <summary>
        /// Gets all orders
        /// </summary>
        /// <return>Returns the Models.ListOrderResponse response from the API call</return>
        Task<Models.ListOrderResponse> GetOrdersAsync();

        /// <summary>
        /// Creates a new Order
        /// </summary>
        /// <param name="body">Required parameter: Request for creating an order</param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        Models.GetOrderResponse CreateOrder(Models.CreateOrderRequest body);

        /// <summary>
        /// Creates a new Order
        /// </summary>
        /// <param name="body">Required parameter: Request for creating an order</param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        Task<Models.GetOrderResponse> CreateOrderAsync(Models.CreateOrderRequest body);

    }
} 