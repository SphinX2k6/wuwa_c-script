using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200291B RID: 10523
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/TLBSBase.EDawnLogLevel")]
	public enum EDawnLogLevel
	{
		// Token: 0x04015671 RID: 87665
		DawnLogLevel_Trace,
		// Token: 0x04015672 RID: 87666
		DawnLogLevel_Debug,
		// Token: 0x04015673 RID: 87667
		DawnLogLevel_Info,
		// Token: 0x04015674 RID: 87668
		DawnLogLevel_Warn,
		// Token: 0x04015675 RID: 87669
		DawnLogLevel_Err,
		// Token: 0x04015676 RID: 87670
		DawnLogLevel_Critical,
		// Token: 0x04015677 RID: 87671
		DawnLogLevel_Off,
		// Token: 0x04015678 RID: 87672
		DawnLogLevel_Max,
		// Token: 0x04015679 RID: 87673
		DawnLogLevel_MAX
	}
}
