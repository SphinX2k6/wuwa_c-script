using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B1F RID: 2847
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EPostSceneColorDecalInsertLocation")]
	public enum EPostSceneColorDecalInsertLocation : byte
	{
		// Token: 0x04004DEF RID: 19951
		AfterTranslucent,
		// Token: 0x04004DF0 RID: 19952
		BeforeTonemap,
		// Token: 0x04004DF1 RID: 19953
		AfterTonemap,
		// Token: 0x04004DF2 RID: 19954
		KuroBlendWaterCopy,
		// Token: 0x04004DF3 RID: 19955
		Default,
		// Token: 0x04004DF4 RID: 19956
		EPostSceneColorDecalInsertLocation_MAX
	}
}
