using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000461 RID: 1121
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Chaos.EFieldResolutionType")]
	public enum EFieldResolutionType
	{
		// Token: 0x04001BFC RID: 7164
		Field_Resolution_Minimal,
		// Token: 0x04001BFD RID: 7165
		Field_Resolution_DisabledParents,
		// Token: 0x04001BFE RID: 7166
		Field_Resolution_Maximum,
		// Token: 0x04001BFF RID: 7167
		Field_Resolution_Max,
		// Token: 0x04001C00 RID: 7168
		Field_Resolution_MAX
	}
}
