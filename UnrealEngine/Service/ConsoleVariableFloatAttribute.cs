using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Service
{
	// Token: 0x020008A9 RID: 2217
	[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
	public class ConsoleVariableFloatAttribute : Attribute
	{
		// Token: 0x0600BE42 RID: 48706 RVA: 0x0012FD30 File Offset: 0x0012DF30
		[NullableContext(1)]
		public ConsoleVariableFloatAttribute(string Name, float DefaultValue, string Help, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_Default)
		{
		}
	}
}
