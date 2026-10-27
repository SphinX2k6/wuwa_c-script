using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000502 RID: 1282
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ControlRig.ETransformGetterType")]
	public enum ETransformGetterType : byte
	{
		// Token: 0x040020AF RID: 8367
		Initial,
		// Token: 0x040020B0 RID: 8368
		Current,
		// Token: 0x040020B1 RID: 8369
		Max,
		// Token: 0x040020B2 RID: 8370
		ETransformGetterType_MAX
	}
}
