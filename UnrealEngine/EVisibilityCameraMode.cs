using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020027AA RID: 10154
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SimplygonUObjects.EVisibilityCameraMode")]
	public enum EVisibilityCameraMode : byte
	{
		// Token: 0x04014A7D RID: 84605
		Manual,
		// Token: 0x04014A7E RID: 84606
		Sphere,
		// Token: 0x04014A7F RID: 84607
		Hemisphere,
		// Token: 0x04014A80 RID: 84608
		EVisibilityCameraMode_MAX
	}
}
