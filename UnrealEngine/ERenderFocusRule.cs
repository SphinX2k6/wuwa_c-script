using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B45 RID: 2885
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ERenderFocusRule")]
	public enum ERenderFocusRule : byte
	{
		// Token: 0x04004F79 RID: 20345
		Always,
		// Token: 0x04004F7A RID: 20346
		NonPointer,
		// Token: 0x04004F7B RID: 20347
		NavigationOnly,
		// Token: 0x04004F7C RID: 20348
		Never,
		// Token: 0x04004F7D RID: 20349
		ERenderFocusRule_MAX
	}
}
