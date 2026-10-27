using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004E9 RID: 1257
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ControlRig.EControlRigDrawSettings")]
	public enum EControlRigDrawSettings
	{
		// Token: 0x0400201E RID: 8222
		Points,
		// Token: 0x0400201F RID: 8223
		Lines,
		// Token: 0x04002020 RID: 8224
		LineStrip,
		// Token: 0x04002021 RID: 8225
		DynamicMesh,
		// Token: 0x04002022 RID: 8226
		EControlRigDrawSettings_MAX
	}
}
