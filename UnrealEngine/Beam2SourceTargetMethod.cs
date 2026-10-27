using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020008A7 RID: 2215
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.Beam2SourceTargetMethod")]
	public enum Beam2SourceTargetMethod
	{
		// Token: 0x04003A38 RID: 14904
		PEB2STM_Default,
		// Token: 0x04003A39 RID: 14905
		PEB2STM_UserSet,
		// Token: 0x04003A3A RID: 14906
		PEB2STM_Emitter,
		// Token: 0x04003A3B RID: 14907
		PEB2STM_Particle,
		// Token: 0x04003A3C RID: 14908
		PEB2STM_Actor,
		// Token: 0x04003A3D RID: 14909
		PEB2STM_MAX
	}
}
