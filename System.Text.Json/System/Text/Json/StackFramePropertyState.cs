using System;

namespace System.Text.Json
{
	// Token: 0x02000050 RID: 80
	internal enum StackFramePropertyState : byte
	{
		// Token: 0x0400015F RID: 351
		None,
		// Token: 0x04000160 RID: 352
		ReadName,
		// Token: 0x04000161 RID: 353
		Name,
		// Token: 0x04000162 RID: 354
		ReadValue,
		// Token: 0x04000163 RID: 355
		ReadValueIsEnd,
		// Token: 0x04000164 RID: 356
		TryRead
	}
}
