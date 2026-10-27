using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Service
{
	// Token: 0x02002AFB RID: 11003
	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	public class ConsoleCommandAttribute : Attribute
	{
		// Token: 0x0602848A RID: 165002 RVA: 0x003D49E4 File Offset: 0x003D2BE4
		[NullableContext(1)]
		public ConsoleCommandAttribute(string Name, string Help, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_Default)
		{
		}
	}
}
