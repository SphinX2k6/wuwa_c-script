using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000341 RID: 833
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroComponent.ESimpleRunState")]
	public enum ESimpleRunState : byte
	{
		// Token: 0x04002334 RID: 9012
		Stop,
		// Token: 0x04002335 RID: 9013
		Run,
		// Token: 0x04002336 RID: 9014
		Wait,
		// Token: 0x04002337 RID: 9015
		ESimpleRunState_MAX
	}
}
