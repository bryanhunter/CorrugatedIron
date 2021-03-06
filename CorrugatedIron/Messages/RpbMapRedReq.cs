﻿// Copyright (c) 2011 - OJ Reeves & Jeremiah Peschka
//
// This file is provided to you under the Apache License,
// Version 2.0 (the "License"); you may not use this file
// except in compliance with the License.  You may obtain
// a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.

using System;
using ProtoBuf;

namespace CorrugatedIron.Messages
{
    [Serializable]
    [ProtoContract(Name = "RpbMapRedReq")]
    internal class RpbMapRedReq
    {
        [ProtoMember(1, IsRequired = true, Name = "request", DataFormat = DataFormat.Default)]
        internal byte[] Request { get; set; }

        [ProtoMember(2, IsRequired = true, Name = "content_type", DataFormat = DataFormat.Default)]
        internal byte[] ContentType { get; set; }
    }
}
