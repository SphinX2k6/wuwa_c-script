using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002644 RID: 9796
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/PhysicsCore.ESleepFamily")]
	public enum ESleepFamily : byte
	{
		// Token: 0x040138DA RID: 80090
		Normal,
		// Token: 0x040138DB RID: 80091
		Sensitive,
		// Token: 0x040138DC RID: 80092
		Custom,
		// Token: 0x040138DD RID: 80093
		ESleepFamily_MAX
	}
}
