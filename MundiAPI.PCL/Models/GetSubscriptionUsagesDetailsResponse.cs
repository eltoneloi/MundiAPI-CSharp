/*
 * MundiAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using MundiAPI.PCL;
using MundiAPI.PCL.Utilities;


namespace MundiAPI.PCL.Models
{
    public class GetSubscriptionUsagesDetailsResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string subscriptionId;
        private int totalAmount;
        private Models.GetPeriodResponse period;
        private List<Models.GetUsageResponse> usages;
        private int? totalDiscount;
        private int? totalIncrement;

        /// <summary>
        /// Subscription Identifier
        /// </summary>
        [JsonProperty("subscription_id")]
        public string SubscriptionId 
        { 
            get 
            {
                return this.subscriptionId; 
            } 
            set 
            {
                this.subscriptionId = value;
                onPropertyChanged("SubscriptionId");
            }
        }

        /// <summary>
        /// Current Invoice Amount
        /// </summary>
        [JsonProperty("total_amount")]
        public int TotalAmount 
        { 
            get 
            {
                return this.totalAmount; 
            } 
            set 
            {
                this.totalAmount = value;
                onPropertyChanged("TotalAmount");
            }
        }

        /// <summary>
        /// Period Details
        /// </summary>
        [JsonProperty("Period")]
        public Models.GetPeriodResponse Period 
        { 
            get 
            {
                return this.period; 
            } 
            set 
            {
                this.period = value;
                onPropertyChanged("Period");
            }
        }

        /// <summary>
        /// Usages Details
        /// </summary>
        [JsonProperty("Usages")]
        public List<Models.GetUsageResponse> Usages 
        { 
            get 
            {
                return this.usages; 
            } 
            set 
            {
                this.usages = value;
                onPropertyChanged("Usages");
            }
        }

        /// <summary>
        /// Total discounted value
        /// </summary>
        [JsonProperty("total_discount")]
        public int? TotalDiscount 
        { 
            get 
            {
                return this.totalDiscount; 
            } 
            set 
            {
                this.totalDiscount = value;
                onPropertyChanged("TotalDiscount");
            }
        }

        /// <summary>
        /// Total inremented value
        /// </summary>
        [JsonProperty("total_increment")]
        public int? TotalIncrement 
        { 
            get 
            {
                return this.totalIncrement; 
            } 
            set 
            {
                this.totalIncrement = value;
                onPropertyChanged("TotalIncrement");
            }
        }
    }
} 