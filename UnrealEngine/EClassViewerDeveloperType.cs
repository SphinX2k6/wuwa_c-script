using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A11 RID: 10769
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EClassViewerDeveloperType")]
	public enum EClassViewerDeveloperType : byte
	{
		// Token: 0x04015D89 RID: 89481
		CVDT_None,
		// Token: 0x04015D8A RID: 89482
		CVDT_CurrentUser,
		// Token: 0x04015D8B RID: 89483
		CVDT_All,
		// Token: 0x04015D8C RID: 89484
		CVDT_Max,
		// Token: 0x04015D8D RID: 89485
		CVDT_MAX
	}
}
