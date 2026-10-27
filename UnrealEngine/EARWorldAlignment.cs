using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003FB RID: 1019
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARWorldAlignment")]
	public enum EARWorldAlignment : byte
	{
		// Token: 0x04001902 RID: 6402
		Gravity,
		// Token: 0x04001903 RID: 6403
		GravityAndHeading,
		// Token: 0x04001904 RID: 6404
		Camera,
		// Token: 0x04001905 RID: 6405
		EARWorldAlignment_MAX
	}
}
