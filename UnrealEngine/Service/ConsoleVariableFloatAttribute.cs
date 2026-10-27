using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Service
{
	// Token: 0x02002AF9 RID: 11001
	[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
	public class ConsoleVariableFloatAttribute : Attribute
	{
		// Token: 0x06028488 RID: 165000 RVA: 0x003D49D4 File Offset: 0x003D2BD4
		[NullableContext(1)]
		public ConsoleVariableFloatAttribute(string Name, float DefaultValue, string Help, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_Default)
		{
		}
	}
}
