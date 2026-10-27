using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A90 RID: 2704
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EKuroLightAttenuationShape")]
	public enum EKuroLightAttenuationShape : byte
	{
		// Token: 0x04004873 RID: 18547
		None,
		// Token: 0x04004874 RID: 18548
		Cone,
		// Token: 0x04004875 RID: 18549
		Pyramid,
		// Token: 0x04004876 RID: 18550
		EKuroLightAttenuationShape_MAX
	}
}
