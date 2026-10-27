using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CB2 RID: 7346
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSDK.UKuroSDKEventType")]
	public enum UKuroSDKEventType : byte
	{
		// Token: 0x0400F4F8 RID: 62712
		KuroSDKLogin,
		// Token: 0x0400F4F9 RID: 62713
		KuroSDKKick,
		// Token: 0x0400F4FA RID: 62714
		KuroSDKSelectedRole,
		// Token: 0x0400F4FB RID: 62715
		KuroSDKCreateRole,
		// Token: 0x0400F4FC RID: 62716
		KuroSDKUpgradeRole,
		// Token: 0x0400F4FD RID: 62717
		KuroSDKExit,
		// Token: 0x0400F4FE RID: 62718
		KuroSDKLogout,
		// Token: 0x0400F4FF RID: 62719
		KuroSDKOpenLoginWnd,
		// Token: 0x0400F500 RID: 62720
		KuroPay,
		// Token: 0x0400F501 RID: 62721
		KuroOpenSdkUrlWnd,
		// Token: 0x0400F502 RID: 62722
		KuroInitializePostWebView,
		// Token: 0x0400F503 RID: 62723
		KuroOpenPostWebView,
		// Token: 0x0400F504 RID: 62724
		KuroOpenPrivacyClauseWnd,
		// Token: 0x0400F505 RID: 62725
		KuroOpenUserCenter,
		// Token: 0x0400F506 RID: 62726
		KuroReadProductInfo,
		// Token: 0x0400F507 RID: 62727
		KuroShowAgreement,
		// Token: 0x0400F508 RID: 62728
		KuroNotiLanguage,
		// Token: 0x0400F509 RID: 62729
		KuroDoInit,
		// Token: 0x0400F50A RID: 62730
		UKuroSDKEventType_MAX
	}
}
