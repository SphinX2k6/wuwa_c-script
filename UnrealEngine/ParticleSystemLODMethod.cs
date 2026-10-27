using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000FC7 RID: 4039
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ParticleSystemLODMethod")]
	public enum ParticleSystemLODMethod
	{
		// Token: 0x04007633 RID: 30259
		PARTICLESYSTEMLODMETHOD_Automatic,
		// Token: 0x04007634 RID: 30260
		PARTICLESYSTEMLODMETHOD_DirectSet,
		// Token: 0x04007635 RID: 30261
		PARTICLESYSTEMLODMETHOD_ActivateAutomatic,
		// Token: 0x04007636 RID: 30262
		PARTICLESYSTEMLODMETHOD_MAX
	}
}
