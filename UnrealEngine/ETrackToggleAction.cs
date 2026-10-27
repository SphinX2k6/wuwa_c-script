using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B98 RID: 2968
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ETrackToggleAction")]
	public enum ETrackToggleAction
	{
		// Token: 0x040051C3 RID: 20931
		ETTA_Off,
		// Token: 0x040051C4 RID: 20932
		ETTA_On,
		// Token: 0x040051C5 RID: 20933
		ETTA_Toggle,
		// Token: 0x040051C6 RID: 20934
		ETTA_Trigger,
		// Token: 0x040051C7 RID: 20935
		ETTA_MAX
	}
}
