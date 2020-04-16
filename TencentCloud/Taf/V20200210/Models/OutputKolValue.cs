/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Taf.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OutputKolValue : AbstractModel
    {
        
        /// <summary>
        /// KOL账号ID[比如微信公众号ID]
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 是否查得[0：未查得；1：查得]
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsCheck")]
        public long? IsCheck{ get; set; }

        /// <summary>
        /// 作弊的可能性[0～100]
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FraudPScore")]
        public long? FraudPScore{ get; set; }

        /// <summary>
        /// 作弊的严重性[0～100]
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EvilPScore")]
        public long? EvilPScore{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "IsCheck", this.IsCheck);
            this.SetParamSimple(map, prefix + "FraudPScore", this.FraudPScore);
            this.SetParamSimple(map, prefix + "EvilPScore", this.EvilPScore);
        }
    }
}

