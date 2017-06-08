﻿/*
 * Copyright © 2012-2016 VMware, Inc.  All Rights Reserved.
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

using System;
using System.Collections.Generic;
using Foundation;

namespace VmIdentity.UI.Common
{
    public class ScopeNodeBase :NSObject
    {
        public String DisplayName;

        public object Tag { get; set; }

        public ScopeNodeBase Parent { get; set; }

        public List<ScopeNodeBase> Children { get; set; }

        public ScopeNodeBase ()
        {
            this.DisplayName = "";
            this.Tag = null;
            this.Children = new List<ScopeNodeBase> ();
            this.Parent = null;
        }

        public int NumberOfChildren ()
        {
            if (this.Children == null)
                return 0;
            else
                return this.Children.Count;
        }

        public ScopeNodeBase ChildAtIndex (int n)
        {
            if (this.Children != null && n < NumberOfChildren ()) {
                ScopeNodeBase item = this.Children [n];
                return item;
            } else {
                return null;
            }
        }
    }
}

