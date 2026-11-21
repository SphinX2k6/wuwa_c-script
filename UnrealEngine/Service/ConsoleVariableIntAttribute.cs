using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Service
{
	// Token: 0x020008A8 RID: 2216
	[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
	public class ConsoleVariableIntAttribute : Attribute
	{
		// Token: 0x0600BE41 RID: 48705 RVA: 0x0012FD28 File Offset: 0x0012DF28
		[NullableContext(1)]
		public ConsoleVariableIntAttribute(string Name, int DefaultValue, string Help, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_Default)
		{
		}
	}
}
