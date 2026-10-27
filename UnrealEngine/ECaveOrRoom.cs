using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A24 RID: 2596
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ECaveOrRoom")]
	public enum ECaveOrRoom : byte
	{
		// Token: 0x0400456B RID: 17771
		Cave,
		// Token: 0x0400456C RID: 17772
		Room,
		// Token: 0x0400456D RID: 17773
		ECaveOrRoom_MAX
	}
}
