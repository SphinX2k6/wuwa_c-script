using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200228A RID: 8842
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MaterialEditor.EOfflineShaderCompiler")]
	public enum EOfflineShaderCompiler : byte
	{
		// Token: 0x04011F2A RID: 73514
		Mali,
		// Token: 0x04011F2B RID: 73515
		Adreno,
		// Token: 0x04011F2C RID: 73516
		EOfflineShaderCompiler_MAX
	}
}
