using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A35 RID: 10805
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EPlayOnBuildMode")]
	public enum EPlayOnBuildMode
	{
		// Token: 0x04015E7C RID: 89724
		PlayOnBuild_Always,
		// Token: 0x04015E7D RID: 89725
		PlayOnBuild_Never,
		// Token: 0x04015E7E RID: 89726
		PlayOnBuild_Default,
		// Token: 0x04015E7F RID: 89727
		PlayOnBuild_IfEditorBuiltLocally,
		// Token: 0x04015E80 RID: 89728
		PlayOnBuild_MAX
	}
}
