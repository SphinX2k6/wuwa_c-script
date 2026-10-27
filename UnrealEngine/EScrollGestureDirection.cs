using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A3D RID: 10813
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EScrollGestureDirection")]
	public enum EScrollGestureDirection : byte
	{
		// Token: 0x04015EAB RID: 89771
		UseSystemSetting,
		// Token: 0x04015EAC RID: 89772
		Standard,
		// Token: 0x04015EAD RID: 89773
		Natural,
		// Token: 0x04015EAE RID: 89774
		EScrollGestureDirection_MAX
	}
}
