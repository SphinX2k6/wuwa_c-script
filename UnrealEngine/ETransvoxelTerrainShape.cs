using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200268A RID: 9866
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Renderer.ETransvoxelTerrainShape")]
	public enum ETransvoxelTerrainShape : byte
	{
		// Token: 0x04013B0E RID: 80654
		Box,
		// Token: 0x04013B0F RID: 80655
		Sphere,
		// Token: 0x04013B10 RID: 80656
		Plane,
		// Token: 0x04013B11 RID: 80657
		ETransvoxelTerrainShape_MAX
	}
}
