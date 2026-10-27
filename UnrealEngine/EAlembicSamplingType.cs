using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020002A3 RID: 675
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AlembicLibrary.EAlembicSamplingType")]
	public enum EAlembicSamplingType : byte
	{
		// Token: 0x04000E3F RID: 3647
		PerFrame,
		// Token: 0x04000E40 RID: 3648
		PerXFrames,
		// Token: 0x04000E41 RID: 3649
		PerTimeStep,
		// Token: 0x04000E42 RID: 3650
		EAlembicSamplingType_MAX
	}
}
