using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Service
{
	// Token: 0x02002AF7 RID: 10999
	[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
	public class ConsoleVariableBoolAttribute : Attribute
	{
		// Token: 0x06028486 RID: 164998 RVA: 0x003D49C4 File Offset: 0x003D2BC4
		[NullableContext(1)]
		public ConsoleVariableBoolAttribute(string Name, bool DefaultValue, string Help, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_Default)
		{
		}
	}
}
