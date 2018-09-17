/*
 * Copyright (c) 2018 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Runtime.InteropServices;
using static Interop.Camera;

namespace Tizen.Multimedia
{
    /// <summary>
    /// The class containing the rgb data for subject distance.
    /// </summary>
    /// <since_tizen> 5 </since_tizen>
    public class RgbPlane : IPreviewPlane
    {
        internal RgbPlane(RgbPlaneStruct unmanagedData)
        {
            Data = new byte[unmanagedData.DataLength];
            Marshal.Copy(unmanagedData.Data, Data, 0, (int)unmanagedData.DataLength);
        }

        /// <summary>
        /// The buffer containing the rgb data.
        /// </summary>
        /// <since_tizen> 5 </since_tizen>
        public byte[] Data { get; }
    }
}
