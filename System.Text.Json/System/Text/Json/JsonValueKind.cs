using System;

namespace System.Text.Json
{
	// Token: 0x0200002C RID: 44
	public enum JsonValueKind : byte
	{
		// Token: 0x0400006E RID: 110
		Undefined,
		// Token: 0x0400006F RID: 111
		Object,
		// Token: 0x04000070 RID: 112
		Array,
		// Token: 0x04000071 RID: 113
		String,
		// Token: 0x04000072 RID: 114
		Number,
		// Token: 0x04000073 RID: 115
		True,
		// Token: 0x04000074 RID: 116
		False,
		// Token: 0x04000075 RID: 117
		Null
	}
}
