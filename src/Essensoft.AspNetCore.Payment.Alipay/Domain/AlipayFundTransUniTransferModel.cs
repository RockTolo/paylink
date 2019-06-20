﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransUniTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransUniTransferModel : AlipayObject
    {
        /// <summary>
        /// 描述特定的业务场景，比如对党费缴纳场景需走党费专户
        /// </summary>
        [JsonProperty("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 转账请求的扩展参数，具体请与支付宝工程师联系
        /// </summary>
        [JsonProperty("business_params")]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 转账的标题，用于在支付宝用户的账单里显示
        /// </summary>
        [JsonProperty("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 原单号。比如抢红包的时候，传红包支付时返回的支付宝单号。
        /// </summary>
        [JsonProperty("original_order_id")]
        public string OriginalOrderId { get; set; }

        /// <summary>
        /// 商户端的唯一订单号，对于同一笔转账请求，商户需保证该订单号唯一。
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 公用回传参数，如果请求时传递了该参数，则异步通知商户时会回传该参数。
        /// </summary>
        [JsonProperty("passback_params")]
        public string PassbackParams { get; set; }

        /// <summary>
        /// 收款方信息
        /// </summary>
        [JsonProperty("payee_info")]
        public Participant PayeeInfo { get; set; }

        /// <summary>
        /// 付款方信息
        /// </summary>
        [JsonProperty("payer_info")]
        public Participant PayerInfo { get; set; }

        /// <summary>
        /// 转账产品码
        /// </summary>
        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 转账备注
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonProperty("trans_amount")]
        public string TransAmount { get; set; }
    }
}
