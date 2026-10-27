using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024DF RID: 9439
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENDISkeletalMesh_SourceMode")]
	public enum ENDISkeletalMesh_SourceMode : byte
	{
		// Token: 0x04012DA9 RID: 77225
		Default,
		// Token: 0x04012DAA RID: 77226
		Source,
		// Token: 0x04012DAB RID: 77227
		AttachParent,
		// Token: 0x04012DAC RID: 77228
		ENDISkeletalMesh_MAX
	}
}
