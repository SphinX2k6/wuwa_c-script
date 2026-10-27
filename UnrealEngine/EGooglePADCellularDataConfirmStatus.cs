using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001452 RID: 5202
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GooglePAD.EGooglePADCellularDataConfirmStatus")]
	public enum EGooglePADCellularDataConfirmStatus : byte
	{
		// Token: 0x0400A2C6 RID: 41670
		AssetPack_CONFIRM_UNKNOWN,
		// Token: 0x0400A2C7 RID: 41671
		AssetPack_CONFIRM_PENDING,
		// Token: 0x0400A2C8 RID: 41672
		AssetPack_CONFIRM_USER_APPROVED,
		// Token: 0x0400A2C9 RID: 41673
		AssetPack_CONFIRM_USER_CANCELED,
		// Token: 0x0400A2CA RID: 41674
		AssetPack_CONFIRM_MAX
	}
}
