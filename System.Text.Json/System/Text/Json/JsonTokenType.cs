using System;

namespace System.Text.Json
{
	// Token: 0x0200002F RID: 47
	public enum JsonTokenType : byte
	{
		// Token: 0x0400007E RID: 126
		None,
		// Token: 0x0400007F RID: 127
		StartObject,
		// Token: 0x04000080 RID: 128
		EndObject,
		// Token: 0x04000081 RID: 129
		StartArray,
		// Token: 0x04000082 RID: 130
		EndArray,
		// Token: 0x04000083 RID: 131
		PropertyName,
		// Token: 0x04000084 RID: 132
		Comment,
		// Token: 0x04000085 RID: 133
		String,
		// Token: 0x04000086 RID: 134
		Number,
		// Token: 0x04000087 RID: 135
		True,
		// Token: 0x04000088 RID: 136
		False,
		// Token: 0x04000089 RID: 137
		Null
	}
}
