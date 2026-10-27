using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A38 RID: 10808
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EProjectPackagingBuild")]
	public enum EProjectPackagingBuild
	{
		// Token: 0x04015E8E RID: 89742
		Always,
		// Token: 0x04015E8F RID: 89743
		Never,
		// Token: 0x04015E90 RID: 89744
		IfProjectHasCode,
		// Token: 0x04015E91 RID: 89745
		IfEditorWasBuiltLocally,
		// Token: 0x04015E92 RID: 89746
		EProjectPackagingBuild_MAX
	}
}
