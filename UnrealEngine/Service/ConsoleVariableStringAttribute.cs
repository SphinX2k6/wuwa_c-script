using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Service
{
	// Token: 0x02002AFA RID: 11002
	[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
	public class ConsoleVariableStringAttribute : Attribute
	{
		// Token: 0x06028489 RID: 165001 RVA: 0x003D49DC File Offset: 0x003D2BDC
		[NullableContext(1)]
		public ConsoleVariableStringAttribute(string Name, string DefaultValue, string Help, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_Default)
		{
		}
	}
}
