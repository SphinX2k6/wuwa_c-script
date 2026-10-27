using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200250E RID: 9486
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagartaDataChannelReadResult")]
	public enum ENiagartaDataChannelReadResult : byte
	{
		// Token: 0x04012EB8 RID: 77496
		Success,
		// Token: 0x04012EB9 RID: 77497
		Failure,
		// Token: 0x04012EBA RID: 77498
		ENiagartaDataChannelReadResult_MAX
	}
}
