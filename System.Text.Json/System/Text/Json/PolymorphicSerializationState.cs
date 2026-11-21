using System;

namespace System.Text.Json
{
	// Token: 0x0200003D RID: 61
	internal enum PolymorphicSerializationState : byte
	{
		// Token: 0x040000EA RID: 234
		None,
		// Token: 0x040000EB RID: 235
		PolymorphicReEntryStarted,
		// Token: 0x040000EC RID: 236
		PolymorphicReEntrySuspended,
		// Token: 0x040000ED RID: 237
		PolymorphicReEntryNotFound
	}
}
