// ByteFX.Data data access components for .Net
// Copyright (C) 2002-2003  ByteFX, Inc.
//
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA

using System;
using System.Runtime.Serialization;

namespace ByteFX.Data.MySqlClient
{
	/// <summary>
	/// Summary description for MySqlException.
	/// </summary>
	[Serializable]
	public sealed class MySqlException : Exception
	{
		public MySqlException(string msg) : base(msg)
		{
		}

		public MySqlException() 
		{
		}

		public MySqlException(string msg, int errno) : base(msg)
		{
			
		}

		public MySqlException(SerializationInfo info,
					StreamingContext context) : base(info, context)
		{
		}

	}
}
