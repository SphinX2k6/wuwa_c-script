using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004F9 RID: 1273
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRhythmGame.EKuroRhythmGameInputType")]
	public enum EKuroRhythmGameInputType : byte
	{
		// Token: 0x04003262 RID: 12898
		TapLeft,
		// Token: 0x04003263 RID: 12899
		TapRight,
		// Token: 0x04003264 RID: 12900
		FlickLeft,
		// Token: 0x04003265 RID: 12901
		FlickRight,
		// Token: 0x04003266 RID: 12902
		Line,
		// Token: 0x04003267 RID: 12903
		EKuroRhythmGameInputType_MAX
	}
}
