﻿using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicLifeLabelBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicLifeLabelBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonProperty("labels")]
        public List<LifeLabel> Labels { get; set; }
    }
}
