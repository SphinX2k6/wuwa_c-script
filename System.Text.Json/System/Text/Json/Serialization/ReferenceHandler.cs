using System;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization
{
	// Token: 0x020000AF RID: 175
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ReferenceHandler
	{
		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x0002A9EA File Offset: 0x00028BEA
		public static ReferenceHandler Preserve { get; } = new PreserveReferenceHandler();

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x0002A9F1 File Offset: 0x00028BF1
		public static ReferenceHandler IgnoreCycles { get; } = new IgnoreReferenceHandler();

		// Token: 0x060009E5 RID: 2533
		public abstract ReferenceResolver CreateResolver();

		// Token: 0x060009E6 RID: 2534 RVA: 0x0002A9F8 File Offset: 0x00028BF8
		internal virtual ReferenceResolver CreateResolver(bool writing)
		{
			return this.CreateResolver();
		}

		// Token: 0x040002C8 RID: 712
		internal ReferenceHandlingStrategy HandlingStrategy = ReferenceHandlingStrategy.Preserve;
	}
}
