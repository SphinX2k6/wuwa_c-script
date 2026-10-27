using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200148A RID: 5258
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EHoudiniInstancerType")]
	public enum EHoudiniInstancerType : byte
	{
		// Token: 0x0400A485 RID: 42117
		Invalid,
		// Token: 0x0400A486 RID: 42118
		ObjectInstancer,
		// Token: 0x0400A487 RID: 42119
		PackedPrimitive,
		// Token: 0x0400A488 RID: 42120
		AttributeInstancer,
		// Token: 0x0400A489 RID: 42121
		OldSchoolAttributeInstancer,
		// Token: 0x0400A48A RID: 42122
		GeometryCollection,
		// Token: 0x0400A48B RID: 42123
		EHoudiniInstancerType_MAX
	}
}
