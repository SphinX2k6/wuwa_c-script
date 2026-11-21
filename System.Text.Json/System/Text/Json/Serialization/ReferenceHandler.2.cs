using System;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization
{
	// Token: 0x020000B0 RID: 176
	public sealed class ReferenceHandler<T> : ReferenceHandler where T : ReferenceResolver, new()
	{
		// Token: 0x060009E9 RID: 2537 RVA: 0x0002AA25 File Offset: 0x00028C25
		[NullableContext(1)]
		public override ReferenceResolver CreateResolver()
		{
			return Activator.CreateInstance<T>();
		}
	}
}
