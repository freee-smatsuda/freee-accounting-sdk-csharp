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

    public partial class UsersCapabilitiesResponse
    {
        /// <summary>
        /// Initializes a new instance of the UsersCapabilitiesResponse class.
        /// </summary>
        public UsersCapabilitiesResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UsersCapabilitiesResponse class.
        /// </summary>
        public UsersCapabilitiesResponse(UsersCapability walletTxns, UsersCapability deals, UsersCapability transfers, UsersCapability docs, UsersCapability docPostings, UsersCapability receipts, UsersCapability receiptStreamEditor, UsersCapability expenseApplications, UsersCapability spreadsheets, UsersCapability paymentRequests, UsersCapability requestForms, UsersCapability approvalRequests, UsersCapability reports, UsersCapability reportsIncomeExpense, UsersCapability reportsReceivables, UsersCapability reportsPayables, UsersCapability reportsCashBalance, UsersCapability reportsCrosstabs, UsersCapability reportsGeneralLedgers, UsersCapability reportsPl, UsersCapability reportsBs, UsersCapability reportsJournals, UsersCapability reportsManagementsPlanning, UsersCapability reportsManagementsNavigation, UsersCapability manualJournals, UsersCapability fixedAssets, UsersCapability inventoryRefreshes, UsersCapability bizAllocations, UsersCapability paymentRecords, UsersCapability annualReports, UsersCapability taxReports, UsersCapability consumptionEntries, UsersCapability taxReturn, UsersCapability accountItemStatements, UsersCapability monthEnd, UsersCapability yearEnd, UsersCapability walletables, UsersCapability companies, UsersCapability invitations, UsersCapability signInLogs, UsersCapability backups, UsersCapability openingBalances, UsersCapability systemConversion, UsersCapability resets, UsersCapability partners, UsersCapability items, UsersCapability sections, UsersCapability tags, UsersCapability accountItems, UsersCapability taxes, UsersCapability userMatchers, UsersCapability dealTemplates, UsersCapability manualJournalTemplates, UsersCapability costAllocations, UsersCapability approvalFlowRoutes, UsersCapability expenseApplicationTemplates, UsersCapability workflows, UsersCapability oauthApplications, UsersCapability oauthAuthorizations, UsersCapability bankAccountantStaffUsers)
        {
            WalletTxns = walletTxns;
            Deals = deals;
            Transfers = transfers;
            Docs = docs;
            DocPostings = docPostings;
            Receipts = receipts;
            ReceiptStreamEditor = receiptStreamEditor;
            ExpenseApplications = expenseApplications;
            Spreadsheets = spreadsheets;
            PaymentRequests = paymentRequests;
            RequestForms = requestForms;
            ApprovalRequests = approvalRequests;
            Reports = reports;
            ReportsIncomeExpense = reportsIncomeExpense;
            ReportsReceivables = reportsReceivables;
            ReportsPayables = reportsPayables;
            ReportsCashBalance = reportsCashBalance;
            ReportsCrosstabs = reportsCrosstabs;
            ReportsGeneralLedgers = reportsGeneralLedgers;
            ReportsPl = reportsPl;
            ReportsBs = reportsBs;
            ReportsJournals = reportsJournals;
            ReportsManagementsPlanning = reportsManagementsPlanning;
            ReportsManagementsNavigation = reportsManagementsNavigation;
            ManualJournals = manualJournals;
            FixedAssets = fixedAssets;
            InventoryRefreshes = inventoryRefreshes;
            BizAllocations = bizAllocations;
            PaymentRecords = paymentRecords;
            AnnualReports = annualReports;
            TaxReports = taxReports;
            ConsumptionEntries = consumptionEntries;
            TaxReturn = taxReturn;
            AccountItemStatements = accountItemStatements;
            MonthEnd = monthEnd;
            YearEnd = yearEnd;
            Walletables = walletables;
            Companies = companies;
            Invitations = invitations;
            SignInLogs = signInLogs;
            Backups = backups;
            OpeningBalances = openingBalances;
            SystemConversion = systemConversion;
            Resets = resets;
            Partners = partners;
            Items = items;
            Sections = sections;
            Tags = tags;
            AccountItems = accountItems;
            Taxes = taxes;
            UserMatchers = userMatchers;
            DealTemplates = dealTemplates;
            ManualJournalTemplates = manualJournalTemplates;
            CostAllocations = costAllocations;
            ApprovalFlowRoutes = approvalFlowRoutes;
            ExpenseApplicationTemplates = expenseApplicationTemplates;
            Workflows = workflows;
            OauthApplications = oauthApplications;
            OauthAuthorizations = oauthAuthorizations;
            BankAccountantStaffUsers = bankAccountantStaffUsers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "wallet_txns")]
        public UsersCapability WalletTxns { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deals")]
        public UsersCapability Deals { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transfers")]
        public UsersCapability Transfers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "docs")]
        public UsersCapability Docs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "doc_postings")]
        public UsersCapability DocPostings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "receipts")]
        public UsersCapability Receipts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "receipt_stream_editor")]
        public UsersCapability ReceiptStreamEditor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expense_applications")]
        public UsersCapability ExpenseApplications { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spreadsheets")]
        public UsersCapability Spreadsheets { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "payment_requests")]
        public UsersCapability PaymentRequests { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "request_forms")]
        public UsersCapability RequestForms { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "approval_requests")]
        public UsersCapability ApprovalRequests { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reports")]
        public UsersCapability Reports { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reports_income_expense")]
        public UsersCapability ReportsIncomeExpense { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reports_receivables")]
        public UsersCapability ReportsReceivables { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reports_payables")]
        public UsersCapability ReportsPayables { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reports_cash_balance")]
        public UsersCapability ReportsCashBalance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reports_crosstabs")]
        public UsersCapability ReportsCrosstabs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reports_general_ledgers")]
        public UsersCapability ReportsGeneralLedgers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reports_pl")]
        public UsersCapability ReportsPl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reports_bs")]
        public UsersCapability ReportsBs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reports_journals")]
        public UsersCapability ReportsJournals { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reports_managements_planning")]
        public UsersCapability ReportsManagementsPlanning { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reports_managements_navigation")]
        public UsersCapability ReportsManagementsNavigation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manual_journals")]
        public UsersCapability ManualJournals { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fixed_assets")]
        public UsersCapability FixedAssets { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "inventory_refreshes")]
        public UsersCapability InventoryRefreshes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "biz_allocations")]
        public UsersCapability BizAllocations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "payment_records")]
        public UsersCapability PaymentRecords { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "annual_reports")]
        public UsersCapability AnnualReports { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tax_reports")]
        public UsersCapability TaxReports { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "consumption_entries")]
        public UsersCapability ConsumptionEntries { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tax_return")]
        public UsersCapability TaxReturn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "account_item_statements")]
        public UsersCapability AccountItemStatements { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month_end")]
        public UsersCapability MonthEnd { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "year_end")]
        public UsersCapability YearEnd { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "walletables")]
        public UsersCapability Walletables { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "companies")]
        public UsersCapability Companies { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invitations")]
        public UsersCapability Invitations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sign_in_logs")]
        public UsersCapability SignInLogs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "backups")]
        public UsersCapability Backups { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opening_balances")]
        public UsersCapability OpeningBalances { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "system_conversion")]
        public UsersCapability SystemConversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resets")]
        public UsersCapability Resets { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partners")]
        public UsersCapability Partners { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public UsersCapability Items { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sections")]
        public UsersCapability Sections { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public UsersCapability Tags { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "account_items")]
        public UsersCapability AccountItems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taxes")]
        public UsersCapability Taxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "user_matchers")]
        public UsersCapability UserMatchers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deal_templates")]
        public UsersCapability DealTemplates { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manual_journal_templates")]
        public UsersCapability ManualJournalTemplates { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cost_allocations")]
        public UsersCapability CostAllocations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "approval_flow_routes")]
        public UsersCapability ApprovalFlowRoutes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expense_application_templates")]
        public UsersCapability ExpenseApplicationTemplates { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflows")]
        public UsersCapability Workflows { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "oauth_applications")]
        public UsersCapability OauthApplications { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "oauth_authorizations")]
        public UsersCapability OauthAuthorizations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bank_accountant_staff_users")]
        public UsersCapability BankAccountantStaffUsers { get; set; }

    }
}