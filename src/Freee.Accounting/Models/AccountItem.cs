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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class AccountItem
    {
        /// <summary>
        /// Initializes a new instance of the AccountItem class.
        /// </summary>
        public AccountItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AccountItem class.
        /// </summary>
        /// <param name="id">勘定科目ID</param>
        /// <param name="name">勘定科目名 (30文字以内)</param>
        /// <param name="companyId">事業所ID</param>
        /// <param name="taxCode">税区分コード</param>
        /// <param name="accountCategoryId">勘定科目のカテゴリーコード</param>
        /// <param name="correspondingTypeExpense">支出取引相手勘定科目ID</param>
        /// <param name="correspondingTypeIncome">収入取引相手勘定科目ID</param>
        /// <param name="searchable">検索可能:2, 検索不可：3</param>
        /// <param name="available">勘定科目の使用設定（true: 使用する、false: 使用しない）</param>
        /// <param name="walletableId">口座ID</param>
        /// <param name="shortcut">ショートカット1 (20文字以内)</param>
        /// <param name="shortcutNum">ショートカット2(勘定科目コード) (20文字以内)</param>
        /// <param name="accumulatedDepAccountItemName">減価償却累計額勘定科目</param>
        public AccountItem(int id, string name, int companyId, int taxCode, int accountCategoryId, int correspondingTypeExpense, int correspondingTypeIncome, int searchable, bool available, int? walletableId, string shortcut = default(string), string shortcutNum = default(string), string accumulatedDepAccountItemName = default(string), IList<AccountItemItemsItem> items = default(IList<AccountItemItemsItem>), IList<AccountItemPartnersItem> partners = default(IList<AccountItemPartnersItem>))
        {
            Id = id;
            Name = name;
            CompanyId = companyId;
            TaxCode = taxCode;
            AccountCategoryId = accountCategoryId;
            Shortcut = shortcut;
            ShortcutNum = shortcutNum;
            CorrespondingTypeExpense = correspondingTypeExpense;
            CorrespondingTypeIncome = correspondingTypeIncome;
            Searchable = searchable;
            AccumulatedDepAccountItemName = accumulatedDepAccountItemName;
            Items = items;
            Partners = partners;
            Available = available;
            WalletableId = walletableId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets 勘定科目ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets 勘定科目名 (30文字以内)
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets 事業所ID
        /// </summary>
        [JsonProperty(PropertyName = "company_id")]
        public int CompanyId { get; set; }

        /// <summary>
        /// Gets or sets 税区分コード
        /// </summary>
        [JsonProperty(PropertyName = "tax_code")]
        public int TaxCode { get; set; }

        /// <summary>
        /// Gets or sets 勘定科目のカテゴリーコード
        /// </summary>
        [JsonProperty(PropertyName = "account_category_id")]
        public int AccountCategoryId { get; set; }

        /// <summary>
        /// Gets or sets ショートカット1 (20文字以内)
        /// </summary>
        [JsonProperty(PropertyName = "shortcut")]
        public string Shortcut { get; set; }

        /// <summary>
        /// Gets or sets ショートカット2(勘定科目コード) (20文字以内)
        /// </summary>
        [JsonProperty(PropertyName = "shortcut_num")]
        public string ShortcutNum { get; set; }

        /// <summary>
        /// Gets or sets 支出取引相手勘定科目ID
        /// </summary>
        [JsonProperty(PropertyName = "corresponding_type_expense")]
        public int CorrespondingTypeExpense { get; set; }

        /// <summary>
        /// Gets or sets 収入取引相手勘定科目ID
        /// </summary>
        [JsonProperty(PropertyName = "corresponding_type_income")]
        public int CorrespondingTypeIncome { get; set; }

        /// <summary>
        /// Gets or sets 検索可能:2, 検索不可：3
        /// </summary>
        [JsonProperty(PropertyName = "searchable")]
        public int Searchable { get; set; }

        /// <summary>
        /// Gets or sets 減価償却累計額勘定科目
        /// </summary>
        [JsonProperty(PropertyName = "accumulated_dep_account_item_name")]
        public string AccumulatedDepAccountItemName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public IList<AccountItemItemsItem> Items { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partners")]
        public IList<AccountItemPartnersItem> Partners { get; set; }

        /// <summary>
        /// Gets or sets 勘定科目の使用設定（true: 使用する、false: 使用しない）
        /// </summary>
        [JsonProperty(PropertyName = "available")]
        public bool Available { get; set; }

        /// <summary>
        /// Gets or sets 口座ID
        /// </summary>
        [JsonProperty(PropertyName = "walletable_id")]
        public int? WalletableId { get; set; }

    }
}