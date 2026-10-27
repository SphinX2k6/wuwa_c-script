using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200263D RID: 9789
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/PhysicsCore.ECollisionTraceFlag")]
	public enum ECollisionTraceFlag
	{
		// Token: 0x0401387A RID: 79994
		CTF_UseDefault,
		// Token: 0x0401387B RID: 79995
		CTF_UseSimpleAndComplex,
		// Token: 0x0401387C RID: 79996
		CTF_UseSimpleAsComplex,
		// Token: 0x0401387D RID: 79997
		CTF_UseComplexAsSimple,
		// Token: 0x0401387E RID: 79998
		CTF_MAX
	}
}
