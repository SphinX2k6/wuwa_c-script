using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Service
{
	// Token: 0x02002AF8 RID: 11000
	[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
	public class ConsoleVariableIntAttribute : Attribute
	{
		// Token: 0x06028487 RID: 164999 RVA: 0x003D49CC File Offset: 0x003D2BCC
		[NullableContext(1)]
		public ConsoleVariableIntAttribute(string Name, int DefaultValue, string Help, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_Default)
		{
		}
	}
}
