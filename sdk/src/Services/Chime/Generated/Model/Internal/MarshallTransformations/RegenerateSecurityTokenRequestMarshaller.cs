/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Chime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Chime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RegenerateSecurityToken Request Marshaller
    /// </summary>       
    public class RegenerateSecurityTokenRequestMarshaller : IMarshaller<IRequest, RegenerateSecurityTokenRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RegenerateSecurityTokenRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RegenerateSecurityTokenRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Chime");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-01";            
            request.HttpMethod = "POST";

            string uriResourcePath = "/accounts/{accountId}/bots/{botId}";
            request.AddSubResource("operation", "regenerate-security-token");
            if (!publicRequest.IsSetAccountId())
                throw new AmazonChimeException("Request object does not have required field AccountId set");
            uriResourcePath = uriResourcePath.Replace("{accountId}", StringUtils.FromStringWithSlashEncoding(publicRequest.AccountId));
            if (!publicRequest.IsSetBotId())
                throw new AmazonChimeException("Request object does not have required field BotId set");
            uriResourcePath = uriResourcePath.Replace("{botId}", StringUtils.FromStringWithSlashEncoding(publicRequest.BotId));
            request.ResourcePath = uriResourcePath;

            return request;
        }
        private static RegenerateSecurityTokenRequestMarshaller _instance = new RegenerateSecurityTokenRequestMarshaller();        

        internal static RegenerateSecurityTokenRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RegenerateSecurityTokenRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}