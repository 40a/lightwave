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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VMDNS.Client;
using VMwareMMCIDP.UI.Common.Utilities;

namespace VMDNSSnapIn.UI
{
    public partial class AddNewForwardZone : Form
    {
        public VMDNS_ZONE_INFO ZoneInfo { get; set; }
        public AddNewForwardZone()
        {
            InitializeComponent();
        }

        void DoValidateControls()
        {
            if (String.IsNullOrWhiteSpace(HostIPText.Text) || String.IsNullOrWhiteSpace(HostNameText.Text) || String.IsNullOrWhiteSpace(ZoneNameText.Text))
                throw new Exception(MMCUIConstants.VALUES_EMPTY);
        }

        private void OK_Click(object sender, EventArgs e)
        {
            UIErrorHelper.CheckedExec(delegate()
            {
                DoValidateControls();
                ZoneInfo = new VMDNS_ZONE_INFO()
                {
                    pszName = ZoneNameText.Text,
                    pszRName = AdminEmailText.Text,
                    pszPrimaryDnsSrvName = HostNameText.Text,
                    dwZoneType = (uint)VmDnsZoneType.FORWARD
                };

                this.Close();
                this.DialogResult = DialogResult.OK;
            });
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
