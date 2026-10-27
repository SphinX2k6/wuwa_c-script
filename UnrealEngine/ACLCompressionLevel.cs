using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020000C6 RID: 198
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ACLPlugin.ACLCompressionLevel")]
	public enum ACLCompressionLevel
	{
		// Token: 0x0400026C RID: 620
		ACLCL_Lowest,
		// Token: 0x0400026D RID: 621
		ACLCL_Low,
		// Token: 0x0400026E RID: 622
		ACLCL_Medium,
		// Token: 0x0400026F RID: 623
		ACLCL_High,
		// Token: 0x04000270 RID: 624
		ACLCL_Highest,
		// Token: 0x04000271 RID: 625
		ACLCL_Automatic,
		// Token: 0x04000272 RID: 626
		ACLCL_MAX
	}
}
