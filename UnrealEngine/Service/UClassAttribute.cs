using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using UnrealEngine.Service.Flags;

namespace UnrealEngine.Service
{
	// Token: 0x020008AE RID: 2222
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	public class UClassAttribute : Attribute
	{
		// Token: 0x0600BE56 RID: 48726 RVA: 0x0012FEB8 File Offset: 0x0012E0B8
		public UClassAttribute([NotNull] string path, EClassFlags flags = EClassFlags.CLASS_None)
		{
		}

		// Token: 0x040056D5 RID: 22229
		public string Path = path;

		// Token: 0x040056D6 RID: 22230
		public EClassFlags Flags = flags;
	}
}
