using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A20 RID: 2592
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ECameraShakeAttenuation")]
	public enum ECameraShakeAttenuation : byte
	{
		// Token: 0x04004558 RID: 17752
		Linear,
		// Token: 0x04004559 RID: 17753
		Quadratic,
		// Token: 0x0400455A RID: 17754
		ECameraShakeAttenuation_MAX
	}
}
