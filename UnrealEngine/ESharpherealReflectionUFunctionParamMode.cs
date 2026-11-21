using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200080B RID: 2059
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Sharphereal.ESharpherealReflectionUFunctionParamMode")]
	public enum ESharpherealReflectionUFunctionParamMode : byte
	{
		// Token: 0x040051C3 RID: 20931
		None,
		// Token: 0x040051C4 RID: 20932
		In,
		// Token: 0x040051C5 RID: 20933
		Ref,
		// Token: 0x040051C6 RID: 20934
		Out,
		// Token: 0x040051C7 RID: 20935
		ESharpherealReflectionUFunctionParamMode_MAX
	}
}
