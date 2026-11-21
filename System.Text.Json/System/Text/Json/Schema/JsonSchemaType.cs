using System;

namespace System.Text.Json.Schema
{
	// Token: 0x02000068 RID: 104
	[Flags]
	internal enum JsonSchemaType
	{
		// Token: 0x04000224 RID: 548
		Any = 0,
		// Token: 0x04000225 RID: 549
		Null = 1,
		// Token: 0x04000226 RID: 550
		Boolean = 2,
		// Token: 0x04000227 RID: 551
		Integer = 4,
		// Token: 0x04000228 RID: 552
		Number = 8,
		// Token: 0x04000229 RID: 553
		String = 16,
		// Token: 0x0400022A RID: 554
		Object = 32,
		// Token: 0x0400022B RID: 555
		Array = 64
	}
}
