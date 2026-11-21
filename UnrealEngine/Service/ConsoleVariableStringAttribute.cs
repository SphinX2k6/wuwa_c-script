using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Service
{
	// Token: 0x020008AA RID: 2218
	[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
	public class ConsoleVariableStringAttribute : Attribute
	{
		// Token: 0x0600BE43 RID: 48707 RVA: 0x0012FD38 File Offset: 0x0012DF38
		[NullableContext(1)]
		public ConsoleVariableStringAttribute(string Name, string DefaultValue, string Help, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_Default)
		{
		}
	}
}
