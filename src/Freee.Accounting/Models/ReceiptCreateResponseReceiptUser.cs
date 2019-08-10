// <auto-generated>
// Copyright (c) freee K.K. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license
// information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
//
// </auto-generated>

namespace Freee.Accounting.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ReceiptCreateResponseReceiptUser
    {
        /// <summary>
        /// Initializes a new instance of the ReceiptCreateResponseReceiptUser
        /// class.
        /// </summary>
        public ReceiptCreateResponseReceiptUser()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReceiptCreateResponseReceiptUser
        /// class.
        /// </summary>
        /// <param name="id">ユーザID</param>
        /// <param name="email">メールアドレス</param>
        /// <param name="displayName">表示名</param>
        public ReceiptCreateResponseReceiptUser(int id, string email, string displayName = default(string))
        {
            Id = id;
            Email = email;
            DisplayName = displayName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ユーザID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets メールアドレス
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets 表示名
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; set; }

    }
}