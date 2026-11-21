using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000650 RID: 1616
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EOutOfBoundsType")]
	public enum EOutOfBoundsType : byte
	{
		// Token: 0x04003DD3 RID: 15827
		NotOut,
		// Token: 0x04003DD4 RID: 15828
		OutOfBegin,
		// Token: 0x04003DD5 RID: 15829
		OutOfEnd,
		// Token: 0x04003DD6 RID: 15830
		EOutOfBoundsType_MAX
	}
}
