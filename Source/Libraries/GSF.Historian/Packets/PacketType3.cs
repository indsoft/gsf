//******************************************************************************************************
//  PacketType3.cs - Gbtc
//
//  Copyright � 2010, Grid Protection Alliance.  All Rights Reserved.
//
//  Licensed to the Grid Protection Alliance (GPA) under one or more contributor license agreements. See
//  the NOTICE file distributed with this work for additional information regarding copyright ownership.
//  The GPA licenses this file to you under the Eclipse Public License -v 1.0 (the "License"); you may
//  not use this file except in compliance with the License. You may obtain a copy of the License at:
//
//      http://www.opensource.org/licenses/eclipse-1.0.php
//
//  Unless agreed to in writing, the subject software distributed under the License is distributed on an
//  "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
//  License for the specific language governing permissions and limitations.
//
//  Code Modification History:
//  -----------------------------------------------------------------------------------------------------
//  06/15/2007 - Pinal C. Patel
//       Generated original version of source code.
//  04/21/2009 - Pinal C. Patel
//       Converted to C#.
//  09/10/2009 - Pinal C. Patel
//       Modified Process() to use deferred execution using "yield" for efficiency.
//  09/15/2009 - Stephen C. Wills
//       Added new header and license agreement.
//  10/11/2010 - Mihir Brahmbhatt
//       Updated header and license agreement.
//  11/30/2011 - J. Ritchie Carroll
//       Modified to support buffer optimized ISupportBinaryImage.
//
//******************************************************************************************************

using System.Collections.Generic;
using GSF.Historian.Files;
using GSF.Parsing;

namespace GSF.Historian.Packets
{
    /// <summary>
    /// Represents a packet to be used for requesting <see cref="MetadataRecord.Summary"/> for the <see cref="QueryPacketBase.RequestIDs"/>.
    /// </summary>
    public class PacketType3 : QueryPacketBase
    {
        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of the <see cref="PacketType3"/> class.
        /// </summary>
        public PacketType3()
            : base(3)
        {
            ProcessHandler = Process;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PacketType3"/> class.
        /// </summary>
        /// <param name="buffer">Binary image to be used for initializing <see cref="PacketType3"/>.</param>
        /// <param name="startIndex">0-based starting index of initialization data in the <paramref name="buffer"/>.</param>
        /// <param name="length">Valid number of bytes in <paramref name="buffer"/> from <paramref name="startIndex"/>.</param>
        public PacketType3(byte[] buffer, int startIndex, int length)
            : this()
        {
            ParseBinaryImage(buffer, startIndex, length);
        }

        #endregion

        #region [ Methods ]

        /// <summary>
        /// Processes <see cref="PacketType3"/>.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/> object containing the binary images of <see cref="MetadataRecord.Summary"/> for the <see cref="QueryPacketBase.RequestIDs"/>.</returns>
        protected virtual IEnumerable<byte[]> Process()
        {
            if (Archive == null)
                yield break;

            byte[] data;
            if (RequestIDs.Count == 0 || (RequestIDs.Count == 1 && RequestIDs[0] == -1))
            {
                // Information for all defined records is requested.
                int id = 0;
                while (true)
                {
                    data = Archive.ReadMetaDataSummary(++id);
                    if (data == null)
                        // No more records.
                        break;
                    else
                        // Yield retrieved data.
                        yield return data;
                }
            }
            else
            {
                // Information for specific records is requested.
                foreach (int id in RequestIDs)
                {
                    data = Archive.ReadMetaDataSummary(id);
                    if (data == null)
                        // ID is invalid.
                        continue;
                    else
                        // Yield retrieved data.
                        yield return data;
                }
            }
            yield return new MetadataRecord(-1).Summary.BinaryImage();    // To indicate EOT.
        }

        #endregion
    }
}