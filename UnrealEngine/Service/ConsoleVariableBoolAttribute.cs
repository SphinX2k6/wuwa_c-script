using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Service
{
	// Token: 0x020008A7 RID: 2215
	[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
	public class ConsoleVariableBoolAttribute : Attribute
	{
		// Token: 0x0600BE40 RID: 48704 RVA: 0x0012FD20 File Offset: 0x0012DF20
		[NullableContext(1)]
		public ConsoleVariableBoolAttribute(string Name, bool DefaultValue, string Help, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_Default)
		{
		}
	}
}
