//******************************************************************************************************
//  Convert.h - Gbtc
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
//  ----------------------------------------------------------------------------------------------------
//  04/06/2012 - Stephen C. Wills
//       Generated original version of source code.
//
//******************************************************************************************************

#ifndef __CONVERT_H
#define __CONVERT_H

#include <cstddef>
#include <string>
#include "Types.h"

namespace GSF {
namespace TimeSeries
{
	// Thin wrapper around strftime to provide formats for milliseconds (%f) and full-resolution ticks (%t).
	std::size_t TicksToString(char* ptr, std::size_t maxsize, std::string format, int64_t ticks);
}}

#endif