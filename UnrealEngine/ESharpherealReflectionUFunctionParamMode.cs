using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200275D RID: 10077
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Sharphereal.ESharpherealReflectionUFunctionParamMode")]
	public enum ESharpherealReflectionUFunctionParamMode : byte
	{
		// Token: 0x04014821 RID: 84001
		None,
		// Token: 0x04014822 RID: 84002
		In,
		// Token: 0x04014823 RID: 84003
		Ref,
		// Token: 0x04014824 RID: 84004
		Out,
		// Token: 0x04014825 RID: 84005
		ESharpherealReflectionUFunctionParamMode_MAX
	}
}
