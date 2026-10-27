using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A29 RID: 10793
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.ELevelVisibilityDirtyMode")]
	public enum ELevelVisibilityDirtyMode : byte
	{
		// Token: 0x04015E35 RID: 89653
		ModifyOnChange,
		// Token: 0x04015E36 RID: 89654
		DontModify,
		// Token: 0x04015E37 RID: 89655
		ELevelVisibilityDirtyMode_MAX
	}
}
