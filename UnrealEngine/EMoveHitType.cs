using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000469 RID: 1129
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroMovement.EMoveHitType")]
	public enum EMoveHitType : byte
	{
		// Token: 0x04002DF4 RID: 11764
		None,
		// Token: 0x04002DF5 RID: 11765
		Wall,
		// Token: 0x04002DF6 RID: 11766
		Floor,
		// Token: 0x04002DF7 RID: 11767
		EMoveHitType_MAX
	}
}
