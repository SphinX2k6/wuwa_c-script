using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using UnrealEngine.Service.Flags;

namespace UnrealEngine.Service
{
	// Token: 0x02002AFE RID: 11006
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	public class UClassAttribute : Attribute
	{
		// Token: 0x0602849C RID: 165020 RVA: 0x003D4B5C File Offset: 0x003D2D5C
		public UClassAttribute([NotNull] string path, EClassFlags flags = EClassFlags.CLASS_None)
		{
		}

		// Token: 0x040162BD RID: 90813
		public string Path = path;

		// Token: 0x040162BE RID: 90814
		public EClassFlags Flags = flags;
	}
}
