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

    public partial class BanksIndexResponseBanksItem
    {
        /// <summary>
        /// Initializes a new instance of the BanksIndexResponseBanksItem
        /// class.
        /// </summary>
        public BanksIndexResponseBanksItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BanksIndexResponseBanksItem
        /// class.
        /// </summary>
        /// <param name="id">連携サービスID</param>
        /// <param name="name">連携サービス名</param>
        /// <param name="type">連携サービス種別: (銀行口座: bank_account, クレジットカード:
        /// credit_card, 現金: wallet). Possible values include: 'bank_account',
        /// 'credit_card', 'wallet'</param>
        /// <param name="nameKana">連携サービス名(カナ)</param>
        public BanksIndexResponseBanksItem(int id, string name = default(string), string type = default(string), string nameKana = default(string))
        {
            Id = id;
            Name = name;
            Type = type;
            NameKana = nameKana;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets 連携サービスID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets 連携サービス名
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets 連携サービス種別: (銀行口座: bank_account, クレジットカード: credit_card,
        /// 現金: wallet). Possible values include: 'bank_account',
        /// 'credit_card', 'wallet'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets 連携サービス名(カナ)
        /// </summary>
        [JsonProperty(PropertyName = "name_kana")]
        public string NameKana { get; set; }

    }
}