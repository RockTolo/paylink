﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicFollowCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicFollowCreateModel : AlipayObject
    {
        /// <summary>
        /// 来源，目前只有"tmall"
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
