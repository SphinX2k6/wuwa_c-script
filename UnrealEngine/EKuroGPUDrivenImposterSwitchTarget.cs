using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001979 RID: 6521
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroGPUDrivenImposterEditor.EKuroGPUDrivenImposterSwitchTarget")]
	public enum EKuroGPUDrivenImposterSwitchTarget : byte
	{
		// Token: 0x0400D1E2 RID: 53730
		KuroImposter,
		// Token: 0x0400D1E3 RID: 53731
		GPUDrivenImposter,
		// Token: 0x0400D1E4 RID: 53732
		EKuroGPUDrivenImposterSwitchTarget_MAX
	}
}
