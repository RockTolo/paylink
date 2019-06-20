﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseContentlibOfferSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseContentlibOfferSyncModel : AlipayObject
    {
        /// <summary>
        /// 参数名代表同步到我方的业务方来源值，在内容中台中是唯一标示，对接内容中台的时候，由中台PD告知对方
        /// </summary>
        [JsonProperty("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 内容中台offer同步，具体的数据内容，是个列表，支持批量修改传递
        /// </summary>
        [JsonProperty("display_app")]
        public OfferObject DisplayApp { get; set; }

        /// <summary>
        /// 标示本次操作具体的行为
        /// </summary>
        [JsonProperty("operate_type")]
        public string OperateType { get; set; }
    }
}
