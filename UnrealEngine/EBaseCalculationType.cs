using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020002A4 RID: 676
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AlembicLibrary.EBaseCalculationType")]
	public enum EBaseCalculationType : byte
	{
		// Token: 0x04000E44 RID: 3652
		None,
		// Token: 0x04000E45 RID: 3653
		PercentageBased,
		// Token: 0x04000E46 RID: 3654
		FixedNumber,
		// Token: 0x04000E47 RID: 3655
		NoCompression,
		// Token: 0x04000E48 RID: 3656
		EBaseCalculationType_MAX
	}
}
