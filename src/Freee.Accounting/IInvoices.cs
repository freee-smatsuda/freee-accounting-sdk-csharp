// <auto-generated>
// Copyright (c) freee K.K. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license
// information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
//
// </auto-generated>

namespace Freee.Accounting
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Invoices operations.
    /// </summary>
    public partial interface IInvoices
    {
        /// <summary>
        /// 請求書一覧の取得
        /// </summary>
        /// <remarks>
        /// 指定した事業所の請求書一覧を取得する
        /// </remarks>
        /// <param name='companyId'>
        /// 事業所ID
        /// </param>
        /// <param name='partnerId'>
        /// 取引先IDで絞込
        /// </param>
        /// <param name='partnerCode'>
        /// 取引先コードで絞込
        /// </param>
        /// <param name='issueDateStart'>
        /// 請求日の開始日(yyyy-mm-dd)
        /// </param>
        /// <param name='issueDateEnd'>
        /// 請求日の終了日(yyyy-mm-dd)
        /// </param>
        /// <param name='dueDateStart'>
        /// 期日の開始日(yyyy-mm-dd)
        /// </param>
        /// <param name='dueDateEnd'>
        /// 期日の終了日(yyyy-mm-dd)
        /// </param>
        /// <param name='invoiceNumber'>
        /// 請求書番号
        /// </param>
        /// <param name='description'>
        /// 概要
        /// </param>
        /// <param name='invoiceStatus'>
        /// 請求書ステータス  (draft: 下書き, applying: 申請中, remanded: 差し戻し, rejected: 却下,
        /// approved: 承認済み, issued: 発行済み). Possible values include: 'draft',
        /// 'applying', 'remanded', 'rejected', 'approved', 'issued'
        /// </param>
        /// <param name='paymentStatus'>
        /// 入金ステータス  (unsettled: 入金待ち, settled: 入金済み). Possible values include:
        /// 'unsettled', 'settled'
        /// </param>
        /// <param name='offset'>
        /// 取得レコードのオフセット (デフォルト: 0)
        /// </param>
        /// <param name='limit'>
        /// 取得レコードの件数 (デフォルト: 20, 最大: 100)
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<InvoicesIndexResponse>> ListWithHttpMessagesAsync(int companyId, int? partnerId = default(int?), string partnerCode = default(string), string issueDateStart = default(string), string issueDateEnd = default(string), string dueDateStart = default(string), string dueDateEnd = default(string), string invoiceNumber = default(string), string description = default(string), string invoiceStatus = default(string), string paymentStatus = default(string), int? offset = default(int?), int? limit = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// 請求書の作成
        /// </summary>
        /// <remarks>
        /// 指定した事業所の請求書を作成する
        /// </remarks>
        /// <param name='parameters'>
        /// 請求書の作成
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<InvoicesResponse>> CreateWithHttpMessagesAsync(InvoicesCreateParams parameters = default(InvoicesCreateParams), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// 請求書の更新
        /// </summary>
        /// <remarks>
        /// 指定した事業所の請求書を更新する
        /// </remarks>
        /// <param name='id'>
        /// 請求書ID
        /// </param>
        /// <param name='parameters'>
        /// 請求書の更新
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<InvoicesResponse>> UpdateWithHttpMessagesAsync(int id, InvoicesUpdateParams parameters = default(InvoicesUpdateParams), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// 請求書の削除
        /// </summary>
        /// <remarks>
        /// 指定した事業所の請求書を削除する
        /// </remarks>
        /// <param name='id'>
        /// </param>
        /// <param name='companyId'>
        /// 事業所ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse> DestroyWithHttpMessagesAsync(int id, int companyId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}