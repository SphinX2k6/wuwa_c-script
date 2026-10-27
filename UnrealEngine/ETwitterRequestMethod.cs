using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BA4 RID: 2980
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ETwitterRequestMethod")]
	public enum ETwitterRequestMethod
	{
		// Token: 0x0400520E RID: 21006
		TRM_Get,
		// Token: 0x0400520F RID: 21007
		TRM_Post,
		// Token: 0x04005210 RID: 21008
		TRM_Delete,
		// Token: 0x04005211 RID: 21009
		TRM_MAX
	}
}
