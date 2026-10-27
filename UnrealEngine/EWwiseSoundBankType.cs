using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A71 RID: 10865
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/WwiseFileHandler.EWwiseSoundBankType")]
	public enum EWwiseSoundBankType : byte
	{
		// Token: 0x04015FDB RID: 90075
		User,
		// Token: 0x04015FDC RID: 90076
		Event = 30,
		// Token: 0x04015FDD RID: 90077
		Bus,
		// Token: 0x04015FDE RID: 90078
		EWwiseSoundBankType_MAX
	}
}
