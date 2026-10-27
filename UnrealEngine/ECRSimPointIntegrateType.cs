using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004F0 RID: 1264
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ControlRig.ECRSimPointIntegrateType")]
	public enum ECRSimPointIntegrateType : byte
	{
		// Token: 0x04002045 RID: 8261
		Verlet,
		// Token: 0x04002046 RID: 8262
		SemiExplicitEuler,
		// Token: 0x04002047 RID: 8263
		ECRSimPointIntegrateType_MAX
	}
}
