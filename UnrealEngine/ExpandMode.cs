using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001805 RID: 6149
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroDynamicAtlas.ExpandMode")]
	public enum ExpandMode : byte
	{
		// Token: 0x0400C5A0 RID: 50592
		None,
		// Token: 0x0400C5A1 RID: 50593
		InPlace,
		// Token: 0x0400C5A2 RID: 50594
		Horizontal,
		// Token: 0x0400C5A3 RID: 50595
		Vertical,
		// Token: 0x0400C5A4 RID: 50596
		ExpandMode_MAX
	}
}
