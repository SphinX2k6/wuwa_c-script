using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200250F RID: 9487
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagraDataChannel_IslandMode")]
	public enum ENiagraDataChannel_IslandMode : byte
	{
		// Token: 0x04012EBC RID: 77500
		AlignedStatic,
		// Token: 0x04012EBD RID: 77501
		Dynamic,
		// Token: 0x04012EBE RID: 77502
		ENiagraDataChannel_MAX
	}
}
