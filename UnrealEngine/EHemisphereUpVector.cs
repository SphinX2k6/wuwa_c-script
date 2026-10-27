using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200278F RID: 10127
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SimplygonUObjects.EHemisphereUpVector")]
	public enum EHemisphereUpVector : byte
	{
		// Token: 0x040149EF RID: 84463
		PositiveX,
		// Token: 0x040149F0 RID: 84464
		NegativeX,
		// Token: 0x040149F1 RID: 84465
		PositiveY,
		// Token: 0x040149F2 RID: 84466
		NegativeY,
		// Token: 0x040149F3 RID: 84467
		PositiveZ,
		// Token: 0x040149F4 RID: 84468
		NegativeZ,
		// Token: 0x040149F5 RID: 84469
		EHemisphereUpVector_MAX
	}
}
