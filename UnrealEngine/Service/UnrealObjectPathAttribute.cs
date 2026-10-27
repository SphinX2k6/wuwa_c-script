using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Service
{
	// Token: 0x02002B02 RID: 11010
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface)]
	public class UnrealObjectPathAttribute : Attribute
	{
		// Token: 0x060284A0 RID: 165024 RVA: 0x003D4B9F File Offset: 0x003D2D9F
		public UnrealObjectPathAttribute(string Path)
		{
		}

		// Token: 0x040162C2 RID: 90818
		public string Path = Path;
	}
}
