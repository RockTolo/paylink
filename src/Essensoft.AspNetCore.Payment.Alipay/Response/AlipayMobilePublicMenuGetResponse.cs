﻿using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicMenuGetResponse.
    /// </summary>
    public class AlipayMobilePublicMenuGetResponse : AlipayResponse
    {
        /// <summary>
        /// success
        /// </summary>
        [JsonProperty("code")]
        public override string Code { get; set; }

        /// <summary>
        /// 菜单内容
        /// </summary>
        [JsonProperty("menu_content")]
        public string MenuContent { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [JsonProperty("msg")]
        public override string Msg { get; set; }
    }
}
