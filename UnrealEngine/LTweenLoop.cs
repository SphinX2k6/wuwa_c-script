using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002255 RID: 8789
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LTween.LTweenLoop")]
	public enum LTweenLoop : byte
	{
		// Token: 0x04011CE5 RID: 72933
		Once,
		// Token: 0x04011CE6 RID: 72934
		Restart,
		// Token: 0x04011CE7 RID: 72935
		Yoyo,
		// Token: 0x04011CE8 RID: 72936
		Incremental,
		// Token: 0x04011CE9 RID: 72937
		LTweenLoop_MAX
	}
}
