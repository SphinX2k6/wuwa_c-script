using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020007BF RID: 1983
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Renderer.EKuroCaptureSceneColorType")]
	public enum EKuroCaptureSceneColorType : byte
	{
		// Token: 0x040049D8 RID: 18904
		KCSCT_Default,
		// Token: 0x040049D9 RID: 18905
		KCSCT_ShouAnRen,
		// Token: 0x040049DA RID: 18906
		KCSCT_Chun,
		// Token: 0x040049DB RID: 18907
		KCSCT_Tideng,
		// Token: 0x040049DC RID: 18908
		KCSCT_MAX
	}
}
