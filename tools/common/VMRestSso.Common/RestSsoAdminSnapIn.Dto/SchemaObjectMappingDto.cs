﻿/*
 * Copyright © 2012-2015 VMware, Inc.  All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the “License”); you may not
 * use this file except in compliance with the License.  You may obtain a copy
 * of the License at http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an “AS IS” BASIS, without
 * warranties or conditions of any kind, EITHER EXPRESS OR IMPLIED.  See the
 * License for the specific language governing permissions and limitations
 * under the License.
 */

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Vmware.Tools.RestSsoAdminSnapIn.Dto
{
    [DataContract]
    public class SchemaObjectMappingDto : IDataContext
    {
        [DataMember]
        private string objectClass;
        public string ObjectClass
        {
            get { return objectClass; }
            set { objectClass = value; }
        }
        [DataMember]
        private Dictionary<string, string> attributeMappings;
        public Dictionary<string, string> AttributeMappings
        {
            get { return attributeMappings; }
            set { attributeMappings = value; }
        }

        public string ObjectId { get; set; }
    }
}
