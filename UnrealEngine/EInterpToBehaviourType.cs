using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A88 RID: 2696
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EInterpToBehaviourType")]
	public enum EInterpToBehaviourType : byte
	{
		// Token: 0x04004842 RID: 18498
		OneShot,
		// Token: 0x04004843 RID: 18499
		OneShot_Reverse,
		// Token: 0x04004844 RID: 18500
		Loop_Reset,
		// Token: 0x04004845 RID: 18501
		PingPong,
		// Token: 0x04004846 RID: 18502
		EInterpToBehaviourType_MAX
	}
}
