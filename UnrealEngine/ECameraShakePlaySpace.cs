using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001D2 RID: 466
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ECameraShakePlaySpace")]
	public enum ECameraShakePlaySpace : byte
	{
		// Token: 0x04000B5C RID: 2908
		CameraLocal,
		// Token: 0x04000B5D RID: 2909
		World,
		// Token: 0x04000B5E RID: 2910
		UserDefined,
		// Token: 0x04000B5F RID: 2911
		ECameraShakePlaySpace_MAX
	}
}
