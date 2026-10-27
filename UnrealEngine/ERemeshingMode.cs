using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200279D RID: 10141
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SimplygonUObjects.ERemeshingMode")]
	public enum ERemeshingMode : byte
	{
		// Token: 0x04014A3C RID: 84540
		Outside,
		// Token: 0x04014A3D RID: 84541
		Inside,
		// Token: 0x04014A3E RID: 84542
		Manual,
		// Token: 0x04014A3F RID: 84543
		ERemeshingMode_MAX
	}
}
