using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009E8 RID: 2536
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAngularDriveMode")]
	public enum EAngularDriveMode
	{
		// Token: 0x04004417 RID: 17431
		SLERP,
		// Token: 0x04004418 RID: 17432
		TwistAndSwing,
		// Token: 0x04004419 RID: 17433
		EAngularDriveMode_MAX
	}
}
