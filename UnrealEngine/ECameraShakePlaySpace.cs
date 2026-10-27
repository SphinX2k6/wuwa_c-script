using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A22 RID: 2594
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ECameraShakePlaySpace")]
	public enum ECameraShakePlaySpace : byte
	{
		// Token: 0x04004561 RID: 17761
		CameraLocal,
		// Token: 0x04004562 RID: 17762
		World,
		// Token: 0x04004563 RID: 17763
		UserDefined,
		// Token: 0x04004564 RID: 17764
		ECameraShakePlaySpace_MAX
	}
}
