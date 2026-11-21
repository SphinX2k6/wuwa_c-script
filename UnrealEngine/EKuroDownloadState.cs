using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200043C RID: 1084
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroHotPatch.EKuroDownloadState")]
	public enum EKuroDownloadState : byte
	{
		// Token: 0x04002CB4 RID: 11444
		None,
		// Token: 0x04002CB5 RID: 11445
		HttpError,
		// Token: 0x04002CB6 RID: 11446
		FileRenameError,
		// Token: 0x04002CB7 RID: 11447
		ValidateError,
		// Token: 0x04002CB8 RID: 11448
		OpenToWriteError,
		// Token: 0x04002CB9 RID: 11449
		NotEnoughSpace,
		// Token: 0x04002CBA RID: 11450
		DownloadCanceled,
		// Token: 0x04002CBB RID: 11451
		DownloadSuccess,
		// Token: 0x04002CBC RID: 11452
		ChangeToCell,
		// Token: 0x04002CBD RID: 11453
		EKuroDownloadState_MAX
	}
}
