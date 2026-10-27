using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A9F RID: 2719
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ELevelInstancePivotType")]
	public enum ELevelInstancePivotType : byte
	{
		// Token: 0x04004913 RID: 18707
		CenterMinZ,
		// Token: 0x04004914 RID: 18708
		Center,
		// Token: 0x04004915 RID: 18709
		Actor,
		// Token: 0x04004916 RID: 18710
		WorldOrigin,
		// Token: 0x04004917 RID: 18711
		ELevelInstancePivotType_MAX
	}
}
