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
using Db4oUnit;
using Db4oUnit.Extensions;
using Db4objects.Db4o.Tests.Common.Interfaces;

namespace Db4objects.Db4o.Tests.Common.Interfaces
{
	public class InterfaceArrayTestCase : AbstractDb4oTestCase
	{
		public interface IFoo
		{
		}

		public class FooImpl : InterfaceArrayTestCase.IFoo
		{
		}

		public class Bar
		{
			public Bar(InterfaceArrayTestCase.IFoo[] foos)
			{
				this.foos = foos;
			}

			public InterfaceArrayTestCase.IFoo[] foos;
		}

		/// <exception cref="System.Exception"></exception>
		protected override void Store()
		{
			Store(new InterfaceArrayTestCase.Bar(new InterfaceArrayTestCase.IFoo[] { new InterfaceArrayTestCase.FooImpl
				() }));
		}

		public virtual void Test()
		{
			Assert.AreEqual(1, ((InterfaceArrayTestCase.Bar)RetrieveOnlyInstance(typeof(InterfaceArrayTestCase.Bar
				))).foos.Length);
		}
	}
}
