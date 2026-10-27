using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003DE RID: 990
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARDepthAccuracy")]
	public enum EARDepthAccuracy : byte
	{
		// Token: 0x0400180C RID: 6156
		Unkown,
		// Token: 0x0400180D RID: 6157
		Approximate,
		// Token: 0x0400180E RID: 6158
		Accurate,
		// Token: 0x0400180F RID: 6159
		EARDepthAccuracy_MAX
	}
}
