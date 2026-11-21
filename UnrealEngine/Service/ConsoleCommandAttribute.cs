using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Service
{
	// Token: 0x020008AB RID: 2219
	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	public class ConsoleCommandAttribute : Attribute
	{
		// Token: 0x0600BE44 RID: 48708 RVA: 0x0012FD40 File Offset: 0x0012DF40
		[NullableContext(1)]
		public ConsoleCommandAttribute(string Name, string Help, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_Default)
		{
		}
	}
}
