using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B50 RID: 2896
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ERotatorQuantization")]
	public enum ERotatorQuantization : byte
	{
		// Token: 0x04004FB8 RID: 20408
		ByteComponents,
		// Token: 0x04004FB9 RID: 20409
		ShortComponents,
		// Token: 0x04004FBA RID: 20410
		ERotatorQuantization_MAX
	}
}
