using System;

namespace System.Text.Json
{
	// Token: 0x0200004C RID: 76
	[Flags]
	internal enum MetadataPropertyName : byte
	{
		// Token: 0x04000131 RID: 305
		None = 0,
		// Token: 0x04000132 RID: 306
		Values = 1,
		// Token: 0x04000133 RID: 307
		Id = 2,
		// Token: 0x04000134 RID: 308
		Ref = 4,
		// Token: 0x04000135 RID: 309
		Type = 8
	}
}
