using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003EF RID: 1007
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARPlaneOrientation")]
	public enum EARPlaneOrientation : byte
	{
		// Token: 0x040018AC RID: 6316
		Horizontal,
		// Token: 0x040018AD RID: 6317
		Vertical,
		// Token: 0x040018AE RID: 6318
		Diagonal,
		// Token: 0x040018AF RID: 6319
		EARPlaneOrientation_MAX
	}
}
