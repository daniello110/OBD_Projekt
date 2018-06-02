/* This file is part of the db4o object database http://www.db4o.com

Copyright (C) 2004 - 2011  Versant Corporation http://www.versant.com

db4o is free software; you can redistribute it and/or modify it under
the terms of version 3 of the GNU General Public License as published
by the Free Software Foundation.

db4o is distributed in the hope that it will be useful, but WITHOUT ANY
WARRANTY; without even the implied warranty of MERCHANTABILITY or
FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License
for more details.

You should have received a copy of the GNU General Public License along
with this program.  If not, see http://www.gnu.org/licenses/. */
using Db4objects.Db4o.Config;

namespace Db4objects.Db4o.Config
{
	/// <summary>
	/// A configuration provider that provides access
	/// to the IdSystem-related configuration methods.
	/// </summary>
	/// <remarks>
	/// A configuration provider that provides access
	/// to the IdSystem-related configuration methods.
	/// </remarks>
	public interface IIdSystemConfigurationProvider
	{
		/// <summary>Access to the IdSystem-related configuration methods.</summary>
		/// <remarks>Access to the IdSystem-related configuration methods.</remarks>
		IIdSystemConfiguration IdSystem
		{
			get;
		}
	}
}
