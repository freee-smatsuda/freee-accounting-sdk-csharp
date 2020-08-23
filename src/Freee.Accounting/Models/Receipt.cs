/*
 * freee API
 *
 *  <h1 id=\"freee_api\">freee API</h1> <hr /> <h2 id=\"start_guide\">スタートガイド</h2>  <p>freee API開発がはじめての方は<a href=\"https://developer.freee.co.jp/getting-started\">freee API スタートガイド</a>を参照してください。</p>  <hr /> <h2 id=\"specification\">仕様</h2>  <pre><code>【重要】会計freee APIの新バージョンについて 2020年12月まで、2つのバージョンが利用できる状態です。古いものは2020年12月に利用不可となります。<br> 新しいAPIを利用するにはリクエストヘッダーに以下を指定します。 X-Api-Version: 2020-06-15<br> 指定がない場合は2020年12月に廃止予定のAPIを利用することとなります。<br> 【重要】APIのバージョン指定をせずに利用し続ける場合 2020年12月に新しいバージョンのAPIに自動的に切り替わります。 詳細は、<a href=\"https://developer.freee.co.jp/release-note/2948\" target=\"_blank\">リリースノート</a>をご覧ください。<br> 旧バージョンのAPIリファレンスを確認したい場合は、<a href=\"https://freee.github.io/freee-api-schema/\" target=\"_blank\">旧バージョンのAPIリファレンスページ</a>をご覧ください。 </code></pre>  <h3 id=\"api_endpoint\">APIエンドポイント</h3>  <p>https://api.freee.co.jp/ (httpsのみ)</p>  <h3 id=\"about_authorize\">認証について</h3> <p>OAuth2.0を利用します。詳細は<a href=\"https://developer.freee.co.jp/docs\" target=\"_blank\">ドキュメントの認証</a>パートを参照してください。</p>  <h3 id=\"data_format\">データフォーマット</h3>  <p>リクエスト、レスポンスともにJSON形式をサポートしていますが、詳細は、API毎の説明欄（application/jsonなど）を確認してください。</p>  <h3 id=\"compatibility\">後方互換性ありの変更</h3>  <p>freeeでは、APIを改善していくために以下のような変更は後方互換性ありとして通知なく変更を入れることがあります。アプリケーション実装者は以下を踏まえて開発を行ってください。</p>  <ul> <li>新しいAPIリソース・エンドポイントの追加</li> <li>既存のAPIに対して必須ではない新しいリクエストパラメータの追加</li> <li>既存のAPIレスポンスに対する新しいプロパティの追加</li> <li>既存のAPIレスポンスに対するプロパティの順番の入れ変え</li> <li>keyとなっているidやcodeの長さの変更（長くする）</li> </ul>  <h3 id=\"common_response_header\">共通レスポンスヘッダー</h3>  <p>すべてのAPIのレスポンスには以下のHTTPヘッダーが含まれます。</p>  <ul> <li> <p>X-Freee-Request-ID</p> <ul> <li>各リクエスト毎に発行されるID</li> </ul> </li> </ul>  <h3 id=\"common_error_response\">共通エラーレスポンス</h3>  <ul> <li> <p>ステータスコードはレスポンス内のJSONに含まれる他、HTTPヘッダにも含まれる</p> </li> <li> <p>一部のエラーレスポンスにはエラーコードが含まれます。<br>詳細は、<a href=\"https://developer.freee.co.jp/tips/faq/40x-checkpoint\">HTTPステータスコード400台エラー時のチェックポイント</a>を参照してください</p> </li> <p>type</p>  <ul> <li>status : HTTPステータスコードの説明</li>  <li>validation : エラーの詳細の説明（開発者向け）</li> </ul> </li> </ul>  <p>レスポンスの例</p>  <pre><code>  {     &quot;status_code&quot; : 400,     &quot;errors&quot; : [       {         &quot;type&quot; : &quot;status&quot;,         &quot;messages&quot; : [&quot;不正なリクエストです。&quot;]       },       {         &quot;type&quot; : &quot;validation&quot;,         &quot;messages&quot; : [&quot;Date は不正な日付フォーマットです。入力例：2013-01-01&quot;]       }     ]   }</code></pre>  </br>  <h3 id=\"api_rate_limit\">API使用制限</h3>    <p>freeeは一定期間に過度のアクセスを検知した場合、APIアクセスをコントロールする場合があります。</p>   <p>その際のhttp status codeは403となります。制限がかかってから10分程度が過ぎると再度使用することができるようになります。</p>  <h4 id=\"reports_api_endpoint\">/reportsエンドポイント</h4>  <p>freeeは/reportsエンドポイントに対して1秒間に10以上のアクセスを検知した場合、APIアクセスをコントロールする場合があります。その際のhttp status codeは429（too many requests）となります。</p>  <p>レスポンスボディのmetaプロパティに以下を含めます。</p>  <ul>   <li>設定されている上限値</li>   <li>上限に達するまでの使用可能回数</li>   <li>（上限値に達した場合）使用回数がリセットされる時刻</li> </ul>  <h3 id=\"plan_api_rate_limit\">プラン別のAPI Rate Limit</h3>   <table border=\"1\">     <tbody>       <tr>         <th style=\"padding: 10px\"><strong>会計freeeプラン名</strong></th>         <th style=\"padding: 10px\"><strong>事業所とアプリケーション毎に1日でのAPIコール数</strong></th>       </tr>       <tr>         <td style=\"padding: 10px\">エンタープライズ</td>         <td style=\"padding: 10px\">10,000</td>       </tr>       <tr>         <td style=\"padding: 10px\">プロフェッショナル</td>         <td style=\"padding: 10px\">5,000</td>       </tr>       <tr>         <td style=\"padding: 10px\">ベーシック</td>         <td style=\"padding: 10px\">3,000</td>       </tr>       <tr>         <td style=\"padding: 10px\">ミニマム</td>         <td style=\"padding: 10px\">3,000</td>       </tr>       <tr>         <td style=\"padding: 10px\">上記以外</td>         <td style=\"padding: 10px\">3,000</td>       </tr>     </tbody>   </table>  <h3 id=\"webhook\">Webhookについて</h3>  <p>詳細は<a href=\"https://developer.freee.co.jp/docs/accounting/webhook\" target=\"_blank\">会計Webhook概要</a>を参照してください。</p>  <hr /> <h2 id=\"contact\">連絡先</h2>  <p>ご不明点、ご要望等は <a href=\"https://support.freee.co.jp/hc/ja/requests/new\">freee サポートデスクへのお問い合わせフォーム</a> からご連絡ください。</p> <hr />&copy; Since 2013 freee K.K.
 *
 * The version of the OpenAPI document: v1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Freee.Accounting.Client.OpenAPIDateConverter;

namespace Freee.Accounting.Models
{
    /// <summary>
    /// Receipt
    /// </summary>
    [DataContract(Name = "receipt")]
    public partial class Receipt : IEquatable<Receipt>
    {
        /// <summary>
        /// アップロード元種別
        /// </summary>
        /// <value>アップロード元種別</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OriginEnum
        {
            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 1,

            /// <summary>
            /// Enum Web for value: web
            /// </summary>
            [EnumMember(Value = "web")]
            Web = 2,

            /// <summary>
            /// Enum Mobilecamera for value: mobile_camera
            /// </summary>
            [EnumMember(Value = "mobile_camera")]
            Mobilecamera = 3,

            /// <summary>
            /// Enum Mobilealbum for value: mobile_album
            /// </summary>
            [EnumMember(Value = "mobile_album")]
            Mobilealbum = 4,

            /// <summary>
            /// Enum Scansnap for value: scansnap
            /// </summary>
            [EnumMember(Value = "scansnap")]
            Scansnap = 5,

            /// <summary>
            /// Enum Scannable for value: scannable
            /// </summary>
            [EnumMember(Value = "scannable")]
            Scannable = 6,

            /// <summary>
            /// Enum Dropbox for value: dropbox
            /// </summary>
            [EnumMember(Value = "dropbox")]
            Dropbox = 7,

            /// <summary>
            /// Enum Mail for value: mail
            /// </summary>
            [EnumMember(Value = "mail")]
            Mail = 8,

            /// <summary>
            /// Enum Safetycontactfile for value: safety_contact_file
            /// </summary>
            [EnumMember(Value = "safety_contact_file")]
            Safetycontactfile = 9,

            /// <summary>
            /// Enum Publicapi for value: public_api
            /// </summary>
            [EnumMember(Value = "public_api")]
            Publicapi = 10

        }

        /// <summary>
        /// アップロード元種別
        /// </summary>
        /// <value>アップロード元種別</value>
        [DataMember(Name = "origin", EmitDefaultValue = false)]
        public OriginEnum Origin { get; set; }
        /// <summary>
        /// ステータス(unconfirmed:確認待ち、confirmed:確認済み、deleted:削除済み、ignored:無視)
        /// </summary>
        /// <value>ステータス(unconfirmed:確認待ち、confirmed:確認済み、deleted:削除済み、ignored:無視)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Unconfirmed for value: unconfirmed
            /// </summary>
            [EnumMember(Value = "unconfirmed")]
            Unconfirmed = 1,

            /// <summary>
            /// Enum Confirmed for value: confirmed
            /// </summary>
            [EnumMember(Value = "confirmed")]
            Confirmed = 2,

            /// <summary>
            /// Enum Deleted for value: deleted
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted = 3,

            /// <summary>
            /// Enum Ignored for value: ignored
            /// </summary>
            [EnumMember(Value = "ignored")]
            Ignored = 4

        }

        /// <summary>
        /// ステータス(unconfirmed:確認待ち、confirmed:確認済み、deleted:削除済み、ignored:無視)
        /// </summary>
        /// <value>ステータス(unconfirmed:確認待ち、confirmed:確認済み、deleted:削除済み、ignored:無視)</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Receipt" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Receipt() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Receipt" /> class.
        /// </summary>
        /// <param name="createdAt">作成日時（ISO8601形式） (required).</param>
        /// <param name="description">メモ.</param>
        /// <param name="fileSrc">ファイルのダウンロードURL（freeeにログインした状態でのみ閲覧可能です。） (required).</param>
        /// <param name="id">証憑ID (required).</param>
        /// <param name="issueDate">発生日.</param>
        /// <param name="mimeType">MIMEタイプ (required).</param>
        /// <param name="origin">アップロード元種別 (required).</param>
        /// <param name="status">ステータス(unconfirmed:確認待ち、confirmed:確認済み、deleted:削除済み、ignored:無視) (required).</param>
        /// <param name="user">user (required).</param>
        public Receipt(string createdAt = default(string), string description = default(string), string fileSrc = default(string), int id = default(int), string issueDate = default(string), string mimeType = default(string), OriginEnum origin = default(OriginEnum), StatusEnum status = default(StatusEnum), DealUser user = default(DealUser))
        {
            // to ensure "createdAt" is required (not null)
            this.CreatedAt = createdAt ?? throw new ArgumentNullException("createdAt is a required property for Receipt and cannot be null");
            // to ensure "fileSrc" is required (not null)
            this.FileSrc = fileSrc ?? throw new ArgumentNullException("fileSrc is a required property for Receipt and cannot be null");
            this.Id = id;
            // to ensure "mimeType" is required (not null)
            this.MimeType = mimeType ?? throw new ArgumentNullException("mimeType is a required property for Receipt and cannot be null");
            this.Origin = origin;
            this.Status = status;
            // to ensure "user" is required (not null)
            this.User = user ?? throw new ArgumentNullException("user is a required property for Receipt and cannot be null");
            this.Description = description;
            this.IssueDate = issueDate;
        }

        /// <summary>
        /// 作成日時（ISO8601形式）
        /// </summary>
        /// <value>作成日時（ISO8601形式）</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// メモ
        /// </summary>
        /// <value>メモ</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// ファイルのダウンロードURL（freeeにログインした状態でのみ閲覧可能です。）
        /// </summary>
        /// <value>ファイルのダウンロードURL（freeeにログインした状態でのみ閲覧可能です。）</value>
        [DataMember(Name = "file_src", EmitDefaultValue = false)]
        public string FileSrc { get; set; }

        /// <summary>
        /// 証憑ID
        /// </summary>
        /// <value>証憑ID</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// 発生日
        /// </summary>
        /// <value>発生日</value>
        [DataMember(Name = "issue_date", EmitDefaultValue = false)]
        public string IssueDate { get; set; }

        /// <summary>
        /// MIMEタイプ
        /// </summary>
        /// <value>MIMEタイプ</value>
        [DataMember(Name = "mime_type", EmitDefaultValue = false)]
        public string MimeType { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public DealUser User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Receipt {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FileSrc: ").Append(FileSrc).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IssueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Receipt);
        }

        /// <summary>
        /// Returns true if Receipt instances are equal
        /// </summary>
        /// <param name="input">Instance of Receipt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Receipt input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FileSrc == input.FileSrc ||
                    (this.FileSrc != null &&
                    this.FileSrc.Equals(input.FileSrc))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.IssueDate == input.IssueDate ||
                    (this.IssueDate != null &&
                    this.IssueDate.Equals(input.IssueDate))
                ) && 
                (
                    this.MimeType == input.MimeType ||
                    (this.MimeType != null &&
                    this.MimeType.Equals(input.MimeType))
                ) && 
                (
                    this.Origin == input.Origin ||
                    this.Origin.Equals(input.Origin)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FileSrc != null)
                    hashCode = hashCode * 59 + this.FileSrc.GetHashCode();
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IssueDate != null)
                    hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.MimeType != null)
                    hashCode = hashCode * 59 + this.MimeType.GetHashCode();
                hashCode = hashCode * 59 + this.Origin.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                return hashCode;
            }
        }

    }

}
