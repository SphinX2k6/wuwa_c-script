using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020000C8 RID: 200
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ACLPlugin.ACLRotationFormat")]
	public enum ACLRotationFormat
	{
		// Token: 0x04000279 RID: 633
		ACLRF_Quat_128,
		// Token: 0x0400027A RID: 634
		ACLRF_QuatDropW_96,
		// Token: 0x0400027B RID: 635
		ACLRF_QuatDropW_Variable,
		// Token: 0x0400027C RID: 636
		ACLRF_MAX
	}
}
