﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GroupFundDetail Data Structure.
    /// </summary>
    [Serializable]
    public class GroupFundDetail : AlipayObject
    {
        /// <summary>
        /// 明细金额
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 收资方支付宝账户ID
        /// </summary>
        [JsonProperty("receiver_user_id")]
        public string ReceiverUserId { get; set; }

        /// <summary>
        /// 出资方支付宝账户ID
        /// </summary>
        [JsonProperty("sender_user_id")]
        public string SenderUserId { get; set; }

        /// <summary>
        /// 明细状态, VALID: 有效的明细, VERIFY: 有效但待核身, INVAILD: 无效的明细,收款方无收款权限
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
