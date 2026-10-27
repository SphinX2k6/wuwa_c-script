using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200275B RID: 10075
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Sharphereal.EMonoAotMode")]
	public enum EMonoAotMode : sbyte
	{
		// Token: 0x040147F4 RID: 83956
		Auto = -1,
		// Token: 0x040147F5 RID: 83957
		MONO_AOT_MODE_NONE,
		// Token: 0x040147F6 RID: 83958
		MONO_AOT_MODE_NORMAL,
		// Token: 0x040147F7 RID: 83959
		MONO_AOT_MODE_HYBRID,
		// Token: 0x040147F8 RID: 83960
		MONO_AOT_MODE_FULL,
		// Token: 0x040147F9 RID: 83961
		MONO_AOT_MODE_LLVMONLY,
		// Token: 0x040147FA RID: 83962
		MONO_AOT_MODE_INTERP,
		// Token: 0x040147FB RID: 83963
		MONO_AOT_MODE_INTERP_LLVMONLY,
		// Token: 0x040147FC RID: 83964
		MONO_AOT_MODE_LLVMONLY_INTERP,
		// Token: 0x040147FD RID: 83965
		MONO_AOT_MODE_INTERP_ONLY,
		// Token: 0x040147FE RID: 83966
		EMonoAotMode_MAX
	}
}
