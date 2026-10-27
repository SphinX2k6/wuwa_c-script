using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004E7 RID: 1255
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ControlRig.EControlRigComponentSpace")]
	public enum EControlRigComponentSpace : byte
	{
		// Token: 0x04002012 RID: 8210
		WorldSpace,
		// Token: 0x04002013 RID: 8211
		ActorSpace,
		// Token: 0x04002014 RID: 8212
		ComponentSpace,
		// Token: 0x04002015 RID: 8213
		RigSpace,
		// Token: 0x04002016 RID: 8214
		LocalSpace,
		// Token: 0x04002017 RID: 8215
		Max,
		// Token: 0x04002018 RID: 8216
		EControlRigComponentSpace_MAX
	}
}
