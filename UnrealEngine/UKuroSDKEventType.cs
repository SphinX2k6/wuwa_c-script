using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200054B RID: 1355
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSDK.UKuroSDKEventType")]
	public enum UKuroSDKEventType : byte
	{
		// Token: 0x04003562 RID: 13666
		KuroSDKLogin,
		// Token: 0x04003563 RID: 13667
		KuroSDKKick,
		// Token: 0x04003564 RID: 13668
		KuroSDKSelectedRole,
		// Token: 0x04003565 RID: 13669
		KuroSDKCreateRole,
		// Token: 0x04003566 RID: 13670
		KuroSDKUpgradeRole,
		// Token: 0x04003567 RID: 13671
		KuroSDKExit,
		// Token: 0x04003568 RID: 13672
		KuroSDKLogout,
		// Token: 0x04003569 RID: 13673
		KuroSDKOpenLoginWnd,
		// Token: 0x0400356A RID: 13674
		KuroPay,
		// Token: 0x0400356B RID: 13675
		KuroOpenSdkUrlWnd,
		// Token: 0x0400356C RID: 13676
		KuroInitializePostWebView,
		// Token: 0x0400356D RID: 13677
		KuroOpenPostWebView,
		// Token: 0x0400356E RID: 13678
		KuroOpenPrivacyClauseWnd,
		// Token: 0x0400356F RID: 13679
		KuroOpenUserCenter,
		// Token: 0x04003570 RID: 13680
		KuroReadProductInfo,
		// Token: 0x04003571 RID: 13681
		KuroShowAgreement,
		// Token: 0x04003572 RID: 13682
		KuroNotiLanguage,
		// Token: 0x04003573 RID: 13683
		KuroDoInit,
		// Token: 0x04003574 RID: 13684
		UKuroSDKEventType_MAX
	}
}
