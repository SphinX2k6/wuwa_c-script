using System;

namespace System.Text.Json.Serialization
{
	// Token: 0x0200007E RID: 126
	[Flags]
	public enum JsonNumberHandling
	{
		// Token: 0x0400025E RID: 606
		Strict = 0,
		// Token: 0x0400025F RID: 607
		AllowReadingFromString = 1,
		// Token: 0x04000260 RID: 608
		WriteAsString = 2,
		// Token: 0x04000261 RID: 609
		AllowNamedFloatingPointLiterals = 4
	}
}
