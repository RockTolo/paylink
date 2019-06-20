﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbTicketUseDetail Data Structure.
    /// </summary>
    [Serializable]
    public class KbTicketUseDetail : AlipayObject
    {
        /// <summary>
        /// 用户购买券的时候实际支付的金额，单位为元，精确到小数点后两位
        /// </summary>
        [JsonProperty("buyer_pay_amount")]
        public string BuyerPayAmount { get; set; }

        /// <summary>
        /// 商家优惠金额，单位为元，精确到小数点后两位
        /// </summary>
        [JsonProperty("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 交易中可给用户开具发票的金额，单位为元，精确到小数点后两位
        /// </summary>
        [JsonProperty("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 口碑补贴金额，单位为元，精确到小数点后两位
        /// </summary>
        [JsonProperty("koubei_subsidy_amount")]
        public string KoubeiSubsidyAmount { get; set; }

        /// <summary>
        /// 商家实收金额，单位为元，精确到小数点后两位
        /// </summary>
        [JsonProperty("receipt_amount")]
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 核销的券码
        /// </summary>
        [JsonProperty("ticket_code")]
        public string TicketCode { get; set; }

        /// <summary>
        /// 券核销流水号
        /// </summary>
        [JsonProperty("ticket_trans_id")]
        public string TicketTransId { get; set; }
    }
}
