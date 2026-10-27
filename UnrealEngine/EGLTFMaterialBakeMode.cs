using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200143C RID: 5180
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GLTFExporter.EGLTFMaterialBakeMode")]
	public enum EGLTFMaterialBakeMode : byte
	{
		// Token: 0x0400A203 RID: 41475
		Disabled,
		// Token: 0x0400A204 RID: 41476
		Simple,
		// Token: 0x0400A205 RID: 41477
		UseMeshData,
		// Token: 0x0400A206 RID: 41478
		EGLTFMaterialBakeMode_MAX
	}
}
