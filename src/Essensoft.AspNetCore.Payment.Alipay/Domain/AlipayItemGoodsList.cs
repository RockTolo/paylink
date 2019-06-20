﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayItemGoodsList Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayItemGoodsList : AlipayObject
    {
        /// <summary>
        /// 外部单品的描述信息（此字段暂时无用）
        /// </summary>
        [JsonProperty("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 外部单品id列表，传入服务商、商户系统中的商品id。
        /// </summary>
        [JsonProperty("goods_list")]
        public List<string> GoodsList { get; set; }
    }
}
