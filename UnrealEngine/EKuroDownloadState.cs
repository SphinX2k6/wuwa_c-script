using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200197F RID: 6527
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroHotPatch.EKuroDownloadState")]
	public enum EKuroDownloadState : byte
	{
		// Token: 0x0400D212 RID: 53778
		None,
		// Token: 0x0400D213 RID: 53779
		HttpError,
		// Token: 0x0400D214 RID: 53780
		FileRenameError,
		// Token: 0x0400D215 RID: 53781
		ValidateError,
		// Token: 0x0400D216 RID: 53782
		OpenToWriteError,
		// Token: 0x0400D217 RID: 53783
		NotEnoughSpace,
		// Token: 0x0400D218 RID: 53784
		DownloadCanceled,
		// Token: 0x0400D219 RID: 53785
		DownloadSuccess,
		// Token: 0x0400D21A RID: 53786
		ChangeToCell,
		// Token: 0x0400D21B RID: 53787
		EKuroDownloadState_MAX
	}
}
