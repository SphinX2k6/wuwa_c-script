using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200284E RID: 10318
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Slate.EScrollWhenFocusChanges")]
	public enum EScrollWhenFocusChanges : byte
	{
		// Token: 0x04014FD4 RID: 85972
		NoScroll,
		// Token: 0x04014FD5 RID: 85973
		InstantScroll,
		// Token: 0x04014FD6 RID: 85974
		AnimatedScroll,
		// Token: 0x04014FD7 RID: 85975
		EScrollWhenFocusChanges_MAX
	}
}
