using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020015BE RID: 5566
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/json2struct.EJson2StructFilterEnum")]
	public enum EJson2StructFilterEnum : byte
	{
		// Token: 0x0400AEA7 RID: 44711
		Skip,
		// Token: 0x0400AEA8 RID: 44712
		MD5,
		// Token: 0x0400AEA9 RID: 44713
		ToLower,
		// Token: 0x0400AEAA RID: 44714
		ToUpper,
		// Token: 0x0400AEAB RID: 44715
		Set,
		// Token: 0x0400AEAC RID: 44716
		EJson2StructFilterEnum_MAX
	}
}
