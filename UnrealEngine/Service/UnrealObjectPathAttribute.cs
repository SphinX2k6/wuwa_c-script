using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Service
{
	// Token: 0x020008B2 RID: 2226
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface)]
	public class UnrealObjectPathAttribute : Attribute
	{
		// Token: 0x0600BE5A RID: 48730 RVA: 0x0012FEFB File Offset: 0x0012E0FB
		public UnrealObjectPathAttribute(string Path)
		{
		}

		// Token: 0x040056DA RID: 22234
		public string Path = Path;
	}
}
