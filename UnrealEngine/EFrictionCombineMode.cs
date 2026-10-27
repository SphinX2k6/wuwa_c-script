using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200263F RID: 9791
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/PhysicsCore.EFrictionCombineMode")]
	public enum EFrictionCombineMode
	{
		// Token: 0x04013884 RID: 80004
		Average,
		// Token: 0x04013885 RID: 80005
		Min,
		// Token: 0x04013886 RID: 80006
		Multiply,
		// Token: 0x04013887 RID: 80007
		Max,
		// Token: 0x04013888 RID: 80008
		EFrictionCombineMode_MAX
	}
}
