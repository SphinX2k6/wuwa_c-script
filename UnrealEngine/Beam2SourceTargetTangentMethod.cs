using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020008A8 RID: 2216
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.Beam2SourceTargetTangentMethod")]
	public enum Beam2SourceTargetTangentMethod
	{
		// Token: 0x04003A3F RID: 14911
		PEB2STTM_Direct,
		// Token: 0x04003A40 RID: 14912
		PEB2STTM_UserSet,
		// Token: 0x04003A41 RID: 14913
		PEB2STTM_Distribution,
		// Token: 0x04003A42 RID: 14914
		PEB2STTM_Emitter,
		// Token: 0x04003A43 RID: 14915
		PEB2STTM_MAX
	}
}
